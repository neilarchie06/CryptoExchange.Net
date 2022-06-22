using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Net.Processors
{
    public class RestDataRequester : IDataRequester
    {
        private IDataSerializer<string> _urlParameterSerializer;
        private IDataSerializer<string> _bodyParameterSerializer;
        private IDataDeserializer<Stream> _deserializer;
        private HttpClient _httpClient;

        public RestDataRequester(
            IDataSerializer<string> urlParameterSerializer, 
            IDataSerializer<string> bodyParameterSerializer,
            IDataDeserializer<Stream> deserializer,
            HttpClient client)
        {
            _urlParameterSerializer = urlParameterSerializer;
            _bodyParameterSerializer = bodyParameterSerializer;
            _deserializer = deserializer;
            _httpClient = client;
        }

        public async Task<CallResult<TOutput>> RequestAsync<TInput, TOutput>(RequestData<TInput> data)
        {
            if (!(data is RestRequestData restRequestData))
                throw new ArgumentException("Invalid request data type for RestDataHandler");

            CallResult<string> serializedData;
            if (restRequestData.ParameterPosition == HttpMethodParameterPosition.InBody)
                serializedData = await _bodyParameterSerializer.SerializeAsync(restRequestData.Data).ConfigureAwait(false);
            else
                serializedData = await _urlParameterSerializer.SerializeAsync(restRequestData.Data).ConfigureAwait(false);

            if (!serializedData)            
                return serializedData.As<TOutput>(default);
            
            var requestMessage = new HttpRequestMessage(restRequestData.Method, restRequestData.Address);
            if (restRequestData.ParameterPosition == HttpMethodParameterPosition.InBody)
                requestMessage.Content = new StringContent(serializedData.Data, Encoding.UTF8);
            else
                requestMessage.RequestUri = new Uri(requestMessage.RequestUri.ToString().AppendPath("/" + serializedData.Data));

            Stream stream;
            HttpResponseMessage result;
            var sw = Stopwatch.StartNew();
            try
            {
                result = await _httpClient.SendAsync(requestMessage).ConfigureAwait(false);
                stream = await result.Content.ReadAsStreamAsync().ConfigureAwait(false);
                sw.Stop();
            }
            catch (Exception ex)
            {
                sw.Stop();
                // Specific handling
                return new CallResult<TOutput>(new ServerError(ex.Message));
            }

            var deserialized = await _deserializer.DeserializeAsync<TOutput>(stream).ConfigureAwait(false);
            if (!deserialized)
            {
                return deserialized.As<TOutput>(default);
            }

            return new WebCallResult<TOutput>(result.StatusCode, result.Headers, sw.Elapsed, null, restRequestData.Address.ToString(), null, restRequestData.Method, result.Headers, deserialized.Data, null);
        }
    }
}

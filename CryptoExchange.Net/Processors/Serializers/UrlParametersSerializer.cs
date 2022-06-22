using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CryptoExchange.Net.Processors
{
    public class UrlParametersSerializer : IDataSerializer<string>
    {
        private ArrayParametersSerialization _arraySerialization;

        public UrlParametersSerializer(ArrayParametersSerialization arraySerialization)
        {
            _arraySerialization = arraySerialization;
        }

        public Task<CallResult<string>> SerializeAsync<TInput>(TInput data)
        {
            if (data == null)
                return Task.FromResult(new CallResult<string>(string.Empty));
            
            if (!(data is Dictionary<string, object> parameters))
                throw new ArgumentException("Expected dictionary");            

            var uriBuilder = new UriBuilder();
            var httpValueCollection = HttpUtility.ParseQueryString(string.Empty);
            foreach (var parameter in parameters)
            {
                if (parameter.Value.GetType().IsArray)
                {
                    foreach (var item in (object[])parameter.Value)
                        httpValueCollection.Add(_arraySerialization == ArrayParametersSerialization.Array ? parameter.Key + "[]" : parameter.Key, item.ToString());
                }
                else
                    httpValueCollection.Add(parameter.Key, parameter.Value.ToString());
            }
            uriBuilder.Query = httpValueCollection.ToString();
            return Task.FromResult(new CallResult<string>(uriBuilder.Query));
        }
    }
}

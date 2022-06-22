using CryptoExchange.Net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CryptoExchange.Net.Processors
{
    public class FormDataSerializer : IDataSerializer<string>
    {
        public Task<CallResult<string>> SerializeAsync<TInput>(TInput data)
        {
            if (data == null)
                return Task.FromResult(new CallResult<string>(string.Empty));

            if (!(data is IDictionary<string, object> parameters))
                throw new ArgumentException("Expected dictionary");

            var formData = HttpUtility.ParseQueryString(string.Empty);
            foreach (var kvp in parameters)
            {
                if (kvp.Value.GetType().IsArray)
                {
                    var array = (Array)kvp.Value;
                    foreach (var value in array)
                        formData.Add(kvp.Key, value.ToString());
                }
                else
                    formData.Add(kvp.Key, kvp.Value.ToString());
            }
            return Task.FromResult(new CallResult<string>(formData.ToString()));
        }
    }
}

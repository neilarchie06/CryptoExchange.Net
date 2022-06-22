using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Net.Processors
{
    public interface IDataRequester
    {
        Task<CallResult<TOutput>> RequestAsync<TInput, TOutput>(RequestData<TInput> data);
    }
}

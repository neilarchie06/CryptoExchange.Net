using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Net.Processors
{
    public interface IDataStreamer
    {
        Task<CallResult<UpdateSubscription>> SubscribeAsync<T>(StreamData<T> streamData);
    }
}

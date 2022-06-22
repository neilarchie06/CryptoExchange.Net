using CryptoExchange.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoExchange.Net.Processors
{
    public class StreamData<T>
    {
        public Uri Address { get; set; }
        public string Topic { get; set; }
        public T SubscribePayload { get; set; }
        public Action<DataEvent<T>> DataHandler { get; set; }
    }
}

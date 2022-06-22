using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Net.Processors.DataStreamers
{
    public abstract class WebSocketDataStreamer : IDataStreamer
    {
        private IDataSerializer<string> _serializer;
        private IDataDeserializer<string> _deserializer;
        private Log _log;
        private WebSocketConnection _connection;

        public WebSocketDataStreamer(Log log, IDataSerializer<string> serializer, IDataDeserializer<string> deserializer)
        {
            _serializer = serializer;
            _deserializer = deserializer;
        }

        public async Task<CallResult<UpdateSubscription>> SubscribeAsync<T>(StreamData<T> streamData)
        {
            _connection = new WebSocketConnection(_log, streamData.Address, IdentifyMessageType, GetMessageIdentifier);
            var connected = await _connection.ConnectAsync().ConfigureAwait(false);
            if (!connected)
                return new CallResult<UpdateSubscription>(new CantConnectError());

            socket.ProcessAsync();
        }

        public abstract MessageType IdentifyMessageType(ReceivedMessage message);
        public abstract string GetMessageIdentifier(ReceivedMessage message);
    }
}

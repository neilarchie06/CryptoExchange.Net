using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Net.Processors.DataStreamers
{
    public enum MessageType
    {
        Event,
        Response,
        Unknown,
        Other
    }

    public class ReceivedMessage
    {
        public string Data { get; set; }
        public DateTime Timestamp { get; set; }
        public MessageType Type { get; set; }
    }

    public  class WebSocketConnection
    {
        private Func<MessageType, ReceivedMessage> _messageTypeIdentifier;
        private Func<string, ReceivedMessage> _messageIdRetriever;

        private IWebsocket _socket;
        private Uri _uri;
        private Log _log;

        public WebSocketConnection(
            Log log,
            Uri uri,
            Func<ReceivedMessage, MessageType> messageTypeIdentifier,
            Func<ReceivedMessage, string> messageIdRetriever
            )
        {
            _log = log;
            _uri = uri;
            _messageTypeIdentifier = messageTypeIdentifier;
            _messageIdRetriever = messageIdRetriever;
        }

        public async Task<bool> ConnectAsync()
        {
            _socket = new CryptoExchangeWebSocketClient(_log, _uri);
            return await _socket.ConnectAsync().ConfigureAwait(false);
        }


    }
}

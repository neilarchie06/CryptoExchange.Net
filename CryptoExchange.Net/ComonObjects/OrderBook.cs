﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoExchange.Net.ComonObjects
{
    /// <summary>
    /// Order book data
    /// </summary>
    public class OrderBook: BaseComonObject
    {
        /// <summary>
        /// List of bids
        /// </summary>
        public IEnumerable<OrderBookEntry> Bids { get; set; } = Array.Empty<OrderBookEntry>();
        /// <summary>
        /// List of asks
        /// </summary>
        public IEnumerable<OrderBookEntry> Asks { get; set; } = Array.Empty<OrderBookEntry>();
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Logging;
using Microsoft.Extensions.Logging;

namespace CryptoExchange.Net.Objects
{
    /// <summary>
    /// Base options, applicable to everything
    /// </summary>
    public class BaseOptions
    {
        /// <summary>
        /// The minimum log level to output
        /// </summary>
        public LogLevel LogLevel { get; set; } = LogLevel.Information;

        /// <summary>
        /// The log writers
        /// </summary>
        public List<ILogger> LogWriters { get; set; } = new List<ILogger> { new DebugLogger() };

        /// <summary>
        /// If true, the CallResult and DataEvent objects will also include the originally received json data in the OriginalData property
        /// </summary>
        public bool OutputOriginalData { get; set; } = false;

        /// <summary>
        /// Copy the values of the def to the input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="def"></param>
        public void Copy<T>(T input, T def) where T : BaseOptions
        {
            input.LogLevel = def.LogLevel;
            input.LogWriters = def.LogWriters.ToList();
            input.OutputOriginalData = def.OutputOriginalData;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"LogLevel: {LogLevel}, Writers: {LogWriters.Count}, OutputOriginalData: {OutputOriginalData}";
        }
    }

    /// <summary>
    /// Client options, for both the socket and rest clients
    /// </summary>
    public class BaseClientOptions : BaseOptions
    {
        /// <summary>
        /// Proxy to use when connecting
        /// </summary>
        public ApiProxy? Proxy { get; set; }

        /// <summary>
        /// Api credentials to be used for signing requests to private endpoints. These credentials will be used for each API in the client, unless overriden in the API options 
        /// </summary>
        public ApiCredentials? ApiCredentials { get; set; }

        /// <summary>
        /// Copy the values of the def to the input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="def"></param>
        public new void Copy<T>(T input, T def) where T : BaseClientOptions
        {
            base.Copy(input, def);

            input.Proxy = def.Proxy;
            input.ApiCredentials = def.ApiCredentials?.Copy();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{base.ToString()}, Proxy: {(Proxy == null ? "-" : Proxy.Host)}";
        }
    }

    /// <summary>
    /// Rest client options
    /// </summary>
    public class BaseRestClientOptions : BaseClientOptions
    {
        /// <summary>
        /// The time the server has to respond to a request before timing out
        /// </summary>
        public TimeSpan RequestTimeout { get; set; } = TimeSpan.FromSeconds(30);

        /// <summary>
        /// Http client to use. If a HttpClient is provided in this property the RequestTimeout and Proxy options provided in these options will be ignored in requests and should be set on the provided HttpClient instance
        /// </summary>
        public HttpClient? HttpClient { get; set; }

        /// <summary>
        /// Copy the values of the def to the input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="def"></param>
        public new void Copy<T>(T input, T def) where T : BaseRestClientOptions
        {
            base.Copy(input, def);

            input.HttpClient = def.HttpClient;
            input.RequestTimeout = def.RequestTimeout;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{base.ToString()}, RequestTimeout: {RequestTimeout:c}, HttpClient: {(HttpClient == null ? "-" : "set")}";
        }
    }

    /// <summary>
    /// Socket client options
    /// </summary>
    public class BaseSocketClientOptions : BaseClientOptions
    {
        /// <summary>
        /// Whether or not the socket should automatically reconnect when losing connection
        /// </summary>
        public bool AutoReconnect { get; set; } = true;

        /// <summary>
        /// Time to wait between reconnect attempts
        /// </summary>
        public TimeSpan ReconnectInterval { get; set; } = TimeSpan.FromSeconds(5);

        /// <summary>
        /// The maximum number of times to try to reconnect, default null will retry indefinitely 
        /// </summary>
        public int? MaxReconnectTries { get; set; }

        /// <summary>
        /// The maximum number of times to try to resubscribe after reconnecting
        /// </summary>
        public int? MaxResubscribeTries { get; set; } = 5;

        /// <summary>
        /// Max number of concurrent resubscription tasks per socket after reconnecting a socket
        /// </summary>
        public int MaxConcurrentResubscriptionsPerSocket { get; set; } = 5;

        /// <summary>
        /// The max time to wait for a response after sending a request on the socket before giving a timeout
        /// </summary>
        public TimeSpan SocketResponseTimeout { get; set; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// The max time of not receiving any data after which the connection is assumed to be dropped. This can only be used for socket connections where a steady flow of data is expected,
        /// for example when the server sends intermittent ping requests
        /// </summary>
        public TimeSpan SocketNoDataTimeout { get; set; }

        /// <summary>
        /// The amount of subscriptions that should be made on a single socket connection. Not all exchanges support multiple subscriptions on a single socket.
        /// Setting this to a higher number increases subscription speed because not every subscription needs to connect to the server, but having more subscriptions on a 
        /// single connection will also increase the amount of traffic on that single connection, potentially leading to issues.
        /// </summary>
        public int? SocketSubscriptionsCombineTarget { get; set; }

        /// <summary>
        /// Copy the values of the def to the input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="def"></param>
        public new void Copy<T>(T input, T def) where T : BaseSocketClientOptions
        {
            base.Copy(input, def);

            input.AutoReconnect = def.AutoReconnect;
            input.ReconnectInterval = def.ReconnectInterval;
            input.MaxReconnectTries = def.MaxReconnectTries;
            input.MaxResubscribeTries = def.MaxResubscribeTries;
            input.MaxConcurrentResubscriptionsPerSocket = def.MaxConcurrentResubscriptionsPerSocket;
            input.SocketResponseTimeout = def.SocketResponseTimeout;
            input.SocketNoDataTimeout = def.SocketNoDataTimeout;
            input.SocketSubscriptionsCombineTarget = def.SocketSubscriptionsCombineTarget;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{base.ToString()}, AutoReconnect: {AutoReconnect}, ReconnectInterval: {ReconnectInterval}, MaxReconnectTries: {MaxReconnectTries}, MaxResubscribeTries: {MaxResubscribeTries}, MaxConcurrentResubscriptionsPerSocket: {MaxConcurrentResubscriptionsPerSocket}, SocketResponseTimeout: {SocketResponseTimeout:c}, SocketNoDataTimeout: {SocketNoDataTimeout}, SocketSubscriptionsCombineTarget: {SocketSubscriptionsCombineTarget}";
        }
    }

    /// <summary>
    /// API client options
    /// </summary>
    public class ApiClientOptions
    {
        /// <summary>
        /// The base address of the API
        /// </summary>
        public string BaseAddress { get; set; }

        /// <summary>
        /// The api credentials used for signing requests to this API. Overrides API credentials provided in the client options
        /// </summary>        
        public ApiCredentials? ApiCredentials { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
#pragma warning disable 8618 // Will always get filled by the implementation
        public ApiClientOptions()
        {
        }
#pragma warning restore 8618

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="baseAddress">Base address for the API</param>
        public ApiClientOptions(string baseAddress)
        {
            BaseAddress = baseAddress;
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="baseOn">Copy values for the provided options</param>
#pragma warning disable 8618 // Will always get filled by the provided options
        public ApiClientOptions(ApiClientOptions baseOn)
        {
            Copy(this, baseOn);
        }
#pragma warning restore 8618

        /// <summary>
        /// Copy the values of the def to the input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="def"></param>
        public void Copy<T>(T input, T def) where T : ApiClientOptions
        {
            if (def.BaseAddress != null)
                input.BaseAddress = def.BaseAddress;
            input.ApiCredentials = def.ApiCredentials?.Copy();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{base.ToString()}, Credentials: {(ApiCredentials == null ? "-" : "Set")}, BaseAddress: {BaseAddress}";
        }
    }
    
    /// <summary>
    /// Rest API client options
    /// </summary>
    public class RestApiClientOptions: ApiClientOptions
    {
        /// <summary>
        /// List of rate limiters to use
        /// </summary>
        public List<IRateLimiter> RateLimiters { get; set; } = new List<IRateLimiter>();

        /// <summary>
        /// What to do when a call would exceed the rate limit
        /// </summary>
        public RateLimitingBehaviour RateLimitingBehaviour { get; set; } = RateLimitingBehaviour.Wait;

        /// <summary>
        /// Whether or not to automatically sync the local time with the server time
        /// </summary>
        public bool AutoTimestamp { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        public RestApiClientOptions()
        {
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="baseAddress">Base address for the API</param>
        public RestApiClientOptions(string baseAddress): base(baseAddress)
        {
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="baseOn">Copy values for the provided options</param>
        public RestApiClientOptions(RestApiClientOptions baseOn)
        {
            Copy(this, baseOn);
        }

        /// <summary>
        /// Copy the values of the def to the input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="def"></param>
        public new void Copy<T>(T input, T def) where T : RestApiClientOptions
        {
            base.Copy(input, def);

            if(def.RateLimiters != null)
                input.RateLimiters = def.RateLimiters.ToList();
            input.RateLimitingBehaviour = def.RateLimitingBehaviour;
            input.AutoTimestamp = def.AutoTimestamp;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{base.ToString()}, RateLimiters: {RateLimiters?.Count}, RateLimitBehaviour: {RateLimitingBehaviour}, AutoTimestamp: {AutoTimestamp}";
        }
    }

    /// <summary>
    /// Base for order book options
    /// </summary>
    public class OrderBookOptions : BaseOptions
    {
        /// <summary>
        /// Whether or not checksum validation is enabled. Default is true, disabling will ignore checksum messages.
        /// </summary>
        public bool ChecksumValidationEnabled { get; set; } = true;
    }

}

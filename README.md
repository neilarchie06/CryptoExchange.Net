# ![.CryptoExchange.Net](https://github.com/JKorf/CryptoExchange.Net/blob/ffcb7db8ff597c2f14982d68464015a748815580/CryptoExchange.Net/Icon/icon.png) CryptoExchange.Net  

[![.NET](https://img.shields.io/github/actions/workflow/status/JKorf/CryptoExchange.Net/dotnet.yml?style=for-the-badge)](https://github.com/JKorf/CryptoExchange.Net/actions/workflows/dotnet.yml) [![Nuget downloads](https://img.shields.io/nuget/dt/CryptoExchange.Net.svg?style=for-the-badge)](https://www.nuget.org/packages/CryptoExchange.Net) ![License](https://img.shields.io/github/license/JKorf/CryptoExchange.Net?style=for-the-badge)

CryptoExchange.Net is a base library which is used to implement different cryptocurrency (exchange) API's. It provides a standardized way of implementing different API's, which results in a very similar experience for users of the API implementations. 
Note that the CryptoExchange.Net package itself can not be used directly for accessing API's. Either install a client library from the list below or use [CryptoClients.Net](https://github.com/jkorf/CryptoClients.Net) which includes access to all exchange API's.

For more information on what CryptoExchange.Net and it's client libraries offers see the [Documentation](https://cryptoexchange.jkorf.dev/).

### CryptoExchange.Net Ecosystem
Full list of all libraries part of the CryptoExchange.Net ecosystem. Consider using a referral link to support development, as well as potentially get some trading fee discount!

||Exchange|Type|Repository|Nuget|Referral Link|Referral Fee Discount|
|--|--|--|--|--|--|--|
|![Binance](https://raw.githubusercontent.com/JKorf/Binance.Net/refs/heads/master/Binance.Net/Icon/icon.png)|Binance|CEX|[JKorf/Binance.Net](https://github.com/JKorf/Binance.Net)|[![Nuget version](https://img.shields.io/nuget/v/Binance.net.svg?style=flat-square)](https://www.nuget.org/packages/Binance.Net)|[Link](https://accounts.binance.com/register?ref=X5K3F2ZG)|20%|
|![BingX](https://raw.githubusercontent.com/JKorf/BingX.Net/refs/heads/main/BingX.Net/Icon/BingX.png)|BingX|CEX|[JKorf/BingX.Net](https://github.com/JKorf/BingX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.BingX.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.BingX.Net)|[Link](https://bingx.com/invite/FFHRJKWG/)|20%|
|![Bitfinex](https://raw.githubusercontent.com/JKorf/Bitfinex.Net/refs/heads/master/Bitfinex.Net/Icon/icon.png)|Bitfinex|CEX|[JKorf/Bitfinex.Net](https://github.com/JKorf/Bitfinex.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bitfinex.net.svg?style=flat-square)](https://www.nuget.org/packages/Bitfinex.Net)|-|-|
|![Bitget](https://raw.githubusercontent.com/JKorf/Bitget.Net/refs/heads/main/Bitget.Net/Icon/icon.png)|Bitget|CEX|[JKorf/Bitget.Net](https://github.com/JKorf/Bitget.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Bitget.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.Bitget.Net)|[Link](https://partner.bitget.com/bg/1qlf6pj1)|20%|
|![BitMart](https://raw.githubusercontent.com/JKorf/BitMart.Net/refs/heads/main/BitMart.Net/Icon/icon.png)|BitMart|CEX|[JKorf/BitMart.Net](https://github.com/JKorf/BitMart.Net)|[![Nuget version](https://img.shields.io/nuget/v/BitMart.net.svg?style=flat-square)](https://www.nuget.org/packages/BitMart.Net)|[Link](https://www.bitmart.com/invite/JKorfAPI/en-US)|30%|
|![BitMEX](https://raw.githubusercontent.com/JKorf/BitMEX.Net/refs/heads/main/BitMEX.Net/Icon/icon.png)|BitMEX|CEX|[JKorf/BitMEX.Net](https://github.com/JKorf/BitMEX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JKorf.BitMEX.net.svg?style=flat-square)](https://www.nuget.org/packages/JKorf.BitMEX.Net)|[Link](https://www.bitmex.com/app/register/94f98e)|30%|
|![Bybit](https://raw.githubusercontent.com/JKorf/Bybit.Net/refs/heads/main/ByBit.Net/Icon/icon.png)|Bybit|CEX|[JKorf/Bybit.Net](https://github.com/JKorf/Bybit.Net)|[![Nuget version](https://img.shields.io/nuget/v/Bybit.net.svg?style=flat-square)](https://www.nuget.org/packages/Bybit.Net)|[Link](https://partner.bybit.com/b/jkorf)|-|
|![Coinbase](https://raw.githubusercontent.com/JKorf/Coinbase.Net/refs/heads/main/Coinbase.Net/Icon/icon.png)|Coinbase|CEX|[JKorf/Coinbase.Net](https://github.com/JKorf/Coinbase.Net)|[![Nuget version](https://img.shields.io/nuget/v/JKorf.Coinbase.Net.svg?style=flat-square)](https://www.nuget.org/packages/JKorf.Coinbase.Net)|[Link](https://advanced.coinbase.com/join/T6H54H8)|-|
|![CoinEx](https://raw.githubusercontent.com/JKorf/CoinEx.Net/refs/heads/master/CoinEx.Net/Icon/icon.png)|CoinEx|CEX|[JKorf/CoinEx.Net](https://github.com/JKorf/CoinEx.Net)|[![Nuget version](https://img.shields.io/nuget/v/CoinEx.net.svg?style=flat-square)](https://www.nuget.org/packages/CoinEx.Net)|[Link](https://www.coinex.com/register?rc=rbtnp)|20%|
|![CoinGecko](https://raw.githubusercontent.com/JKorf/CoinGecko.Net/refs/heads/main/CoinGecko.Net/Icon/icon.png)|CoinGecko|-|[JKorf/CoinGecko.Net](https://github.com/JKorf/CoinGecko.Net)|[![Nuget version](https://img.shields.io/nuget/v/CoinGecko.net.svg?style=flat-square)](https://www.nuget.org/packages/CoinGecko.Net)|-|-|
|![Crypto.com](https://raw.githubusercontent.com/JKorf/CryptoCom.Net/refs/heads/main/CryptoCom.Net/Icon/icon.png)|Crypto.com|CEX|[JKorf/CryptoCom.Net](https://github.com/JKorf/CryptoCom.Net)|[![Nuget version](https://img.shields.io/nuget/v/CryptoCom.net.svg?style=flat-square)](https://www.nuget.org/packages/CryptoCom.Net)|[Link](https://crypto.com/exch/26ge92xbkn)|-|
|![DeepCoin](https://raw.githubusercontent.com/JKorf/DeepCoin.Net/refs/heads/main/DeepCoin.Net/Icon/icon.png)|DeepCoin|CEX|[JKorf/DeepCoin.Net](https://github.com/JKorf/DeepCoin.Net)|[![Nuget version](https://img.shields.io/nuget/v/DeepCoin.net.svg?style=flat-square)](https://www.nuget.org/packages/DeepCoin.Net)|[Link](https://s.deepcoin.com/jddhfca)|-|
|![Gate.io](https://raw.githubusercontent.com/JKorf/GateIo.Net/refs/heads/main/GateIo.Net/Icon/icon.png)|Gate.io|CEX|[JKorf/GateIo.Net](https://github.com/JKorf/GateIo.Net)|[![Nuget version](https://img.shields.io/nuget/v/GateIo.net.svg?style=flat-square)](https://www.nuget.org/packages/GateIo.Net)|[Link](https://www.gate.io/share/JKorf)|20%|
|![HTX](https://raw.githubusercontent.com/JKorf/HTX.Net/refs/heads/master/HTX.Net/Icon/icon.png)|HTX|CEX|[JKorf/HTX.Net](https://github.com/JKorf/HTX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JKorf.HTX.net.svg?style=flat-square)](https://www.nuget.org/packages/JKorf.HTX.Net)|[Link](https://www.htx.com/invite/en-us/1f?invite_code=ekek5223)|30%|
|![HyperLiquid](https://raw.githubusercontent.com/JKorf/HyperLiquid.Net/refs/heads/main/HyperLiquid.Net/Icon/icon.png)|HyperLiquid|DEX|[JKorf/HyperLiquid.Net](https://github.com/JKorf/HyperLiquid.Net)|[![Nuget version](https://img.shields.io/nuget/v/HyperLiquid.Net.svg?style=flat-square)](https://www.nuget.org/packages/HyperLiquid.Net)|[Link](https://app.hyperliquid.xyz/join/JKORF)|4%|
|![Kraken](https://raw.githubusercontent.com/JKorf/Kraken.Net/refs/heads/master/Kraken.Net/Icon/icon.png)|Kraken|CEX|[JKorf/Kraken.Net](https://github.com/JKorf/Kraken.Net)|[![Nuget version](https://img.shields.io/nuget/v/KrakenExchange.net.svg?style=flat-square)](https://www.nuget.org/packages/KrakenExchange.Net)|-|-|
|![Kucoin](https://raw.githubusercontent.com/JKorf/Kucoin.Net/refs/heads/master/Kucoin.Net/Icon/icon.png)|Kucoin|CEX|[JKorf/Kucoin.Net](https://github.com/JKorf/Kucoin.Net)|[![Nuget version](https://img.shields.io/nuget/v/Kucoin.net.svg?style=flat-square)](https://www.nuget.org/packages/Kucoin.Net)|[Link](https://www.kucoin.com/r/rf/QBS4FPED)|-|
|![Mexc](https://raw.githubusercontent.com/JKorf/Mexc.Net/refs/heads/main/Mexc.Net/Icon/icon.png)|Mexc|CEX|[JKorf/Mexc.Net](https://github.com/JKorf/Mexc.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.Mexc.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.Mexc.Net)|-|-|
|![OKX](https://raw.githubusercontent.com/JKorf/OKX.Net/refs/heads/main/OKX.Net/Icon/icon.png)|OKX|CEX|[JKorf/OKX.Net](https://github.com/JKorf/OKX.Net)|[![Nuget version](https://img.shields.io/nuget/v/JK.OKX.net.svg?style=flat-square)](https://www.nuget.org/packages/JK.OKX.Net)|[Link](https://www.okx.com/join/14592495)|20%|
|![Toobit](https://raw.githubusercontent.com/JKorf/Toobit.Net/refs/heads/main/Toobit.Net/Icon/icon.png)|Toobit|CEX|[JKorf/Toobit.Net](https://github.com/JKorf/Toobit.Net)|[![Nuget version](https://img.shields.io/nuget/v/Toobit.net.svg?style=flat-square)](https://www.nuget.org/packages/Toobit.Net)|[Link](https://www.toobit.com/en-US/register?invite_code=zsV19h)|-|
|![WhiteBit](https://raw.githubusercontent.com/JKorf/WhiteBit.Net/refs/heads/main/WhiteBit.Net/Icon/icon.png)|WhiteBit|CEX|[JKorf/WhiteBit.Net](https://github.com/JKorf/WhiteBit.Net)|[![Nuget version](https://img.shields.io/nuget/v/WhiteBit.net.svg?style=flat-square)](https://www.nuget.org/packages/WhiteBit.Net)|[Link](https://whitebit.com/referral/a8e59b59-186c-4662-824c-3095248e0edf)|-|
|![XT](https://raw.githubusercontent.com/JKorf/XT.Net/refs/heads/main/XT.Net/Icon/icon.png)|XT|CEX|[JKorf/XT.Net](https://github.com/JKorf/XT.Net)|[![Nuget version](https://img.shields.io/nuget/v/XT.net.svg?style=flat-square)](https://www.nuget.org/packages/XT.Net)|[Link](https://www.xt.com/ru/accounts/register?ref=CZG39C)|25%|

Any of these can be installed independently or install [CryptoClients.Net](https://github.com/jkorf/CryptoClients.Net) which includes all exchange API's.

## Discord
[![Nuget version](https://img.shields.io/discord/847020490588422145?style=for-the-badge)](https://discord.gg/MSpeEtSY8t)  
A Discord server is available [here](https://discord.gg/MSpeEtSY8t). Feel free to join for discussion and/or questions around the CryptoExchange.Net and implementation libraries.

## Support the project
Any support is greatly appreciated.

### Referral
When creating an account on new exchanges please consider using a referral link from above.

### Donate
Make a one time donation in a crypto currency of your choice. If you prefer to donate a currency not listed here please contact me.

**Btc**:  bc1q277a5n54s2l2mzlu778ef7lpkwhjhyvghuv8qf  
**Eth**:  0xcb1b63aCF9fef2755eBf4a0506250074496Ad5b7   
**USDT (TRX)**  TKigKeJPXZYyMVDgMyXxMf17MWYia92Rjd

### Sponsor
Alternatively, sponsor me on Github using [Github Sponsors](https://github.com/sponsors/JKorf). 

## Release notes
* Version 9.3.0 - 23 Jul 2025
    * Updated websocket message to listener matching logic to be more flexible
    * Updated decimal parser to support "NaN" and "-Infinity" strings, added check for negative overflow value, improved performance in most cases

* Version 9.2.1 - 16 Jul 2025
    * Added setting for whether or not to process unparsable websocket messages
    * Fixed issue causing duplicate subscriptions and data in the TradeTracker and KlineTracker when websocket connection was reconnected

* Version 9.2.0 - 14 Jul 2025
    * Added support for sending byte data on websocket
    * Added support for handling both string and byte data with different IMessageAccessor types
    * Split IMessageSerializer into IByteMessageSerializer and IStringMessageSerializer
    * Renamed IMessageAccessor.IsJson to IsValid
    * Refactored ArrayConverter to remove separate converter options cache

* Version 9.1.0 - 28 May 2025
    * Added JsonConverter implementation for SharedQuantity and SharedSymbol types, making usage of the types easier
    * Updated dotnet dependency packages from 9.0.0 to 9.0.5
    * Replaced Microsoft.Extensions.Logging.Abstractions with Microsoft.Extensions.Logging
    * Replaced Microsoft.Extensions.Options.ConfigurationExtensions with Microsoft.Extensions.Configuration.Binder, which includes a source generator for AOT publishing
    * Removed redundant Microsoft.Extensions.DependencyInjection.Abstractions package reference

* Version 9.0.1 - 20 May 2025
    * Improved response time on CancellationToken cancel during subscribing
    * Added support for sending query without expecting a response

* Version 9.0.0 - 13 May 2025
    * Added support for Native AOT compilation
    * Updated all IEnumerable response types to array response types
    * Added Pass support for ApiCredentials, removing the need for most implementations to add their own ApiCredentials type
    * Added KeepAliveTimeout setting setting ping frame timeouts for SocketApiClient
    * Added IBookTickerRestClient Shared interface for requesting book tickers
    * Added ISpotTriggerOrderRestClient Shared interface for managing spot trigger orders
    * Added ISpotOrderClientIdClient Shared interface for managing spot orders by client order id
    * Added IFuturesTriggerOrderRestClient Shared interface for managing futures trigger orders
    * Added IFuturesOrderClientIdClient Shared interface for managing futures orders by client order id
    * Added IFuturesTpSlRestClient Shared interface for setting TP/SL on open futures positions
    * Added GenerateClientOrderId to ISpotOrderRestClient and IFuturesOrderRestClient interface
    * Added OptionalExchangeParameters and Supported properties to EndpointOptions
    * Refactor Shared interfaces quantity parameters and properties to use SharedQuantity
    * Added SharedSymbol property to Shared interface models returning a symbol
    * Added TriggerPrice, IsTriggerOrder, TakeProfitPrice, StopLossPrice and IsCloseOrder to SharedFuturesOrder response model
    * Added MaxShortLeverage and MaxLongLeverage to SharedFuturesSymbol response model
    * Added StopLossPrice and TakeProfitPrice to SharedPosition response model
    * Added TriggerPrice and IsTriggerOrder to SharedSpotOrder response model
    * Added QuoteVolume property to SharedSpotTicker response model
    * Added AssetAlias configuration models
    * Added static ExchangeSymbolCache for tracking symbol information from exchanges
    * Added static CallResult.SuccessResult to be used instead of constructing success CallResult instance
    * Added static ApplyRules, RandomHexString and RandomLong helper methods to ExchangeHelpers class
    * Added AsErrorWithData To CallResult
    * Added OriginalData property to CallResult
    * Added support for adjusting the rate limit key per call, allowing for ratelimiting depending on request parameters
    * Added implementation for integration testing ISymbolOrderBook instances
    * Added implementation for integration testing socket subscriptions
    * Added implementation for testing socket queries
    * Updated request cancellation logging to Debug level
    * Updated logging SourceContext to include the client type
    * Updated some logging logic, errors no longer contain any data, exception are not logged as string but instead forwarded to structured logging
    * Fixed warning for Enum parsing throwing exception and output warnings for each object in a response to only once to prevent slowing down execution
    * Fixed memory leak in AsyncAutoRestEvent
    * Fixed logging for ping frame timeout
    * Fixed warning getting logged when user stops SymbolOrderBook instance
    * Fixed socket client `UnsubscribeAll` not unsubscribing dedicated connections
    * Fixed memory leak in Rest client cache
    * Fixed integers bigger than int16 not getting correctly parsed to enums
    * Fixed issue where the default options were overridden when using SetApiCredentials
    * Removed Newtonsoft.Json dependency
    * Removed legacy Rest client code
    * Removed legacy ISpotClient and IFuturesClient support

* Version 9.0.0-beta7 - 06 May 2025
    * Added AssetAlias configuration classes
    * Added Exception property on Error objects
    * Updated logging to no longer log full stacktraces but instead pass exceptions to struct
    * Removed the Data property from Error objects (is already available on CallResult)ured logging
    * Updated ArrayConverter _typeAttributesCache from ConcurrentDictionary to lazy list since each type has it's own ArrayConverter instance now
    * Updated SocketApiClient to create RateLimiter instance if none is provided
    * Fixed issue with ArrayConverter creating seperate JsonSerializerContext instance for each type by adding JsonSerializerContextCache

* Version 9.0.0-beta6 - 03 May 2025
    * Fixed initial asset info in ExchangeSymbolCache not getting cached in uppercase
    * Fixed ArrayConverter creating new JsonSerializerContext for each default json deserialization

* Version 9.0.0-beta5 - 30 Apr 2025
    * Add support for specifying additional custom converters when creating JsonSerializerOptions
    * Fix issue overriding default options when using SetApiCredentials on client

* Version 9.0.0-beta4 - 28 Apr 2025
    * Support reading of int32 (up from int16) as enum values in EnumConverter

* Version 9.0.0-beta3 - 27 Apr 2025
    * Fixed memory leak in cache
    * Fixed memory leak in array converter
    * Fixed incorrect log verbosity for log message when stopping order book

* Version 9.0.0-beta2 - 23 Apr 2025
    * Added QuoteVolume property to SharedSpotTicker model
    * Map asset names as uppercase in ExchangeSymbolCache
    * Renamed ISpotOrderClientIdClient to ISpotOrderClientIdRestClient and IFuturesOrderClientIdClient to IFuturesOrderClientIdRestClient

* Version 9.0.0-beta1 - 16 Apr 2025
    * Added support for Native AOT compilation
    * Updated all IEnumerable response types to array response types
    * Added Pass support for ApiCredentials, removing the need for most implementations to add their own ApiCredentials type
    * Added KeepAliveTimeout setting setting ping frame timeouts for SocketApiClient
    * Added IBookTickerRestClient Shared interface for requesting book tickers
    * Added ISpotTriggerOrderRestClient Shared interface for managing spot trigger orders
    * Added ISpotOrderClientIdClient Shared interface for managing spot orders by client order id
    * Added IFuturesTriggerOrderRestClient Shared interface for managing futures trigger orders
    * Added IFuturesOrderClientIdClient Shared interface for managing futures orders by client order id
    * Added IFuturesTpSlRestClient Shared interface for setting TP/SL on open futures positions
    * Added GenerateClientOrderId to ISpotOrderRestClient and IFuturesOrderRestClient interface
    * Added OptionalExchangeParameters and Supported properties to EndpointOptions
    * Refactor Shared interfaces quantity parameters and properties to use SharedQuantity
    * Added SharedSymbol property to Shared interface models returning a symbol
    * Added TriggerPrice, IsTriggerOrder, TakeProfitPrice, StopLossPrice and IsCloseOrder to SharedFuturesOrder response model
    * Added MaxShortLeverage and MaxLongLeverage to SharedFuturesSymbol response model
    * Added StopLossPrice and TakeProfitPrice to SharedPosition response model
    * Added TriggerPrice and IsTriggerOrder to SharedSpotOrder response model
    * Added static ExchangeSymbolCache for tracking symbol information from exchanges
    * Added static CallResult.SuccessResult to be used instead of constructing success CallResult instance
    * Added static ApplyRules, RandomHexString and RandomLong helper methods to ExchangeHelpers class
    * Added AsErrorWithData To CallResult
    * Added OriginalData property to CallResult
    * Added support for adjusting the rate limit key per call, allowing for ratelimiting depending on request parameters
    * Added implementation for integration testing ISymbolOrderBook instances
    * Added implementation for integration testing socket subscriptions
    * Added implementation for testing socket queries
    * Updated request cancellation logging to Debug level
    * Fixed memory leak in AsyncAutoRestEvent
    * Fixed logging for ping frame timeout
    * Fixed socket client `UnsubscribeAll` not unsubscribing dedicated connections
    * Removed Newtonsoft.Json dependency
    * Removed legacy Rest client code
    * Removed legacy ISpotClient and IFuturesClient support

* Version 8.8.0 - 10 Feb 2025
    * Split DataEvent.Timestamp in DataEvent.ReceivedTime and DataEvent.DataTime
    * Added SharedKlineInterval enum values
    * Fixed some typos

* Version 8.7.4 - 08 Feb 2025
    * Fixed exception when creating rest client for mono runtime

* Version 8.7.3 - 05 Feb 2025
    * Added handling of negative number DateTime deserialization to default
    * Updated SharedSymbol from class to record
    * Fixed issue with serialization of nullable types in System.Text.Json ArrayConverter
    * Fix for unnecessary error message in logging when closing websocket connection

* Version 8.7.2 - 27 Jan 2025
    * Some small fixes in the System.Text.Json ArrayConverter
    * Added support for Flags enum deserialization in System.Text.Json EnumConverter

* Version 8.7.1 - 24 Jan 2025
    * Added Authenticated property to IBaseApiClient interface to check if a client was provided API credentials

* Version 8.7.0 - 21 Jan 2025
    * Added GetMillisecondTimestampLong helper method to AuthenticationProvider
    * Added PriceSignificationFigures to SharedSpotSymbol model

* Version 8.6.1 - 09 Jan 2025
    * Fixed websocket connection getting stuck after a ping frame timeout
    * Removed websocket Error callback when exception is expected
    * Removed unnecessary type restraints on RestApiClient.SendAsync methods

* Version 8.6.0 - 07 Jan 2025
    * Added support for passing weight to apply to an individual ratelimit guard
    * Added IFeeRestClient to service registration
    * Added response headers parameter to RestApiClient.TryParseError method
    * Added check for ServerRateLimitError on RestApiClient.TryParseError response
    * Added ExchangeType Enum
    * Some small improvements

* Version 8.5.0 - 23 Dec 2024
    * Added SetOptions method to update client settings
    * Added SocketConnection parameter to PeriodicQuery callback
    * Added setting of DefaultProxyCredentials on HttpClient instance when client is not provided by DI
    * Added support for overriding request timeout per request
    * Added build target for net9.0
    * Added setting of KeepAliveTimeout on websocket connections to improve dropped connection detection
    * Changed max wait time for close handshake response from 5 seconds to 1 second
    * Fixed exception in trade tracker when there is no data in the initial snapshot

* Version 8.4.5 - 20 Dec 2024
    * Added EmptyArrayObjectConverter System.Text.Json JsonConverter
    * Added JsonSerializerOptions parameter to SystemTextJsonMessageAccessor constructor

* Version 8.4.4 - 08 Dec 2024
    * Changed JsonConverterCtorAttribute to use constructor type parameter instead of generic type parameter to support .net framework

* Version 8.4.3 - 03 Dec 2024
    * Fixed KlineTracker update handling

* Version 8.4.2 - 02 Dec 2024
    * Removed special characters in ClientOrderIdSeperator to adhere to field content rules

* Version 8.4.1 - 02 Dec 2024
    * Added JsonConverterCtorAttribute to allow specifying a custom JsonConverter with constructor parameters on properties
    * Added ReplaceConverter System.Text.Json converter
    * Added LibraryHelpers class for internal helper methods

* Version 8.4.0 - 28 Nov 2024
    * Added GetFeesAsync Shared REST client support
    * Added LibraryOptions base class
    * Added CommaSplitEnumConverter System.Text.Json converter
    * Added TimePeriodFilterSupport and MaxLimit properties to PaginatedEndpointOptions
    * Updated package dependency versions

* Version 8.3.0 - 19 Nov 2024
    * Added support for IOptions injection, allowing options to be read from IConfiguration
    * Added handling of Infinity values in decimal converter
    * Added rate limit update event
    * Small refactor on client options internals
    * Fixed concurrency issue when unsubscribing websocket subscription during reconnection

* Version 8.2.0 - 06 Nov 2024
    * Added support for not allowing duplicate subscription topics on the same websocket connection
    * Added PerAccount SharedLeverageSettingMode enum value, changed Side on SharedUserTrade to nullable
    * Added support for object deserialization in SystemTextJsonMessageAccessor.GetValue<T>
    * Changed SocketApiClient GetAuthenticationRequest to GetAuthenticationRequestAsync to allow for requesting token

* Version 8.1.1 - 01 Nov 2024
    * Fixed socket connections trying to authenticated connection when it's marked as dedicated request connection even when no authentication is needed
    * Fixed System.Text.Json ArrayConverter not passing serializer options to nested deserialization
    * Fixed System.Text.Json ArrayConverter creating new serializer options each time a JsonConverter attribute is encountered

* Version 8.1.0 - 28 Oct 2024
    * Added KlineTracker and TradeTracker implementation
    * Added Side to SharedTrade model
    * Added overload for Create method in OrderBookFactory using SharedSymbol
    * Added ValidateMessage method to websocket Query object to filter messages even though it is matched to the query based on the  ListenIdentifier
    * Added DoHandleReset method for websocket subscriptions
    * Added ConnectionId to RequestDefinition to correctly handle connection and path rate limiting configuration
    * Added System.Text.Json ArrayConverter Write implementation
    * Updated SharedFuturesTicker LastPrice, HighPrice and LowPrice properties to be nullable
    * Updated SetApiCredentials method to also updated the credentials on the client specific options to prevent unknown client credentials in some situations

* Version 8.0.3 - 14 Oct 2024
    * Added support for duplicate array indexes in System.Text.Json ArrayConverter
    * Added fallback for unparsable value in System.Text.Json NumberStringConverter
    * Added Authenticated property on base client and shared client
    * Added GetValues System.Text.Json implementation in message accessor

* Version 8.0.2 - 09 Oct 2024
    * Updated dependency versions, including System.Text.Json from 8.0.4 to 8.0.5 containing a vulnerability fix

* Version 8.0.1 - 07 Oct 2024
    * Added cached library version properties on base client
    * Added support for derserializing 0001-01-01 as datetime null value
    * Added ToRfc3339String extension method for DateTime type

* Version 8.0.0 - 27 Sep 2024
    * Added new cross exchange interfaces implementation
        * Supports REST, WebSocket, Spot and Futures API's
        * Added various client interfaces for specific functionality
        * Added SharedSymbol type, taking care of symbol formatting for different exchanges
        * Added dynamic pagination support for shared functionality
        * Added various shared Enum definitions
        * Added ExchangeWebResult and ExchangeEvent, exchange specific versions of WebCallResult and DataEvent
        * See https://jkorf.github.io/CryptoExchange.Net/index.html#idocs_shared for more info
    * Added tradingMode and deliverData parameters to BaseApiClient FormatSymbol method
    * Added ExecutePages method to ExchangeHelpers static class
    * Added ApplySymbolRules method to ExchangeHelpers static class
    * Added ResubscribingFailed event for websocket connections
    * Added handling of http result 429 (ratelimited) during websocket connection
    * Added Websocket dispose before creating new connection when reconnecting
    * Updated Sourcelink package version
    * Marked ISpotClient and IFuturesClient references as deprecated


* Version 7.11.2 - 28 Aug 2024
    * Fixed issues when ratelimiting is canceled using the provided cancellation token

* Version 7.11.1 - 25 Aug 2024
    * Improved closing logic websockets

* Version 7.11.0 - 07 Aug 2024
    * Added ParseString static method on EnumConverter for parsing strings manually
    * Added support for decimal values in System.Text.Json NumberStringConverter
    * Added support for `null` string values in System.Text.Json DecimalConverter
    * Added support for number deserialization when requesting string in System.Text.Json MessageAccessor.GetValue
    * Added deserialization handling of json values too big to fit decimal value
    * Decreased some memory allocations during rest request authentication
    * Fixed subscriptions trying to send unsubscribe request when the socket connection will be closed anyway
    * Removed SecureString usage in credentials; it's not recommended to be used
    * Removed some extension methods no longer relevant
    * Improved testing checks

* Version 7.10.0 - 26 Jul 2024
    * Added System.Text.Json NumberStringConverter
    * Added integration testing base class
    * Added AddSecondsString and AddOptionalSecondsString to ParameterCollection
    * Added Decompress method for ReadOnlyMemory using non-GZip deflate
    * Added SocketConnection parameter to SocketConnection PreprocessStreamMessage
    * Fixed websocket reconnect/unsubscribe timing bug
    * Fixed issue in System.Text.Json array object deserialization skipping property when skipping an index
    * Fixed order book logging bug
    * Fixed bug in ParameterCollection AddEnumAsInt

* Version 7.9.0 - 16 Jul 2024
    * Added some checks in websocket connection handling
    * Added As<T> and AsError<T> methods on untyped WebCallResult
    * Updated System.Text.Json package to version 8.0.4 to fix vulnerability
    * Updated websocket subscription response handling to remove the thread blocking ManualResetEvent usage
    * Updated static logging classes access modifier from internal to public so they can be called in overriden methods
    * Updated some testing object implementations
    * Fixed authentication error when reconnecting an unauthenticated connection which was marked as dedicated query connection
    * Small improvements in SystemTextJsonMessageAccessor
    * Fixed System.Text.Json ArrayConverter implementation nullable value types handling

* Version 7.8.0 - 02 Jul 2024
    * Updated single endpoint limit configuration
    * Added LongConverter for nullable longs
    * Updated SystemTextJsonComparer logic

* Version 7.7.3 - 26 Jun 2024
    * Fixed request ids not matching in logging
    * Added nullable int converter for System.Text.Json
    * Small fixes in tests

* Version 7.7.2 - 25 Jun 2024
    * Fixed ratelimiting issue possibly creating negative delays

* Version 7.7.1 - 23 Jun 2024
    * Fixes for caching implementation

* Version 7.7.0 - 23 Jun 2024
    * Caching support
        * Caching is supported for GET requests within a certain time frame
        * Enable caching by setting CachingEnabled to true in the client options
        * Added DataSource to CallResult object
    * Dedicated websocket connection
        * Added functionality for always having a connection open which can then be used for order operations
        * This eliminates the initial connection time for the first request
        * WebSocket connection can be prepared by calling PrepareConnectionsAsync on the Api client, for example `await binanceSocketClient.SpotApi.PrepareConnectionsAsync()`. This is only needed initially; it will be reconnected when connection is lost.
    * Added CancellationToken support for websocket queries
    * Added SocketConnection parameter to SocketApiClient.GetAuthenticationRequest method
    * Added ObjectStringConverter base converter for deserializing nested json strings
    * Fixed websocket issue with ratelimiting and reconnecting interaction
    * Fixed rate limiting issue with sub-millisecond delays
    * Fixed websocket connection will now close if authentication fails because of not set credentials
    * Updated websocket reconnection handling and options, added backoff policy
    * Removed check for confirmed subscription as data often is pushed before the subscription is confirmed

* Version 7.6.0 - 11 Jun 2024
    * Added support for specifying seperate uri and body parameters
    * Added support for different message and handling generic types on socket queries
    * Added support for PATCH http method requests
    * Added support for setting http request body to a specific type directly
    * Split DataEvent.Topic into StreamId and Symbol properties
    * Added support for negative time values parsing
    * Added some helper methods for converting DataEvent to CallResult
    * Added support for GZip/Deflate automatic decompressing in the default HttpClient
    * Updated some testing methods

* Version 7.5.2 - 07 May 2024
    * Fixed SetApiCredentials not correctly being used by rate limiter causing exception

* Version 7.5.1 - 03 May 2024
    * Some small improvements in unit testing components

* Version 7.5.0 - 01 May 2024
    * Added testing implementations
    * Small refactor AuthenticationProvider to allow better testing
    * Change result of MessageAccessor.Read methods to CallResult so error can be returned
    * Moved some DateTimeConverter logic to seperate methods to allow access from outside converters

* Version 7.4.0 - 28 Apr 2024
    * Added FormatSymbol on IBaseApiClient interface
    * Added IOrderBookFactory interface
    * Removed ExchangeOptions as base class for OrderBookOptions

* Version 7.3.3 - 23 Apr 2024
    * Added support for new DateTime format parsing
    * Updated some logging
    * Fixed concurrency issue in rest request sending

* Version 7.3.2 - 19 Apr 2024
    * Fix for endpoint specific rate limiting throwing exception

* Version 7.3.1 - 18 Apr 2024
    * Fixed websocket system subscriptions getting marked as unconfirmed when reconnecting

* Version 7.3.0 - 17 Apr 2024
    * Added new method for sending Rest requests which splits the static and dynamic parameters
	* Refactored rate limiting implementation
		* Ratelimiters now statically applied for all clients
		* Added support for different rate limit window types
		* Added modular configuration of rate limits
		* Added rate limit check when creating websocket connections
		* Added automatic handling and retry for Retry-After responses
		* Added configuration for setting ratelimit for each individual endpoint
		* Added event for when rate limit is triggered
	* Added SocketClient GetSocketApiClientStates method

* Version 7.2.1 - 05 Apr 2024
    * Improved websocket reconnect logic
    * Simplified SystemTextJsonMessageAccessor value retrieval
    * Fixed System.Text.Json BoolConverter value writing

* Version 7.2.0 - 24 Mar 2024
    * Added ArrayParametersSerialization.JsonArray support
    * Refactored to high-performance logging for hot paths
    * Updated SymbolOrderBook to use LoggerFactory
    * Performance improvements
    * Small bug fixes
    * Updated logging

* Version 7.1.0 - 16 Mar 2024
	* Added initial System.Text.Json deserialization support
	* Added support for setting MessageSendSizeLimit for websocket clients to limit message size
	* Added Exchange name property to IRestClient and ISocketClient interface
	* Abstracted out rest client deserialization so different (de)serializers can be used
	* Cleaned up rest client response handling
	* Continued update of websocket message handling
		* Use ReadonlyMemory<byte> to represent message data to prevent copying data multiple times
		* Switched back to non-async websocket message handling to remove tasks overhead
	* Updated package dependencies to latest versions
	* Updated unit test package dependencies and updated tests accordingly
	* Moved some properties used by the RestApiClient from the BaseApiClient
	* Fixed issue with multiple concurrent subscribe calls in socket client

* Version 7.0.0 - 24 Feb 2024
    * Full overhaul of Websocket message handling
    * Abstracted out Newtonsoft.Json references in preparation of moving to System.Text.Json
    * Updated SendPeriodic to operate on connection level instead of client level to prevent looping when there are no connections
    * Added check to not send an unsubscribe message if there is another subscription listening to the same events
    * Added CryptoRestClient and CryptoSocketClient as aggregate for accessing different exchange APIs
    * Updated socket client log messages
    * Updated socket client GetSubscriptionState output

* Version 6.2.5 - 09 Jan 2024
    * Added support for deserializing null and empty string values to BoolConverter

* Version 6.2.4 - 04 Jan 2024
    * Fixed parsing of DateTime value of zero with additional zero decimal places

* Version 6.2.3 - 02 Dec 2023
    * Fixed requestBodyFormat parameter handling

* Version 6.2.2 - 02 Dec 2023
    * Added support for specifying the request body content type on a per request basis
    * Added DecimalStringWriterConverter
    * Added RequestId to WebCallResult model
    * Updated response logging

* Version 6.2.1 - 28 Oct 2023
    * Utility methods

* Version 6.2.0 - 24 Oct 2023
    * Added SerializerOptions helper class for setting a default serializer
    * Added ParameterCollection helper class for easier parameter definition
    * Added extra helper methods AuthenticationProvider
    * Remove interface entries meant for internal use
    * Added support for writing int values to the EnumConverter

* Version 6.1.5 - 08 Oct 2023
    * Added UpdateType to socket DataEvent
    * Added additional scenarios for BoolConverter
    * Updated some logging

* Version 6.1.4 - 23 Sep 2023
    * Added BoolConverter
    * Added parameter for logging warning message on missing enum entry to EnumConverter

* Version 6.1.3 - 18 Sep 2023
    * Fix for concurrency exception in socket subscription

* Version 6.1.2 - 11 Sep 2023
    * Added support for multiple of the same ratelimiting type in the same rate limiter
    * Fixed nullreference on rate limit error if no Retry-After header is returned

* Version 6.1.1 - 04 Sep 2023
    * Fixes for json converters

* Version 6.1.0 - 24 Aug 2023
    * Added support for ratelimiting on socket connections
    * Added rest ratelimit handling and parsing
    * Added ServerRatelimitError error

* Version 6.0.3 - 23 Jul 2023
    * Fixed Proxy not getting applied in rest clients when not using DI

* Version 6.0.2 - 05 Jul 2023
    * Added properties generic dictionary to SocketConnection

* Version 6.0.1 - 29 Jun 2023
    * Added LogLevel optional parameter to TraceLoggerProvider

* Version 6.0.0 - 25 Jun 2023
    * Updated ApiCredentials to support RSA signing as well as the default Hmac signature
    * Removed custom logging implementation in favor of using `Microsoft.Extensions.Logging` ILogger directly
    * Refactored client options for easier use
    * Added easier way of switching environments
    * Added ResponseLength and ToString() override on WebCallResult object
    * Fixed memory leak in AsyncResetEvent

* Version 5.4.3 - 14 Apr 2023
    * Fixed potential threading exception in socket connection

* Version 5.4.2 - 01 Apr 2023
    * Reverted socket changes as it seems to cause reconnect to hang

* Version 5.4.1 - 18 Mar 2023
    * Added CalculateTradableAmount to SymbolOrderBook
    * Improved socket reconnect robustness
    * Fixed api rate limiter not working correctly

* Version 5.4.0 - 14 Feb 2023
    * Added unsubscribing when receiving subscribe answer after the request timeout has passed
    * Fixed socket options copying
    * Made TimeSync implementation optional
    * Cleaned up ApiCredentials and added better support for extending ApiCredentials

* Version 5.3.1 - 08 Dec 2022
    * Added default request parameter ordering before applying authentication
    * Fixed possible issue where a socket would reconnect when it should close if it was already in reconnecting

* Version 5.3.0 - 14 Nov 2022
    * Reworked client architecture, shifting funcationality to the ApiClient
    * Fixed ArrayConverter exponent parsing
    * Fixed ArrayConverter not checking null
    * Added optional delay setting after establishing socket connection
    * Added callback for revitalizing a socket request when reconnecting
    * Fixed proxy setting websocket

* Version 5.2.4 - 31 Jul 2022
    * Added handling of PlatformNotSupportedException when trying to use websocket from WebAssembly
    * Changed DataEvent to have a public constructor for testing purposes
    * Fixed EnumConverter serializing values without proper quotes
    * Fixed websocket connection reconnecting too quickly when resubscribing/reauthenticating fails

* Version 5.2.3 - 19 Jul 2022
    * Fixed socket getting disconnected when `no data` timeout is reached instead of being reconnected

* Version 5.2.2 - 17 Jul 2022
    * Added support for retrieving a new url when socket connection is lost and reconnection will happen

* Version 5.2.1 - 16 Jul 2022
    * Fixed socket reconnect issue
    * Fixed `message not handled` messages after unsubscribing
    * Fixed error returning for non-json error responses

* Version 5.2.0 - 10 Jul 2022
    * Refactored websocket code, removed some clutter and simplified
    * Added ReconnectAsync and GetSubscriptionsState methods on socket clients

* Version 5.1.12 - 12 Jun 2022
    * Changed time sync so requests no longer wait for it to complete unless it's the first time
    * Made log client options changable after client creation
    * Fixed proxy setting not used when reconnecting socket
    * Changed MaxSocketConnections to a client options
    * Updated socket reconnection logic

* Version 5.1.12 - 12 Jun 2022
    * Changed time sync so requests no longer wait for it to complete unless it's the first time
    * Made log client options changable after client creation
    * Fixed proxy setting not used when reconnecting socket
    * Updated socket reconnection logic

* Version 5.1.11 - 24 May 2022
    * Added KeepAliveInterval setting
    * Fixed port not being copied when setting parameters on request
    * Fixed inconsistent PackageReference casing in csproj

* Version 5.1.10 - 22 May 2022
    * Fixed order book reconnecting while Diposed
    * Fixed exception when disposing socket client while reconnecting
    * Added additional null/default checking in DateTimeConverter
    * Changed ConnectionLost subscription event to run in seperate task to prevent exception/longer operations from intervering with reconnecting

* Version 5.1.9 - 08 May 2022
    * Added latency to the timesync calculation
    * Small fix for exception in socket close handling

* Version 5.1.8 - 01 May 2022
    * Cleanup socket code, fixed an issue which could cause connections to never reconnect when connection was lost
    * Added support for sending requests which expect an empty response
    * Fixed issue with the DateTimeConverter date interpretation

* Version 5.1.7 - 14 Apr 2022
    * Moved some Rest parameters from BaseRestClient to RestApiClient to allow different implementations for sub clients

* Version 5.1.6 - 10 Mar 2022
    * Updated EnumConverter to properly handle emtpy/null and default values

* Version 5.1.5 - 09 Mar 2022
    * Removed ResubscribeMaxRetries default value of 5
    * Updated logging and log verbosity

* Version 5.1.4 - 04 Mar 2022
    * Fixed ArraySerialization handling
    * Added check for invalid rate limit configured for a request

* Version 5.1.3 - 01 Mar 2022
    * Fixed some issues in websocket reconnection, should be more robust now
    * Prevent duplicate data reading on error in rest request
    * Added ApiName to time sync state to improve log feedback

* Version 5.1.2 - 27 Feb 2022
    * Fixed issue where the rate limiter was messing with time syncing
    * Added support for delegate parameters
    * Added `ignoreRateLimit` paramter in `SendRequestAsync`

* Version 5.1.1 - 24 Feb 2022
    * Fixed issue ApiCredentials

* Version 5.1.0 - 24 Feb 2022
    * Improved dispose handling in SymbolOrderBook
    * Fixed TimeSync RecalculationInterval not being respected
    * Small rework client options

* Version 5.0.0
	* Added Github.io page for documentation: https://jkorf.github.io/CryptoExchange.Net/
	* Added single DateTimeConverter replacing the different timestamp converters 
	* Added additional request related properties to WebCallResult
	* Added CancelationToken support for websockets
	* Added CancelationToken support for SymbolOrderBook starting
	* Added TimeSync support
	* Refactored base client classes into BaseClient and ApiClient to provide a more defined client structure
	* Refactored client options to have better control over each different ApiClient
	* Refactored authentication provider to be more flexible
	* Refactored rate limiter implementation
	* Refactored IExchangeClient interface to ISpotClient and IFuturesClient
	* Refactored socket reconnection to immediately try to reconnect before waiting the ReconnectTimeout
	* Improved SymbolOrderBook stability
	* Updated code docs

* Version 4.2.8 - 08 Oct 2021
    * Fixed deadlock in socket receive
    * Fixed issue in reconnection handling when the client is disconnected again during resubscribing
    * Added some additional checking of socket state to prevent sending/expecting data when socket is not connected

* Version 4.2.7 - 06 Oct 2021
    * Made receivedMessages protected again to allow implementations with custom transport (Bittrex) to use it again

* Version 4.2.6 - 06 Oct 2021
    * Fixed an issue causing socket client to stop processing data in .NET Framework

* Version 4.2.5 - 05 Oct 2021
    * Added custom async wait event implementation as previous method seems to not work 100% of the time

* Version 4.2.4 - 30 Sep 2021
    * Fix for InvalidOperationExceptions when running socket connections from .Net framework

* Version 4.2.3 - 29 Sep 2021
    * Added IncomingKbps property to socket/socket client
    * Updated logging
    * Socket performance improvements

* Version 4.2.2 - 23 Sep 2021
    * Restored missing request parameters log

* Version 4.2.1 - 22 Sep 2021
    * Fìx for websocket not automatically reconnecting when connection is closed unexpectedly

* Version 4.2.0 - 20 Sep 2021
    * Prevent reconnect spamming when invalid checksum is calculated in SymbolOrderBook
    * Added default nonce provider implementation

* Version 4.1.0 - 15 Sep 2021
    * Added overload for UnsubscribeAsync with id parameter
    * Added parameter position configuration per HttpMethod type
    * Added option to send custom headers with each requets
    * Added option to send custom headers with individual requests
    * Added debug data on error

* Version 4.0.8 - 26 Aug 2021
    * Added rate limiting option for outgoing messages per socket

* Version 4.0.7 - 24 Aug 2021
    * Additional error info on websocket exception

* Version 4.0.6 - 24 Aug 2021
    * Removed some debug logging

* Version 4.0.5 - 24 Aug 2021
    * Added ConnectionClosed event on UpdateSubscriptions to signal the connection was closed and no reconnecting is happening

* Version 4.0.4 - 24 Aug 2021
    * Websocket connection fixes/improvements
    * Added ChecksumValidationEnabled option for controlling checksum validation in SymbolOrderBook
    * Added MaxReconnectTries option
    * Added MaxResubscribeTries option
    * Added MaxConcurrentResubscriptionsPerSocket option
    * Fix for TimestampSecondsConverter rounding to nearest millisecond

* Version 4.0.3 - 20 Aug 2021
    * Fix for concurrent sent socket issue

* Version 4.0.2 - 20 Aug 2021
    * Fixed socket client continuing before the send/receive loops have been started, which could cause issues when doing concurrent connections

* Version 4.0.1 - 13 Aug 2021
    * Fixed OperationCancelledException when closing socket from a project targeting .net framework

* Version 4.0.0 - 12 Aug 2020
	* Release version, summed up changes from previous beta releases:
		* Removed `Websocket4Net` dependency in favor of a `ClientWebSocket` native implementation for websocket connections
		* Socket events now always come wrapped in a `DataEvent<>` object which contain the timestamp of the data, and optionally the originally received json string
		* Implemented usage of the `Microsoft.Extensions.Logging.Abstractions` `ILogger` interface instead of a custom implementation
		* Added some properties to the `IExchangeClient` interface
			* `ICommonOrder.CommonOrderTime`
			* `ICommonOrder.CommonOrderStatus` enum
			* `ICommonTrade.CommonTradeTime`
		* Added `OnOrderPlaced` and `OnOrderCanceled` events on the `IExchangeClient` interface
		* Added `ExchangeHelpers` static class for various helper methods
		* Removed non-async methods due to too much overhead in development/maintainance
			* If you were previously using non-async methods you can add `.Result` to the end of the async call to get the same result
		* Added `Book` property to `SymbolOrderBook` for a book snapshot
		* Added `CalculateAverageFillPrice` to `SymbolOrderBook` to calculate the average fill price for an order with the current order book state
		* Various fixes

* Version 4.0.0-beta15 - 12 Aug 2021
    * Conditional version Logging.Abstractions

* Version 4.0.0-beta14 - 09 Aug 2021
    * Fix for bug in processing order in SymbolOrderBook

* Version 4.0.0-beta13 - 31 Jul 2021
    * Fix for socket connection

* Version 4.0.0-beta12 - 26 Jul 2021
    * Fix for socket connection

* Version 4.0.0-beta11 - 09 Jul 2021
    * Added CalculateAverageFillPrice to SymbolOrderBook
    * Added Book property to SymbolOrderBook
    * Added Async postfix to async methods

* Version 4.0.0-beta10 - 07 Jul 2021
    * Updated BaseConverter to be case sensitive
    * Added ExchangeHelpers class containing some helper methods
    * Fixed responses not being logged on Trace log level
    * Added some code docs

* Version 4.0.0-beta9 - 17 Jun 2021
    * Small fixes

* Version 4.0.0-beta8 - 08 Jun 2021
    * Fixed exception socket buffer size in .net framework

* Version 4.0.0-beta7 - 07 Jun 2021
    * Added CommonOrderTime to IOrder
    * Added OrderStatus enum for IOrder
    * Added OnOrderPlaced and OnOrderCanceled events on IExchangeClient
    * Added CommonTradeTime to ICommonTrade

* Version 4.0.0-beta6 - 01 jun 2021
    * Some logging adjustments
    * Fixed some async issues

* Version 4.0.0-beta5 - 26 May 2021
    * Added DataEvent wrapper for socket updates
    * Added optional original json output
    * Changed logging implementation to use ILogger

* Version 4.0.0-beta4 - 06 mei 2021
    * Added analyzers
    * Fixed some warnings

* Version 4.0.0-beta3 - 30 Apr 2021
    * Updated socket closing

* Version 4.0.0-beta2 - 30 apr 2021
    * Fix for closing socket without timeout task

* Version 4.0.0-beta1 - 30 apr 2021
    * Removed Websocket4Net dependency
    * Added custom ClientWebSocket implementation
    * Renamed handler -> subscription internally
    * Renamed socket -> socketConenction when type is socketConnection

* Version 3.9.0 - 28 apr 2021
    * Added optional JsonSerializer parameter to SendRequest to use during deserialization
    * Fix for unhandled message warning when unsubscribing a socket subscription

* Version 3.8.1 - 19 apr 2021
    * Added debug logs
	* Added ValidateNullOrNotEmpty extension method

* Version 3.8.0 - 30 mrt 2021
    * Better handling of json errors while deserializing stream
    * Added string datetime converter

* Version 3.7.1 - 10 mrt 2021
    * Performance improvemnt for the ArrayConverter

* Version 3.7.0 - 01 mrt 2021
    * Changed GetResponse in RestClient to protected
    * Added configuration for deterministic build

* Version 3.6.1 - 16 feb 2021
    * Fix for timing related exception when stopping an symbol order book

* Version 3.6.0 - 22 jan 2021
    * Added CommonVolume and CommonOpenTime to ICommonKline interface

* Version 3.5.0 - 11 jan 2021
    * Additional info on exception messages
    * Added support for rate limiting using credits

* Version 3.4.0 - 21 dec 2020
    * Updated IExchangeClient interface
    * Fix for dropping message after timeout on socket
    * Added virtual HandleUnhandledMessage method in SocketClient

* Version 3.3.0 - 10 dec 2020
    * Added client name
    * Added common interfaces
    * Fixed api key plain text storing in RateLimitterApiKey

* Version 3.2.1 - 19 nov 2020
    * Fixed error code parsing

* Version 3.2.0 - 19 nov 2020
    * Fix for multiple socket subscriptions re-using the same socket connection
    * Updated errors

* Version 3.1.0 - 08 Oct 2020
    * Added CallResult without type parameter for calls which don't return data
    * Added GetErrorOrResult method on CallResult to support proper nullability checking
    * Fix for reading credentials from file
    * Fix for setting custom base addresses in clients

* Version 3.0.15 - 06 Oct 2020
    * Changed default ShouldCheckObjects to false to prevent spam in logging

* Version 3.0.14 - 24 Aug 2020
    * Updated exception message logging

* Version 3.0.13 - 24 Aug 2020
    * Added request tracing id for logging
    * Added shared HttpClient option

* Version 3.0.12 - 12 Aug 2020
    * Named parameters on SymbolOrderBook events

* Version 3.0.11 - 20 Jun 2020
	* Added support for checksum in SymbolOrderBook

* Version 3.0.10 - 16 Jun 2020
    * Fix for order book synchronization

* Version 3.0.9 - 07 Jun 2020
	* Added arraySerialization and postParameterPosition to AuthenticationProvider interface
	* Fixed array serialization in request body

* Version 3.0.8 - 02 Jun 2020
	* Added requestBodyEmptyContent setting for rest client
	* Added TryParseError for rest implementations to check for error with success status code

* Version 3.0.7 - 20 May 2020
    * Added error debug output
    * Fix for unsubscribe causing possible deadlock

* Version 3.0.6 - 03 Mar 2020
    * Added BestOffer to SymbolOrderBook, removed invalid check on proxy

* Version 3.0.5 - 05 Feb 2020
    * Added PausedActivity events on socket subscriptions

* Version 3.0.4 - 29 Jan 2020
	* Removed unnecessary json serialization

* Version 3.0.3 - 23 Jan 2020
    * Added OnBestOffersChanged event to order book implementations

* Version 3.0.2 - 10 Dec 2019
    * Removed invalid check for unauthenticated proxy

* Version 3.0.1 - 14 Nov 2019
    * Re-enabled debug response logging

* Version 3.0.0 - 23 Oct 2019
	* Updated to C# 8.0
	* Added .NetStandard2.1 support
	* Added Nullability support
	* Now using HttpClient instead of WebRequest, should result in faster consequtive requests
	* Added CancellationToken support
	* Added bool compare override to CallResult (now possible to `if(callresult)` instead of `if(callresult.Success)`)
	* Added input validation methods
		* Wrong input will now throw exceptions rather than error results
	* OnOrderBookUpdate event added to `SymbolOrderBook`


* Version 2.1.8 - 29 Aug 2019
    * Added array serialization options for implementations

* Version 2.1.7 - 07 Aug 2019
    * Fixed bug with socket connection not being disposed after lost connection
    * Resubscribing after reconnecting socket now in parallel

* Version 2.1.6 - 06 Aug 2019
    * Fix for missing subscription events if they are also a request response, added code docs

* Version 2.1.5 - 09 jul 2019
	* Updated SymbolOrderBook

* Version 2.1.4 - 24 jun 2019
	* Added checks for json deserialization issues

* Version 2.1.3 - 16 may 2019
	* Refactored SymbolOrderBook
	* Added BestBid/BestAsk properties for order book

* Version 2.1.2 - 14 may 2019
	* Added order book base class for easy implementation
	* Added additional constructor to ApiCredentials to be able to read from file
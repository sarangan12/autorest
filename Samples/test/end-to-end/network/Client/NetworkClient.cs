// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Microsoft Azure Network management API provides a RESTful set of
    /// web services that interact with Microsoft Azure Networks service to
    /// manage your network resources. The API has entities that capture the
    /// relationship between an end user and the Microsoft Azure Networks
    /// service.
    /// </summary>
    public partial class NetworkClient : ServiceClient<NetworkClient>, INetworkClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The subscription credentials which uniquely identify the Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every service
        /// call.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Client API version.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IApplicationGatewaysOperations.
        /// </summary>
        public virtual IApplicationGatewaysOperations ApplicationGateways { get; private set; }

        /// <summary>
        /// Gets the IExpressRouteCircuitAuthorizationsOperations.
        /// </summary>
        public virtual IExpressRouteCircuitAuthorizationsOperations ExpressRouteCircuitAuthorizations { get; private set; }

        /// <summary>
        /// Gets the IExpressRouteCircuitPeeringsOperations.
        /// </summary>
        public virtual IExpressRouteCircuitPeeringsOperations ExpressRouteCircuitPeerings { get; private set; }

        /// <summary>
        /// Gets the IExpressRouteCircuitsOperations.
        /// </summary>
        public virtual IExpressRouteCircuitsOperations ExpressRouteCircuits { get; private set; }

        /// <summary>
        /// Gets the IExpressRouteServiceProvidersOperations.
        /// </summary>
        public virtual IExpressRouteServiceProvidersOperations ExpressRouteServiceProviders { get; private set; }

        /// <summary>
        /// Gets the ILoadBalancersOperations.
        /// </summary>
        public virtual ILoadBalancersOperations LoadBalancers { get; private set; }

        /// <summary>
        /// Gets the INetworkInterfacesOperations.
        /// </summary>
        public virtual INetworkInterfacesOperations NetworkInterfaces { get; private set; }

        /// <summary>
        /// Gets the INetworkSecurityGroupsOperations.
        /// </summary>
        public virtual INetworkSecurityGroupsOperations NetworkSecurityGroups { get; private set; }

        /// <summary>
        /// Gets the ISecurityRulesOperations.
        /// </summary>
        public virtual ISecurityRulesOperations SecurityRules { get; private set; }

        /// <summary>
        /// Gets the INetworkWatchersOperations.
        /// </summary>
        public virtual INetworkWatchersOperations NetworkWatchers { get; private set; }

        /// <summary>
        /// Gets the IPacketCapturesOperations.
        /// </summary>
        public virtual IPacketCapturesOperations PacketCaptures { get; private set; }

        /// <summary>
        /// Gets the IPublicIPAddressesOperations.
        /// </summary>
        public virtual IPublicIPAddressesOperations PublicIPAddresses { get; private set; }

        /// <summary>
        /// Gets the IRouteFiltersOperations.
        /// </summary>
        public virtual IRouteFiltersOperations RouteFilters { get; private set; }

        /// <summary>
        /// Gets the IRouteFilterRulesOperations.
        /// </summary>
        public virtual IRouteFilterRulesOperations RouteFilterRules { get; private set; }

        /// <summary>
        /// Gets the IRouteTablesOperations.
        /// </summary>
        public virtual IRouteTablesOperations RouteTables { get; private set; }

        /// <summary>
        /// Gets the IRoutesOperations.
        /// </summary>
        public virtual IRoutesOperations Routes { get; private set; }

        /// <summary>
        /// Gets the IBgpServiceCommunitiesOperations.
        /// </summary>
        public virtual IBgpServiceCommunitiesOperations BgpServiceCommunities { get; private set; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        public virtual IUsagesOperations Usages { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworksOperations.
        /// </summary>
        public virtual IVirtualNetworksOperations VirtualNetworks { get; private set; }

        /// <summary>
        /// Gets the ISubnetsOperations.
        /// </summary>
        public virtual ISubnetsOperations Subnets { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworkPeeringsOperations.
        /// </summary>
        public virtual IVirtualNetworkPeeringsOperations VirtualNetworkPeerings { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworkGatewaysOperations.
        /// </summary>
        public virtual IVirtualNetworkGatewaysOperations VirtualNetworkGateways { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworkGatewayConnectionsOperations.
        /// </summary>
        public virtual IVirtualNetworkGatewayConnectionsOperations VirtualNetworkGatewayConnections { get; private set; }

        /// <summary>
        /// Gets the ILocalNetworkGatewaysOperations.
        /// </summary>
        public virtual ILocalNetworkGatewaysOperations LocalNetworkGateways { get; private set; }

        /// <summary>
        /// Initializes a new instance of the NetworkClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected NetworkClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected NetworkClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected NetworkClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the NetworkClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected NetworkClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the NetworkClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public NetworkClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the NetworkClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public NetworkClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the NetworkClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public NetworkClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the NetworkClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public NetworkClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            ApplicationGateways = new ApplicationGatewaysOperations(this);
            ExpressRouteCircuitAuthorizations = new ExpressRouteCircuitAuthorizationsOperations(this);
            ExpressRouteCircuitPeerings = new ExpressRouteCircuitPeeringsOperations(this);
            ExpressRouteCircuits = new ExpressRouteCircuitsOperations(this);
            ExpressRouteServiceProviders = new ExpressRouteServiceProvidersOperations(this);
            LoadBalancers = new LoadBalancersOperations(this);
            NetworkInterfaces = new NetworkInterfacesOperations(this);
            NetworkSecurityGroups = new NetworkSecurityGroupsOperations(this);
            SecurityRules = new SecurityRulesOperations(this);
            NetworkWatchers = new NetworkWatchersOperations(this);
            PacketCaptures = new PacketCapturesOperations(this);
            PublicIPAddresses = new PublicIPAddressesOperations(this);
            RouteFilters = new RouteFiltersOperations(this);
            RouteFilterRules = new RouteFilterRulesOperations(this);
            RouteTables = new RouteTablesOperations(this);
            Routes = new RoutesOperations(this);
            BgpServiceCommunities = new BgpServiceCommunitiesOperations(this);
            Usages = new UsagesOperations(this);
            VirtualNetworks = new VirtualNetworksOperations(this);
            Subnets = new SubnetsOperations(this);
            VirtualNetworkPeerings = new VirtualNetworkPeeringsOperations(this);
            VirtualNetworkGateways = new VirtualNetworkGatewaysOperations(this);
            VirtualNetworkGatewayConnections = new VirtualNetworkGatewayConnectionsOperations(this);
            LocalNetworkGateways = new LocalNetworkGatewaysOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2016-12-01";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
        /// <summary>
        /// Checks whether a domain name in the cloudapp.net zone is available for use.
        /// </summary>
        /// <param name='location'>
        /// The location of the domain name.
        /// </param>
        /// <param name='domainNameLabel'>
        /// The domain name to be verified. It must conform to the following regular
        /// expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<DnsNameAvailabilityResult>> CheckDnsNameAvailabilityWithHttpMessagesAsync(string location, string domainNameLabel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "location");
            }
            if (ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.ApiVersion");
            }
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.SubscriptionId");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("location", location);
                tracingParameters.Add("domainNameLabel", domainNameLabel);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "CheckDnsNameAvailability", tracingParameters);
            }
            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/CheckDnsNameAvailability").ToString();
            _url = _url.Replace("{location}", System.Uri.EscapeDataString(location));
            _url = _url.Replace("{subscriptionId}", System.Uri.EscapeDataString(SubscriptionId));
            List<string> _queryParameters = new List<string>();
            if (domainNameLabel != null)
            {
                _queryParameters.Add(string.Format("domainNameLabel={0}", System.Uri.EscapeDataString(domainNameLabel)));
            }
            if (ApiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(ApiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (GenerateClientRequestId != null && GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    CloudError _errorBody =  SafeJsonConvert.DeserializeObject<CloudError>(_responseContent, DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex = new CloudException(_errorBody.Message);
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_httpResponse.Headers.Contains("x-ms-request-id"))
                {
                    ex.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                }
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<DnsNameAvailabilityResult>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<DnsNameAvailabilityResult>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}

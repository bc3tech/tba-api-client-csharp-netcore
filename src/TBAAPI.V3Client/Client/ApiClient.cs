/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace TBAAPI.V3Client.Client;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using RestSharp;
using RestSharp.Deserializers;

using RestSharpMethod = RestSharp.Method;

/// <summary>
/// Allows RestSharp to Serialize/Deserialize JSON using our custom logic, but only when ContentType is JSON. 
/// </summary>
internal partial class CustomJsonCodec : RestSharp.Serializers.ISerializer, IDeserializer
{
    private readonly IReadableConfiguration _configuration;
    private static readonly string _contentType = "application/json";
    private readonly JsonSerializerOptions _serializerSettings = new()
    {
        // OpenAPI generated types generally hide default constructors.
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };

    public CustomJsonCodec(IReadableConfiguration configuration) => _configuration = configuration;

    public CustomJsonCodec(JsonSerializerOptions serializerSettings, IReadableConfiguration configuration)
    {
        _serializerSettings = serializerSettings;
        _configuration = configuration;
    }

    public string Serialize(object obj)
    {
        var result = JsonSerializer.Serialize(obj, obj.GetType(), _serializerSettings);
        return result;
    }

    public T Deserialize<T>(IRestResponse response)
    {
        var result = (T)Deserialize(response, typeof(T));
        return result;
    }

    /// <summary>
    /// Deserialize the JSON string into a proper object.
    /// </summary>
    /// <param name="response">The HTTP response.</param>
    /// <param name="type">Object type.</param>
    /// <returns>Object representation of the JSON string.</returns>
    internal object Deserialize(IRestResponse response, Type type)
    {
        IList<Parameter> headers = response.Headers;
        if (type == typeof(byte[])) // return byte array
        {
            return response.RawBytes;
        }

        // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
        if (type == typeof(Stream))
        {
            if (headers != null)
            {
                var filePath = string.IsNullOrEmpty(_configuration.TempFolderPath)
                    ? Path.GetTempPath()
                    : _configuration.TempFolderPath;
                Regex regex = ContentDispositionRegex();
                foreach (Parameter header in headers)
                {
                    Match match = regex.Match(header.ToString());
                    if (match.Success)
                    {
                        var fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                        File.WriteAllBytes(fileName, response.RawBytes);
                        return new FileStream(fileName, FileMode.Open);
                    }
                }
            }

            var stream = new MemoryStream(response.RawBytes);
            return stream;
        }

        if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
        {
            return DateTime.Parse(response.Content, null, System.Globalization.DateTimeStyles.RoundtripKind);
        }

        if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
        {
            return Convert.ChangeType(response.Content, type);
        }

        // at this point, it must be a model (json)
        try
        {
            return JsonSerializer.Deserialize(response.Content, type, _serializerSettings);
        }
        catch (Exception e)
        {
            throw new ApiException(500, e.Message);
        }
    }

    public string RootElement { get; set; }
    public string Namespace { get; set; }
    public string DateFormat { get; set; }

    public string ContentType
    {
        get => _contentType;
        set => throw new InvalidOperationException("Not allowed to set content type.");
    }

    [GeneratedRegex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$")]
    private static partial Regex ContentDispositionRegex();
}
/// <summary>
/// Provides a default implementation of an Api client (both synchronous and asynchronous implementatios),
/// encapsulating general REST accessor use cases.
/// </summary>
public partial class ApiClient : ISynchronousClient, IAsynchronousClient
{
    private readonly string _baseUrl;

    /// <summary>
    /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
    /// </summary>
    /// <param name="request">The RestSharp request object</param>
    partial void InterceptRequest(IRestRequest request);

    /// <summary>
    /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
    /// </summary>
    /// <param name="request">The RestSharp request object</param>
    /// <param name="response">The RestSharp response object</param>
    partial void InterceptResponse(IRestRequest request, IRestResponse response);

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient" />, defaulting to the global configurations' base url.
    /// </summary>
    public ApiClient() => _baseUrl = GlobalConfiguration.Instance.BasePath;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient" />
    /// </summary>
    /// <param name="basePath">The target service's base path in URL format.</param>
    /// <exception cref="ArgumentException"></exception>
    public ApiClient(string basePath)
    {
        if (string.IsNullOrEmpty(basePath))
        {
            throw new ArgumentException("basePath cannot be empty");
        }

        _baseUrl = basePath;
    }

    /// <summary>
    /// Constructs the RestSharp version of an http method
    /// </summary>
    /// <param name="method">Swagger Client Custom HttpMethod</param>
    /// <returns>RestSharp's HttpMethod instance.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private static RestSharpMethod Method(HttpMethod method)
    {
        RestSharpMethod other = method switch
        {
            HttpMethod.Get => RestSharpMethod.GET,
            HttpMethod.Post => RestSharpMethod.POST,
            HttpMethod.Put => RestSharpMethod.PUT,
            HttpMethod.Delete => RestSharpMethod.DELETE,
            HttpMethod.Head => RestSharpMethod.HEAD,
            HttpMethod.Options => RestSharpMethod.OPTIONS,
            HttpMethod.Patch => RestSharpMethod.PATCH,
            _ => throw new ArgumentOutOfRangeException(nameof(method), method, null),
        };
        return other;
    }

    /// <summary>
    /// Provides all logic for constructing a new RestSharp <see cref="RestRequest"/>.
    /// At this point, all information for querying the service is known. Here, it is simply
    /// mapped into the RestSharp request.
    /// </summary>
    /// <param name="method">The http verb.</param>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>[private] A new RestRequest instance.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    private static RestRequest NewRequest(
        HttpMethod method,
        string path,
        RequestOptions options,
        IReadableConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(path);
        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(configuration);

        RestRequest request = new(Method(method))
        {
            Resource = path,
            JsonSerializer = new CustomJsonCodec(configuration)
        };

        if (options.PathParameters != null)
        {
            foreach (KeyValuePair<string, string> pathParam in options.PathParameters)
            {
                request.AddParameter(pathParam.Key, pathParam.Value, ParameterType.UrlSegment);
            }
        }

        if (options.QueryParameters != null)
        {
            foreach (KeyValuePair<string, IList<string>> queryParam in options.QueryParameters)
            {
                foreach (var value in queryParam.Value)
                {
                    request.AddQueryParameter(queryParam.Key, value);
                }
            }
        }

        if (configuration.DefaultHeaders != null)
        {
            foreach (KeyValuePair<string, string> headerParam in configuration.DefaultHeaders)
            {
                request.AddHeader(headerParam.Key, headerParam.Value);
            }
        }

        if (options.HeaderParameters != null)
        {
            foreach (KeyValuePair<string, IList<string>> headerParam in options.HeaderParameters)
            {
                foreach (var value in headerParam.Value)
                {
                    request.AddHeader(headerParam.Key, value);
                }
            }
        }

        if (options.FormParameters != null)
        {
            foreach (KeyValuePair<string, string> formParam in options.FormParameters)
            {
                request.AddParameter(formParam.Key, formParam.Value);
            }
        }

        if (options.Data != null)
        {
            if (options.HeaderParameters != null)
            {
                IList<string> contentTypes = options.HeaderParameters["Content-Type"];
                if (contentTypes == null || contentTypes.Any(header => header.Contains("application/json")))
                {
                    request.RequestFormat = DataFormat.Json;
                }
                else
                {
                    // TODO: Generated client user should add additional handlers. RestSharp only supports XML and JSON, with XML as default.
                }
            }
            else
            {
                // Here, we'll assume JSON APIs are more common. XML can be forced by adding produces/consumes to openapi spec explicitly.
                request.RequestFormat = DataFormat.Json;
            }

            request.AddJsonBody(options.Data);
        }

        if (options.FileParameters != null)
        {
            foreach (KeyValuePair<string, Stream> fileParam in options.FileParameters)
            {
                var bytes = ClientUtils.ReadAsBytes(fileParam.Value);
                if (fileParam.Value is FileStream fileStream)
                {
                    request.Files.Add(FileParameter.Create(fileParam.Key, bytes, Path.GetFileName(fileStream.Name)));
                }
                else
                {
                    request.Files.Add(FileParameter.Create(fileParam.Key, bytes, "no_file_name_provided"));
                }
            }
        }

        if (options.Cookies != null && options.Cookies.Count > 0)
        {
            foreach (Cookie cookie in options.Cookies)
            {
                request.AddCookie(cookie.Name, cookie.Value);
            }
        }

        return request;
    }

    private static ApiResponse<T> ToApiResponse<T>(IRestResponse<T> response)
    {
        T result = response.Data;
        var rawContent = response.Content;

        var transformed = new ApiResponse<T>(response.StatusCode, [], result, rawContent)
        {
            ErrorText = response.ErrorMessage,
            Cookies = []
        };

        if (response.Headers != null)
        {
            foreach (Parameter responseHeader in response.Headers)
            {
                transformed.Headers.Add(responseHeader.Name, ClientUtils.ParameterToString(responseHeader.Value));
            }
        }

        if (response.Cookies != null)
        {
            foreach (RestResponseCookie responseCookies in response.Cookies)
            {
                transformed.Cookies.Add(
                    new Cookie(
                        responseCookies.Name,
                        responseCookies.Value,
                        responseCookies.Path,
                        responseCookies.Domain)
                    );
            }
        }

        return transformed;
    }

    private ApiResponse<T> Exec<T>(RestRequest req, IReadableConfiguration configuration)
    {
        RestClient client = new(_baseUrl);

        client.ClearHandlers();
        var existingDeserializer = req.JsonSerializer as IDeserializer;
        if (existingDeserializer is not null)
        {
            IDeserializer factory() => existingDeserializer;
            client.AddHandler("application/json", factory);
            client.AddHandler("text/json", factory);
            client.AddHandler("text/x-json", factory);
            client.AddHandler("text/javascript", factory);
            client.AddHandler("*+json", factory);
        }
        else
        {
            var customCodec = new CustomJsonCodec(configuration);
            IDeserializer factory() => customCodec;
            client.AddHandler("application/json", factory);
            client.AddHandler("text/json", factory);
            client.AddHandler("text/x-json", factory);
            client.AddHandler("text/javascript", factory);
            client.AddHandler("*+json", factory);
        }

        var xmlSerializerInstance = new XmlDeserializer();
        IDeserializer xmlDeserializerFactory() => xmlSerializerInstance;
        client.AddHandler("application/xml", xmlDeserializerFactory);
        client.AddHandler("text/xml", xmlDeserializerFactory);
        client.AddHandler("*+xml", xmlDeserializerFactory);
        client.AddHandler("*", xmlDeserializerFactory);

        client.Timeout = configuration.Timeout;

        if (configuration.UserAgent != null)
        {
            client.UserAgent = configuration.UserAgent;
        }

        if (configuration.ClientCertificates != null)
        {
            client.ClientCertificates = configuration.ClientCertificates;
        }

        InterceptRequest(req);

        IRestResponse<T> response = client.Execute<T>(req);

        InterceptResponse(req, response);

        ApiResponse<T> result = ToApiResponse(response);
        if (response.ErrorMessage != null)
        {
            result.ErrorText = response.ErrorMessage;
        }

        if (response.Cookies != null && response.Cookies.Count > 0)
        {
            result.Cookies ??= [];

            foreach (RestResponseCookie restResponseCookie in response.Cookies)
            {
                var cookie = new Cookie(
                    restResponseCookie.Name,
                    restResponseCookie.Value,
                    restResponseCookie.Path,
                    restResponseCookie.Domain
                )
                {
                    Comment = restResponseCookie.Comment,
                    CommentUri = restResponseCookie.CommentUri,
                    Discard = restResponseCookie.Discard,
                    Expired = restResponseCookie.Expired,
                    Expires = restResponseCookie.Expires,
                    HttpOnly = restResponseCookie.HttpOnly,
                    Port = restResponseCookie.Port,
                    Secure = restResponseCookie.Secure,
                    Version = restResponseCookie.Version
                };

                result.Cookies.Add(cookie);
            }
        }

        return result;
    }

    private async Task<ApiResponse<T>> ExecAsync<T>(RestRequest req, IReadableConfiguration configuration)
    {
        RestClient client = new(_baseUrl);

        client.ClearHandlers();
        if (req.JsonSerializer is IDeserializer existingDeserializer)
        {
            IDeserializer factory() => existingDeserializer;
            client.AddHandler("application/json", factory);
            client.AddHandler("text/json", factory);
            client.AddHandler("text/x-json", factory);
            client.AddHandler("text/javascript", factory);
            client.AddHandler("*+json", factory);
        }
        else
        {
            var customCodec = new CustomJsonCodec(configuration);
            IDeserializer factory() => customCodec;
            client.AddHandler("application/json", factory);
            client.AddHandler("text/json", factory);
            client.AddHandler("text/x-json", factory);
            client.AddHandler("text/javascript", factory);
            client.AddHandler("*+json", factory);
        }

        var xmlSerializerInstance = new XmlDeserializer();
        IDeserializer xmlDeserializerFactory() => xmlSerializerInstance;
        client.AddHandler("application/xml", xmlDeserializerFactory);
        client.AddHandler("text/xml", xmlDeserializerFactory);
        client.AddHandler("*+xml", xmlDeserializerFactory);
        client.AddHandler("*", xmlDeserializerFactory);

        client.Timeout = configuration.Timeout;

        if (configuration.UserAgent != null)
        {
            client.UserAgent = configuration.UserAgent;
        }

        if (configuration.ClientCertificates != null)
        {
            client.ClientCertificates = configuration.ClientCertificates;
        }

        InterceptRequest(req);

        IRestResponse<T> response = await client.ExecuteAsync<T>(req);

        InterceptResponse(req, response);

        ApiResponse<T> result = ToApiResponse(response);
        if (response.ErrorMessage != null)
        {
            result.ErrorText = response.ErrorMessage;
        }

        if (response.Cookies != null && response.Cookies.Count > 0)
        {
            result.Cookies ??= [];

            foreach (RestResponseCookie restResponseCookie in response.Cookies)
            {
                var cookie = new Cookie(
                    restResponseCookie.Name,
                    restResponseCookie.Value,
                    restResponseCookie.Path,
                    restResponseCookie.Domain
                )
                {
                    Comment = restResponseCookie.Comment,
                    CommentUri = restResponseCookie.CommentUri,
                    Discard = restResponseCookie.Discard,
                    Expired = restResponseCookie.Expired,
                    Expires = restResponseCookie.Expires,
                    HttpOnly = restResponseCookie.HttpOnly,
                    Port = restResponseCookie.Port,
                    Secure = restResponseCookie.Secure,
                    Version = restResponseCookie.Version
                };

                result.Cookies.Add(cookie);
            }
        }

        return result;
    }

    #region IAsynchronousClient
    /// <summary>
    /// Make a HTTP GET request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return ExecAsync<T>(NewRequest(HttpMethod.Get, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP POST request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return ExecAsync<T>(NewRequest(HttpMethod.Post, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP PUT request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return ExecAsync<T>(NewRequest(HttpMethod.Put, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP DELETE request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return ExecAsync<T>(NewRequest(HttpMethod.Delete, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP HEAD request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return ExecAsync<T>(NewRequest(HttpMethod.Head, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP OPTION request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return ExecAsync<T>(NewRequest(HttpMethod.Options, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP PATCH request (async).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return ExecAsync<T>(NewRequest(HttpMethod.Patch, path, options, config), config);
    }
    #endregion IAsynchronousClient

    #region ISynchronousClient
    /// <summary>
    /// Make a HTTP GET request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public ApiResponse<T> Get<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return Exec<T>(NewRequest(HttpMethod.Get, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP POST request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public ApiResponse<T> Post<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return Exec<T>(NewRequest(HttpMethod.Post, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP PUT request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public ApiResponse<T> Put<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return Exec<T>(NewRequest(HttpMethod.Put, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP DELETE request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public ApiResponse<T> Delete<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return Exec<T>(NewRequest(HttpMethod.Delete, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP HEAD request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public ApiResponse<T> Head<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return Exec<T>(NewRequest(HttpMethod.Head, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP OPTION request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public ApiResponse<T> Options<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return Exec<T>(NewRequest(HttpMethod.Options, path, options, config), config);
    }

    /// <summary>
    /// Make a HTTP PATCH request (synchronous).
    /// </summary>
    /// <param name="path">The target path (or resource).</param>
    /// <param name="options">The additional request options.</param>
    /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
    /// GlobalConfiguration has been done before calling this method.</param>
    /// <returns>A Task containing ApiResponse</returns>
    public ApiResponse<T> Patch<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
    {
        IReadableConfiguration config = configuration ?? GlobalConfiguration.Instance;
        return Exec<T>(NewRequest(HttpMethod.Patch, path, options, config), config);
    }
    #endregion ISynchronousClient
}

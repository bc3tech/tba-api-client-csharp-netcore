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
using System.Net;

/// <summary>
/// Provides a non-generic contract for the ApiResponse wrapper.
/// </summary>
public interface IApiResponse
{
    /// <summary>
    /// The data type of <see cref="Content"/>
    /// </summary>
    Type ResponseType { get; }

    /// <summary>
    /// The content of this response
    /// </summary>
    object? Content { get; }

    /// <summary>
    /// Gets or sets the status code (HTTP status code)
    /// </summary>
    /// <value>The status code.</value>
    HttpStatusCode StatusCode { get; }

    /// <summary>
    /// Gets or sets the HTTP headers
    /// </summary>
    /// <value>HTTP headers</value>
    Multimap<string, string?> Headers { get; }

    /// <summary>
    /// Gets or sets any error text defined by the calling client.
    /// </summary>
    string? ErrorText { get; set; }

    /// <summary>
    /// Gets or sets any cookies passed along on the response.
    /// </summary>
    IList<Cookie>? Cookies { get; set; }

    /// <summary>
    /// The raw content of this response
    /// </summary>
    string? RawContent { get; }
}

/// <summary>
/// API Response
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
/// </remarks>
/// <param name="statusCode">HTTP status code.</param>
/// <param name="headers">HTTP headers.</param>
/// <param name="data">Data (parsed HTTP body)</param>
/// <param name="rawContent">Raw content.</param>
public class ApiResponse<T>(HttpStatusCode statusCode, Multimap<string, string?>? headers, T? data, string? rawContent) : IApiResponse
{
    #region Properties

    /// <summary>
    /// Gets or sets the status code (HTTP status code)
    /// </summary>
    /// <value>The status code.</value>
    public HttpStatusCode StatusCode { get; } = statusCode;

    /// <summary>
    /// Gets or sets the HTTP headers
    /// </summary>
    /// <value>HTTP headers</value>
    public Multimap<string, string?> Headers { get; } = headers ?? [];

    /// <summary>
    /// Gets or sets the data (parsed HTTP body)
    /// </summary>
    /// <value>The data.</value>
    public T? Data { get; } = data;

    /// <summary>
    /// Gets or sets any error text defined by the calling client.
    /// </summary>
    public string? ErrorText { get; set; }

    /// <summary>
    /// Gets or sets any cookies passed along on the response.
    /// </summary>
    public IList<Cookie>? Cookies { get; set; }

    /// <summary>
    /// The content of this response
    /// </summary>
    public Type ResponseType => typeof(T);

    /// <summary>
    /// The data type of <see cref="Content"/>
    /// </summary>
    public object? Content => this.Data;

    /// <summary>
    /// The raw content
    /// </summary>
    public string? RawContent { get; } = rawContent;

    #endregion Properties
    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
    /// </summary>
    /// <param name="statusCode">HTTP status code.</param>
    /// <param name="headers">HTTP headers.</param>
    /// <param name="data">Data (parsed HTTP body)</param>
    public ApiResponse(HttpStatusCode statusCode, Multimap<string, string?> headers, T data) : this(statusCode, headers, data, null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
    /// </summary>
    /// <param name="statusCode">HTTP status code.</param>
    /// <param name="data">Data (parsed HTTP body)</param>
    /// <param name="rawContent">Raw content.</param>
    public ApiResponse(HttpStatusCode statusCode, T data, string? rawContent) : this(statusCode, null, data, rawContent)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
    /// </summary>
    /// <param name="statusCode">HTTP status code.</param>
    /// <param name="data">Data (parsed HTTP body)</param>
    public ApiResponse(HttpStatusCode statusCode, T data) : this(statusCode, data, null)
    {
    }

    #endregion Constructors
}

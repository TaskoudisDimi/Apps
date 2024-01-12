using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{

    #region Cookie


    //static async Task Main(string[] args)
    //{
    //    // Perform authentication to obtain the cookie value
    //    string cookieValue = await PerformAuthenticationAndGetCookieValue();

    //    if (!string.IsNullOrEmpty(cookieValue))
    //    {
    //        // Use the obtained cookie value in subsequent requests
    //        await MakeAuthenticatedRequestWithCookie(cookieValue);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Failed to obtain the authentication cookie value.");
    //    }
    //}

    //static async Task<string> PerformAuthenticationAndGetCookieValue()
    //{
    //    using var httpClient = new HttpClient();

    //    // Perform authentication (e.g., sending credentials to a login endpoint)
    //    // Replace the URL and authentication credentials with your actual authentication logic
    //    var loginData = new StringContent(
    //        JsonSerializer.Serialize(new
    //        {
    //            username = "DimTask",
    //            password = "9963"
    //            // Add other authentication parameters as needed
    //        }),
    //        Encoding.UTF8,
    //        "application/json"
    //    );

    //    var loginResponse = await httpClient.PostAsync("https://localhost:7008/login", loginData);

    //    if (loginResponse.IsSuccessStatusCode)
    //    {
    //        // Retrieve the authentication cookie value from the response headers
    //        if (loginResponse.Headers.TryGetValues("Set-Cookie", out var cookieValues))
    //        {
    //            foreach (var cookie in cookieValues)
    //            {
    //                if (cookie.StartsWith("AuthCookie="))
    //                {
    //                    // Extract the value of the authentication cookie
    //                    var cookieParts = cookie.Split(';')[0].Split('=');
    //                    if (cookieParts.Length == 2)
    //                    {
    //                        return cookieParts[1];
    //                    }
    //                }
    //            }
    //        }
    //    }

    //    return null;
    //}

    //static async Task MakeAuthenticatedRequestWithCookie(string cookieValue)
    //{
    //    using var httpClient = new HttpClient();

    //    // Set the obtained authentication cookie value in the request headers
    //    httpClient.DefaultRequestHeaders.Add("Cookie", $"AuthCookie={cookieValue}");

    //    // Replace the URL with your API endpoint
    //    string apiUrl = "https://localhost:7008/api/Product/cookie";

    //    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

    //    if (response.IsSuccessStatusCode)
    //    {
    //        string content = await response.Content.ReadAsStringAsync();
    //        Console.WriteLine("Response from API: " + content);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Failed to authenticate. Status code: " + response.StatusCode);
    //    }
    //}


    #endregion

    #region JWT

    //static async Task Main(string[] args)
    //{
    //    // Perform authentication to obtain the JWT
    //    string jwtToken = await PerformAuthenticationAndGetJwt();

    //    if (!string.IsNullOrEmpty(jwtToken))
    //    {
    //        Console.WriteLine("JWT Token obtained: " + jwtToken);
    //        // Use the obtained JWT in subsequent requests
    //        await MakeAuthenticatedRequestWithJwt(jwtToken);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Failed to obtain the JWT.");
    //    }
    //}

    //static async Task<string> PerformAuthenticationAndGetJwt()
    //{
    //    using var httpClient = new HttpClient();

    //    // Perform authentication (e.g., sending credentials to a login endpoint)
    //    var loginData = new StringContent(
    //        JsonSerializer.Serialize(new
    //        {
    //            username = "Dimitask",
    //            password = "9963"
    //            // Add other authentication parameters as needed
    //        }),
    //        Encoding.UTF8,
    //        "application/json"
    //    );

    //    var loginResponse = await httpClient.PostAsync("https://localhost:7008/login", loginData);

    //    if (loginResponse.IsSuccessStatusCode)
    //    {
    //        // Extract the JWT from the response content
    //        var responseContent = await loginResponse.Content.ReadAsStringAsync();
    //        var tokenObject = JsonSerializer.Deserialize<Dictionary<string, string>>(responseContent);

    //        if (tokenObject.TryGetValue("token", out var jwtToken))
    //        {
    //            return jwtToken;
    //        }
    //    }

    //    return null;
    //}

    //static async Task MakeAuthenticatedRequestWithJwt(string jwtToken)
    //{
    //    using var httpClient = new HttpClient();

    //    // Set the obtained JWT in the Authorization header
    //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);

    //    // Replace the URL with your API endpoint
    //    string apiUrl = "https://localhost:7008/api/Product/jwt";

    //    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

    //    if (response.IsSuccessStatusCode)
    //    {
    //        string content = await response.Content.ReadAsStringAsync();
    //        Console.WriteLine("Response from API: " + content);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Failed to authenticate. Status code: " + response.StatusCode);
    //    }
    //}

    #endregion

    #region Basic Auth

    //// Replace with your actual username and password for Basic Authentication
    //private const string Username = "Dimitask";
    //private const string Password = "9963";

    //static async Task Main(string[] args)
    //{
    //    await MakeAuthenticatedRequestWithBasicAuth();
    //}

    //static async Task MakeAuthenticatedRequestWithBasicAuth()
    //{
    //    using var httpClient = new HttpClient();

    //    // Encode the credentials in Base64
    //    var authHeaderValue = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));

    //    // Set the Authorization header with Basic authentication credentials
    //    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authHeaderValue);

    //    // Replace the URL with your API endpoint
    //    string apiUrl = "https://localhost:7008/api/Product/BasicAuth";

    //    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

    //    if (response.IsSuccessStatusCode)
    //    {
    //        string content = await response.Content.ReadAsStringAsync();
    //        Console.WriteLine("Response from API: " + content);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Failed to authenticate. Status code: " + response.StatusCode);
    //    }
    //}

    #endregion

    #region API Key

    //static async Task Main(string[] args)
    //{
    //    await MakeRequest("https://localhost:7008/api/Product/ApiKey", "ztpvzE5zFnxyXZbCoTsrrkzS5d9VNO");
    //}

    //private static async Task MakeRequest(string apiURL, string apiKey)
    //{
    //    using var httpClient = new HttpClient();

    //    if (!string.IsNullOrEmpty(apiKey))
    //    {
    //        httpClient.DefaultRequestHeaders.Add("Api-Key", apiKey);
    //    }

    //    HttpResponseMessage response = await httpClient.GetAsync(apiURL);

    //    if (response.IsSuccessStatusCode)
    //    {
    //        string content = await response.Content.ReadAsStringAsync();
    //        Console.WriteLine("Response from API: " + content);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Failed to authenticate. Status code: " + response.StatusCode);
    //    }


    //}


    #endregion

    #region OAuth 



    #endregion
}

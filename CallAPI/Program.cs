using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
    //    var loginData = new FormUrlEncodedContent(new[]
    //    {
    //        new KeyValuePair<string, string>("username", "yourUsername"),
    //        new KeyValuePair<string, string>("password", "yourPassword")
    //        // Add other authentication parameters as needed
    //    });

    //    var loginResponse = await httpClient.PostAsync("https://yourapi.com/login", loginData);

    //    if (loginResponse.IsSuccessStatusCode)
    //    {
    //        // Retrieve the authentication cookie value from the response headers
    //        if (loginResponse.Headers.TryGetValues("Set-Cookie", out var cookieValues))
    //        {
    //            foreach (var cookie in cookieValues)
    //            {
    //                if (cookie.StartsWith("MyCookie="))
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
    //    httpClient.DefaultRequestHeaders.Add("Cookie", $"MyCookie={cookieValue}");

    //    // Replace the URL with your API endpoint
    //    string apiUrl = "https://yourapi.com/protectedEndpoint";

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
    //// Replace with the actual JWT token received after successful authentication
    //private const string YourJwtToken = "YOUR_JWT_TOKEN_HERE";

    //static async Task Main(string[] args)
    //{
    //    if (!string.IsNullOrEmpty(YourJwtToken))
    //    {
    //        await MakeAuthenticatedRequestWithJwt();
    //    }
    //    else
    //    {
    //        Console.WriteLine("Please provide a valid JWT token.");
    //    }
    //}

    //static async Task MakeAuthenticatedRequestWithJwt()
    //{
    //    using var httpClient = new HttpClient();

    //    // Set the JWT token in the Authorization header
    //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", YourJwtToken);

    //    // Replace the URL with your API endpoint
    //    string apiUrl = "https://yourapi.com/protectedEndpoint";

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
    //private const string Username = "yourUsername";
    //private const string Password = "yourPassword";

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
    //    string apiUrl = "https://yourapi.com/protectedEndpoint";

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
}

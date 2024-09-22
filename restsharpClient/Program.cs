// using RestSharp;
// using System;
// using System.Net;
// using System.Net.Security;
// using System.Security.Cryptography.X509Certificates;
// using System.Threading.Tasks;

// public class Program
// {
//     public static async Task Main()
//     {
//         // Ignore SSL certificate errors (not recommended for production)
//         ServicePointManager.ServerCertificateValidationCallback +=
//         (sender, certificate, chain, sslPolicyErrors) => true;

//         Console.WriteLine("Starting request...");
//         var restClientOptions = new RestClientOptions("https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0") {
//             RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
//         };

//         var client = new RestClient(restClientOptions);
        
//         var request = new RestRequest("/report", Method.Get);
//         request.AddHeader("connection", "keep-alive");
//         request.AddHeader("API-Key", "eyJraWQiOiJnYXRld2F5X2NlcnRpZmljYXRlX2FsaWFzIiwiYWxnIjoiUlMyNTYifQ.eyJzdWIiOiJjZmNiOGQ5ZC0zNzEwLTQ1ZWUtYWU1NS1lNzNmMzA2NWQxNTNAY2FyYm9uLnN1cGVyIiwiYXVkIjoiY2hvcmVvOmRlcGxveW1lbnQ6c2FuZGJveCIsImlzcyI6Imh0dHBzOlwvXC9zdHMuY2hvcmVvLmRldjo0NDNcL2FwaVwvYW1cL3B1Ymxpc2hlclwvdjJcL2FwaXNcL2ludGVybmFsLWtleSIsImtleXR5cGUiOiJTQU5EQk9YIiwic3Vic2NyaWJlZEFQSXMiOlt7InN1YnNjcmliZXJUZW5hbnREb21haW4iOm51bGwsIm5hbWUiOiJuZXdhcGlwcm94eSIsImNvbnRleHQiOiJcLzRiOWFmZWZiLTRiY2MtNGU2My04NWQzLWRkZDU5Mzg0MTAxMlwveXN4clwvbmV3YXBpcHJveHlcL3YxLjAiLCJwdWJsaXNoZXIiOiJjZmNiOGQ5ZC0zNzEwLTQ1ZWUtYWU1NS1lNzNmMzA2NWQxNTMiLCJ2ZXJzaW9uIjoidjEuMCIsInN1YnNjcmlwdGlvblRpZXIiOm51bGx9XSwiZXhwIjoxNzI0MzM1MjM5LCJ0b2tlbl90eXBlIjoiSW50ZXJuYWxLZXkiLCJpYXQiOjE3MjQzMzQ2MzksImp0aSI6IjBlNWVkNGNlLWI5NzctNDgyMC1hZjcwLWI1NDBiZWU0YjFjYyJ9.O6pS5dZBb9l59wkNqzEFj-2xNv9gQtviOBkRDTRnrB8x4xRgvcAFnoSepLjE0q4AoSxyQBAFKLwx3ARUxD8MgpKl6BfmT0HhkX-dLYHX-X-CmF0XfU24mnHhs87GA6NS5E-MUCNPqhUg1IBrPZCOqncL2f1PXAyqBQQqRTM8DeIisP7LjSHN0yMoN6oQWE_EFZ36hMouRT3_oPOB3EVHNymptEwnEneqiBHHQOwJj7XNF-RrPb0XgiMng-evxYUxqDrGbQ1KsBJoDZ6Zaw0cHvjV-iyELyfSks1iwaVDBW4VXbrv8WhNabyZynDO-l2YByxC1kPzbssxfonVIgGL0HTfJRRt7A0-IQ-0Y69pLGCyMqpsoRd6nnLrAXnIbG6pbQEWwuEGAU1Gh4YVWBBaZ3m7R7vMKmjjpclLBVVQk7u17NfP5MlgYvO53Ye2CLEua4OHsHTkFbO23y6HfdFltYj6MDQSYigYHoC9KUuApf0_echRvqeaJDk_AwNQOzmReNinxV0mBN4fURpjwJ4173_0XBqtRJmA2dXPocHxFsXTK58XnuLHkgZtESfJSGo8CDMpWjIrLysLxt--IWQ70tFtZ36lxtoS11s_7EklBATOW77bscym9Ere34iISxlhCsVsZEcCsdgyvcV9cMFZRrq95sT79IpMARjAmvqmbe8");


//         const int maxRetries = 10;
//         int retryCount = 0;
//         bool success = false;

//         while (retryCount < maxRetries && !success)
//         {
//             Console.WriteLine($"\nAttempt {retryCount + 1} of {maxRetries}:");

//             try
//             {
//                 var response = await client.ExecuteAsync(request);

//                 if (response.IsSuccessful)
//                 {
//                     Console.WriteLine("Response Content:");
//                     Console.WriteLine(response.Content);
//                     success = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Error: {response.StatusCode} - {response.StatusDescription}");
//                     Console.WriteLine("Response Code:");
//                     Console.WriteLine(response.StatusCode);
//                     Console.WriteLine("Response Content:");
//                     Console.WriteLine(response.Content);

//                     if (response.ErrorException != null)
//                     {
//                         Console.WriteLine("Exception:");
//                         Console.WriteLine(response.ErrorException);
//                     }

//                     retryCount++;

//                     if (retryCount < maxRetries)
//                     {
//                         Console.WriteLine("Retrying...\n");
//                         await Task.Delay(2000);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Max retry attempts reached. Exiting.");
//                     }
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("An exception occurred:");
//                 Console.WriteLine(ex);
//                 break;
//             }
//         }
//     }
// }


// using System;
// using System.IO;
// using System.Net;
// using System.Security.Cryptography.X509Certificates;
// using System.Threading.Tasks;

// public class Program
// {
//     public static async Task Main()
//     {
//         const string url = "https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0/report";
//         const int maxRetries = 10;
//         int retryCount = 0;
//         bool success = false;

//         // Ignore SSL certificate errors (not recommended for production)
//         ServicePointManager.ServerCertificateValidationCallback = 
//             (sender, certificate, chain, sslPolicyErrors) => true;

//         while (retryCount < maxRetries)
//         {
//             Console.WriteLine($"\nAttempt {retryCount + 1} of {maxRetries}:");

//             try
//             {
//                 // Create the HttpWebRequest
//                 HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
//                 request.Method = "GET";

//                 // Print request details
//                 Console.WriteLine("Request Details:");
//                 Console.WriteLine($"URL: {request.RequestUri}");
//                 Console.WriteLine($"Method: {request.Method}");

//                 // Send the request and get the response
//                 using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
//                 {
//                     Console.WriteLine($"Status Code: {response.StatusCode}");

//                     // Read and print the response
//                     using (StreamReader reader = new StreamReader(response.GetResponseStream()))
//                     {
//                         string responseText = await reader.ReadToEndAsync();
//                         Console.WriteLine("Response Content:");
//                         Console.WriteLine(responseText);
//                     }
//                     success = true;
//                 }
//             }
//             catch (WebException webEx) when (webEx.Response is HttpWebResponse errorResponse)
//             {
//                 Console.WriteLine($"Error: {errorResponse.StatusCode} - {errorResponse.StatusDescription}");

//                 // Print the exception details
//                 if (webEx.Status == WebExceptionStatus.ProtocolError)
//                 {
//                     using (StreamReader reader = new StreamReader(errorResponse.GetResponseStream()))
//                     {
//                         string errorText = await reader.ReadToEndAsync();
//                         Console.WriteLine("Response Content:");
//                         Console.WriteLine(errorText);
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Exception:");
//                     Console.WriteLine(webEx);
//                 }

//                 retryCount++;

//                 if (retryCount < maxRetries)
//                 {
//                     Console.WriteLine("Retrying...\n");
//                     await Task.Delay(2000); // Optional: Wait for 2 seconds before retrying
//                 }
//                 else
//                 {
//                     Console.WriteLine("Max retry attempts reached. Exiting.");
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("An exception occurred:");
//                 Console.WriteLine(ex);
//                 break;
//             }
//         }
//     }
// }

using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {

        const string url = "https://prod2.thuhsnaidevenv.work.gd/usproject/mediationProxyAPI/v1.0";
        const int maxRetries = 3600;
        int retryCount = 0;
        bool success = false;

        // Ignore SSL certificate errors (not recommended for production)
        ServicePointManager.ServerCertificateValidationCallback = 
            (sender, certificate, chain, sslPolicyErrors) => true;

            while (retryCount < maxRetries && !success)
        {
            Console.WriteLine($"\nAttempt {retryCount + 1} of {maxRetries}:");

            try
            {
                Uri uri = new Uri(url);
                IPHostEntry hostEntry = await Dns.GetHostEntryAsync(uri.Host);
                IPEndPoint endPoint = new IPEndPoint(hostEntry.AddressList[0], uri.Port);

                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    await socket.ConnectAsync(endPoint);
                    using (NetworkStream networkStream = new NetworkStream(socket, false))
                    using (SslStream sslStream = new SslStream(networkStream, false, ValidateServerCertificate, null))
                    {
                        await sslStream.AuthenticateAsClientAsync(uri.Host);

                        string request = $"GET {uri.PathAndQuery} HTTP/1.1\r\nHost: {uri.Host}\r\nConnection: close\r\n\r\n";
                        byte[] requestBytes = Encoding.ASCII.GetBytes(request);
                        await sslStream.WriteAsync(requestBytes, 0, requestBytes.Length);

                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            await sslStream.CopyToAsync(memoryStream);
                            string response = Encoding.ASCII.GetString(memoryStream.ToArray());

                            Console.WriteLine("Response Content:");
                            Console.WriteLine(response);
                        }

                        retryCount++;
                    }

                    // Set linger option and close the socket
                    socket.LingerState = new LingerOption(true, 0);
                    socket.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                retryCount++;

                if (retryCount < maxRetries)
                {
                    Console.WriteLine("Retrying...\n");
                    await Task.Delay(2000);
                }
                else
                {
                    Console.WriteLine("Max retry attempts reached. Exiting.");
                }
            }
        }
    }

    private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        // For testing purposes, accept all certificates
        // In production, you should properly validate the certificate
        return true;
    }
}

// TCP RETRANSMISSION

// Error: Cannot access a disposed object.
// Object name: 'System.Net.Sockets.Socket'.
// Retrying...

// while (retryCount < maxRetries && !success)
//         {
//             Console.WriteLine($"\nAttempt {retryCount + 1} of {maxRetries}:");

//             try
//             {
//                 Uri uri = new Uri(url);
//                 using (TcpClient tcpClient = new TcpClient())
//                 {
//                     await tcpClient.ConnectAsync(uri.Host, uri.Port);
//                     using (SslStream sslStream = new SslStream(tcpClient.GetStream(), false, ValidateServerCertificate, null))
//                     {
//                         await sslStream.AuthenticateAsClientAsync(uri.Host);

//                         string request = $"GET {uri.PathAndQuery} HTTP/1.1\r\nHost: {uri.Host}\r\nConnection: close\r\n\r\n";
//                         byte[] requestBytes = Encoding.ASCII.GetBytes(request);
//                         await sslStream.WriteAsync(requestBytes, 0, requestBytes.Length);

//                         using (MemoryStream memoryStream = new MemoryStream())
//                         {
//                             await sslStream.CopyToAsync(memoryStream);
//                             string response = Encoding.ASCII.GetString(memoryStream.ToArray());

//                             Console.WriteLine("Response Content:");
//                             Console.WriteLine(response);
//                         }

//                         success = true;
//                     }

//                     // Set linger option before closing
//                     tcpClient.Client.LingerState = new LingerOption(true, 0);
//                 }
//                 // The TcpClient is now disposed, which will close the underlying socket
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Error: {ex.Message}");
//                 retryCount++;

//                 if (retryCount < maxRetries)
//                 {
//                     Console.WriteLine("Retrying...\n");
//                     await Task.Delay(2000);
//                 }
//                 else
//                 {
//                     Console.WriteLine("Max retry attempts reached. Exiting.");
//                 }
//             }
//         }
//     }

//     private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
//     {
//         // For testing purposes, accept all certificates
//         // In production, you should properly validate the certificate
//         return true;
//     }

// using System;
// using System.IO;
// using System.Net;
// using System.Security.Cryptography.X509Certificates;
// using System.Threading.Tasks;

// public class Program
// {
//     public static async Task Main()
//     {
//         const string url = "https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0/report";
//         const int maxRetries = 10;
//         int retryCount = 0;
//         bool success = false;

//         // Ignore SSL certificate errors (not recommended for production)
//         ServicePointManager.ServerCertificateValidationCallback = 
//             (sender, certificate, chain, sslPolicyErrors) => true;

//         while (retryCount < maxRetries)
//         {
//             Console.WriteLine($"\nAttempt {retryCount + 1} of {maxRetries}:");

//                 // Create the HttpWebRequest
//                 HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
//                 request.Method = "GET";

//                 // Print request details
//                 Console.WriteLine("Request Details:");
//                 Console.WriteLine($"URL: {request.RequestUri}");
//                 Console.WriteLine($"Method: {request.Method}");

//                 // Send the request and get the response
//                 using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
//                 {
//                     Console.WriteLine($"Status Code: {response.StatusCode}");

//                     // Read and print the response
//                     using (StreamReader reader = new StreamReader(response.GetResponseStream()))
//                     {
//                         string responseText = await reader.ReadToEndAsync();
//                         Console.WriteLine("Response Content:");
//                         Console.WriteLine(responseText);
//                     }
//                     success = true;
//                 }
//     }
// }
// }

// /* Running for 10 times socket httpwebrequest*/

// using System;
// using System.Net.Sockets;
// using System.Text;

// public class Program
// {
//     public static void Main()
//     {
//         Uri uri = new Uri("https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0/report");

//         // Loop to send the request 10 times
//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine($"\nRequest {i + 1}:");
//             SendHttpRequest(uri, 443);
//             Console.WriteLine($"\nEnd of Request {i + 1}");
//         }
//     }

//     private static void SendHttpRequest(Uri? uri = null, int port = 80)
//     {
//         uri ??= new Uri("https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0/report/1");

//         // Construct a minimalistic HTTP/1.1 request
//         byte[] requestBytes = Encoding.ASCII.GetBytes(@$"GET {uri.AbsoluteUri} HTTP/1.0
//             Host: {uri.Host}
//             Connection: Keep-Alive

//         ");

//         var IpEndPoint = new IPEndPoint(IPAddress.Parse("20.22.170.145"), 443);
//         // Create and connect a dual-stack socket
//         using Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
//         // socket.SetSocketOption( SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true );
//         socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
//         socket.Connect(IpEndPoint);
//         // socket.Connect(uri.Host, port);

//         // Send the request.
//         int bytesSent = 0;
//         while (bytesSent < requestBytes.Length)
//         {
//             bytesSent += socket.Send(requestBytes, bytesSent, requestBytes.Length - bytesSent, SocketFlags.None);
//         }

//         // Do minimalistic buffering assuming ASCII response
//         byte[] responseBytes = new byte[256];
//         char[] responseChars = new char[256];

//         while (true)
//         {
//             int bytesReceived = socket.Receive(responseBytes);

//             // Receiving 0 bytes means EOF has been reached
//             if (bytesReceived == 0) break;

//             // Convert byteCount bytes to ASCII characters using the 'responseChars' buffer as destination
//             int charCount = Encoding.ASCII.GetChars(responseBytes, 0, bytesReceived, responseChars, 0);

//             // Print the contents of the 'responseChars' buffer to Console.Out
//             Console.Out.Write(responseChars, 0, charCount);
//         }
//     }
// }

/* Running for 10 times keepalive*/
// using System;
// using System.Net.Sockets;
// using System.Text;

// public class Program
// {
//     public static void Main()
//     {
//         Uri uri = new Uri("https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0/report");

//         // Loop to send the request 10 times
//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine($"\nRequest {i + 1}:");
//             SendHttpRequest(uri, 443);
//             Console.WriteLine($"\nEnd of Request {i + 1}");
//         }
//     }

//     private static void SendHttpRequest(Uri? uri = null, int port = 80)
//     {
//         uri ??= new Uri("https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0/report");

//         // Construct a minimalistic HTTP/1.1 request
//         byte[] requestBytes = Encoding.ASCII.GetBytes(@$"GET {uri.AbsoluteUri} HTTP/1.0
//             Host: {uri.Host}
//             Connection: Keep-Alive

//         ");

//         // Create and connect a new socket for each request attempt
//         using Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

//         // Enable TCP Keep-Alive
//         socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);

//         // Set keep-alive options (macOS/Linux compatible)
//         socket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveTime, 5); // Idle time before sending keep-alive probes (in seconds)
//         socket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveInterval, 1); // Interval between keep-alive probes (in seconds)

//         try
//         {
//             socket.Connect(uri.Host, port);

//             // Send the request.
//             int bytesSent = 0;
//             while (bytesSent < requestBytes.Length)
//             {
//                 bytesSent += socket.Send(requestBytes, bytesSent, requestBytes.Length - bytesSent, SocketFlags.None);
//             }

//             // Do minimalistic buffering assuming ASCII response
//             byte[] responseBytes = new byte[256];
//             char[] responseChars = new char[256];

//             while (true)
//             {
//                 int bytesReceived = socket.Receive(responseBytes);

//                 // Receiving 0 bytes means EOF has been reached
//                 if (bytesReceived == 0) break;

//                 // Convert byteCount bytes to ASCII characters using the 'responseChars' buffer as destination
//                 int charCount = Encoding.ASCII.GetChars(responseBytes, 0, bytesReceived, responseChars, 0);

//                 // Print the contents of the 'responseChars' buffer to Console.Out
//                 Console.Out.Write(responseChars, 0, charCount);
//             }
//         }
//         catch (SocketException ex)
//         {
//             Console.WriteLine($"Connection attempt failed: {ex.Message}");
//             // Handle specific socket exceptions as needed
//         } catch (Exception ex) {
//             Console.WriteLine($"Connection attempt failed: {ex.Message}");
//         }
//     }
// }




// using System;
// using RestSharp;

// public class Program
// {
//     public static void Main()
//     {
//         // Use a non-existent or intentionally refusing server IP/port to trigger the exception
//         string baseUrl = "https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0"; // This IP should be unreachable or refusing connections
//         string resource = "/report";

//         try
//         {
//             var client = new RestClient(baseUrl);
//             var request = new RestRequest(resource, Method.Get);

//             // Attempt to execute the request
//             var response = client.Execute(request);

//             // Print response details
//             Console.WriteLine($"Status Code: {response.StatusCode}");
//             Console.WriteLine($"Response Content: {response.Content}");
//             Console.WriteLine($"Error Message: {response.ErrorMessage}");
//             Console.WriteLine($"Error Exception: {response.ErrorException}");
//         }
//         catch (Exception ex)
//         {
//             // Catch any exceptions and print the details
//             Console.WriteLine($"Exception: {ex.Message}");
//             Console.WriteLine($"Stack Trace: {ex.StackTrace}");
//         }
//     }
// }

// using System;
// using RestSharp;

// public class Program
// {
//     public static async Task Main()
//     {
//         string baseUrl = "https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0/report"; // Replace with your actual URL
//         string resource = "/report";

//         // Ignore SSL certificate errors (not recommended for production)
//                 ServicePointManager.ServerCertificateValidationCallback = 
//                     (sender, certificate, chain, sslPolicyErrors) => true;

// //         while (retryCount < maxRetries)
// //         {
// //             Console.WriteLine($"\nAttempt {retryCount + 1} of {maxRetries}:");

// //                 // Create the HttpWebRequest
// //                 HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
// //                 request.Method = "GET";
//         try
//         {
//             // var client = new RestClient(baseUrl);
//             // var request = new RestRequest(resource, Method.Get);

//             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl);
//             request.Method = "GET";

//             // Attempt to execute the request
//             using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())

//             // Print response details
//             Console.WriteLine($"Status Code: {response.StatusCode}");
//             // Console.WriteLine($"Response Content: {response.}");
//             // Console.WriteLine($"Error Message: {response.ErrorMessage}");
//             // Console.WriteLine($"Error Exception: {response.ErrorException}");
//         }
//         catch (System.Security.Authentication.AuthenticationException authEx)
//         {
//             Console.WriteLine($"SSL/TLS Authentication Exception: {authEx.Message}");
//             Console.WriteLine($"Stack Trace: {authEx.StackTrace}");
//         }
//         catch (System.Net.Http.HttpRequestException httpReqEx)
//         {
//             Console.WriteLine($"HTTP Request Exception: {httpReqEx.Message}");
//             Console.WriteLine($"Stack Trace: {httpReqEx.StackTrace}");
//         }
//         catch (Exception ex)
//         {
//             // Catch any other exceptions
//             Console.WriteLine($"Exception: {ex.Message}");
//             Console.WriteLine($"Stack Trace: {ex.StackTrace}");
//         }
//     }
// }


















// using System;
// using RestSharp;
// using System.Collections.Generic;

// public class CustomHttpClient
// {
//     private readonly string _baseUrl;
//     private readonly int _port;
//     private readonly bool _useSsl;

//     public CustomHttpClient(string baseUrl, int port = 443, bool useSsl = true)
//     {
//         _baseUrl = baseUrl;
//         _port = port;
//         _useSsl = useSsl;
//     }

//     public string SendRequest(string method, string path, IDictionary<string, string>? headers = null, string? body = null)
//     {
//         // Determine the correct scheme and port
//         var scheme = _useSsl ? "https" : "http";
//         var url = $"{scheme}://{_baseUrl}:{_port}{path}";

//         // Create the RestClient
//         var client = new RestClient(url);

//         // Create the request and set the method
//         var request = new RestRequest
//         {
//             Method = method.ToUpper() switch
//             {
//                 "GET" => Method.Get,
//                 "POST" => Method.Post,
//                 "PUT" => Method.Put,
//                 "DELETE" => Method.Delete,
//                 _ => throw new ArgumentException("Unsupported HTTP method", nameof(method))
//             }
//         };

//         // Add headers to the request
//         if (headers != null)
//         {
//             foreach (var header in headers)
//             {
//                 request.AddHeader(header.Key, header.Value);
//             }
//         }

//         // Add body to the request
//         if (!string.IsNullOrEmpty(body))
//         {
//             request.AddStringBody(body, DataFormat.None);
//         }

//         // Execute the request and get the response
//         var response = client.Execute(request);

//         // Return the response content or throw an exception if the request was unsuccessful
//         if (response.IsSuccessful)
//         {
//             return response.Content;
//         }
//         else
//         {
//             throw new Exception($"Request failed with status {response.StatusCode}: {response}");
//         }
//     }
// }

// // Usage example
// public class Program
// {
//     public static void Main()
//     {
//         try
//         {
//             var client = new CustomHttpClient("https://dev.thushanitest.work.gd/ysxr/newapiproxy/v1.0", useSsl: true);
//             var response = client.SendRequest("GET", "/report", headers: new Dictionary<string, string>
//             {
//                 { "User-Agent", "CustomClient/1.0" }
//             });

//             Console.WriteLine(response);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An error occurred: {ex}");
//         }
//     }
// }


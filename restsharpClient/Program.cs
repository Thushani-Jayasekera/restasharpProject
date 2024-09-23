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
                Console.WriteLine($"Resolving host: {uri.Host}");
                IPHostEntry hostEntry = await Dns.GetHostEntryAsync(uri.Host);
                Console.WriteLine($"Resolved IP: {hostEntry.AddressList[0]}");
                IPEndPoint endPoint = new IPEndPoint(hostEntry.AddressList[0], uri.Port);

                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    await socket.ConnectAsync(endPoint);

                    // Set keep-alive
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                    socket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveTime, 60);

                    using (NetworkStream networkStream = new NetworkStream(socket, false))
                    using (SslStream sslStream = new SslStream(networkStream, false, ValidateServerCertificate, null))
                    {
                        await sslStream.AuthenticateAsClientAsync(uri.Host);

                        string request = $"GET {uri.PathAndQuery} HTTP/1.1\r\nHost: {uri.Host}\r\nConnection: keep-alive\r\n\r\n";
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
                    await Task.Delay(TimeSpan.FromSeconds(60));

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


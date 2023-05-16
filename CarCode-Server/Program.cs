using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Sockets;

namespace CarCode_Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 8008);
            NetworkStream stream = null;

            try
            {
                tcpListener.Start();
                while(true)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    Task.Run(() =>
                    {
                        Console.WriteLine($"Client connected {client.Client.RemoteEndPoint}");
                        stream = client.GetStream();
                        StreamReader reader = new StreamReader(stream);
                        StreamWriter writer = new StreamWriter(stream);

                        while(client.Connected)
                        {
                            string message = reader.ReadLine();
                            Console.WriteLine($"You received the following message:");
                            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} :: {message}");

                            string responseMessage;
                            if (message.Length > 2)
                                responseMessage = FindRegionCode(message);
                            else
                                responseMessage = FindRegion(message);

                            writer.WriteLine(responseMessage);
                            writer.Flush();
                        }
                        Console.WriteLine("Client closed connection");
                    });
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null) stream.Close();
                tcpListener.Stop();
            }
        }
        public static string FindRegion(string code)
        {
            string result = "Not found!";
            using (DbContextCarCode db = new DbContextCarCode())
            {
                var regions = db.CarNumberCodes.Include(r => r.Region).ToList();
                var codeRegion = regions.FirstOrDefault(r => r.RegionCode == code);
                if (codeRegion != null)
                    result = codeRegion.Region.RegionName;
            }
            return result;
        }
        public static string FindRegionCode(string region)
        {
            string result = "Not found!";
            using (DbContextCarCode db = new DbContextCarCode())
            {
                var codes = db.CarNumberCodes.Include(c => c.Region).ToList();
                var regionCodes = codes.Where(c => c.Region.RegionName == region);
                if (regionCodes != null)
                    result = String.Join("/", regionCodes.Select(c => c.RegionCode));
            }
            return result;
        }
    }
}
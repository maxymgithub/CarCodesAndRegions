using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarCode_Client
{
    public partial class MainWindow : Window
    {
        TcpClient client = new TcpClient();
        NetworkStream stream = null;
        StreamReader reader = null;
        StreamWriter writer = null;
        public MainWindow()
        {
            InitializeComponent();
            ConnectClient();
        }
        private void ConnectClient()
        {
            try
            {
                string hostName = Dns.GetHostName();
                var host = Dns.GetHostEntry(hostName);
                string myIP = null;
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        myIP = ip.ToString();
                }
                if (myIP != null)
                    client.Connect(myIP, 8008);
                //client.Connect("192.168.0.104", 8008); // Ввести свій IP
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void codeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (codeInput.Text == null)
                MessageBox.Show("Enter region code!");
            else
            {
                try
                {
                    writer.WriteLine(codeInput.Text.ToUpper());
                    writer.Flush();

                    result.Text = reader.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void regionBtn_Click(object sender, RoutedEventArgs e)
        {
            if (regionInput.Text == null)
                MessageBox.Show("Enter region!");
            else
            {
                try
                {
                    writer.WriteLine(regionInput.Text);
                    writer.Flush();

                    result.Text = reader.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (stream != null) stream.Close();
            client.Close();
            reader.Close();
            writer.Close();
        }
    }
}

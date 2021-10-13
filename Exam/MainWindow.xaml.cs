using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam
{
    public partial class MainWindow : Window
    {
        NotifyIcon notifyIcon = new NotifyIcon();
        public MainWindow()
        {
            InitializeComponent();
            notifyIcon.Visible = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

            notifyIcon.BalloonTipText = "Waiting for notification...";
            notifyIcon.ShowBalloonTip(1000);
            if (WindowState == WindowState.Normal)
            {
                Hide();
                notifyIcon.Visible = true;
            }

            notifyIcon.Icon = new Icon("C:\\Users\\Гульзада\\Desktop\\Step\\1.ico");

            Connect();
        }

        public string Connect()
        {
            string responseData = String.Empty;
            try
            {
                int port = 5001;
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);

                server.Bind(endPoint);
                byte[] data = new byte[1024];
                                
                EndPoint endPoint_2 = endPoint;
                int bytes = server.ReceiveFrom(data, ref endPoint_2);
                responseData = Encoding.UTF8.GetString(data, 0, bytes);

                notifyIcon.BalloonTipText = responseData;
                notifyIcon.ShowBalloonTip(1000);
                string logMessage = "Successfully received notification! " + " Time: " + DateTime.Now + "\n";
                CreateLog(logMessage);

                server.Close();
            }           
            catch (SocketException e)
            {
                string logMessage = "SocketException: " + e + " Time: " + DateTime.Now + "\n";
                CreateLog(logMessage);               
            }
                        
            return responseData;
        }

        public void CreateLog(string logMessage)
        {
            try
            {                
                string currentFilePath = Directory.GetCurrentDirectory() + "/logs.txt";
                FileStream fs = new FileStream(currentFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                                
                byte[] data = Encoding.UTF8.GetBytes(logMessage);
                fs.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

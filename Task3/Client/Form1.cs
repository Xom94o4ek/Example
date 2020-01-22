using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private int port = 8888;
        private string server = "127.0.0.1";
        public Form1()
        {
            InitializeComponent();
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ipTextBox.Text)) server = ipTextBox.Text;
            if (!String.IsNullOrEmpty(portTextBox.Text)) port = Convert.ToInt32(portTextBox.Text);
            if (!String.IsNullOrEmpty(messageTextBox.Text) && !String.IsNullOrEmpty(nameTextBox.Text))
            {
                try
                {
                    TcpClient client = new TcpClient();
                    client.Connect(server, port);

                    byte[] data = new byte[256];
                    StringBuilder response = new StringBuilder();
                    NetworkStream stream = client.GetStream();

                    string send_message = String.Format("{0}:{1}", nameTextBox.Text, messageTextBox.Text);
                    data = System.Text.Encoding.UTF8.GetBytes(send_message);
                    stream.Write(data, 0, data.Length);
                    resultTextBox.AppendText("Отправлен текст: " + send_message + "\r\n");

                    do
                    {
                        int bytes = stream.Read(data, 0, data.Length);
                        response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable); // пока данные есть в потоке

                    resultTextBox.AppendText("Принятый текст: " + response.ToString() + "\r\n");

                    // Закрываем потоки
                    stream.Close();
                    client.Close();
                }
                catch (SocketException ex)
                {
                    resultTextBox.AppendText(String.Format("SocketException: {0}", ex));
                }
                catch (Exception ex)
                {
                    resultTextBox.AppendText(String.Format("Exception: {0}", ex.Message));
                }
                resultTextBox.AppendText("Запрос завершен...\r\n");
            }
            else
            {
                MessageBox.Show("Пустая строка!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        const int port = 8888; // порт для прослушивания подключений
        static void Main(string[] args)
        {
            TcpListener server = null;
            string path = "Log.txt";
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, port);

                // запуск слушателя
                server.Start();

                while (true)
                {
                    Console.WriteLine("Ожидание подключений... ");

                    // получаем входящее подключение
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Подключен клиент. Выполнение запроса...");

                    // получаем сетевой поток для чтения и записи
                    NetworkStream stream = client.GetStream();

                    byte[] data = new byte[256];
                    int bytes = stream.Read(data, 0, data.Length); // получаем количество считанных байтов
                    string message = Encoding.UTF8.GetString(data, 0, bytes);
                    Console.WriteLine("Принятое сообщение: {0}", message);
                    string[] text = message.Split(':');
                    if (text[0] == "Вася")
                    {
                        File.AppendAllText(path, message + "\r\n");
                        Console.WriteLine("Сообщение записано в файл!");
                    }

                    // сообщение для отправки клиенту
                    string response = "Сообщение успешно принято";
                    // преобразуем сообщение в массив байтов
                    data = Encoding.UTF8.GetBytes(response);

                    // отправка сообщения
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("Отправлено сообщение: {0}", response);
                    // закрываем поток
                    stream.Close();
                    // закрываем подключение
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (server != null)
                    server.Stop();
            }
        }
    }
}

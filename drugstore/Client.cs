using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace drugstore
{
    public class Client
    {
        private static Client instance;
        public static List<byte> data, response;
        public static char JSONend;
        public static byte[] bytesRead;
        public static Socket tcpClient;

        public static Client GetInstance()
        {
            if (instance == null)
            {
                instance = new Client();
            }
            return instance;
        }
        public enum SentDataMessages
        {
            SUCCESS,
            ERROR
        }
        public enum QueryTypes
        {
            EXIT,
            LOGIN,
            REGISTER,
            SEARCH,
            GET_CART,
            ADD_TO_CART,
            GET_BY_ID,
            DELETE_FROM_CART,
            SET_CART_ITEM_COUNT,
            ADD_TO_CATALOG
        }

        public async Task Send(List<byte> data, object sender)
        {
            // System.Windows.Forms.MessageBox.Show("SEND");
            
            data = Encoding.UTF8.GetBytes(sender.ToString() + "\n").ToList();
            await tcpClient.SendAsync(new ArraySegment<byte>(data.ToArray()), SocketFlags.None);
            while (true)
            {
                await tcpClient.ReceiveFromAsync(new ArraySegment<byte>(bytesRead), SocketFlags.None, new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888));
                // смотрим, если считанный байт представляет конечный символ, выходим
                //if (string.IsNullOrEmpty(Encoding.UTF8.GetString(bytesRead))) MessageBox.Show("NO");
                if (bytesRead[0] == '\n')
                {

                    //response.Add(Encoding.UTF8.GetBytes(JSONend.ToString())[0]);

                    break;
                }
                // иначе добавляем в буфер
                response.Add(bytesRead[0]);
                

            }

            //MessageBox.Show(response.Count.ToString());
            //if (response.Count == 1) response = Encoding.UTF8.GetBytes("[]").ToList(); 
            //if (response.Count > 0 && !Encoding.UTF8.GetString(response.ToArray()).Contains("]")) response.Add(Encoding.UTF8.GetBytes("]")[0]);
            App.Received = response.ToArray();
            string t = Encoding.UTF8.GetString(App.Received);
            data = new List<byte>();
            response = Encoding.UTF8.GetBytes("\n").ToList();
            // имитируем долговременную работу, чтобы одновременно несколько клиентов обрабатывались
            await Task.Delay(500);
            // отправляем маркер завершения подключения - END
            //await tcpClient.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes("END\n")), SocketFlags.None);
            
        }

        public async Task Connect()
        {
            tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                await tcpClient.ConnectAsync("127.0.0.1", 8888);

                response = new List<byte>();
                JSONend = ']';

                
                bytesRead = new byte[1];

                //await Send(data);


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}


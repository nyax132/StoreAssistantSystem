using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace StoreServerSystem
{
    internal static class TcpServer
    {
        static private TcpListener server = null;
        static private List<TcpClient> clients = new();
        public static async void ServerStart(string adress, int port)
        {
            try
            {
                IPAddress localAddr = IPAddress.Parse(adress);

                // TCPサーバーを作成して開始します。
                server = new TcpListener(localAddr, port);
                server.Start();
                Program.form.loglistBox.Items.Add("Server started...");

                while (true)
                {
                    // クライアントからの接続を非同期で受け付けます。
                    TcpClient client = await server.AcceptTcpClientAsync();
                    Program.form.loglistBox.Items.Add("Client connected!");

                    // クライアントとの通信を非同期で処理します。
                    _ = Task.Run(() => HandleClient(client));
                }
            }
            catch (SocketException e)
            {
                Program.form.loglistBox.Items.Add("Received socket:" + e);
            }
            finally
            {
                // サーバーを停止します
                ServerStop();
                Program.form.loglistBox.Items.Add("\nサーバーを終了しました。");
            }
        }

        private static async void HandleClient(TcpClient client)
        {
            try
            {
                // ネットワークストリームを作成します。
                NetworkStream stream = client.GetStream();
                clients.Add(client);

                byte[] buffer = new byte[1024];
                int bytesRead;

                while (true)
                {
                    // クライアントからのデータを非同期で読み取ります。
                    bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        // クライアントが切断された場合はループを抜けます。
                        break;
                    }

                    // 受信したデータを文字列に変換します。
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Program.form.loglistBox.Invoke(new Action(() => Program.form.loglistBox.Items.Add("Received:" + data)));
                    var SQLDatas = SQLLisner.SQLListener.Classification(data);

                    // クライアントにデータを送信します。
                    //listを整列させる
                    byte[] message = Encoding.UTF8.GetBytes(string.Join(" ", SQLDatas));
                    await stream.WriteAsync(message, 0, message.Length);
                    Program.form.loglistBox.Invoke(new Action(() => Program.form.loglistBox.Items.Add("Sent:" + Encoding.UTF8.GetString(message, 0, message.Length))));
                }

                // クライアントとの接続を閉じます。
                client.Close();
                Program.form.loglistBox.Invoke(new Action(() => Program.form.loglistBox.Items.Add("Client disconnected.")));
            }
            catch (Exception e)
            {
                Program.form.loglistBox.Invoke(new Action(() => Program.form.loglistBox.Items.Add("Received handle:" + e)));
            }
        }

        public static void ServerStop()
        {
            // クライアント接続を閉じます
            foreach (TcpClient client in clients)
            {
                client.Close();
            }

            // サーバーを停止します
            server.Stop();
        }
    }
}

using System.Net;
using System.Net.Sockets;
using System.Text;

namespace StoreServerSystem
{
    internal static class TcpServer
    {
        static private TcpListener server;
        static private List<TcpClient> clients = new();
        static private List<NetworkStream> streams = new();
        public static async Task ServerStart(string adress, int port)
        {
            try
            {
                IPAddress localAddr = IPAddress.Parse(adress);

                // TCPサーバーを作成して開始します。
                server = new TcpListener(localAddr, port);
                server.Start();
                Program.form.loglistBox.Items.Add("サーバーを開始しました");

                while (true)
                {
                    // クライアントからの接続を非同期で受け付けます。
                    TcpClient client = await server.AcceptTcpClientAsync();
                    Program.form.loglistBox.Items.Add("クライアントと接続しました！");

                    // クライアントとの通信を非同期で処理します。
                    _ = Task.Run(() => HandleClient(client));
                }
            }
            catch (Exception e)
            {
                Program.form.loglistBox.Items.Add("SocketException: " + e.Message);
            }
            finally
            {
                // サーバーを停止します
                ServerStop();
                Program.form.loglistBox.Items.Add("\nサーバーを終了しました。");
            }
        }

        private static async Task HandleClient(TcpClient client)
        {
            // ネットワークストリームを作成します。
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                streams.Add(stream);
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
                    Array.Clear(buffer, 0, buffer.Length);
                    Program.form.loglistBox.Invoke(new Action(() => Program.form.loglistBox.Items.Add("Received: " + data)));

                    //SQL実行
                    var SQLDatas = SQLLisner.SQLListener.ParseDatabaseAction(data);

                    // クライアントにデータを送信します。
                    //listを整列させる
                    byte[] message = Encoding.UTF8.GetBytes(SQLDatas[0]);
                    if (SQLDatas.Count > 1)
                    {
                        message = Encoding.UTF8.GetBytes(string.Join(" ", SQLDatas));
                    }
                    await stream.WriteAsync(message, 0, message.Length);
                    Program.form.loglistBox.Invoke(new Action(() => Program.form.loglistBox.Items.Add("Send: " + Encoding.UTF8.GetString(message, 0, message.Length))));
                }

                Program.form.loglistBox.Invoke(new Action(() => Program.form.loglistBox.Items.Add("Client disconnected.")));
            }
            catch (Exception e)
            {
                await HandleException(client, e);
            }
            finally
            {
                stream?.Close();
                client?.Close();
            }
        }

        private static async Task HandleException(TcpClient client, Exception e)
        {
            try
            {
                Program.form.loglistBox.Invoke(new Action(() => Program.form.loglistBox.Items.Add("HandleException: " + e.Message)));
                // エラーメッセージをクライアントに送信します。
                string errorMessage = "UNSUCCESS " + e.Message;
                byte[] errorBytes = Encoding.UTF8.GetBytes(errorMessage);
                NetworkStream stream = client.GetStream();
                await stream.WriteAsync(errorBytes, 0, errorBytes.Length);
            }
            catch (Exception)
            {
            }
        }


        public static void ServerStop()
        {
            // クライアント接続を閉じます

            foreach (NetworkStream stream in streams)
            {
                stream.Close();
            }

            foreach (TcpClient client in clients)
            {
                client.Close();
            }

            // サーバーを停止します
            server.Stop();
        }
    }
}

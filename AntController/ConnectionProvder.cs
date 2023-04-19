using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AntController
{
    internal class ConnectionProvider
    {
        static TcpClient _client;
        private static NetworkStream _stream;
        public delegate void MessageReceivedHandler(string message);
        public event MessageReceivedHandler MessageReceived;
        public delegate void ConnectionEstablishedHandler(bool connected);
        public event ConnectionEstablishedHandler ConectionEstablished;
        private CancellationTokenSource _taskCancellationToken;


        public bool Connected { get; set; }


        public ConnectionProvider()
        {

            Connected = false;
        }

        public void Connect(string ip, int port, int timeout = 1, int retry = 1)
        {
            _client = new TcpClient();

            try
            {
                WriteLog("Trying to connect");
                _taskCancellationToken = new CancellationTokenSource();
                //   _client.Connect(ip, port);
                var result = _client.BeginConnect(ip, port, null, null);

                var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(timeout));

                if (!success)
                {
                    throw new Exception("Failed to connect.");
                }



                _stream = _client.GetStream();

                Task.Run(() => ReceiveMessage(_taskCancellationToken.Token));
                //Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                //receiveThread.Start();
                SendMessage("WARMUP", 5);
                Thread.Sleep(1000);
                SendMessage("C11", 1);
                //byte[] data = Encoding.ASCII.GetBytes("C11;C11;C11;C11;C11;");
                //_stream.Write(data, 0, data.Length);
                Connected = true;
                if (ConectionEstablished != null) ConectionEstablished(true);
                WriteLog("Connected");

            }
            catch (Exception)
            {
                WriteLog($"Could not connect to the {ip} on port {port}   ");
                Disconnect();
                throw;
            }

        }

        public void SendMessage(string message, int retry)
        {
            if (retry == 0)
            {
                retry = 1;
            }
            message += ";";
            try
            {
                for (int i = 0; i < retry; i++)
                {

                    byte[] data = Encoding.ASCII.GetBytes(message);
                    _stream.Write(data, 0, data.Length);
                    Thread.Sleep(200);
                }


            }
            catch (Exception ex)
            {
                WriteLog("Error while sending a message: " + ex);
                Disconnect();
                throw ex;
            }

        }
        //public void ReceiveMessage(CancellationToken token)
        //{
        //    while (true)
        //    {
        //        if (token.IsCancellationRequested)
        //        { 
        //            return;
        //        }

        //        try
        //        {
        //            byte[] data = new byte[64];
        //            StringBuilder builder = new StringBuilder();
        //            int bytes = 0;
        //            do
        //            {
        //                bytes = _stream.Read(data, 0, data.Length);
        //                builder.Append(Encoding.ASCII.GetString(data, 0, bytes));
        //            }
        //            while (_stream.DataAvailable);

        //          //  WriteLog(" RAW Message recieved : " +builder.ToString());
        //           // WriteLog(" RAW Message recieved : " + builder[builder.Length - 1]);                
        //          //  if (builder[builder.Length -1] == ";".ToCharArray()[0])
        //          if(builder.Length > 6)
        //            {

        //                string message = builder.ToString();
        //                WriteLog("Message recieved before : " + message);
        //                message = new string(message.Where(c => char.IsDigit(c)).ToArray());
        //                WriteLog("Message recieved : " + message);
        //                MessageReceived(message);
        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            WriteLog("Error while recieving a message " + e );
        //            Disconnect();

        //        }
        //    }
        //}

        public void ReceiveMessage(CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                try
                {
                    byte[] data = new byte[64];
                    StringBuilder builder = new StringBuilder();
                    //  int bytes = 0;
                    var memStream = new MemoryStream();
                    int bytes = _stream.Read(data, 0, data.Length);
                    while (bytes > 0)
                    {
                        memStream.Write(data, 0, bytes);
                        Thread.Sleep(20);
                        bytes = 0;
                        if (_stream.DataAvailable)
                            bytes = _stream.Read(data, 0, data.Length);
                    }

                    var ms = Encoding.ASCII.GetString(memStream.ToArray());
                    //  WriteLog(" RAW Message recieved : " +builder.ToString());
                    // WriteLog(" RAW Message recieved : " + builder[builder.Length - 1]);                
                    //  if (builder[builder.Length -1] == ";".ToCharArray()[0])
                    ms = ms.Trim();

                    WriteLog("Message lenght before checking : " + ms.Length);
                    WriteLog("Message first symbol : " + ms[0]);
                    WriteLog("Message last symbol : " + ms[ms.Length - 1]);

                    var index = ms.IndexOf(";", StringComparison.Ordinal);
                    if (ms[0] == 'Z' && index == 6)
                    {

                        //  string message = builder.ToString();
                        WriteLog("Message received before : " + ms);
                        var message2 = new string(ms.Where(char.IsDigit).ToArray());
                        WriteLog("Message received : " + message2);
                        MessageReceived(message2);
                    }

                    else
                    {
                        WriteLog("Message received incorrect  : " + ms);
                        SendMessage("C11", 1);
                    }


                }
                catch (Exception e)
                {
                    WriteLog("Error while receiving a message " + e);
                    Disconnect();

                }
            }
        }



        public void WriteLog(string message)
        {
            TextWriter writer = null;
            try
            {

                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(folder, "AntController");
                // CreateDirectory will check if folder exists and, if not, create it.
                // If folder exists then CreateDirectory will do nothing.
                Directory.CreateDirectory(specificFolder);
                var file = specificFolder + "\\" + DateTime.Now.ToString("MMMM-dd") + "log.txt";
                var contentsToWriteToFile = "\n" + DateTime.Now + " " + message;
                writer = new StreamWriter(file, true);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }


        public void Disconnect()
        {
            if (Connected)
            {
                _taskCancellationToken?.Cancel();
                _stream?.Close();
                _client?.Close();
                Connected = false;
                ConectionEstablished(false);
                WriteLog("Disconnected");
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntController
{
   public class Configuration
    {
        public  string Host;
        public  int Port;
        public  bool AllowNumLock;
        public bool AllowHotKey;
        public int Timeout;
        public int Retry;
        public string [] Directions = new string [12];
        public int[] NumKeys = new int[12];
        public bool AlwaysOnTop;
        public Color MainFormColor;

        public Configuration(bool def = false)
        {
            if (def)
            {
                AllowHotKey = false;
                AllowNumLock = false;
                AlwaysOnTop = false;
                Port = 11011;
                Host = "192.168.1.244";
                Retry = 1;
                Timeout = 1;
                MainFormColor = SystemColors.Control;


                for (int i = 0; i < Directions.Length; i++)
                {
                    Directions[i] = (i * 30).ToString();
                }

                for (int i = 0; i < NumKeys.Length; i++)
                {
                    NumKeys[i] = i;
                }
            }

        }

        

    }
}

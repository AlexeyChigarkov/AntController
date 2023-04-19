using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AntController
{



    public  class ControllerCondition
    {
        public string Band { get; set; }
        public int Antenna { get; set; }
        public string Tx { get; set; }
        public int Lna { get; set; }

        public string Pattern = "[0-1][0-9][1-3][0-3][0-1]";



        public void SetCurrentCondition(string condition)
        {
            Antenna = Convert.ToInt32(condition.Substring(0, 2));
            Band = ConvertBand((condition.Substring(3, 1)));
            Tx = ConvertTx(condition.Substring(4, 1));
            Lna = Convert.ToInt32(condition.Substring(2, 1));
        }

        private string ConvertBand(string rawBand)
        {
            switch (rawBand)
            {
                case "0":
                    return "Off";
                case "1":

                    return "160";
                case "2":
                    return "80";
                case "3":
                    return "40";
                default:
                    return "Unknown";
            }
        }

        private string ConvertTx(string rawTx)
        {
            switch(rawTx)
            {
                case "0":
                return "RX";
                case "1":
                    return "TX";
                default:
                    return "Unknown";
            }
        }

        private string ConvertLna(string rawTx)
        {
            switch (rawTx)
            {
                case "1":
                    return "OFF";
                case "2":
                    return "12";
                case "3":
                    return "24";
                default:
                    return "Unknown";
            }
        }

    }
}

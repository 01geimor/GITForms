using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;

namespace _01_SerialComunication
{
    class SerialConnect
    {
        private static string com;
        private static int baud;

        private static int databits;
        private static int stoppbit;
        public static bool connection;
        

        public SerialConnect(string port, int baudrate, int data, int stop)
        {
            com = port;
            baud = baudrate;
            databits = data;
            stoppbit = stop;
        }

         

        public void Start()
        {
            SerialPort sport = new SerialPort(com, baud, Parity.None, databits, (StopBits)stoppbit);
            
            try
            {
                sport.Open();
                connection = true;
                sport.Close();
            }
            catch (Exception ex)
            {
                Util.Write(ex.ToString(), ConsoleColor.Red);
                StreamWriter sw = new StreamWriter("Error.txt");
                sw.Write(ex.ToString());
                sw.Close();
            }


            ConsoleKeyInfo ei = Console.ReadKey();
            switch (ei.Key)
            {
                case ConsoleKey.W :
                    Write();
                    break;
                case ConsoleKey.R:
                    Read();
                    break;
            }

            sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived);
            
        }

        private void sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            Console.WriteLine("[" + dtn + "] " + "Received: " + sport.ReadExisting() + "\n");
        }

        private static void Write(SerialPort sport)
        {
            string a;
            while (connection)
            {
                a = Console.ReadLine();
                sport.Open();
                sport.Write(a);
                sport.Close();
            }
        }

        private static void Read()
        {
            string a;
            while (connection)
            {
                sport.Open();
                a = sport.ReadLine();
                sport.Write(a);
                sport.Close();
            }
        }
    }
}

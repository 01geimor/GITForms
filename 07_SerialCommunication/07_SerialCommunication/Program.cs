using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SerialComunication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 25;
            Console.WindowWidth = 0;
            Console.WriteLine("COM");
            string a = Console.ReadLine();
            SerialConnect port = new SerialConnect(a,9600,0,8,1);
            port.Start();
        }
    }
}

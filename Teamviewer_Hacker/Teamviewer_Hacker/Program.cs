// This file is part of Teamviewer_Hacker.

// Teamviewer_Hacker is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Teamviewer_Hacker is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Teamviewer_Hacker.  If not, see<http://www.gnu.org/licenses/>.

// THIS IS AN APRIL FOOLS JOKE. THIS DOES NOT DO ANYTHING HARMFUL.
// youtube.com/etnguyen03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Teamviewer_Hacker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teamviewer Hacker");
            Console.WriteLine("Copyright (c) 2018 Ethan Nguyen. All rights reserved");
            Console.WriteLine("");
            Console.Write("Enter Teamviewer ID: ");
            Int64 id = Convert.ToInt64(Console.ReadLine());
            Console.Clear();
            Console.Write("For Teamviewer ID ");
            Console.Write(id);
            Console.WriteLine(": ");
            Console.WriteLine("Please select an attack vector");
            Console.WriteLine("[1] DNS Flood");
            Console.WriteLine("(2) Denial of Service - UDP Flood");
            Console.WriteLine("(3) Denial of Service - SYN Flood");
            Console.WriteLine("(4) Denial of Service - Ping Flood");
            Console.WriteLine("(5) Degredation of Service");
            Console.WriteLine("(6) Distributed Denial of Service");
            Console.WriteLine();
            Console.Write("Select your attack vector [1]: ");
            int attack = Convert.ToInt32(Console.ReadLine());

            // Prepare for attacks
            switch (attack)
            {
                case 6:
                    Console.WriteLine("Contacting IP servers... ");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.WriteLine("Preparing attacks...");
                    Thread.Sleep(2000);
                    break;
            }

            int[] receivedPackets = {1000, 500, 250, 125, 63, 32, 16, 8, 4, 2, 1, 0};

            // Run attacks
            bool Break = true;
            int i = 0;
            while (Break == true)
            {
                try
                {
                    Console.WriteLine("Sending 1000 packets of size 4096 MB to Teamviewer ID " + id);
                    Thread.Sleep(1000);
                    Console.WriteLine("Received " + receivedPackets[i] + " packets");
                    Thread.Sleep(500);
                    i += 1;
                }
                catch (Exception)
                {
                    Console.WriteLine("Received 0 packets");
                    Thread.Sleep(500);
                    Break = false;
                    // empty
                }
            }
            while (true)
            {
                Console.WriteLine("Sending 1000 packets of size 4096 MB to Teamviewer ID " + id);
                Thread.Sleep(1000);
                Console.WriteLine("Received 0 packets");
                Thread.Sleep(500);
            }
        }
    }
}

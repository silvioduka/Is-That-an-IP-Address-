/*
Is That an IP Address? from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-04 

Given a string as input, create a program to evaluate whether or not it is a valid IPv4 address. 

A valid IP address should be in the form of: a.b.c.d where a, b, c and d are integer values ranging from 0 to 255 inclusive. 

For example: 
127.0.0.1 - valid 
127.255.255.255 - valid 
257.0.0.1 - invalid 
255a.0.0.1 - invalid 
127.0.0.0.1 - invalid 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThatAnIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "255a.0.0.1"; // Insert here an IP address to verify

            Console.WriteLine($"The IP Address {ip} - {((VerifyIP(ip)) ? "valid" : "invalid")}");
        }

        static bool VerifyIP(string ip)
        {
            string[] ipa = ip.Split('.');

            if (ipa.Length != 4) return false;

            foreach (string s in ipa)
            {
                int n;

                bool b = Int32.TryParse(s, out n);

                if (n < 0 || n > 255 || b == false) return false;
            }

            return true;
        }
    }
}
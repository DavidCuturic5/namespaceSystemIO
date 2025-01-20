﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemIOStreamPisac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Upišite prezime: ");
            string prezime = Console.ReadLine();

            StreamWriter sw = new StreamWriter(
                @"C:\1\mojaDatoteka.txt");

            sw.WriteLine("Ime: {0}", ime);
            sw.WriteLine("Prezime: {0}", prezime);
            sw.Close();


            StreamReader sr = new StreamReader(
                @"C:\1\mojaDatoteka.txt");

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();

            Console.ReadKey();
        }
    }
}

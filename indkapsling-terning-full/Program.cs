﻿using System;

namespace indkapsling_terning_full
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Terning
    {
        public int Værdi { get; set; }

        public void Ryst()
        {
            System.Random rnd = new Random();
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.Værdi}]");
        }

        public Terning()
        {
            this.Ryst();
        }
        public Terning(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                throw new Exception("Forkert værdi");
            this.Værdi = værdi;
        }

    }
}
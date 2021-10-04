﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PrimeNumbersAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, prime;
            Stopwatch timer = new Stopwatch();


            // Start Initialization
            PrintBanner();
            n = GetNumber();
            // Initialization Complete

            // Start The Algorithm
            timer.Start();
            prime = FindNthPrime(n);
            timer.Stop();
            // Algorithm Complete


            Console.WriteLine(
                $"\nToo easy.. {prime} is the nth prime when n is {n}. I found that answer in {timer.Elapsed.Seconds}.{timer.Elapsed.Milliseconds} seconds.");

            EvaluatePassingTime(timer.Elapsed.Seconds);
        }

        static int FindNthPrime(int n)
        {
            int numberOfPrimes = 0;
            int primeNthNumber = 0;
            for (int i = 2; i < 2000000; i++)
            {
                if (numberOfPrimes == n) break;

                for (int x = 2; x < i; x++)
                {
                    if (numberOfPrimes == n) break;
                    if (i % x != 0)
                    {
                        numberOfPrimes++;
                        primeNthNumber = i;
                    }
                }


            }


            return primeNthNumber;
        }

        static int GetNumber()
        {
            int n = 0;
            while (true)
            {
                Console.Write("Which nth prime should I find?: ");

                string num = Console.ReadLine();
                if (Int32.TryParse(num, out n))
                {
                    return n;
                }

                Console.WriteLine($"{num} is not a valid number.  Please try again.\n");
            }
        }

        static void PrintBanner()
        {
            Console.WriteLine(".................................................");
            Console.WriteLine(".#####...#####...######..##...##..######...####..");
            Console.WriteLine(".##..##..##..##....##....###.###..##......##.....");
            Console.WriteLine(".#####...#####.....##....##.#.##..####.....####..");
            Console.WriteLine(".##......##..##....##....##...##..##..........##.");
            Console.WriteLine(".##......##..##..######..##...##..######...####..");
            Console.WriteLine(".................................................\n\n");
            Console.WriteLine(
                "Nth Prime Solver O-Matic Online..\nGuaranteed to find primes up to 2 million in under 30 seconds!\n\n");
        }

        static void EvaluatePassingTime(int time)
        {
            Console.WriteLine("\n");
            Console.Write("Time Check: ");

            if (time <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pass");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
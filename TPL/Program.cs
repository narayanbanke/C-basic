﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# For Loop");
            Thread thread = new Thread(Runmillianitraton);

            //int number = 10000000;
            //for (int count = 0; count < number; count++)
            //{
            //    //Thread.CurrentThread.ManagedThreadId returns an integer that 
            //    //represents a unique identifier for the current managed thread.
            //    Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
            //    //Sleep the loop for 10 miliseconds
            //    Thread.Sleep(10);
            //}
            Console.WriteLine();

            //Console.WriteLine("Parallel For Loop");
            //Parallel.For(0, number, count =>
            //{
            //    Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
            //    //Sleep the loop for 10 miliseconds
            //    Thread.Sleep(10);
            //});
            //Console.ReadLine();
        }
        private static void Runmillianitraton()
        {
            string x = "";

            for (int i = 0; i < 1000000; i++)
            { 
            
            }
        }


    }
}
    
 
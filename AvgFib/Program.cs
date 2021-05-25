using System;
using System.Collections.Generic;
using Doud.Fib;
/*
 * You are to calculate the average of the sequence of the fibinacci sequence that ends with the first
 * number greater than 200. Store the generated numbers in a List<int> collection then calculate the
 * average and display it using a Console.WriteLine statement
 */
namespace AvgFib {
    class Program {
        static void Main(string[] args) {
            List<int> fibs = Fib.GenerateSequence(200);
            var sum = 0;
            foreach(var fib in fibs) {
                sum = sum + fib;
            }
            var avg = sum / fibs.Count;
            Console.WriteLine($"Fibs avg is {avg}");
        }
    }
}

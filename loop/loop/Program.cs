/*
 Name
 student id
 
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int start = 5;
            int finish = 8;
            /*title*/
            Console.WriteLine("I\tI*10\tI*100\ti*1000");
            Console.WriteLine(" \t----\t-----\t------");

            /*task 1*/
            Console.WriteLine(">>> for loop <<<");
            /*For loop*/
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine($"{i}\t{i * 10}\t{i * 100}\t{i * 1000}");
            }
            Console.WriteLine("\n>>> while loop <<<");


            while (start <= finish)
            {
                Console.WriteLine($"{start}\t{start * 10}\t{start * 100}\t{start * 1000}");
                start++;
            }
            Console.WriteLine("\n>>> do while loop <<<");
            start = 3;

            do
            {
                Console.WriteLine($"{ start}\t{ start * 10}\t{ start * 100}\t{ start * 1000}");
                start++;
            } while (start <= finish) ;
            Console.WriteLine("Task 1 complete - press ENTER to continue...");
            Console.ReadLine();

            /*Task 2*/
            Console.Clear();
            Console.WriteLine("Task 2 complete - press ENTER to continue...");
            Console.WriteLine();
            /*Task 3*/
            Console.Clear();
            Console.WriteLine("Task 2 complete - press ENTER to exit the program...");
            Console.ReadLine();


        }
    }
}

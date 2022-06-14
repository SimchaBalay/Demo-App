using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_App
{
    internal class Program:Calculator 
    {
       
            static void Main(string[] args)
            {

                Console.WriteLine("This program performs basic math operation on 2 numbers");
                Console.WriteLine("Please insert the first number");

                double firstNumber = Convert.ToDouble(Console.ReadLine());




                Console.WriteLine("Please insert the second number");
                Console.WriteLine("Please insert the second number");

                double secondNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please select your operation");
                Console.WriteLine("+: for addition");
                Console.WriteLine("-: for subtraction");
                Console.WriteLine("*: for multiplication");
                Console.WriteLine("/: for division");

                var operand = Console.ReadLine();

                if (operand == "+")
                {
                    var result = Add(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }
                else if (operand == "-")
                {
                    var result = Subtract(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }
                else if (operand == "*")
                {
                    var result = Multiply(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }
                else if (operand == "/")
                {
                    var result = Divide(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("You have made an invalid selection");
                }
            }
            //FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\Queen B\Desktop\simcha");
            //watcher.EnableRaisingEvents = true;
            //watcher.IncludeSubdirectories = true;



            //watcher.Created += FileSystemWatcher_Created;

            //watcher.Renamed += FileSystemWatcher_Renamed;

            //watcher.Deleted += FileSystemWatcher_Deleted;

            //watcher.EnableRaisingEvents = true;

            //Console.ReadKey();
        

   //     static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
   //     {
   //         Console.WriteLine("File: {0} , created at time/* {1}*/ ", e.Name/*, e.OldName*/);
   //     }
   //static void FileSystemWatcher_Renamed(object sender, FileSystemEventArgs e)
   //     {
   //         Console.WriteLine("File: {0} , renamed to {1} at time {2}", e.Name/*, e.OldName*/, DateTime.Now.ToLocalTime());
   //     }

   //     static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)

   //     {
   //         Console.WriteLine("File: {0} , deleted at time: {1} ", e.Name, DateTime.Now.ToLocalTime());
   //     }
   //     static void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)

   //     {
   //         Console.WriteLine("File: {0} , change at time: {1} ", e.Name, DateTime.Now.ToLocalTime());

   //     }
    
        //static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        //{
        //    Console.WriteLine("File: {0} ,", e.Name);
        //}

        //static void FileSystemWatcher_Renamed(object sender, FileSystemEventArgs e)
        //{
        //    Console.WriteLine("File: {0} ,at time {1}", e.Name, DateTime.Now.ToLocalTime());
        //}

        //static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)

        //{
        //    Console.WriteLine("File: {0} , deleted at time: {1} ", e.Name, DateTime.Now.ToLocalTime());
        //}
        //static void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)

        //{
        //    Console.WriteLine("File: {0} , change at time: {1} ", e.Name, DateTime.Now.ToLocalTime());
        //}
    }
}

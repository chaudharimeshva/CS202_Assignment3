// See https://aka.ms/new-console-template for more information
using System;

namespace ConstructorsAndDataControl
{
    class Program
    {
        private int data;                  
        private static int objectCounter=1; 

        public Program()
        {
            objectCounter+=1;
            Console.WriteLine("Constuctor Called");
            Console.WriteLine($"Constructor Called. Active Objects: {objectCounter}");
        }

        // Destructor
        ~Program()
        {
            objectCounter--;
            Console.WriteLine("Object Destroyed");
            Console.WriteLine($"Available Objects: {objectCounter}");
        }

        // Set data
        public void set_data(int x)
        {
            data = x;
        }

        // Show data
        public void show_data()
        {
            Console.WriteLine($"Data = {data}");
        }

        // Main method
        public void Main(string[] args)
        {
            Console.WriteLine("Creating Objects");
            Program p1 = new Program();
            Program p2 = new Program();
            Program p3 = new Program();

            p1.set_data(10);
            p2.set_data(20);
            p3.set_data(30);

            Console.WriteLine("Displaying data:");
            p1.show_data();
            p2.show_data();
            p3.show_data();

            Console.WriteLine("Program Ended");


        }
    }
}

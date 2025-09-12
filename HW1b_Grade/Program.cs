// HW1b Grade

// Your Name: Marlen Rojo
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            string id = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for your exam 1?");
            double exam1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is you overall percentage grade for exam 2?");
            double exam2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is you overall percentage grade for exam 3?");
            double exam3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is you overall percentage grade for homework?");
            double homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is you overall percentage grade for participationandquizzes?");
            double participationandquizzes = Convert.ToDouble(Console.ReadLine());

            

            double finalgrade = (exam1 * 0.15) + (exam2 * 0.25) + (exam3 * 0.25) + (homework * 0.20) + (participationandquizzes * 0.15);
            Console.WriteLine($"{firstname} {lastname} ({id}), your final grade is {finalgrade}%.");





        }
    }
}

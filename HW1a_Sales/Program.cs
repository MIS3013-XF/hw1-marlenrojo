// HW1a Sales Total

// Your Name: Marlen Rojo
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string productname = Console.ReadLine();

            double num1;
            double num2;
            

            double subtotal;
            double salestax;
            double totalbill;

            const double taxrate = 0.085;

            string Num1AsString;
            string Num2AsString;

            Console.WriteLine("How many Football Ticket's do you want to buy?");
            Num1AsString = Console.ReadLine();

            Console.WriteLine("What is the price for each Football Ticket?");
            Num2AsString = Console.ReadLine();

            num1 = Convert.ToDouble(Num1AsString);
            num2 = Convert.ToDouble(Num2AsString);

            subtotal = num1 * num2;
            Console.WriteLine($"Your subtotal for your bill is $" + subtotal.ToString("N2"));

            salestax = subtotal * taxrate;
            Console.WriteLine($"Your sales tax for your bill is $" + salestax.ToString("N2"));

            totalbill = subtotal + salestax;
            Console.WriteLine($"Your total for your bill is $" + totalbill.ToString("N2"));
            

            
          

          
            

        }
    }
}

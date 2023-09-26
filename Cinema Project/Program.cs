using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Aquinas Multiplex");
            Console.WriteLine("We are presently showing:");
            Console.WriteLine("1. Rush (15)");
            Console.WriteLine("2. How I Live Now (15)");
            Console.WriteLine("3. Thor: The Dark World (12)");
            Console.WriteLine("4. Filth (18)");
            Console.WriteLine("5. Planes (U)");

            Console.WriteLine("Enter the number of the film you want to see:");
            string placeholderfilmnumber = Console.ReadLine();
            int filmnumber = int.Parse(placeholderfilmnumber);

            Console.WriteLine("Enter your age");
            string placeholderage = Console.ReadLine();
            int age = int.Parse(placeholderage);

            if (filmnumber < 1 || filmnumber > 5)
            {
                Console.Write("Access Denied - No such film");
            }

            if (age < 18 && filmnumber == 4)
            {
                Console.WriteLine("Accessed Denied - You are too young");
            }

            if (age < 15 && filmnumber == 2)
            {
                Console.WriteLine("Accessed Denied - You are too young");
            }

            if (age < 15 && filmnumber == 1)
            {
                Console.WriteLine("Accessed Denied - You are too young");
            }

            if (age < 12 && filmnumber == 3)
            {
                Console.WriteLine("Accessed Denied - You are too young");
            }

            else
            {
                Console.WriteLine("What date do you want to see it? Must be less than 1 week in the future.");
                string dateplaceholder = Console.ReadLine();
                DateTime date = DateTime.Parse(dateplaceholder);

                if (date < DateTime.Now)
                {
                    Console.WriteLine("Access Denied - Invalid Date");
                }

                if (date - 7 > DateTime.Now)
                {
                    Console.WriteLine("Access Denied - Invalid Date");
                }
            }
            Console.ReadLine();
        }
    }
}

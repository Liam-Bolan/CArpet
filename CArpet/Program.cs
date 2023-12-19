using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CArpet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int width = 4;
            Console.WriteLine("Welcome to Bob's Carpet Emporium\n");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"What type of carpet would you like {name}?\n\n1 - Wool (£42.99 per square metre)\n\n2 - Artificial Fibre (£18.99 per metre)\n\n3 - Mixed (£28.99 per square metre)\n");
            int choice = int.Parse(Console.ReadLine());
            while(choice <1 || choice > 3)
            {
                Console.WriteLine("Invalid Choice!");
                choice = int.Parse(Console.ReadLine());
            }
            string carpChoice;
            double choicePrice = 0;

            if (choice == 1)
            {
                carpChoice = "Wool";
                choicePrice = 42.99;
                Console.Write("Please enter colour of carpet: ");
                string colour = Console.ReadLine();
                colour = colour.ToUpper();
                Console.Write("Carpet comes in 4m widths. Please enter the number of metres length you require: \n");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nYou have selected {carpChoice} in {colour}");
                double cost = width * length * choicePrice;
                Console.WriteLine($"TOTAL COST = {cost}");
                Console.WriteLine("Hit a key!");
                Console.ReadKey();
            }
            if (choice == 2)
            {
                carpChoice = "Artificial Fibre";
                choicePrice = 18.99;
                Console.Write("Please enter colour of carpet: ");
                string colour = Console.ReadLine();
                colour = colour.ToUpper();
                Console.Write("Carpet comes in 4m widths. Please enter the number of metres length you require: \n");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nYou have selected {carpChoice} in {colour}");
                double cost = width * length * choicePrice;
                Console.WriteLine($"TOTAL COST = {cost}");
                Console.WriteLine("Hit a key!");
                Console.ReadKey();
            }
            if (choice == 3)
            {
                carpChoice = "Mixed";
                choicePrice = 28.99;
                Console.Write("Please enter colour of carpet: ");
                string colour = Console.ReadLine();
                colour = colour.ToUpper();
                Console.Write("Carpet comes in 4m widths. Please enter the number of metres length you require: \n");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nYou have selected {carpChoice} in {colour}");
                double cost = width * length * choicePrice;
                Console.WriteLine($"TOTAL COST = {cost}");
                Console.WriteLine("Hit a key!");
                Console.ReadKey();
            }
            

        }
    }
}

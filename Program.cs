using System;

namespace FlooringShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // flooring options with price per square foot
            string floor1 = "A) Walnut Wood - $7.40 per sq.ft";
            string floor2 = "B) Grey Vinyl - $3.85 per sq.ft";
            string floor3 = "C) Granite Tile - $11.20 per sq.ft";

            // prices as numbers so we can do the math later
            double price1 = 7.40;
            double price2 = 3.85;
            double price3 = 11.20;

            // to store the user's flooring choice
            string choice = "";

            // room size in feet
            double length = 0.0;
            double width = 0.0;

            Console.WriteLine("Welcome to the Flooring Shop!");
            Console.WriteLine();
                        // ask user for the length of the room
            Console.Write("Enter the length of your room in feet: ");
            string lengthInput = Console.ReadLine();

            // check if it is a number
            if (double.TryParse(lengthInput, out length) && length > 0)
            {
                length = Math.Round(length, 1);
            }
            else
            {
                Console.WriteLine("Invalid length! Please enter a number like 12.5");
                Console.ReadLine();
                return;
            }
            // ask user for the width of the room
            Console.Write("Enter the width of your room in feet: ");
            string widthInput = Console.ReadLine();

            // check if it is a number
            if (double.TryParse(widthInput, out width) && width > 0)
            {
                width = Math.Round(width, 1);
            }
            else
            {
                Console.WriteLine("Invalid width! Please enter a number like 10.5");
                Console.ReadLine();
                return;
            }
                        // show the flooring options
            Console.WriteLine();
            Console.WriteLine("Which flooring would you like?");
            Console.WriteLine(floor1);
            Console.WriteLine(floor2);
            Console.WriteLine(floor3);
            Console.Write("Type A, B or C: ");
            string letter = Console.ReadLine().ToUpper();

            // check if the letter is valid
            if (letter == "A" || letter == "B" || letter == "C")
            {
                choice = letter;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please type A, B or C");
                Console.ReadLine();
                return;
            }

            double area = 0;
            double cost = 0;
            string floorName = "";

            // calculate area and cost for each choice
            if (choice == "A")
            {
                area = length * width;
                cost = area * price1;
                floorName = "Walnut Wood";
            }
            if (choice == "B")
            {
                area = length * width;
                cost = area * price2;
                floorName = "Grey Vinyl";
            }
            if (choice == "C")
            {
                area = length * width;
                cost = area * price3;
                floorName = "Granite Tile";
            }

            // show the final result
            Console.WriteLine();
            Console.WriteLine("You picked " + floorName + ". The area of your floor is "
                + area.ToString("0.0") + " sq.ft and the total cost is $" + cost.ToString("0.00"));
            

            Console.ReadLine();
        }
    }
}

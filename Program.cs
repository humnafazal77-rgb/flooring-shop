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

            // ---- part 2 (flooring choice + cost) goes here ----

            Console.ReadLine();
        }
    }
}
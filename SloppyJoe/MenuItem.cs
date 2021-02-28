using System;
using System.Collections.Generic;
using System.Text;

namespace SloppyJoe
{
    class MenuItem
    {
        public static Random randomizer = new Random();
        public string[] proteins =
        {
            "Roast Beef",
            "Salami",
            "Turkey",
            "Ham",
            "Pastrami",
            "Tofu"
        };

        public string[] condiments =
        {
            "Yellow Mustard",
            "Brown Mustard",
            "Honey Mustard",
            "Mayo",
            "Relish",
            "French Dressing"

        };

        public string[] breads =
        {
            "Rye",
            "White",
            "Wheat",
            "Pumpernickel",
            "Sourdough"
        };

        public string Description = "";
        public string Price;


        public void Generate()
        {
            string randomProtein = proteins[randomizer.Next(proteins.Length)];
            string randomCondiment = condiments[randomizer.Next(condiments.Length)];
            string randomBread = breads[randomizer.Next(breads.Length)];
            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            decimal bucks = randomizer.Next(2, 5);
            decimal cents = randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01M);
            Price = price.ToString("c");

        }



    }
}

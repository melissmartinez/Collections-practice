using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create an array to hold integer values 0 through 9
            int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(array);

        // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] stringArr;
            stringArr = new string [] {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(stringArr);

        // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArr = new bool[10];
            boolArr[0] = true;
            boolArr[1] = false;
            boolArr[2] = true;
            boolArr[3] = false;
            boolArr[4] = true;
            boolArr[5] = false;
            boolArr[6] = true;
            boolArr[7] = false;
            boolArr[8] = true;
            boolArr[9] = false;
            Console.WriteLine(boolArr);

        // Make a list of icecream that holds 5 diff flavors
            List<string> iceCream = new List<string>();
            iceCream.Add("Cookies n Cream");
            iceCream.Add("Strawberry Cheesecake");
            iceCream.Add("Butter Pecan");
            iceCream.Add("Rocky Road");
            iceCream.Add("Cotton Candy");

        // Output the length of this list after building it
            Console.WriteLine($"The length of the iceCream list string is {iceCream.Count}.");

        // Output the third flavor in the list, then remove this value
            Console.WriteLine($"The third flavor from this list is {iceCream[2]}.");
        // removing the value
            iceCream.Remove(iceCream[2]);
        // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine($"The new length of the iceCream list is {iceCream.Count}.");

        // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> iceCreamLovers = new Dictionary<string, string>();
        // Add key/value pairs to this dictionary where:
        // each key is a name from your names array
        // each value is a randomly select a flavor from your flavors list.
            Random rand = new Random();
            iceCreamLovers.Add(stringArr[0], iceCream[rand.Next(0, 4)]);
            iceCreamLovers.Add(stringArr[1], iceCream[rand.Next(0, 4)]);
            iceCreamLovers.Add(stringArr[2], iceCream[rand.Next(0, 4)]);
            iceCreamLovers.Add(stringArr[3], iceCream[rand.Next(0, 4)]);
        // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var item in iceCreamLovers)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}

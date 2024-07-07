using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqexercies
{
    public class exercies
    {
        //comment out other Main methods to run each question or copy each Main method to run by yourself

        /* 1. Numbers from range
        Given an array of integers, write a query that returns a list of numbers greater than 30 and less than 100.
        Expected input and output
        [67, 92, 153, 15] → 67, 92 */

        public static void Main()
        {
            List<int> Numbers = new List<int> { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };

            // Solution
            var result = Numbers.Where(n => n > 30 && n < 100).ToList();

            result.ForEach(Console.WriteLine);
        }

        /* 2. Minimum length
        Write a query that returns words at least 5 characters long and make them uppercase.
        Expected input and output
        "computer", "usb" → "COMPUTER" */

        // Uncomment to run this example
        /*
        public static void Main()
        {
            List<string> animals = new List<string>
            {
                "zebra",
                "elephant",
                "cat",
                "dog",
                "rhino",
                "bat"
            };

            // Solution
            var result = animals.Where(a => a.Length >= 5).Select(a => a.ToUpper()).ToList();

            result.ForEach(Console.WriteLine);
        }
        */

        /* 3. Select words
        Write a query that returns words starting with letter 'a' and ending with letter 'm'.
        Expected input and output
        "mum", "amsterdam", "bloom" → "amsterdam" */

        // Uncomment to run this example
        /*
        public static void Main()
        {
            List<string> words = new List<string>
            {
                "alabam",
                "am",
                "balalam",
                "tara",
                "",
                "a",
                "axeliam",
                "39yo0m",
                "trol"
            };

            // Solution
            var result = words.Where(w => w.StartsWith('a') && w.EndsWith('m')).ToList();

            result.ForEach(Console.WriteLine);
        }
        */

        /* 4. Top 5 numbers
        Write a query that returns top 5 numbers from the list of integers in descending order.
        Expected input and output
        [78, -9, 0, 23, 54, 21, 7, 86]  → 86 78 54 23 21 */

        // Uncomment to run this example
        /*
        public static void Main()
        {
            List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };

            // Solution
            var result = numbers.OrderByDescending(n => n).Take(5).ToList();

            result.ForEach(Console.WriteLine);
        }
        */

        /* 5. Square greater than 20
        Write a query that returns a list of numbers and their squares only if the square is greater than 20
        Expected input and output
        [7, 2, 30] → 7 - 49, 30 - 900 */

        // Uncomment to run this example
        /*
        public static void Main()
        {
            List<int> Numbers = new List<int> { 3, 9, 2, 4, 6, 5, 7 };

            // Solution
            var result = Numbers.Where(n => n * n > 20).Select(n => new { Number = n, Square = n * n }).ToList();

            result.ForEach(r => Console.WriteLine($"{r.Number} - {r.Square}"));
        }
        */

        /* 6. Most frequent character
        Write a query that returns the most frequent character in a string. Assume that there is only one such character.
        Expected input and output
        "panda"  → 'a'
        "n093nfv034nie9"→ 'n' */

        // Uncomment to run this example
        /*
        public static void Main()
        {
            string str = "49fjs492jfJs94KfoedK0iejksKdsj3";

            // Solution
            var result = str.GroupBy(c => c)
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.Key)
                            .FirstOrDefault();

            Console.WriteLine(result);
        }
        */

        /* 7.Last word containing letter
        Given a non-empty list of words, sort it alphabetically and return a word that contains the letter 'e'.
        Expected input and output
        ["plane", "ferry", "car", "bike"]→ "plane" */

        // Uncomment to run this example
        /*
        public static void Main()
        {
            var words = new List<string>
            {
                "cow",
                "dog",
                "elephant",
                "cat",
                "rat",
                "squirrel",
                "snake",
                "stork"
            };

            // Solution
            var result = words.Where(w => w.Contains('e')).OrderBy(w => w).LastOrDefault();

            Console.WriteLine(result);
        }
        */
    }
}

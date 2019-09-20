using System;
using System.Linq;

namespace ISM4300Method
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\nPlease enter your name, with a capital for the first letter only: ");
                string name = Console.ReadLine();

                /*
                 * Execute the Print_Name method and
                 * pass the name of the user from input.
                 */
                Print_Name(name);

                Console.WriteLine("\nShorthand often removes all vowels except those you would find at the beginning and end of a word");
                Console.Write("This is how you would write your name in shorthand: ");


                // take name and split into characters in an array
                char[] name_array = name.ToCharArray();

                // capture last character in name
                char check = name_array.Last();

                /*
                 * Execute the Is_Not_Vowel method
                 * for each character in name_array
                 * returns true if the character is not a vowel.
                 */
                name_array = Array.FindAll(name_array, Is_Not_Vowel).ToArray();

                Console.Write(name_array);

                // add last character to name if a vowel
                if (Is_Not_Vowel(check) == false)
                {
                    Console.WriteLine(check);
                } 

            } //end of try
            catch
            {
                Console.WriteLine("Please make sure you are entering your name properly and using letters of the roman alphabet!");
            } //end of catch
        } //end of main method

        // Print_Name method
        private static void Print_Name(string n)
        {
            Console.WriteLine("Hello {0}!", n);
        }


        //Is_Not_Vowel method
        private static bool Is_Not_Vowel(char m)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return !vowels.Contains(m);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordFrequency
{
    class Program
    {
        static int MAX_CHAR = 26;

        //Method to get frequency of occurence of each letters in a given string.
        static void countCharacterFrequency(string str)
        {
            //Array to keep count of occurence of each letter in the string
            int[] char_count = new int[MAX_CHAR];
            int totalLetters = 0;

            //Set the whole string to uppercase so alphabets a and A, b and B, c and C... are considered same
            str = str.ToUpper();
            // Traverse the string 
            for (int i = 0; i < str.Length; i++)
            {
                // Count occurrence of uppercase  
                // letters 
                if (char.IsUpper(str[i]))
                {
                    totalLetters++;
                    char_count[str[i] - 'A']++;
                }
            }

            //strings that will help displaying alphabets and their individual occurence count in tabular format
            StringBuilder charString = new StringBuilder();
            StringBuilder charCount = new StringBuilder();

            // Traverse for all letters A to Z 
            for (int i = 0; i < MAX_CHAR; i++)
            {
                char ch = (char)('A' + i);
                charString.Append(" | ");
                charString.Append(ch);

                charCount.Append(" | ");
                charCount.Append(char_count[i]);
            }
            charString.Append(" | ");
            charCount.Append(" | ");

            //Printing the result in tabular form 2nd line has characters | A | B | C.. and 4th line has frequency of those characters for eg: | 3 | 2 | 1 |...
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------");
            Console.WriteLine(charString.ToString());
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------");
            Console.WriteLine(charCount.ToString());
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------");

            //Print the count of total letters processed
            Console.WriteLine("The text has been processed. Total letters counted: " + totalLetters.ToString());

            //2 blank lines for separation 
            Console.WriteLine(" ");
            Console.WriteLine(" ");

        }

        static void Main(string[] args)
        {
            //Keep console app looping and running, so that user can process multiple strings one after the other.
            while (true)
            {
                Console.WriteLine("Please Enter your string");
                var str = Console.ReadLine();
                countCharacterFrequency(str);
            }
        }

    }
}

using System;

namespace UnitTest_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "Sneh";
            string num = "1929S";
            if (num.IsValidNumeric() == true)
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            Console.WriteLine("##==##==##==##==##==##==##==##==##==##==##==##==##==##==##==##==##==##==");
            if (num.ConvertStringToNumber() == null)
                Console.WriteLine("\"" + num + "\" can not convert in numeric value");
            else
                Console.WriteLine("\"" + num + "\" numeric value is : " + num.ConvertStringToNumber());
            Console.WriteLine("Input : \"" + input + "\" into Uppercase Letter : " + input.ConvertToUpper());
            input = "SNEH";
            Console.WriteLine("Input : \"" + input + "\" into Lowercase Letter : " + input.ConvertToLower());
            input = "sneh patel";
            Console.WriteLine("Input : \"" + input + "\" into Titlecase Letter : " + input.ConvertToTitleCase());
            input = "sneh";
            Console.WriteLine("Check all the character of string is lower case or not : \"" + input + "\" : " + input.IsLower());
            input = "sneh patel";
            Console.WriteLine("Input : \"" + input + "\" into Capitalize : " + input.ConvertToCapitalize());
            input = "SNEH";
            Console.WriteLine("Is input in uppercase : \"" + input + "\" : " + input.IsUpper());
            input = "sneh patel";
            Console.WriteLine("No of words in the input : \"" + input + "\" : " + input.CountingWord());
            input = "Sneh Patel";
            Console.WriteLine("Removing last character from input : \"" + input + "\" : "+ input.RemoveLastCharacterFrom());            
            Console.WriteLine("##==##==##==##==##==##==##==##==##==##==##==##==##==##==##==##==##==##==");
        }
    }
}

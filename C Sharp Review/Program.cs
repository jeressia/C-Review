using System;

namespace C_Sharp_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your word:");
            var response = Console.ReadLine();
            var noSpaces= response.Replace(" ", "");
            Console.WriteLine($"You entered: {noSpaces}");

            var allCharacters = "";

            for (int i = 0; i < noSpaces.Length; i++)
            {
                int j = 0; var temp = "";
                while (j <= i )
                {
                    temp += string.Concat((j == 0) ? char.ToUpper(noSpaces[i]) : char.ToLower(noSpaces[i]));
                    j++;
                }
                allCharacters += temp + '-';
            }
            var finishedProduct = allCharacters.TrimEnd('-');
            Console.WriteLine($"{finishedProduct}");

        }
    }
}

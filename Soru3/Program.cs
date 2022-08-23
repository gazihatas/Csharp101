using System;

namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string? sentence = Console.ReadLine();
            List<char> vowels = new List<char>() { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int vowelsCount = vowels.Count;
            string sentenceVowels = "";

            if (!String.IsNullOrEmpty(sentence))
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    for (int j = 0; j < vowelsCount; j++)
                    {
                        if (char.ToLower(sentence[i]) == vowels[j])
                        {
                            sentenceVowels += sentence[i];
                            vowels.Remove(vowels[j]);
                            vowelsCount--;
                        }
                    }
                }
            }
            else
                Console.WriteLine("Sentence can not be a null value");

            if (!string.IsNullOrEmpty(sentence))
            {
                char[] vowelArray = sentenceVowels.ToArray();
                Array.Sort(vowelArray);

                for (int i = 0; i < vowelArray.Length; i++)
                    Console.WriteLine(vowelArray[i]);
            }
        }
    }
}

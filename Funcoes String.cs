using System;
namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            string frase = "AbcDe FgHiJk LmNoPq RsTuV wXyZ 0abc5 0016 091abc8560151abc0 658 46           a";
            Console.WriteLine("Frase normal: " + frase);

            string fraseMinuscula = frase.ToLower();
            Console.WriteLine("frase.ToLower(): " + fraseMinuscula);

            string fraseMaiuscula = frase.ToUpper();
            Console.WriteLine("frase.Upper(): " + fraseMaiuscula);

            string fraseTrim = frase.Trim();
            Console.WriteLine("frase.Trim(): " + fraseTrim);

            int fraseLastIndex = frase.LastIndexOf("15");
            Console.WriteLine("frase.LastIndexOf(15): " + fraseLastIndex);

            int fraseIndexOf = frase.IndexOf("15");
            Console.WriteLine("frase.IndexOf(15): " + fraseIndexOf);

            int fraseLength = frase.Length;
            Console.WriteLine("frase.Length: " + fraseLength);

            string fraseSubString = frase.Substring(5);
            Console.WriteLine("frase.SubString(5): " + fraseSubString);

            fraseSubString = frase.Substring(5, 10);
            Console.WriteLine("frase.SubString(5, 10): " + fraseSubString);

            string[] fraseSplit = frase.Split(' ');
            Console.Write("frase.Split(' '): ");
            foreach (string palavras in fraseSplit)
            {
                Console.Write(palavras + " ");
            }
        }
    }
}
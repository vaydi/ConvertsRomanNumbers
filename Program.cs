using Microsoft.VisualBasic;
using System;

namespace convertsRomanNumbers
{
    internal class Program
    {
        private static int _compt;

        private static void Main(string[] args)
        {
            string rom = Console.ReadLine();

            if (rom != null)
            {
                var result = Convert(rom);

                Console.WriteLine(result == 0
                    ? "There is a problem with the roman letter"
                    : $"The result is: {result}");
            }
            else
            {
                Console.WriteLine("You have to write a roman letter");
            }
        }

        private static long Convert(string rom)
        {
            bool isCorrect = true;
            long sol = 0;
            try
            {
                for (_compt = 1; _compt < rom.Length; _compt++)
                {
                    long romOne = Symbol(Strings.Mid(rom, _compt, 1));
                    long romTow = Symbol(Strings.Mid(rom, _compt + 1, 1));

                    if (romOne == 0 || romTow == 0)
                    {
                        Console.WriteLine("You must submit a correct roman number. ");
                        isCorrect = false;
                        break;
                    }

                    sol += Calcul(romOne, romTow);
                }

                return isCorrect ? sol : 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static long Symbol(string symbol)
        {
            switch (symbol)
            {
                case "I":
                    return 1;

                case "V":
                    return 5;

                case "X":
                    return 10;

                case "L":
                    return 50;

                case "C":
                    return 100;

                case "D":
                    return 500;

                case "M":
                    return 1000;
            }

            return 0;
        }

        private static long Calcul(long romOne, long romTow)
        {
            try
            {
                if (romTow <= romOne) return romOne;

                _compt++;
                return romTow - romOne;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
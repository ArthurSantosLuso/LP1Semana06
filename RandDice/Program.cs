using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            long somaDados = 0;
            Random rnd = new Random(int.Parse(args[1]));

            for(int i = 0; i < int.Parse(args[0]); i++)
            {
                somaDados += rnd.NextInt64(1, 6);
            }

            Console.WriteLine(somaDados);

        }
    }
}

using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[2];
            //Enemy[] enemies = new Enemy[int.Parse(args[0])];

            for(int i = 0; i < enemies.Length; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                enemies[i] = new Enemy(Console.ReadLine());
            }

            foreach(Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }

        }
    }
}

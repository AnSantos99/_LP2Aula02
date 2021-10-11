using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables of type player
            Player player1, player2;

            // Initialize and set default values for health and armor properties
            player1 = new Player() {Health = 110f, Armor = 130f};

            // Point to the same reference
            player2 = player1;

            Console.WriteLine("Valores iniciais:");

            // Print out the result of each player instance
            Console.WriteLine($"Player1:\tHealth:{player1.Health}\tArmor:{player1.Armor}");

            Console.WriteLine($"Player2:\tHealth:{player2.Health}\tArmor:{player2.Armor}");

            DuplicateStats(player1);
            player1.Armor = 500f;

            Console.WriteLine("Valores depois:");

            // Print out the result of each player instance
            Console.WriteLine($"Player1:\tHealth:{player1.Health}\tArmor:{player1.Armor}");

            Console.WriteLine($"Player2:\tHealth:{player2.Health}\tArmor:{player2.Armor}");
        }

        public static void DuplicateStats(Player p)
        {
            p.Health *= 2;
        }
    }
}

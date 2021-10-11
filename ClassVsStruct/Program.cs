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
            player1 = new Player() {Health = 100f, Armor = 150f};

            // Point to the same reference
            player2 = player1;

            // Print out the result of each player instance
            Console.WriteLine($"Player1:\tHealth:{player1.Health}\tArmor:{player1.Armor}");

            Console.WriteLine($"Player2:\tHealth:{player2.Health}\tArmor:{player2.Armor}");


        }
    }
}

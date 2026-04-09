using System;

namespace Gun_VS_Plant
{
    public class Program
    {
        static void Main(string[] args)
        {
            // PLAYER SETUP
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            // PLAYER TYPE SELECTION
            Console.WriteLine("\nChoose your Player Type:");
            Console.WriteLine("1. Soldier       (Health: 100 | Bonus Damage: +0)");
            Console.WriteLine("2. Assasine      (Health:  70 | Bonus Damage: +30)");
            Console.WriteLine("3. Defender      (Health: 150 | Bonus Damage: +0)");

            int typeChoice = Convert.ToInt32(Console.ReadLine());

            Player player;

            if (typeChoice == 1)
            {
                player = new Soldier();
            }
            else if (typeChoice == 2)
            {
                player = new Assasine();
            }
            else
            {
                player = new Defender();
            }

            player.name = playerName;

           Console.WriteLine($"\n Player Created: {player.name} | Type: {player.PlayerType}" +
               $"\n Health {player.health} | Bonus Damage: {player.BonusDamage}");

            // GUN SELECTION
            Console.WriteLine("Choose your Gun:");
            Console.WriteLine("1. Desert Eagle (Damage: 15)");
            Console.WriteLine("2. AKM-47 (Damage: 30)");
            Console.WriteLine("3. Bazooka Rocket Launcher (Damage: 60)");

            int gunChoice = Convert.ToInt32(Console.ReadLine());

            if (gunChoice == 1)
                player.gun = new Gun("Desert Eagle", 15);
            else if (gunChoice == 2)
                player.gun = new Gun("AKM-47", 30);
            else
                player.gun = new Gun("Bazooka", 60);

            // ENEMY SETUP

            PlantEnemy plant = new PlantEnemy();

            Console.WriteLine("Choose Enemy Type: ");
            Console.WriteLine("1. Easy Plant (Health : 50) ");
            Console.WriteLine("2. Normal Plant (Health : 100) ");
            Console.WriteLine("3. Hard Plant (Health : 200) ");

            int enemyChoice = Convert.ToInt32(Console.ReadLine());

            if (enemyChoice == 1)
            {
                plant.type = "Easy Plant";
                plant.health = 50;
            }
            else if (enemyChoice == 2)
            {
                plant.type = "Normal Plant";
                plant.health = 100;
            }
            else
            {
                plant.type = "Hard Plant";
                plant.health = 200;
            }

            Console.WriteLine("\n ---------GAME START--------\n");

            //  GAME LOOP       

            while (player.IsAlive() && plant.IsAlive())
            {
                Console.WriteLine("---------------------");

                plant.ActivateShield();

                player.Attack(plant);

                Console.WriteLine("Enemy Health: " + plant.health);

                Console.ReadKey();

            }

            // RESULT

            if (plant.health <= 0)
                Console.WriteLine("\n" + player.name + " [" + player.PlayerType + "] WINS!");
            else
                Console.WriteLine("\n" + plant.type + " WINS!");







        }
    }
}

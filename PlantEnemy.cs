using System;


namespace Gun_VS_Plant
{
    public class PlantEnemy
    {
        public string type;
        public int health;
        public bool shieldActive;

        private static Random rand = new Random();

        public void ActivateShield()
        {
            int chance = rand.Next(0, 2);

            if (chance == 0)
            {
                shieldActive = true;
                Console.WriteLine(type + " activated Shield!");
            }
            else
            {
                shieldActive = false;
            }

        }

        public void TakeDamage(int damage)
        {
            if (shieldActive)
            {
                Console.WriteLine(type + " blocked the attack!");
                shieldActive = false;
            }
            else
            {
                health-= damage;
                Console.WriteLine(type + " took " + damage + " damage! ");
            }
        }

        public bool IsAlive()
        {
            return health > 0;
        }

    }
}



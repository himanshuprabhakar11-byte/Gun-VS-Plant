using System;


namespace Gun_VS_Plant
{
    public class Player
    {
        public string name;
        public int health;
        public Gun gun;

        public void Attack(PlantEnemy enemy)
        {
            Console.WriteLine(name + " attacks with " + gun.name);
            enemy.TakeDamage(gun.damage);
        }
        public bool IsAlive()
        {
            return health > 0;
        }

    }
}




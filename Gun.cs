using System;


namespace Gun_VS_Plant
{
    public class Gun
    {
        public string name;
        public int damage;

        public Gun(string name , int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        //Attack Logic

        public void Attack(PlantEnemy enemy , int bonusDamage = 0)
        {
            int totalDamage = damage + bonusDamage;
            if (bonusDamage>0)
            {
                Console.WriteLine($" >> Bonus Damage applied : {bonusDamage} ");
                enemy.TakeDamage(totalDamage);
            }
            
        }

    }

}



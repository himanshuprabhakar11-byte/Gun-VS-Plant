using System;


namespace Gun_VS_Plant
{
    // BASE CLASS FOR PLAYER    
    public class Player
    {
        public string name;
        public int health;
        public Gun gun;

        public virtual string PlayerType => "Player";
        public virtual int BonusDamage => 0;
        public void Attack(PlantEnemy enemy)
        {
            Console.WriteLine(name + " [ "+ PlayerType + " ]" +" attacks with " + gun.name +" "+ gun.damage+ " point hits!");
            enemy.TakeDamage(gun.damage);
        }
        public bool IsAlive()
        {
            return health > 0;
        }

    }
    // PlayerType = Soldier : Power = Avarage : Power ups = null

    public class Soldier : Player
    {
        public override string PlayerType => "Soldier";
        public override int BonusDamage => 0;

        public Soldier()
        {
            health = 100;
        }
    }
    // PlayerType = Assasine : Power = High Damage   : Power ups = +30 damage

    public class Assasine : Player
    {
        public override string PlayerType => "Assasine";
        public override int BonusDamage => 30;

        public Assasine()
        {
            health = 70;
        }
    }

    // PlayerType = Defender: Power = Extra Health : Power ups = +50 health

    public class Defender : Player
    {
        public override string PlayerType => "Defender";
        public override int BonusDamage => 0;

        public Defender()
        {
            health = 150;
        }
    }

}




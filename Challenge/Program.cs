namespace Challenge
{

    internal class Program
    {
        class Player
        {
            public string name;
            public double health;
            public double experience;
            public const double ImproveHisExp = 0.01;
            public const double LowerHealth = 0.1;

            public void SetName(string name)
            {
                if (name.Length > 2)
                {
                    this.name = name;

                }
            }

            public string GetName()
            {
                return this.name;
            }

            public void SetHealth(double health)
            {
                this.health = health;
            }
            public void SetExperience(int experience)
            {
                this.experience = experience;
            }

            public double GetHealth()
            {
                return this.health;
            }
            public double GetExperience()
            {
                return this.experience;
            }
            public Player(string name, double health, int experience)  //Method
            {
                this.name = name;
                this.health = health;
                this.experience = experience;
            }

            public double Shoot()
            {
                return experience += experience * ImproveHisExp;
            }

            public double Run()
            {
                return health -= health * LowerHealth;
            }

            public void Pass(Player player)
            {
                Console.WriteLine($"The Player {this.name} is shooting to {player.name}");
            }

        }



        static void Main(string[] args)
        {
            Player p1 = new Player("Ramy",200,90);
            p1.Run();
            Console.WriteLine("The Health is : " + p1.GetHealth());
            p1.Shoot();
            Console.WriteLine("The experience is :"+p1.GetExperience());
            Player p2 = new Player("Ahmed",220,100);
            p2.Pass(p1);
        }
    }
}

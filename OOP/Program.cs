namespace OOP
{

    class Player
    {
        public string name;
        public string health;
        public int experience;

       public void SetName(string name)
        {
            if(name.Length > 2)
            {
                this.name = name;

            }
        }

       public string GetName()
        {
            return this.name;
        }

        public void SetHealth(string health)
        {
            this.health = health;
        }
       public void SetExperience(int experience)
        {
            this.experience = experience;
        } 

        public string GetHealth()
        {
            return this.health;
        }
        public int GetExperience()
        {
            return this.experience;
        }
      public  Player(string name,string health,int experience)  //Method
        {
            this.name=name;
            this.health = health;
            this.experience = experience;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Ramy", "Good", 1);
            player.SetName("Ahmed");
            Console.WriteLine(player.GetName());
        }
    }
}

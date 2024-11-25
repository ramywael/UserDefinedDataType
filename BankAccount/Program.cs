namespace BankAccount
{
    class BankAccount
    {
        public string name;
        public int id;
        public int balance;

        public BankAccount(string name = "Name", int id = 1, int balance = 1000)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }

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

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }
        public void SetBalance(int balance)
        {
            this.balance = balance;
        }
        public int GetBalance()
        {
            return this.balance;
        }

        public bool Withdraw(int amount)
        {
            if(balance - amount > 0)
            {
                this.balance -= amount;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Deposite(int amount)
        {
            if(amount > 0)
            {
                this.balance+= amount;
                return true;
            }
            else
            {
                return false;

            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new("Ramy",1,2000);
            if (acc1.Withdraw(3000))
            {
                Console.WriteLine("Successfull");
                Console.WriteLine(acc1.GetBalance());
            }
            else
            {
                Console.WriteLine("Failed"); 
            }
            if (acc1.Deposite(500))
            {
                Console.WriteLine("Successful");
                Console.WriteLine(acc1.GetBalance());
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}

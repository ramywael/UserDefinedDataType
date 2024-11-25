using System.Data;

namespace ListOfTransaction
{
    internal class Program
    {
        class Transaction {
            public int id;
            public string status;
            public int amount;
            public DateTime dateTime;

            public Transaction(int id,string status,int amount,DateTime dateTime)
            {
                this.id = id;
                this.status = status;
                this.amount = amount;
                this.dateTime = dateTime;
            }
        }

        class BankAccount
        {
            public string name;
            public int id;
            public int balance;
            public List<Transaction> transaction;

            public BankAccount(string name = "Name", int id = 1, int balance = 1000)
            {
                this.name = name;
                this.id = id;
                this.balance = balance;
                this.transaction = new List<Transaction>(); // When the Constructor is called and already is called a first it will create an empty list
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
                if (balance - amount > 0)
                {
                    this.balance -= amount;
                  Transaction  transaction1 = new Transaction(1, "Withdraw", amount, DateTime.Now);
                    transaction.Add(transaction1);
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public bool Deposite(int amount)
            {
                if (amount > 0)
                {
                    this.balance += amount;
                    Transaction transaction1 = new Transaction(1, "Deposite", amount, DateTime.Now);
                    transaction.Add(transaction1);
                    return true;
                }
                else
                {
                    return false;

                }
            }
        }
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Ramy", 1, 2000);
            if (acc1.Withdraw(1000))
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
            for (int i = 0; i < acc1.transaction.Count; i++)
            {
                Console.WriteLine(acc1.transaction[i].id);
                Console.WriteLine(acc1.transaction[i].status);

                Console.WriteLine(acc1.transaction[i].amount);

                Console.WriteLine(acc1.transaction[i].dateTime);
                Console.WriteLine("==========================");

            }
        }
    }
}

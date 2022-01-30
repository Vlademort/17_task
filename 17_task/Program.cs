using System;

namespace _17_task
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> ba1 = new BankAccount<int>(000000, 150000, "");
            ba1.SetName("Иванов Иван Иванович");
            ba1.SetCheck(8951367);
            ba1.GetInfo();

            BankAccount<string> ba2 = new BankAccount<string>("AAAAAA", 379550, "");
            ba2.SetName("Петров Петр Петрович");
            ba2.SetCheck("3T158GF");
            ba2.GetInfo();

            Console.ReadKey();
        }
    }

    class BankAccount<T>
    {
        private T Check { get; set; }
        private double Balance { get; set; }
        private string FullName { get; set; }

        public BankAccount(T check, double balance, string fullname)
        {
            Check = check;
            Balance = balance;
            FullName = fullname;
        }

        public void SetName(string fullname) // ability to change user name
        {
            FullName = fullname;
        }
        public void SetCheck(T check) // ability to change bill
        {
            Check = check;
        }
        public void GetInfo()
        {
            Console.WriteLine($"На счету {Check} вкладчика {FullName} лежит {Balance} рублей \n");
        }
    }
}

using System;

namespace EventsQuestion
{
    public delegate void dele();
    class Account
    {
        public event dele zerobalance;
        public event dele underbalance;
        public int AccNumber;
        public string Name;
        public int balance;
        public Account(int AccNumber, string Name, int balance)
        {
            this.AccNumber = AccNumber;
            this.Name = Name;
            this.balance = balance;
        }
        public void withdraw(int Amount)
        {
             balance = balance - Amount;
           
            if(balance==0)
            {
                onzerobalance();
            }
           else if (balance < 500)
            {
                onunderbalance();
            }
        }
        public int Deposit(int Amount)
        {
            return balance = balance + Amount;
        }
       
       public void onunderbalance()
        {
            underbalance?. Invoke();
        }
        public void onzerobalance()
        {
            zerobalance?.Invoke();
        }
    }
        class EventsProgram
        {
        static void Main(string[] args)
        {
         
            Account ac = new Account(111, "satya",1000);
            ac.underbalance += c1.underbalEventHandler;
            ac.zerobalance += c1.zerobalEventHandler;

            ac.withdraw(1000);
            
            //ac.withdraw(600);
        }
    }
}

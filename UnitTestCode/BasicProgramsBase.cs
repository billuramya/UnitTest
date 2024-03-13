using System;
namespace UnitTestCodes
{
    public class BankBalance
    {
        string _bankHoderName;
        double balance;
        public void banckAccount(string bankHoderName, double Balance)
        {
            _bankHoderName = bankHoderName;
            balance = Balance;
        }
        public double Balance { get { return balance; } }

        public void Debit(double amount)
        {
            if (amount == 0)
            {
                throw new ArgumentException("amount ==0");
            }
            if (amount <= 0 || amount > balance)
            {
                throw new ArgumentException("amount <=0 or amount > balance");
            }
            balance -= amount;

        }

    }

    public class GenericCalculation<T>
    {
        public T Add(T a,T b)
        {
            dynamic num1 = a;
            dynamic num2= b;
            return num1 + num2;
        }
        public T sub(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 - num2;
        }
        public T mul(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 * num2;
        }
        public T div(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            if (num1 == 0)
            {
                throw new DivideByZeroException("denominator not zero");
            }
            return num1 / num2;
        }
        
    }
}
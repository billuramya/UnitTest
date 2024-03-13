using System;

namespace BasicMathTest
{
    internal class BankBalance
    {
        private string v1;
        private int v2;

        public BankBalance(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Balance { get; internal set; }

        internal void bankAccount(string v)
        {
            throw new NotImplementedException();
        }

        internal void Credit(int v)
        {
            throw new NotImplementedException();
        }

        internal void Credit()
        {
            throw new NotImplementedException();
        }

        internal void Debit(int v)
        {
            throw new NotImplementedException();
        }
    }
}
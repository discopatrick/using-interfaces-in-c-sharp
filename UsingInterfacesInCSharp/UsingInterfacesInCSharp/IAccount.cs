using System;

namespace UsingInterfacesInCSharp
{
    delegate void OverdrawnEventHandler(decimal balance, string name);

    public class OverdrawnEventArgs : EventArgs
    {
        decimal Balance { get; }
    }

    interface IAccount
    {
        event EventHandler<OverdrawnEventArgs> Overdrawn;
        event OverdrawnEventHandler Overdrawn2;
        event Action<decimal, string> Overdrawn3;
        event Func<decimal, string, bool> Overdrawn4;
    }

    class Customer : IAccount
    {
        public event EventHandler<OverdrawnEventArgs> Overdrawn;
        public event OverdrawnEventHandler Overdrawn2;
        public event Action<decimal, string> Overdrawn3;
        public event Func<decimal, string, bool> Overdrawn4;
    }

    class Test
    {
        void TestEvents()
        {
            IAccount cust = new Customer();
            cust.Overdrawn += Cust_Overdrawn;
            cust.Overdrawn2 += Cust_Overdrawn2;
            cust.Overdrawn3 += Cust_Overdrawn3;
            cust.Overdrawn4 += Cust_Overdrawn4;
        }

        void Cust_Overdrawn(object sender, EventArgs e)
        {

        }

        void Cust_Overdrawn2(decimal balance, string name)
        {

        }

        void Cust_Overdrawn3(decimal arg1, string arg2)
        {

        }

        bool Cust_Overdrawn4(decimal arg1, string arg2)
        {
            return true;
        }

    }
}



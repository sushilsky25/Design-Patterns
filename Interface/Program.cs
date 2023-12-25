using System;

namespace Interface
{
    using System;
    interface Customer
    {
        int AMT { get; } // public + static + final
        void Purchase(); // public + abstract
    }

    class SellerSky : Customer
    {
        public int AMT { get; } = 5;

        public void Purchase()
        {
            Console.WriteLine($"Customer needs {AMT} Kg rice");
        }
    }

    class Check
    {
        public static void Main(string[] args)
        {
            Customer s = new SellerSky();
            s.Purchase();
            Console.WriteLine(((SellerSky)s).AMT);
        }
    }
}

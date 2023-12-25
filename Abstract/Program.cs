using System;

namespace Abstract
{
    abstract class Programming
    {
        public abstract void Developer();
        public abstract void Rank();
    }

    abstract class HTML : Programming
    {
        public override void Developer()
        {
            Console.WriteLine("Sushil Yadav");
        }
    }

    class Java : HTML
    {
        public override void Rank()
        {
            Console.WriteLine("1st");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Programming h = new Java();
            h.Developer();
            h.Rank();
        }
    }
}

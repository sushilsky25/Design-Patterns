Singleton Design Pattern - C#:

Singleton pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is a pattern that is one of the simplest design patterns. This pattern ensures that a class has only one instance. In this article, I would like to share what is Singleton pattern and how is it works?

What is Singleton Pattern?
Singleton Design pattern is one of the simplest design patterns. This pattern ensures that a class has only one instance and provides a global point of access to it.

A singleton design pattern in C# is one of the widely used & most popular design patterns around the corner. By using this design pattern, a class will have only a single instance of the program that provides a global point of access to it seamlessly. In other words, we can say that the singleton pattern follows is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.

Singleton Pattern - UML Diagram & Implementation:

![image](https://github.com/sushilsky25/Design-Patterns/assets/31982301/fc6e8e50-c3ed-4e41-b578-698d89b0e3cd)

The classes and objects in the above UML class diagram are as follows:

Singleton:
1.This is a class that is responsible for creating and maintaining its own unique instance.

Who is what?

The classes and objects in the above class diagram can be identified as follows:

Singleton - Singleton class

C# - Example Code:

using System;

namespace SingletonPattern
{

    // The 'Singleton' class    
    public class Singleton
    {
        // .NET guarantees thread safety for static initialization
        private static Singleton instance = null;
        private string Name { get; set; }
        private string IP { get; set; }
        private Singleton()
        {
            //To DO: Remove below line
            Console.WriteLine("Singleton Intance");

            Name = "SkyIP";
            IP = "192.168.1.37";
        }
        // Lock synchronization object
        private static object syncLock = new object();

        public static Singleton Instance
        {
            get
            {
                // Support multithreaded applications through
                // 'Double checked locking' pattern which (once
                // the instance exists) avoids locking each
                // time the method is invoked
                lock (syncLock)
                {
                    if (Singleton.instance == null)
                        Singleton.instance = new Singleton();

                    return Singleton.instance;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Sky Server's Information is : Name={0} & IP={1}", Name, IP);
        }

    }

    /// Singleton Pattern 
    
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Show();
            Singleton.Instance.Show();
            Singleton.Instance.Show();

            Console.ReadKey();
        }
    }
}

OUTPUT:
![image](https://github.com/sushilsky25/Design-Patterns/assets/31982301/1e1c3c37-bfcd-4c33-9fed-00110e659549)

When to use it?
1.Exactly one instance of a class is required.

2.Controlled access to a single object is necessary.
When we required no thread-safe singleton design pattern


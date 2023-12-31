Factory Method Design Pattern - C#:

The factory method design pattern abstract the process of object creation and allows the object to be created at run-time when it is required. Factory method pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is used to create objects. People usually use this pattern as the standard way to create objects. In this article, I would like to share what is factory pattern and how it works?

What is Factory Method Pattern?
In Factory pattern, we create the object without exposing the creation logic. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate. The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.

In short, factory method design pattern abstract the process of object creation and allows the object to be created at run-time when it is required.

Factory Method Pattern - UML Diagram & Implementation:

![image](https://github.com/sushilsky25/Design-Patterns/assets/31982301/a44fc273-bbba-4e65-bb21-d2fe298fe928)

The classes, interfaces and objects in the above UML class diagram are as follows:

1.Product
This is an interface for creating the objects.

2.ConcreteProduct
This is a class which implements the Product interface.

3.Creator
This is an abstract class and declares the factory method, which returns an object of type Product.

4.ConcreteCreator
This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.

Factory Method Pattern - Example:

![image](https://github.com/sushilsky25/Design-Patterns/assets/31982301/fe89bd78-ca74-49a4-beb0-ee51f82012eb)


Who is what in Code?

The classes, interfaces, and objects in the above class diagram can be identified as follows:

1.IFactory - Interface

2.Scooter & Bike - Concreate Product classes

3.VehicleFactory - Creator

4.ConcreteVehicleFactory - Concreate Creator

C# Code Example:
using System;

namespace FactoryPattern
{
    // The Product interface
    public interface IFactory
    {
        void Drive(int miles);
    }

    // A ConcreteProduct class
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }

    // A ConcreteProduct class
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }

    // The Creator Abstract Class
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);

    }

    // A ConcreteCreator class
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }
    }

    // Factory Pattern
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadKey();

        }
    }
}

When to use it?
1.Subclasses figure out what objects should be created.

2.Parent class allows later instantiation to subclasses means the creation of an object is done when it is required.

3.The process of objects created is required to centralize within the application.

4.A class (creator) will not know what classes it will be required to create.



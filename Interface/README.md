C# Interface:

![Interface](https://github.com/sushilsky25/Design-Patterns/assets/31982301/70678274-dce6-489e-8674-41d12857ec5e)


Like a class, Interface can have methods, properties, events, and indexers as its members. But interfaces will contain only the declaration of the members. The implementation of the interface’s members will be given by class who implements the interface implicitly or explicitly.

Interfaces specify what a class must do and not how.
Interfaces can’t have private members.
By default all the members of Interface are public and abstract.
The interface will always defined with the help of keyword ‘interface‘.
Interface cannot contain fields because they represent a particular implementation of data.
Multiple inheritance is possible with the help of Interfaces but not with classes.

Syntax for Interface Declaration:
interface  <interface_name >
{
    // declare Events
    // declare indexers
    // declare methods 
    // declare properties
}

Syntax for Implementing Interface:
class class_name : interface_name
To declare an interface, use interface keyword. It is used to provide total abstraction. That means all the members in the interface are declared with the empty body and are public and abstract by default. A class that implements interface must implement all the methods declared in the interface.

![interafce2](https://github.com/sushilsky25/Design-Patterns/assets/31982301/8b8bd52c-cf1f-4456-8c4e-b4fbe59f73b3)


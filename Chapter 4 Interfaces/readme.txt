Interfaces

1. What is an interface
A language construct that is similar to a class(in terms of syntax) but is fundamentally different.
Instead of using the class keyword you use the interface keyword and they start with the letter I.
Interfaces do not have implementation.
They are used to build loosely-coupled applications.
An interface is a just reference. It doesn't have code. It's methods do not have a body.
Interfaces are really powerful and help for to create loosely-coupled applications. 
As you can see in interfaces_force_implementation.jpg they provide some type of safety.
Imagine interfaces like labels for class so they tell the class what methods and properties should have.

2. How to declare and implement intefaces
Interface memebers do not have access modifiers as you can see below and no curly braces for its members.

-Example

public interface ITaxCalculator
{
	int Calculate();
}

The best example of interfaces so you can understand them
https://www.youtube.com/watch?v=IQpss9YAc4g

3. Why not use a base class
Because we can use multiple interfaces that we can derive and by using interfaces we are saying how the class 
is going to work.

4. Interfaces and Testability
Project Interfaces_and_Testability

5. Interfaces and extensibility
Project Interfaces_and_Extensibility
An ideal application is made in that way, that you can change the behaviour of a class 
without affecting other classes and changing its code.
With extensibility instead of using the code in the existing class you 
create new class that don't affect the previous one and change the behavior of the system.
That is a little hard to implement it and the cost is too much that is not worth it.
Well that's where interfaces come in.

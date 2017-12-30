1. What is a class

- A class is a building block of an application. A simpler meaning is that a class is a file that contains code.
- An application has many classes that will have different behaviors.

2. What a class has

- Data(fields)
- Behaviour(methods/functions)


3. UML 

- To represent a program in paper we have the Unified Modeling language which is easily understood. 
Imagine it like the design.

If we would like to represent a class in UML it would look like this.

---Person---
------------
Name: string
Age: byte
Height: float
Weight : byte
------------
Walk()
Eat()
Talk()
Sleep()


---Post---
------------
Title: string
Description: string
Date: DateTime
------------
Publish()
Like()
Comment()


4. Object

- Sometimes we say class is an object or vice versa. This isn't true since an object is an instance of a class.
- The Person class is the blueprint which we can define as many Objects as we want.
- Like a house can have a blueprint and you can built as many houses you want with different color etc the same applies to a class.

Class					Objects				
---Person---			George
------------			John
Name: string			Elizabeth			
Age: byte
Height: float
Weight : byte
------------
Walk()
Eat()
Talk()
Sleep()


5. To declare a class in C#

- First access modifier, then the keyword class and then the name of the class with Pascal Case(the firstletter of words is uppercase)
- To declare fields access modifier first then data type adn then name/identifier
- In a real world application you shouldn't t declare a field as public
- To declare a method in class is very similar and it can have a return type or void which doesn't return anything. In parenthesis we put any parameters we might need.

public class Person
{
	public string Name;
	
	public void Introduce()
	{
		Console.WriteLine("Hi my name is " + Name);
	
	}


}


6. Create an object

Person person = new Person();

var person = new person();


7. Use an Object

var person = new Person();

//Accessing the Name field
person.Name = "Mosh";

//Accessing the method introduce
person.Introduce();


8. Class Members
In C# we have 2 types of class members

- Instance : accessible from an object
var person = new person();
person.Introduce();


- Static : directly accessible from the class 
//Also a great explanation can be found here :https://unity3d.com/learn/tutorials/topics/scripting/statics
//Console is a class and WriteLine is a static method
Console.WriteLine();

--Why use static members?

To represent concepts that are unique like datetime

DateTime.Now
Console.WriteLine()

---Delcaring static members

public class Person
{

	public static int PeopleCount = 0;

}

9. Create class in Visual Studio

- Solution Explorer right click in your name's app then Add New Item or Add Class








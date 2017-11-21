1. Access Modifiers
We have used public as we have seen. An access modifier is a way to control access to a class and/or its members.
We use them so we can have safety in our programs.

- Public
- Private
- Protected
- Internal
- Protected Internal

--Example

public class Customer
{

	private string Name;

}

var customer = new Customer();
customer.Name = "John"; // Won't compile

2. Object-oriented Programming pillars

- Encapsulation/Information Hiding
Encapsulation is related to Access Modifiers. Classes must be responsible for one thing and not do many things. 
They must have information hidden from outside.
Imagine it like a building. You don't want anyone to have access everywhere but give specific people permissions to enter a room or
imagine a class Hero that it has a field heroRealId. You don't want villains to know the heroRealId.
So encapsulation is to hide details for fields/methods from outside the class.

-- Define fields as private
-- Provide getter/setter methods as public

--- Example

public class Person
{

	private string Name;
	
	public void SetName(string name)
	{
	
		if(!String.IsNullOrEmpty(name))
			this.Name = name;
	
	}
	
	public string GetName()
	{
	
		return Name;
	
	}

}

- Inheritance
- Polymorphism


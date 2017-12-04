1. Why access modifiers are important

2. Vault metaphor
Imagine access mofifiers like a vault tht we don't want anyone to have access in it. We don't know what's inside the vault.
The more of a class reveals of its internal implentation the more chances to break other parts of the system. Don't forget that some systems depend on that class.



3. C# access modifiers
- public 
-- Accesible from everywhere

	public class Customer
	{

		public void Promote()
		{
		}


	}
	
......
//We create a customer object somewher else in the code and call the Promote method
var customer = new Customer();
customer.Promote();	
	

- private
-- Accesible only to from current class.

	public class Customer
	{
	
		private int CalculateRating()
		{
		
		
		}
	
	}
	
.....
//We don't want CalculateRating to be visible anywhere else since it won't help us
var customer = new Customer();
customer.CalculateRating();	


- protected
--Accessible only from the class and its derived classes. It's similar to private but derived classes can call it also.
-- any class derived from it will have CalculateRating but this breaks encapsulation. Try to avoid it and use private methods but if needed use it.
public class Customer
	{
	
		protected int CalculateRating()
		{
		
		
		}
	
	}
	
.....
//This will show error since we can't call CalculateRating
var customer = new Customer();
customer.CalculateRating();	




- internal
It is used with the classes and not members. Accessible only from the same assembly.

internal class RateCalculator
{
}

//In the same assembly
var calc = new RateCalculator();

//In another assembly we have an error
var calc = new RateCalculator();


- protected internal 
One the weirdest things of C#. Accessible only from the same assmbly or any derived classes.
This is bad in both temrs of teaching and learning , writing code and someone reading that code. It' s just confusing.

public class Customer
{

	protected internal void Weirdo()
	{
	
	
	}

}

Check the project Access_Modifiers
We don't want CalculateRating() to be public since if someone tries to call it directly and we make a change then it all breaks.
After all we only want to calculate rating in this class. 
If we make it protected we create a dependency on this so any changes will affect derived classes.
That's why encapsulation is so important in OOP.


4. Create a DLL 
As you see in create_dll.jpg right click in project and then New Project then add Class Library and name it Amazon.
Now check amazon_dll.jpg to see what happened ad delete the default Class1.cs.
We has a class Customer.cs in Access_Modifiers which we moved to Amazon dll.
If we delete the class Customer.cs that was in Access_Modifiers we will get an error as seen in no_customer_access_modifiers.jpg.
Then to reference that right click in Access_Modifiers references and check create_reference.jpg and write using Amazon so you can use the
namespace you want.

5. Amazon namespace
Aw you can see in Amazon_namespace.jpg by typing Amazon you can see it's classes.
We declare the Rate_Calculator class as internal so we can't call it from other assembly as you see in no_access_internal.jpg.






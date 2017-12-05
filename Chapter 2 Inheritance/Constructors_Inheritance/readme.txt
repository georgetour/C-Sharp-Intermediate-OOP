Constructor Inheritance

- Base class constructiors are always executed first.
- Base class constructors are not inherited.

Example

public class Vehicle
{

	private string _registrationNumber;
	
	public Vehicle(string registrationNumber)
	{
	
		_registrationNumber = registrationNumber;
	
	}



}


//Derived class

public class Car:Vehicle
{

	public Car(string registrationNumber)
	{
	
		//Not valid since _registrationNumber in Vehicle class is encapsulated as private
		_registrationNumber = registrationNumber;
	
	}

}

2. The base keyword
To fix the above so we can access the private field that's used in the constructor of Car class we use 
the base keyword.

public class Car:Vehicle
{
	public Car(string registrationNumber)
		:base(registrationNumber)
		{
		
			//Initialise fields specific to the Car class
		
		}
	
}

As you see in our project by using the keyword base we have a parameter that uses the argument of public Car(string registrationNumber)
and the constructor of Vehicle is executed first.
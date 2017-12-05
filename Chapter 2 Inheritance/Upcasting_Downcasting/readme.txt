Upcasting_Downcasting

- Conversion from a derived class to a base class(upcasting)
- Conversion from a base class to a derived class(downcasting)
- The as and is keywords

1. Upcasting example

public class Shape
{
}


public class Circle:Shape
{
}

//Upcasting
Circle circle = new Circle();
Shape shape = circle;

2. Downcasting example
Circle circle = new Circle();
Shape shape = circle;

Circle anotherCircle = (Circle)shape;
Car car = (Car)shape; //throws InvalidCastException


3. The as keyword

//This might get an exception
Car car = (Car) obj;

//Correct way of doing it. If the object can't be converted it doesn't throw an exception it just returns null
Car car = obj as Car; 

if(car != null)
{
}

4. The is keyword 
We can check the type of an object.

if(obj is Car)
{

	//Then safely cast it to car 
	Car car = (Car) obj;

}

5. Search for an object in Visual Studio
Go to View Object Browser and search for the object

6. shape2 object in our project
To see the value and type of shape2 that we created in our project :
F9 to add breakpoint
F5 to run the app in debug mode
F10 to step over the code


7. Limited view of an object
Also you can use downcasting to see the properties of an object that don't appear normally 
as you see in the project in button click the sender object.

Abstract Classes and Members

1. Abstract Modifier
Indicates that a class or a member is missing implementation.

- Example

public class Shape
{
	public virtual void Draw()
	{
	}
}

public class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Draw a circle");
	}

}

Here comes the problem. We don't know how to Draw a shape in our base/parent class.
In Circle class we know how to draw a circle. In situations like this it's better to use 
the abstract keyword in our Draw method in base class to say that this method is missing implementation 
and we leave it to the derived classes that have implem,entation methods.


2. Abstract classes and members
When we declare a method as abstract the class that has the method needs to be declared abstract as well.
With this example we are saying that the shape class is missing implementation and that implementation needs
to be provided in the derived classes.
So abstract methods are virtual also and can provide polymorphic behavior as you have seen earlier.

-- Correct way of the above example

public abstract class Shape
{
	public abstract void Draw()
	{
	}
}

public class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Draw a circle");
	}

}

3. Abstract Members
- Do not include implementation.

public abstract void Draw();

- If a member is declared as abstract, the containing class needs to be declared abstract as well.

public abstract class Shape
{
	public abstract void Draw()
	{
	}
}

- Derived classes must implement all abstract members in the base abstract class.

public class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Draw a circle");
	}

}

4. Abstract Classes
- Cannot be instantiated.

var shape = new Shape(); //Won't compile


5. Why to use abstract
We use abstract when we want to provide some common behaviour while forcing other developers to follow your design.


public abstract class Shape
{
	public abstract void Draw()
	{
	}
}

public class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Draw a circle");
	}

}

In our example above we make sure that if a developer derives a class from the shape they will
provide an implementation for the draw method. 
If we didn't make it like that we might run into a problem when a developer doesn't override the Draw method.

5. Sealed classes and members
It's the opposite of abstract and it means it cannot be derived. It's hardly ever used and it means bad implementation of our code.
Method Overriding

1. Method overriding
Modifying the implementation of an inherited method. When we use inheritance there might needed to 
modify a method that was inherited from a base class.

-- Example

public class Shape
{
	public void Draw()
	{
	}
} 

public class Circle:Shape
{
}

public class Image: Shape
{
}

2. Virtual/override keywords

To override a method as we see in the above example so we can use it differently it's done like that:

public class Shape
{
	public virtual void Draw()
	{
		//Default implementation
	}

}

public class Circle:Shape
{
	public override void Draw()
	{
	
		//New implementation
	
	}
	

}

This technique is very powerful and it's one way of polymmorhic behavior in C#.

3. base keyword

When we type override visual studio finds the methods that can override automatically by adding the keyword base and then the method.

 public override void Draw()
        {
            base.Draw();
        }

Base is a reference to the parent class.

4. Polymorphism

Poly in Greek means many. Morphism means form. So Polymorphism means many forms. As you see in the project we have
the concept of shape and the concept of drawing a shape. But that concept can have different forms depending on the objects we have at run time.
With polymorphism we have zero impact in our other classes. This is a sign of loosely coupled applications.


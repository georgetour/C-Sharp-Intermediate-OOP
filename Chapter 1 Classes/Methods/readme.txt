1. Methods
As we already know a method is a named block of code that does or returns something and we call it anywhere we want so we don't repeat.

- Signature of Methods
- Method Overloading
- Params modifier
- Ref modifier (not used a lot)
- Out modifier (not used a lot)


2. Signature of a method
- Name 
- Number and Type of parameters

-- Example
public class Point
{
	 public void Move(int x, int y)
	 {
	 
	 }

}


3. Overloading Methods
Method with same name but with different signatures

-- Example with three overloads
public class Point
{
	 public void Move(int x, int y)
	 {
		public void Move(int x, int y) {}
		
		public void Move(Point newLocation){}
		
		public void Move(Point newLocation, int speed) {}
		
		
	 }

}


4. Varying number of paramaters
Instead of using many many overload methods we can use 

public class Calculator
{

	public int Add(int[]numbers){}

}

var result = calculator.Add(new int[]{1, 2, 3, 4});


5. Params modifier
With the above example we have to use the new keyword everytime to initialize an array. It's a better way to do this.

public class Calculator
{

	public int Add(params int[]numbers){}

}

var result = calculator.Add(1, 2, 3, 4);








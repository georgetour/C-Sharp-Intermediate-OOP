1. What is a constructor

- A constructor is a method that is called automatically when an instance of a class is created.

2. Why we need a constructor

- To put an object in an early state. If we want something to be done for the object before eveything else runs. 

3. How we declare a constructor

- We give same name to method as the class
- Also constructors do not have a return type or void


-- Example 


public class Customer 
{

	//This is a parameter less or a default constructor
	public Customer()
	{
	
	
	
	}

}

-- Example with parameter


public class Customer 
{

	public string Name;

	//The constructor parameter here will pass the value to the field Name
	public Customer(string name)
	{
	
		//This is a keyword that references to the current object and with that way it makes sense 
		//since we are are saying for this object the field Name = name
		this.Name = name;
	
	
	}

}

4. Create instance and use of the constructor for the above example

//Now the field name will have value John immediately at creation
var customer = new Customer("John");

5. Constructor Overloading

- Overloading means having a method by the same name but different signatures.
- A signature is something unique that identifies the method like return type, it's name and the types and numbers of paramaters.
- We cannot have two constructors with the same signature.
- The reason we need overloading is that sometimes we might need the method but we only know some parameters or we might don't want to return something.
- Also to see how overloads appear check overloads.jpg and to see all overloads of method Ctrl+Shift+Space



public class Customer
{

	//Example with Three constructors with different signatures
	public Customer(){...}
	
	public Customer(string name) {...}
	
	public Customer(int id, string name) {...}


}

6. An easy way to create a constructor is to type ctor for code snippet

7. Default constructor

- This is a constructor from C# compliler that gives to fields default values as shown in default_values.jpg

8. This()

- This() is used to initialize the constructor at a method of the class without repeating yourself
- It's not used in general since we have bad control overflow

-- Example

public class Customer
    {
        
        public int Id;
        public string Name;

        
        public List<Order> Orders;


        public Customer()
        {
            //Empty list created at instantiation with contructor
            Orders = new List<Order>();
        }

        public Customer(int id)
			//This will initialize the Customer constructor without arguments
            :this()
        {

            this.Id = id;

        }
	}



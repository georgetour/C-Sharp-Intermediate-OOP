1. Fields
- Initialization
- Read-only fields


2. Initialization

--Example 

public class Customer
{

	List<Order> Orders;
	
	public Customer()
	{
	
		Orders = new List<Order>();
	
	}
	


}

//Initializing without need of using the constructor
public class Customer
{

	List<Order> Orders = new List<Order>();


}


3. Read-only Fields 
Read-only fields are only assigned once. It's used so we can protect something from being re initialized and lose data.

public class Customer
{

	readonly List<Order> Orders = new List<Order>();

}
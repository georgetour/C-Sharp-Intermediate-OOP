1. Object Initializers

- A syntax that quickly initializes the object without the need to call one of its contructors
- This is done so we avoid creating multiple constructors

-- Example

//With this syntax we are not calling any of the contructors of Person class
var person = new Person
				{
				
				FirstName = "George",
				LastName = "Tourtsinakis"
				
				};	
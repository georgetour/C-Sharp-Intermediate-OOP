1. Indexers
A way to access elements in a class that represents a list of values.

- Examples
var array = new int[5];
array[0] = 1;

var list = new List<int>();
list[0] = 1;

- Example
var cookie = new HttpCookie();
cookie.Expire = DateTime.Today.AddDays(5);

cookie["name"] = "George";

//Without the indexer
cookie.SetItem =("name", "George");

var name = cookie["name"];

//Without the indexer
var name = cookie.GetItem("name");

2. How to declare an indexer

- Example 

public class HttpCookie

{

	public string this[string key]
	{
	
		get{}
		set{}
	
	
	}



}
1. What is composition
Like inheritance it's a relationship between two classes that allows one to contain the other.

- Example
Car has an engine

2. Benefits
- Code reusability
- Flexibility
- Loose coupling

- Example
Let's say we have class that's called DbMigrator and it s responsible to migrate our database but it requires logging.
Also we have an installer for our application that also requires logging. We have two classes that have logging in common. 

So we will create a class that will called Logger and out above classes will be related to it.

3. UML Notation
Check composition_uml.jpg

4. Syntax

public class Installer
{
	private Logger _logger;
	
	public Installer(Logger logger)
	{
	
		_logger = logger;
	
	}
}

5. Problems with Inheritance
- Easily abused by amateur designers/developers
- This leads to large hierarchies of classes which makes them fragile. If you change a class on top of the hierarchy alll inherited classes will have problems
- Fragile 
- Tightly Coupling

- Example
uml_inheritance.jpg

6. Advanctages of Composition Over Inheritance
- Any inheritance relationship can be translated to composition
- We need to design our classes so a change in the class has a minimum impact on the whole system
- In our below example in why_composition_uml.jpg instead of person and dog deriving from animal they have an animal
- With composition we encapsulate some common functionality and we can create new classes with new capabilities and compose them together
- Minimal or zero impact on other classes
- Flexibility
- Loose Coupling

7. Summary
We have two types of relationships 
- Inheritance(Is-a)
- Composition(Has-a)

-- Inheritenace
Pros: Reusability, easier to understand
Cons: Tightly Coupled, fragile, can be abused

-- Composition
Pros: Code reusability, great flexibility, loose coupling,
Cons: Harder to understand

Inheritance is not necessarily a bad thing. Use both Inheritance and Composition.



Boxing and Unboxing

- Value Types and Reference Types
- Boxing and Unboxing


1. Value Types
- Are stored on the stack.
-- All primitive types :byte, int, float char , bool
-- The struct type

2. The stack
When the program is executed a limited amount of space in the memory is allocated to each thread 
of your program and this space is used to store simple values like all primitive types.
They have a short lifetime which means when they go out of scope the get out of stack.

3. Reference Types
-Are stored in the heap
-- Any classes(Object, Array, String, DbMigrator, etc)

4. The heap
It's a larger amount of memory. It is used to use objects that require a longer lifetime.  


5. Boxing
Boxing is the process of converting a value type instance to an object reference

- Example
int number = 10;
object obj = number;

//or 
//This will be stored in the heap instead of the stack
object obj = 10;

6. Unboxing is the opposite of boxing

- Example
object obj = 10;

//Now we cast the obj to an integer unboxing happens and the result is we get a new variable on the stack.
int number = (int)obj;


7. Boxing/Unboxing they have a performance penalty because of that extra object creation




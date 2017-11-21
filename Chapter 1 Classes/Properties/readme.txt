1. Properties
A class member that encapsulates a getter/setter for accessing a field. With a property we create a getter/setter with less code.

- Example
public class Person
    {

        private DateTime _birthdate;

        //The property must have exact data type as the field
        public DateTime Birthdate
        {
            get { return _birthdate;  }
            set { _birthdate = value; }
            
            
        }


    }
	
2. Auto-implemented Properties

- Example
public class Person
    {

        private DateTime _birthdate;

        //The property must have exact data type as the field
        public DateTime Birthdate
        {
             {get; set; }
            
            
        }


    }
	
When the compiler sees that it creates a a hidden private field automatically.

3. Visual Studio Command Prompt 

You must download the Productivity Power Tools 2015 from Tools->Extensions and Updates. 
To see where the compile files or the assemblies are check compile_files_and_assemblies.jpg
We have a Properties.exe which means it's an executable an application.
Write ildasm which stands for intermediate language disassembler which is the language the C# compiler targets.
The Backing Field which you will see in ildasm.jpg is the automatically field created by the compiler.


4. Property shortcut
To create a property fast you type prop then press tab tab


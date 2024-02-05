using System;

public class Person
{
    protected string Name;
	protected string Address;

	public Person(string name, string address)
	{
		Name = name;
		Address = address;
	}

	public string GetName()
	{
		return Name;
	}

	public string GetAddress() 
    { 
		return Address;
	}

    public virtual void OutputName()
    {
        Console.WriteLine(Name);
    }

    public void SetName(string change)
    {
        Name = change;
    }

    public void SetAddress(string newAddress)
    {
        Address = newAddress;
    }

	public static void PersonTests()
	{
		Person personOne = new Person("L","E");
        Person personTwo = new Person("J","K");
        Person personThree = new Person("O","P");

        Console.WriteLine(personOne.GetAddress());
        Console.WriteLine(personTwo.GetAddress());
        Console.WriteLine(personThree.GetAddress());
        Console.WriteLine(personOne.GetName());
        Console.WriteLine(personTwo.GetName());
        Console.WriteLine(personThree.GetName());

        personOne.SetName("J");
        personOne.SetAddress("G");
        personTwo.SetName("S");
        personTwo.SetAddress("S");
        personThree.SetName("C");
        personThree.SetAddress("C");

		Console.WriteLine(personOne.GetAddress());
        Console.WriteLine(personTwo.GetAddress());
        Console.WriteLine(personThree.GetAddress());
        Console.WriteLine(personOne.GetName());
        Console.WriteLine(personTwo.GetName());
        Console.WriteLine(personThree.GetName());
        
        //subprogram is a block of code that will carry out a task when called
        //both functions and procedures are subprograms
        //difference between a function and a procedure: A function will return a value whereas a procedure will not.
        //Because procedures do not return a value they will usually have another side effect such as printing
        //or changing a value.

        //To differentiate between a function and a procedure, each subprogram must either be specified as "void" or
        //have an assigned data type to return such as "string"

        //getters are generally functions whereas setters are generally procedures
        //To test a function you can print the return value, but to test a procedure that doesn't already print something
        //you can print something to display that the currect side effect has occured.
    }


}

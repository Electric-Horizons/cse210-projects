using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
    }
}

//Primitive types
int i;
long l;
float f;
double d;
char c;
string s;
byte b;
bool b2;


//Variables
int myCount = 4;
string aName = "bob";
myCount = "bob"; //can't do this

//var
var anotherCount = 4;
anotherCount = 3.4; //can't do this already set as integer (not floating point)

//Printing Variables
Console.Write("What's your age?");

//ReadLine
var age = Console.ReadLine();
Console.Write
System.Console.WriteLine($"My age is {age}."); //(cw + tab) // $ let's the compiler know that you have embedded values
System.Console.WriteLine("My age is" + age + ".");

//Converting Variables
int age = int.Parse(ageString);

//Conditionals
if (age < 18)
{
    System.Console.WriteLine("You're a minor"); //contitional only applys to net line unless you do blocks (uses the curly brackets {})
    System.Console.WriteLine("Another string to print");
}
else
{
    System.Console.WriteLine("You are old");
}




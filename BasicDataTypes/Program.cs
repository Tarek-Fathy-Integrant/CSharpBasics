using System.Numerics;
Console.WriteLine("***** Fun with Basic Data Types *****");

//LocalVarDeclarations();
//DefaultDeclarations();
//NewingDataTypes();
//NewingDataTypesWith9();
//DataTypeFunctionality();

ParseFromStrings();

static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations:");

    int myInt = 0;

    string myString;
    myString = "This is my character data";

    bool b1 = true, b2 = false, b3 = b1;

    System.Boolean b4 = false;
    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
    myInt, myString, b1, b2, b3, b4);

    Console.WriteLine();
}

static void DefaultDeclarations()
{
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
    Console.WriteLine(myInt);
}

static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool(); // Set to false.
    int i = new int(); // Set to 0.
    double d = new double(); // Set to 0.
    DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

static void NewingDataTypesWith9()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new(); // Set to false.
    int i = new(); // Set to 0.
    double d = new(); // Set to 0.
    DateTime dt = new(); // Set to 1/1/0001 12:00:00 AM

    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

static void DataTypeFunctionality()
{
    Console.WriteLine("=> Data type Functionality:");
    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity: {0}",
    double.PositiveInfinity);
    Console.WriteLine("double.NegativeInfinity: {0}",
    double.NegativeInfinity);
    Console.WriteLine();
}

static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
}
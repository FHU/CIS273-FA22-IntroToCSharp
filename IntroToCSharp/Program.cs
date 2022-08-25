// See https://aka.ms/new-console-template for more information
using IntroToCSharp;

Console.WriteLine("Hello, World!");

string className = "CIS273";

Console.WriteLine(className);

string classNumber = className.Substring(3);

Console.WriteLine(classNumber);

int x = 42;
double d = 4.2345678;
bool b = true;

int[] intArray = new int[5];
intArray[0] = 2;
intArray[1] = 2;
intArray[2] = 4;
intArray[3] = 6;
intArray[4] = 8;

foreach(int num in intArray)
{
    Console.WriteLine(num);
}

int sum = 0;
for(int index=0; index < intArray.Length; index++)
{
    //Console.WriteLine(intArray[index]);
    sum += intArray[index];
}
double average = (double)sum / intArray.Length;

Console.WriteLine( $"average: {average}" );

for (int index = 0; index < intArray.Length; index++)
{
    intArray[index] = 2 * intArray[index];
}


Console.WriteLine("done");


string name = "Hi";
Methods.bar(name);
Console.WriteLine(name);


Animal dog = new Animal("Golden Retreiver", 4);
dog.Weight = 42.4;
//dog.Speed = 20.1;

dog.Move();
dog.Vocalize();

dog.NumberOfLegs = -9;
int n = dog.NumberOfLegs;

dog.NumberOfLegs = 8;
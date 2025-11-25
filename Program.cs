// Ask name
Console.Write("Enter Your Name: ");
string name = Console.ReadLine();

//Ask age 
Console.Write("Enter You Age: ");
int age = int.Parse(Console.ReadLine());

//Calculate the year you will turn 40
int currentYear = DateTime.Now.Year;
int yearAt40 = currentYear + (40 - age);

Console.WriteLine();
Console.WriteLine($"Hey {name}, you will turn 40 in the year {yearAt40}!");


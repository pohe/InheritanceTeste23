// See https://aka.ms/new-console-template for more information
using InheritanceTeste23;

Console.WriteLine("Hello, World!");


Employee e1 = new Employee(1, "Ole", "121212");

Teacher t1 = new Teacher(2, "Charlotte", "232323", "SWD");
Console.WriteLine("Teachers salary " + t1.CalculateSalary());

Console.WriteLine(t1.ToString());

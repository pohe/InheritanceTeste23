// See https://aka.ms/new-console-template for more information
using InheritanceTeste23;

Console.WriteLine("Hello, World!");


//Employee e1 = new Employee(1, "Ole", "121212");

Teacher t1 = new Teacher(2, "Charlotte", "232323", "SWD");
Console.WriteLine("Teachers salary " + t1.CalculateSalary());

Console.WriteLine(t1.ToString());

Employee e2 = new Secretary(3, "Kurt", "2323", "SU");
Employee e3 = new Teacher(4, "Susanne", "232323", "SWC");

Secretary s1 = new Secretary(5, "Frank", "343434", "International");
int salary = e3.CalculateSalary();

List<Employee> list = new List<Employee>();
//list.Add(e1);
list.Add(e2);
list.Add(e3);
list.Add(t1);


foreach(Employee e in list)
{
    Console.WriteLine($"Employe {e.Name} salary {e.CalculateSalary()} pension {e.CalculatePension()} type {e.GetType()} ");
}


IGeometryDraw geo = new Geometry();
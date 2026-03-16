using Domain;
using Domain.Models;
using Infrastructure;
using Infrastructure.Services;


EmployeeServices employeeServices = new();

Employee employee = new Employee()
{
    Firstname = "Jumaev",
    Lastname = "Shahrom",
    BirthDate = 19,
    Salary = 9999999,
};

Employee employee1 = new Employee()
{
    Firstname = "Jumaev",
    Lastname = "Akbar",
    BirthDate = 17,
    Salary = 9999990,
};

Employee employee2 = new Employee()
{
    Firstname = "Jumaev",
    Lastname = "Abdullo",
    BirthDate = 15,
    Salary = 9999900,
};



DepartmentServices departmentServices = new();

Department department = new Department()
{
  Name = "Shahrom",
  Description = "Programmer",  
};

Department departmen1 = new Department()
{
  Name = "Akbar",
  Description = "Bughalter",  
};

Department departmen2 = new Department()
{
  Name = "Abdullo",
  Description = "Doctor",  
};


departmentServices.AddDepartments(department);
departmentServices.AddDepartments(departmen1);
departmentServices.AddDepartments(departmen2);
Console.WriteLine(departmentServices.CountDepartments(department));
List<Department> departments = departmentServices.GetDepartments();
foreach (var obwiydepartment in departments)
{
    Console.WriteLine($"{obwiydepartment.Name}\t {obwiydepartment.Description}");
}


employeeServices.AddEmployee(employee);
employeeServices.AddEmployee(employee1);
employeeServices.AddEmployee(employee2);
Console.WriteLine(employeeServices.CountEmployees(employee));
List<Employee> employees = employeeServices.GetEmployees();
foreach (var obwiyemployee in employees)
{
    Console.WriteLine($"{obwiyemployee.Firstname}\t {obwiyemployee.Lastname}\t {obwiyemployee.BirthDate}\t {obwiyemployee.Salary}");
}
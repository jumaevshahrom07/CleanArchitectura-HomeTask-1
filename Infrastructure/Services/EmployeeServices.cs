using Domain.Models;
namespace Infrastructure.Services;

public class EmployeeServices
{
    private List<Employee> employees = new List<Employee>();

    public List<Employee> GetEmployees()
    {
        return employees;
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public int CountEmployees(Employee employee)
    {
        return employees.Count();
    }
}

using System.Data;
using labapi.Models;
using Microsoft.AspNetCore.Mvc;
namespace labapi.Controllers;
[ApiController]
[Route("[controller]/[action]")]
public class EmployeeController:ControllerBase 
{
[HttpGet( Name= "GetAllEmployee")]
public List<Employee> GetEmployees()
{
    var employees =new List<Employee>();
    employees.Add(new Employee{ Id =1 , Name ="Mohammad"});
    return employees;
}
[HttpPost (Name = "AddEmployee")]
public string AddEmployee()
{
    return "Employee Added";
}
[HttpPost(Name = "Employee Created")]
public string createEmployee(){
    Employee employee =new Employee();
    employee.Name = "husni developer";
    return employee.Name;
}
[HttpPut(Name = "Employee Updated")]
public void Update(Employee employee){
        Employee newemployee =new Employee();
        string Name ="ahmad";
        string Title = "developer";
    Name = newemployee.Name;
    Title = newemployee.Title;
    // return newemployee.Title;
    

}
[HttpPatch(Name ="Employee Deleted")]
public int Delete(){
    int id = 9;
    return id;

}
[HttpGet(Name = "Employee Readed")]
public string Read(){
Employee newemployeedata =new Employee();
newemployeedata.Name = "messi";
newemployeedata.Title = "number one ";
return newemployeedata.Title;
        
}
}
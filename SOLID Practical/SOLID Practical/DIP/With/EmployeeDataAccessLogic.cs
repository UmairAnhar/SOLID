using SOLID_Practical.DIP.Without;

namespace SOLID_Practical.DIP.With;

public sealed class EmployeeDataAccessLogic : IEmployeeDataAccessLogic
{
    public Employee GetEmployeeDetails(int id)
    {
        //In real time get the employee details from database
        //but here we have hard coded the employee details
        Employee emp = new Employee()
        {
            ID = id,
            Name = "Umair",
            Department = "IT",
            Salary = 10000
        };
        return emp;
    }
}

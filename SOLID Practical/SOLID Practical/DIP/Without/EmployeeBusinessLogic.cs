namespace SOLID_Practical.DIP.Without;

public sealed class EmployeeBusinessLogic
{
    EmployeeDataAccessLogic _EmployeeDataAccessLogic;
    public EmployeeBusinessLogic()
    {
        _EmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
    }
    public Employee GetEmployeeDetails(int id)
    {
        return _EmployeeDataAccessLogic.GetEmployeeDetails(id);
    }
}

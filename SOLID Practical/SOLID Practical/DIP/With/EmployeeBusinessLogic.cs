using SOLID_Practical.DIP.Without;

namespace SOLID_Practical.DIP.With;

public sealed class EmployeeBusinessLogic
{
    IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;
    public EmployeeBusinessLogic()
    {
        _IEmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
    }
    public Employee GetEmployeeDetails(int id)
    {
        return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
    }
}

namespace SOLID_Practical.DIP.Without;

public sealed class DataAccessFactory
{
    public static EmployeeDataAccessLogic GetEmployeeDataAccessObj()
    {
        return new EmployeeDataAccessLogic();
    }
}

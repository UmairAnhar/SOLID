namespace SOLID_Practical.DIP.With;

public sealed class DataAccessFactory
{
    public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
    {
        return new EmployeeDataAccessLogic();
    }
}

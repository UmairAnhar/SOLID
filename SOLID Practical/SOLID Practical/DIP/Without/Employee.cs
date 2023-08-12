namespace SOLID_Practical.DIP.Without;

public sealed class Employee
{
    public int ID { get; set; }
    public string Name { get; set; } = null!;
    public string Department { get; set; } = null!;
    public int Salary { get; set; }
}

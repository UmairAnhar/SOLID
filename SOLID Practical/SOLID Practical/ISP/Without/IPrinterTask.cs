namespace SOLID_Practical.ISP.Without;

public interface IPrinterTask
{
    void Print(string printContent);
    void Scan(string scanContent);
    void Fax(string faxContent);
    void PrintDuplex(string printDuplexContent);
}

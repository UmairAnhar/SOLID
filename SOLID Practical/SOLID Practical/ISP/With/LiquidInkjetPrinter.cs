namespace SOLID_Practical.ISP.With;

public sealed class LiquidInkjetPrinter : IPrinterTask
{
    public void Print(string PrintContent)
    {
        Console.WriteLine("Print Done");
    }
    public void Scan(string ScanContent)
    {
        Console.WriteLine("Scan content");
    }
}

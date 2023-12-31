﻿namespace SOLID_Practical.ISP.With;

public sealed class HPLaserJetPrinter : IPrinterTask, IFaxTask, IPrintDuplexTask
{
    public void Print(string PrintContent)
    {
        Console.WriteLine("Print Done");
    }
    public void Scan(string ScanContent)
    {
        Console.WriteLine("Scan content");
    }
    public void Fax(string FaxContent)
    {
        Console.WriteLine("Fax content");
    }
    public void PrintDuplex(string PrintDuplexContent)
    {
        Console.WriteLine("Print Duplex content");
    }
}

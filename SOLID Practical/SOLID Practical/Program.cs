using WithLSP = SOLID_Practical.LSP.With;
using WithoutLSP = SOLID_Practical.LSP.Without;
using SOLID_Practical.OCP.With;
using SOLID_Practical.ISP.With;
using SOLID_Practical.DIP.Without;

#region OCP

#region WITH

Console.WriteLine("Invoice Amount: 10000");
Invoice FInvoice = new FinalInvoice();
double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
Console.WriteLine($"Final Invoive : {FInvoiceAmount}");
Invoice PInvoice = new ProposedInvoice();
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
Console.WriteLine($"Proposed Invoive : {PInvoiceAmount}");
Invoice RInvoice = new RecurringInvoice();
double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
Console.WriteLine($"Recurring Invoive : {RInvoiceAmount}");
Console.ReadKey();

#endregion

#endregion

#region LSP

#region WITHOUT

WithoutLSP.Apple apple = new WithoutLSP.Orange();
Console.WriteLine(apple.GetColor());
Console.ReadKey();

#endregion

#region WITH

WithLSP.IFruit fruit = new WithLSP.Orange();
Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
fruit = new WithLSP.Apple();
Console.WriteLine($"Color of Apple: {fruit.GetColor()}");

#endregion

#endregion


#region ISP

#region WITH

//Using HPLaserJetPrinter we can access all Printer Services
HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
hPLaserJetPrinter.Print("Printing");
hPLaserJetPrinter.Scan("Scanning");
hPLaserJetPrinter.Fax("Faxing");
hPLaserJetPrinter.PrintDuplex("PrintDuplex");
//Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
liquidInkjetPrinter.Print("Printing");
liquidInkjetPrinter.Scan("Scanning");
Console.ReadKey();

#endregion

#endregion

#region DIP

#region WITH

EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
Console.ReadKey();

#endregion

#endregion
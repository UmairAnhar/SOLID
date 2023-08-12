namespace SOLID_Practical.OCP.With;

public class Invoice
{
    public virtual double GetInvoiceDiscount(double amount)
    {
        return amount;
    }
}
public class FinalInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return amount - 50;
    }
}
public class ProposedInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return amount - 40;
    }
}
public class RecurringInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return amount - 30;
    }
}
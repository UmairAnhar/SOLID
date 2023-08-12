using System.Net.Mail;

namespace SOLID_Practical.SRP.With;

public sealed class Invoice
{
    public long Amount { get; set; }
    public DateTimeOffset Date { get; set; }

    private ILogger fileLogger;
    private MailSender emailSender;
    public Invoice()
    {
        fileLogger = new Logger();
        emailSender = new MailSender();
    }
    public void AddInvoice()
    {
        try
        {
            fileLogger.Info("Add method Start");
            // Here we need to write the Code for adding invoice
            // Once the Invoice has been added, then send the  mail
            emailSender.From = "emailfrom@xyz.com";
            emailSender.To = "emailto@xyz.com";
            emailSender.Subject = "Single Responsibility Princile";
            emailSender.Body = "A class should have only one reason to change";
            emailSender.SendEmail();
        }
        catch (Exception ex)
        {
            fileLogger.Error("Error Occurred while Generating Invoice", ex);
        }
    }
    public void DeleteInvoice()
    {
        try
        {
            //Here we need to write the Code for Deleting the already generated invoice
            fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
        }
        catch (Exception ex)
        {
            fileLogger.Error("Error Occurred while Deleting Invoice", ex);
        }
    }
}

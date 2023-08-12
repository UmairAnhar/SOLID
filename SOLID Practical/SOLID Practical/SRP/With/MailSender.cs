namespace SOLID_Practical.SRP.With;

public sealed class MailSender
{
    public string From { get; set; } = null!;
    public string To { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string Body { get; set; } = null!;

    public void SendEmail()
    {
        // Here we need to write the Code for sending the mail
    }
}

using System;

abstract class Notification
{
    protected string message;

    public Notification(string msg)
    {
        message = msg;
    }

    // Abstract method (no body)
    public abstract void Send();

    public void Preview()
    {
        Console.WriteLine($"Preview: {message}");
    }
}

class EmailNotification : Notification
{
    private string emailAddress;

    public EmailNotification(string msg, string email) : base(msg)
    {
        emailAddress = email;
    }

    public override void Send()
    {
        Console.WriteLine($"[Email] Sending to {emailAddress}: {message}");
    }
}

class SMSNotification : Notification
{
    private string phoneNumber;

    public SMSNotification(string msg, string phone) : base(msg)
    {
        phoneNumber = phone;
    }

    public override void Send()
    {
        Console.WriteLine($"[SMS] Sending to {phoneNumber}: {message}");
    }
}

class PushNotification : Notification
{
    private string deviceId;

    public PushNotification(string msg, string device) : base(msg)
    {
        deviceId = device;
    }

    public override void Send()
    {
        Console.WriteLine($"[Push] Sending to device {deviceId}: {message}");
    }
}

class Program
{
    static void Main()
    {

        Notification email = new EmailNotification("Hello via Email!", "user@test.com");
        Notification sms = new SMSNotification("Hello via SMS!", "07666664567");
        Notification push = new PushNotification("Hello via Push!", "Tecno-");

        email.Preview();
        email.Send();

        sms.Preview();
        sms.Send();

        push.Preview();
        push.Send();
    }
}
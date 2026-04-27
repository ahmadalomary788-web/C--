using System;

// Base class
class Payment
{
    // Virtual method (to be overridden)
    public virtual void ProcessPayment()
    {
        Console.WriteLine("Processing generic payment...");
    }

    // Overloading methods (flexibility)
    public void Pay(double amount)
    {
        Console.WriteLine("Paid: " + amount);
    }

    public void Pay(double amount, string currency)
    {
        Console.WriteLine("Paid: " + amount + " " + currency);
    }
}

// Cash payment
class Cash : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Processing cash payment...");
    }
}

// Credit Card payment
class CreditCard : Payment
{
    private string cardNumber;
    private int sec_number;

    // Constructor with CVV
    public CreditCard(string cardNumber, int sec_number)
    {
        cardNumber = cardNumber;
         sec_number = sec_number;
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment...");
        Console.WriteLine("Card: **** **** **** " );
        Console.WriteLine("Security Code verified");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Polymorphism (Overriding)
        Payment p1 = new Cash();
        Payment p2 = new CreditCard("1234567812345678", 123);

        p1.ProcessPayment();
        p2.ProcessPayment();

        Console.WriteLine("----------------");

        // Overloading
        p1.Pay(100);
        p2.Pay(200, "USD");
    }
}
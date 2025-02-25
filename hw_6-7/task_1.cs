class CreditCard
{
    private string card_number;
    private string owner_name;
    private int cvc;
    private DateTime expiry_date;
    private decimal balance;

    public string CardNumber
    {
        get { return card_number; }
        set
        {
            if (value.Length != 16)
                throw new ArgumentException("Invalid card number");
            card_number = value;
        }
    }

    public string OwnerName { get; set; }

    public int CVC
    {
        get { return cvc; }
        set
        {
            if (value < 100 || value > 999)
                throw new ArgumentException("Invalid CVC");
            cvc = value;
        }
    }

    public DateTime ExpiryDate
    {
        get { return expiry_date; }
        set
        {
            if (value <= DateTime.Now)
                throw new ArgumentException("Card expired");
            expiry_date = value;
        }
    }

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative");
            balance = value;
        }
    }

    public CreditCard(string cardNumber, string ownerName, int cvc, DateTime expiryDate, decimal balance)
    {
        CardNumber = cardNumber;
        OwnerName = ownerName;
        CVC = cvc;
        ExpiryDate = expiryDate;
        Balance = balance;
    }

    public static CreditCard operator +(CreditCard card, decimal amount)
    {
        return new CreditCard(card.CardNumber, card.OwnerName, card.CVC, card.ExpiryDate, card.Balance + amount);
    }

    public static CreditCard operator -(CreditCard card, decimal amount)
    {
        if (card.Balance < amount)
            throw new InvalidOperationException("No money");
        return new CreditCard(card.CardNumber, card.OwnerName, card.CVC, card.ExpiryDate, card.Balance - amount);
    }

    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        return card1.CVC == card2.CVC;
    }

    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return !(card1.CardNumber == card2.CardNumber);
    }

    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.Balance < card2.Balance;
    }

    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.Balance > card2.Balance;
    }
}

class Program
{
    static void Main()
    {

        CreditCard card1 = new CreditCard("1234567890123456", "Max Kos", 123, new DateTime(2026, 12, 31), 500);
        CreditCard card2 = new CreditCard("0987654321098765", "Andrew Kos", 456, new DateTime(2027, 11, 30), 1000);

        Console.WriteLine($"Card1 Balance: {card1.Balance}");
        Console.WriteLine($"Card2 Balance: {card2.Balance}");

        card1.Balance += 200m;
        Console.WriteLine($"Card1 Balance after deposit: {card1.Balance}");

        card2.Balance -= 500m;
        Console.WriteLine($"Card2 Balance after withdrawal: {card2.Balance}");

        Console.WriteLine($"Card1 == Card2: {card1 == card2}");
        Console.WriteLine($"Card1 > Card2: {card1 > card2}");

    }
}
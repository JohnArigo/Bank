public class saving : account
{
    int counter = 1;

    public saving(string first, string last, decimal balances)
    {
        balance = balances;
        firstName = first;
        lastName = last;
    }

    public string AccountOwner()
    {
        return firstName + " " + lastName;
    }

    public string Withdraw(decimal money)
    {
        if (balance > money)
        {
            Console.WriteLine(counter);
            if (counter < 3)
            {
                decimal savingPull = money + 2;
                balance = balance - savingPull;
                counter++;
                return balance.ToString();
            }
            else
            {
                return "Can't withdraw more than 3 times";
            }
        }

        return "Cant withdraw more than balance";
    }

    public decimal Deposit(decimal money)
    {
        balance = balance + money;
        return balance;
    }

    public decimal ApplyInterest()
    {
        decimal interestRate = 0.02M;
        balance = (decimal.Multiply(balance, interestRate)) + balance;
        return balance;
    }
}

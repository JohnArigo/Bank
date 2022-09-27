public class checking : account
{
    public checking(string first, string last, decimal balances)
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
        int counter = 0;

        if (balance < money)
        {
            counter++;
            decimal savingPull = money + 35;
            balance = balance - savingPull;
            return balance.ToString();
        }
        else
        {
            balance = balance - money;
            return balance.ToString();
        }
    }

    public string Deposit(decimal money)
    {
        balance = balance + money;
        return balance.ToString();
    }
}

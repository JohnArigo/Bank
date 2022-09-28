// See https://aka.ms/new-console-template for more information
namespace defining
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make a checking and savings account");
            Console.WriteLine("First Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Checking Balance?");
            string checkBalance = Console.ReadLine();
            decimal cBalance = Decimal.Parse(checkBalance);
            Console.WriteLine("Savings Balance?");
            string saveBalance = Console.ReadLine();
            decimal sBalance = Decimal.Parse(saveBalance);

            checking c1 = new checking($"{firstName}", $"{lastName}", cBalance);
            saving s1 = new saving($"{firstName}", $"{lastName}", sBalance);

            c1.Withdraw(1000.0M);
            Console.WriteLine(c1.balance);
            c1.Withdraw(1000.0M);
            Console.WriteLine(c1.balance);
            c1.Withdraw(1000.0M);
            Console.WriteLine(c1.balance);
            c1.Withdraw(1000.0M);
            Console.WriteLine(c1.balance);
            c1.Withdraw(1000.0M);
            Console.WriteLine(c1.balance);
            Console.WriteLine(s1);
            s1.Withdraw(80.0M);
            s1.Withdraw(80.0M);
            s1.Withdraw(80.0M);
            s1.Withdraw(80.0M);
            Console.WriteLine(s1.balance);
        }
    }
}

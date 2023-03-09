namespace SimpleBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount Bob = new BankAccount("Bob", 1000, false);
            Console.WriteLine(Bob.ToString());
            Console.WriteLine(Bob.Balance);
            Bob.Deposit(300);
            Console.WriteLine(Bob.Balance);
            Bob.Withdraw(200);
            Console.WriteLine(Bob.Balance);
            Console.WriteLine(Bob.ToString());
        }
    }
}
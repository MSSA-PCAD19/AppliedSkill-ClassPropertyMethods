namespace Banking {
    public class Program
    {
        public static void Main()
        {
            // TODO Task 1.2 create an instance of BankAccount class here
            // var account = ...
            var account = new BankAccount()
            {
                AccountNumber = "123-456",
                Balance = 1000.50m
            };
            // END OF TODO Task 1.2 - DO NOT MODIFY PAST THIS LINE
            Console.WriteLine($"Account {account.AccountNumber} Balance: {account.Balance:C}");
        }
    }
}

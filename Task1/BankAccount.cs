// TODO Task 1.1 Compose your BankAccount class code in this file
namespace Banking;

public class BankAccount
{
    //Create two properties named AccountNumber and Balance. The AccountNumber property must store strings in the format of "123-456". The Balance property must be of type decimal.

    private string? accountNumber;
    public required string AccountNumber
    {
        get=> accountNumber?? string.Empty;
        set
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d{3}-\d{3}$"))
            {
                throw new System.ArgumentException("Account number must be in the format '123-456'.");
            }
            accountNumber = value;
        }
    }
    public decimal Balance { get; set; }    

}
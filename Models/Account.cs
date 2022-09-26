namespace Banking.Models;

public class Account {

    public int AccountNo {get; set; }
    public string Description {get; set; } = string.Empty;
    public decimal Balance {get; set; }

    public bool Deposit(decimal amount) {
        //add read of the account using the AccountNo
        
        //Add the deposit amount passed through to the account balance
        Balance += amount;
        return true;
    }
    public bool Withdrawal(decimal amount) {
        if(Balance < amount) {
            System.Console.WriteLine("Insufficient funds");
        }
        Balance -= amount;
        return true;
    }

    public bool Transfer(decimal amount, Account ToAccount) {
            bool success = Withdrawal(amount);
            if(success) { 
            success = ToAccount.Deposit(amount);
            }
            return success;

    }
}

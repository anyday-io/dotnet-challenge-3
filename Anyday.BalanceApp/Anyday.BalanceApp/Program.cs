using Anyday.BalanceApp.Models;

//Add user transactions to a list
List<Transaction> transactions = new List<Transaction>();
const bool exit = false;

while (!exit)
{
	Console.WriteLine("Welcome to the Anyday Finance System"); // Ensure all type of user inputs can execute, without any error. User can type number, alphabet, special character or anything.
	Console.WriteLine("1. Add Income");
	Console.WriteLine("2. Add Expense");
	Console.WriteLine("3. View Transactions");
	Console.WriteLine("4. View Balance");
	Console.WriteLine("5. Exit");
	Console.Write("Select an option: ");

	switch (Console.ReadLine())
	{
		case "1":
			Console.Write("Enter income amount: "); // Add Transaction, with type TransactionType.Income
			Console.WriteLine("Income added successfully!");
			break;

		case "2":
			Console.Write("Enter expense amount: "); // Add Transaction, with type TransactionType.Expense
			Console.WriteLine("Expense added successfully!");
			break;

		case "3":
			Console.WriteLine("Transactions:");
			//Show paginated transactions (5 per page)
			break;

		case "4":
			//Implement Calculate Balance logic.
			//Console.WriteLine("Your current balance is:"+ balance);
			break;

		default:
			Console.WriteLine("Invalid option. Please try again.");
			break;
	}

	Console.WriteLine();
}

decimal CalculateBalance(List<Transaction> transactions)
{
	//Get all Income type - Get all Expense type
	throw new NotImplementedException();
}

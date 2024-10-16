namespace Anyday.BalanceApp.Models
{
	public class Transaction
	{
		public decimal Amount { get; set; }
		public TransactionType Type { get; set; }
		public DateTime Date { get; set; }
	}

	public enum TransactionType
	{
		Income,
		Expense
	}
}

namespace  FinanceApp.Models
{
    public class Transaction : BaseEntity
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Category { get; set; }
        public string Type { get; set; } // e.g., Income, Expense
 

    }
    
}
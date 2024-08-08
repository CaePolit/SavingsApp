namespace SavingsApp.Models
{
    public class SavingAccount
    {
        public Guid Id { get; set; }
        public string AccountName { get; set; } = string.Empty;

        public double firstDepot { get; set; }

        public double InterestRate { get; set; }
    }
}

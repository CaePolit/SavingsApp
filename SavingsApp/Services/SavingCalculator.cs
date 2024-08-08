using SavingsApp.Models;

namespace SavingsApp.Services
{
    public class SavingCalculator
    {
        public List<SavingAccount> Accounts { get; set; }
        public Person Person { get; set; }

        public SavingCalculator(Person person)
        {
            Person = person;
            Accounts = person.SavingAccounts.ToList();
        }

    }
}

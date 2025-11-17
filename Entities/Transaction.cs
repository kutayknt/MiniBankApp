using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankApp.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public BankAccount BankAccount { get; set; }
        public int BankAccountId { get; set; }
        public BankAccount? FromAccount { get; set; } 
        public int? FromAccountId { get; set; }
        public BankAccount? ToAccount { get; set; } 
        public int? ToAccountId { get; set; }
        public TransactionType TransactionType { get; set; }
    }
    public enum TransactionType
    {
        Deposit,
        Withdraw,
        Transfer
    }
}

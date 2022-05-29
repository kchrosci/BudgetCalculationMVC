using System;
using System.Collections.Generic;

namespace BudgetCalculation.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Date { get; set; } = null!;
        public int TransactionType { get; set; }
        public int CategoryId { get; set; }
        public string Amount { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
    }
}

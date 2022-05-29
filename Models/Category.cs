using System;
using System.Collections.Generic;

namespace BudgetCalculation.Models
{
    public partial class Category
    {
        public Category()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

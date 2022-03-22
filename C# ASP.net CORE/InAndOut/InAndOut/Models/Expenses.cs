﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Amount must be greater than 0")]
        public double Amount { get; set; }

        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }
       
        [DisplayName("Expense Type")]

        public int ExpenseTypeId { get; set; }

        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }

    }
}

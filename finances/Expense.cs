using System.ComponentModel.DataAnnotations;

namespace finances

{
    public class Expense
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(20)] public string? Category { get; set; }

        [MaxLength(100)] public string? Description { get; set; }
    }
}
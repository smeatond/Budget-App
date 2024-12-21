using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Abstractions;

namespace DS.BA.Common.Models.Database.Entities;

[Table("Income")]
public class IncomeEntity : BaseEntity
{
    public string? Name { get; set; }

    public string? Notes { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [ForeignKey("BudgetEntity")]
    public Guid BudgetId { get; set; }

    // Navigation property
    public required BudgetEntity Budget { get; set; }

}
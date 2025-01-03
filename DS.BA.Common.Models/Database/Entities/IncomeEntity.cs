using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Abstractions;

namespace DS.BA.Common.Models.Database.Entities;

/// <summary>
///     Represents the income entity
/// </summary>
[Table("Incomes")]
public class IncomeEntity : BaseEntity
{
    /// <summary>
    ///     Name of the income
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     The amount of incomes
    /// </summary>
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    /// <summary>
    ///     Related budgets
    /// </summary>
    public ICollection<BudgetEntity> Budgets { get; set; } = [];

    /// <summary>
    ///     Connected family
    /// </summary>
    [Required]
    public Guid FamilyId { get; set; }

    /// <summary>
    ///     The connected family entity
    /// </summary>
    [ForeignKey("FamilyId")]
    public FamilyEntity Family {get;set;}

}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Abstractions;

namespace DS.BA.Common.Models.Database.Entities;

[Table("Expenditures")]
public class ExpenditureEntity : BaseEntity
{
    /// <summary>
    ///     The name of the expenditure
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     The amount of the expenditure
    /// </summary>
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    /// <summary>
    ///     Related budgets
    /// </summary>
    public ICollection<BudgetEntity> Budgets { get; set; } = [];

    /// <summary>
    ///  Related Expenditure Types
    /// </summary>
    public ICollection<ExpenditureTypesEntity> ExpenditureTypes { get; set; } = [];

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
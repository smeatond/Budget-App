using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Abstractions;

namespace DS.BA.Common.Models.Database.Entities;

[Table("Budgets")]
public class BudgetEntity : BaseEntity
{
    /// <summary>
    ///     The name of the budget
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     The related incomes
    /// </summary>
    public ICollection<IncomeEntity> Incomes { get; set; } = [];

    /// <summary>
    ///     The related expenditures
    /// </summary>
    public ICollection<ExpenditureEntity> Expenditures { get; set; } = [];

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
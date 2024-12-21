using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Abstractions;

namespace DS.BA.Common.Models.Database.Entities;

[Table("Budget")]
public class BudgetEntity : BaseEntity
{
    public string? Name { get; set; }

    public ICollection<IncomeEntity> Incomes { get; set; } = [];
}
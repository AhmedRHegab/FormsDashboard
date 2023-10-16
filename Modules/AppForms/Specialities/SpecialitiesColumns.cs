using Serenity.ComponentModel;
using System.ComponentModel;

namespace AppForms.AppForms.Columns;

[ColumnsScript("AppForms.Specialities")]
[BasedOnRow(typeof(SpecialitiesRow), CheckNames = true)]
public class SpecialitiesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
}
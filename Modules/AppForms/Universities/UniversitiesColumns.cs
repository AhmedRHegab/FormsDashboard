using Serenity.ComponentModel;
using System.ComponentModel;

namespace AppForms.AppForms.Columns;

[ColumnsScript("AppForms.Universities")]
[BasedOnRow(typeof(UniversitiesRow), CheckNames = true)]
public class UniversitiesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
}
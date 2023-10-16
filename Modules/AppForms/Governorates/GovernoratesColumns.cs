using Serenity.ComponentModel;
using System.ComponentModel;

namespace AppForms.AppForms.Columns;

[ColumnsScript("AppForms.Governorates")]
[BasedOnRow(typeof(GovernoratesRow), CheckNames = true)]
public class GovernoratesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
}
using Serenity.ComponentModel;
using System.ComponentModel;

namespace AppForms.AppForms.Columns;

[ColumnsScript("AppForms.Faculties")]
[BasedOnRow(typeof(FacultiesRow), CheckNames = true)]
public class FacultiesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
}
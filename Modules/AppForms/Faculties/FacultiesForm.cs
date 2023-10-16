using Serenity.ComponentModel;

namespace AppForms.AppForms.Forms;

[FormScript("AppForms.Faculties")]
[BasedOnRow(typeof(FacultiesRow), CheckNames = true)]
public class FacultiesForm
{
    public string Name { get; set; }
}
using Serenity.ComponentModel;

namespace AppForms.AppForms.Forms;

[FormScript("AppForms.Universities")]
[BasedOnRow(typeof(UniversitiesRow), CheckNames = true)]
public class UniversitiesForm
{
    public string Name { get; set; }
}
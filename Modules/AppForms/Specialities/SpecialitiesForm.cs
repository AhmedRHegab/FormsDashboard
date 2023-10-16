using Serenity.ComponentModel;

namespace AppForms.AppForms.Forms;

[FormScript("AppForms.Specialities")]
[BasedOnRow(typeof(SpecialitiesRow), CheckNames = true)]
public class SpecialitiesForm
{
    public string Name { get; set; }
}
using Serenity.ComponentModel;

namespace AppForms.AppForms.Forms;

[FormScript("AppForms.Governorates")]
[BasedOnRow(typeof(GovernoratesRow), CheckNames = true)]
public class GovernoratesForm
{
    public string Name { get; set; }
}
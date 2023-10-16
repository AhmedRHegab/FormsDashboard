using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AppForms.AppForms.Pages;

[PageAuthorize(typeof(GovernoratesRow))]
public class GovernoratesPage : Controller
{
    [Route("AppForms/Governorates")]
    public ActionResult Index()
    {
        return this.GridPage("@/AppForms/Governorates/GovernoratesPage",
            GovernoratesRow.Fields.PageTitle());
    }
}
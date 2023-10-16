using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AppForms.AppForms.Pages;

[PageAuthorize(typeof(UniversitiesRow))]
public class UniversitiesPage : Controller
{
    [Route("AppForms/Universities")]
    public ActionResult Index()
    {
        return this.GridPage("@/AppForms/Universities/UniversitiesPage",
            UniversitiesRow.Fields.PageTitle());
    }
}
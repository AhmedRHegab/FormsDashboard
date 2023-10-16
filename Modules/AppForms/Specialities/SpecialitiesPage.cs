using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AppForms.AppForms.Pages;

[PageAuthorize(typeof(SpecialitiesRow))]
public class SpecialitiesPage : Controller
{
    [Route("AppForms/Specialities")]
    public ActionResult Index()
    {
        return this.GridPage("@/AppForms/Specialities/SpecialitiesPage",
            SpecialitiesRow.Fields.PageTitle());
    }
}
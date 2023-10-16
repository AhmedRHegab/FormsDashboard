using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AppForms.AppForms.Pages;

[PageAuthorize(typeof(FacultiesRow))]
public class FacultiesPage : Controller
{
    [Route("AppForms/Faculties")]
    public ActionResult Index()
    {
        return this.GridPage("@/AppForms/Faculties/FacultiesPage",
            FacultiesRow.Fields.PageTitle());
    }
}
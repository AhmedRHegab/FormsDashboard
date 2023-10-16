using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AppForms.AppForms.Pages;

[PageAuthorize(typeof(ApplicantsFromsRow))]
public class ApplicantsFromsPage : Controller
{
    [Route("AppForms/ApplicantsFroms")]
    public ActionResult Index()
    {
        return this.GridPage("@/AppForms/ApplicantsFroms/ApplicantsFromsPage",
            ApplicantsFromsRow.Fields.PageTitle());
    }
}
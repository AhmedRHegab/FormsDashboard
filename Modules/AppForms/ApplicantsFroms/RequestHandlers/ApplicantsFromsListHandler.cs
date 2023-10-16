using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AppForms.AppForms.ApplicantsFromsRow>;
using MyRow = AppForms.AppForms.ApplicantsFromsRow;

namespace AppForms.AppForms;

public interface IApplicantsFromsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ApplicantsFromsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IApplicantsFromsListHandler
{
    public ApplicantsFromsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
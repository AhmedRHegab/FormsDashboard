using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AppForms.AppForms.ApplicantsFromsRow;

namespace AppForms.AppForms;

public interface IApplicantsFromsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ApplicantsFromsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IApplicantsFromsDeleteHandler
{
    public ApplicantsFromsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
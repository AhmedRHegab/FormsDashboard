using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AppForms.AppForms.ApplicantsFromsRow>;
using MyRow = AppForms.AppForms.ApplicantsFromsRow;

namespace AppForms.AppForms;

public interface IApplicantsFromsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ApplicantsFromsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IApplicantsFromsRetrieveHandler
{
    public ApplicantsFromsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AppForms.AppForms.ApplicantsFromsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AppForms.AppForms.ApplicantsFromsRow;

namespace AppForms.AppForms;

public interface IApplicantsFromsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ApplicantsFromsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IApplicantsFromsSaveHandler
{
    public ApplicantsFromsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
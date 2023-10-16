using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AppForms.AppForms.GovernoratesRow>;
using MyRow = AppForms.AppForms.GovernoratesRow;

namespace AppForms.AppForms;

public interface IGovernoratesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class GovernoratesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGovernoratesRetrieveHandler
{
    public GovernoratesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
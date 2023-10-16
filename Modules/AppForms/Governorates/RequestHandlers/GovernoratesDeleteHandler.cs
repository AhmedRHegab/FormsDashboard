using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AppForms.AppForms.GovernoratesRow;

namespace AppForms.AppForms;

public interface IGovernoratesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class GovernoratesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGovernoratesDeleteHandler
{
    public GovernoratesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AppForms.AppForms.GovernoratesRow>;
using MyRow = AppForms.AppForms.GovernoratesRow;

namespace AppForms.AppForms;

public interface IGovernoratesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class GovernoratesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGovernoratesListHandler
{
    public GovernoratesListHandler(IRequestContext context)
            : base(context)
    {
    }
}
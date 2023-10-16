using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AppForms.AppForms.GovernoratesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AppForms.AppForms.GovernoratesRow;

namespace AppForms.AppForms;

public interface IGovernoratesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class GovernoratesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGovernoratesSaveHandler
{
    public GovernoratesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AppForms.AppForms.SpecialitiesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AppForms.AppForms.SpecialitiesRow;

namespace AppForms.AppForms;

public interface ISpecialitiesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class SpecialitiesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISpecialitiesSaveHandler
{
    public SpecialitiesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
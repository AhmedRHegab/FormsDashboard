using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AppForms.AppForms.UniversitiesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AppForms.AppForms.UniversitiesRow;

namespace AppForms.AppForms;

public interface IUniversitiesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class UniversitiesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUniversitiesSaveHandler
{
    public UniversitiesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
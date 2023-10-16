using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AppForms.AppForms.FacultiesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AppForms.AppForms.FacultiesRow;

namespace AppForms.AppForms;

public interface IFacultiesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class FacultiesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IFacultiesSaveHandler
{
    public FacultiesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
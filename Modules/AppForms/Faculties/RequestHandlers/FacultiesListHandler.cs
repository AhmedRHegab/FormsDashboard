using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AppForms.AppForms.FacultiesRow>;
using MyRow = AppForms.AppForms.FacultiesRow;

namespace AppForms.AppForms;

public interface IFacultiesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class FacultiesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IFacultiesListHandler
{
    public FacultiesListHandler(IRequestContext context)
            : base(context)
    {
    }
}
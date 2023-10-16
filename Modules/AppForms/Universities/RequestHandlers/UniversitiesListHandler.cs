using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AppForms.AppForms.UniversitiesRow>;
using MyRow = AppForms.AppForms.UniversitiesRow;

namespace AppForms.AppForms;

public interface IUniversitiesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class UniversitiesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUniversitiesListHandler
{
    public UniversitiesListHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AppForms.AppForms.SpecialitiesRow>;
using MyRow = AppForms.AppForms.SpecialitiesRow;

namespace AppForms.AppForms;

public interface ISpecialitiesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class SpecialitiesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISpecialitiesListHandler
{
    public SpecialitiesListHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AppForms.AppForms.SpecialitiesRow>;
using MyRow = AppForms.AppForms.SpecialitiesRow;

namespace AppForms.AppForms;

public interface ISpecialitiesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class SpecialitiesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISpecialitiesRetrieveHandler
{
    public SpecialitiesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
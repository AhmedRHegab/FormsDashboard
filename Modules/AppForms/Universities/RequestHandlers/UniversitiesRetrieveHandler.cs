using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AppForms.AppForms.UniversitiesRow>;
using MyRow = AppForms.AppForms.UniversitiesRow;

namespace AppForms.AppForms;

public interface IUniversitiesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class UniversitiesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUniversitiesRetrieveHandler
{
    public UniversitiesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AppForms.AppForms.FacultiesRow>;
using MyRow = AppForms.AppForms.FacultiesRow;

namespace AppForms.AppForms;

public interface IFacultiesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class FacultiesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IFacultiesRetrieveHandler
{
    public FacultiesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AppForms.AppForms.FacultiesRow;

namespace AppForms.AppForms;

public interface IFacultiesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class FacultiesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IFacultiesDeleteHandler
{
    public FacultiesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
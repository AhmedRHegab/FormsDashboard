using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AppForms.AppForms.UniversitiesRow;

namespace AppForms.AppForms;

public interface IUniversitiesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class UniversitiesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUniversitiesDeleteHandler
{
    public UniversitiesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AppForms.AppForms.SpecialitiesRow;

namespace AppForms.AppForms;

public interface ISpecialitiesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class SpecialitiesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISpecialitiesDeleteHandler
{
    public SpecialitiesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = AppForms.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<AppForms.Administration.UserRow>;
using MyRow = AppForms.Administration.UserRow;

namespace AppForms.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
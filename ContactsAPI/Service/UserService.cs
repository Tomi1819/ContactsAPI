using ContactsAPI.IService;

namespace ContactsAPI.Service
{
    public class UserService : IUserService
    {
        public bool ChechUser(string username, string password)
        {
            return username.Equals("abc") && password.Equals("123");
        }
    }
}

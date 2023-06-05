using CustomerCareWebApp.Models;

namespace CustomerCareWebApp.BAL
{
    public class ACCOUNTRepository : IAccountrepository
    {
        public UserViewModel GetUser(LoginViewModel loginViewModel)
        {
            var UserViewModel = new UserViewModel();
            return UserViewModel;
        }
    }
}

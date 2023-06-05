using CustomerCareWebApp.Models;

namespace CustomerCareWebApp.BAL
{
    public interface IAccountrepository
    {
        UserViewModel GetUser(LoginViewModel loginViewModel);
    }
}

using BookServiceWEBAPI.Entities;

namespace BookServiceWEBAPI.Service
{
    public interface IUserService
    {
        void CreateUser(User user);
        List<User> GetAllUsers();

        User GetUser(int userId);
        void EditUser(User user);
        void DeleteUser(int userId);
        User ValidteUser(string email, string password);
    }
}

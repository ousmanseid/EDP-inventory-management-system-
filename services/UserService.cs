using System.Linq;
using InventorySystem.Models;
using InventorySystem.Storage;

namespace InventorySystem.Services
{
    public class UserService
    {
        // Simple login validation
        public User Login(string username, string password)
        {
            return MemoryStorage.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public List<User> GetAllUsers()
        {
            return MemoryStorage.Users;
        }

        public void AddUser(User user)
        {
            MemoryStorage.Users.Add(user);
        }

        public void DeleteUser(string userId)
        {
            var user = MemoryStorage.Users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                MemoryStorage.Users.Remove(user);
            }
        }
    }
}

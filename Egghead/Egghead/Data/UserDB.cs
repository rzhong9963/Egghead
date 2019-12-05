using Egghead.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

// General format taken from Microsoft Documentaion on Local SQLite Databases

namespace Egghead.Data
{
    public class UserDB
    {
        readonly SQLiteAsyncConnection db;

        // Get local database location
        public UserDB(string path)
        {
            db = new SQLiteAsyncConnection(path);
            db.CreateTableAsync<User>().Wait();
        }

        // Get list of all users
        public Task<List<User>> GetUsersAsync()
        {
            return db.Table<User>().ToListAsync();
        }

        // Get user based on primary key
        public Task<User> GetUserAsync(int id)
        {
            return db.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        // Get user based on email
        public Task<User> GetUserAsync(string email)
        {
            return db.Table<User>().Where(i => i.Email == email).FirstOrDefaultAsync();
        }

        // Get user based on email and password
        public Task<User> GetUserAsync(string email, string password)
        {
            return db.Table<User>().Where(i => i.Email == email && i.Password == password).FirstOrDefaultAsync();
        }

        // Save user info if any changes
        public Task<int> SaveUserAsync(User u)
        {
            if (u.ID != 0)
            {
                return db.UpdateAsync(u);
            }
            else
            {
                return db.InsertAsync(u);
            }
        }

        // Delete user--currently not used anywhere
        public Task<int> DeleteUserAsync(User u)
        {
            return db.DeleteAsync(u);
        }
    }
}

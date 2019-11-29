using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Egghead.Models;

// General format taken from Microsoft Documentaion on Local SQLite Databases

namespace Egghead.Data
{
    public class UserDB
    {
        readonly SQLiteAsyncConnection db;

        public UserDB(string path)
        {
            db = new SQLiteAsyncConnection(path);
            db.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsersAsync()
        {
            return db.Table<User>().ToListAsync();
        }

        public Task<User> GetUserAsync(int id)
        {
            return db.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<User> GetUserAsync(string email)
        {
            return db.Table<User>().Where(i => i.Email == email).FirstOrDefaultAsync();
        }

        public Task<User> GetUserAsync(string email, string password)
        {
            return db.Table<User>().Where(i => i.Email == email && i.Password == password).FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User u)
        {
           if(u.ID != 0){
                return db.UpdateAsync(u);
           }
           else
           {
                return db.InsertAsync(u);
           }
        }

        public Task<int> DeleteUserAsync(User u)
        {
            return db.DeleteAsync(u);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Egghead.Models
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string School
        {
            get;
            set;
        }
    }
}

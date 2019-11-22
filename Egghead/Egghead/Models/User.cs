using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Egghead.Models
{
    public class User
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
        public string Role
        {
            get;
            set;
        }
        public string Bio
        {
            get;
            set;
        }
        public byte[] Pic
        {
            get;
            set;
        } = null;
        public string Name
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        // City, State, Phone, Interests, Matches/Connections, Messages, etc
    }
}

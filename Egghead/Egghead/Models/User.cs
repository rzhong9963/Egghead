using SQLite;

namespace Egghead.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        // Primary key for database
        public int ID
        {
            get;
            set;
        }

        // User email
        public string Email
        {
            get;
            set;
        }

        // User password
        public string Password
        {
            get;
            set;
        }

        // The following database options are not implemented and left blank

        // User's first name
        public string FirstName
        {
            get;
            set;
        }

        // User's last name
        public string LastName
        {
            get;
            set;
        }

        // User's school
        public string School
        {
            get;
            set;
        }

        // User's role
        public string Role
        {
            get;
            set;
        }

        // User's profile bio
        public string Bio
        {
            get;
            set;
        }

        // User's profile pic
        public byte[] Pic
        {
            get;
            set;
        } = null;

        // User's full name
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    /// <summary>
    /// Emulation data base users
    /// </summary>
    public class UsersDate
    {
       private  List<User> _Users = new List<User>();

        public List<User> Users
        {
            get
            {
                return _Users;
            }
        }

        public void AddUser(string FirstName, string LastName, string EmailAddres )
        {
            Users.Add( new User(FirstName, LastName, EmailAddres));
        }
        public void AddUser(User user)
        {
            Users.Add(user);
        }

    }

     
    public class User
    {
          public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddres { get; set; } 



        public User (string FirstName, string LastName, string EmailAddres)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddres = EmailAddres;
        }


        public User( )
        { 
        }


        public override string ToString()
        {
            return FirstName + " " + LastName + " " + EmailAddres;
        }

        // other
        // ...
        //

    }
}
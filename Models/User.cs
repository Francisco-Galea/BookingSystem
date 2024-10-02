using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class User
    {
        private int UserId;
        private string UserName;
        private string Email;

        public User(string userName, string email)
        {
            this.UserName = userName;
            this.Email = email;
        }

        public User()
        {
        }
        
        public int GetUserId()
        {
            return this.UserId; 
        }
        public void SetUserId(int userId)
        {
            this.UserId = userId;
        }

        public string GetUserName()
        {
            return this.UserName;
        }
        public void SetUserName(string userName)
        {
            this.UserName = userName;
        }

        public string GetEmail()
        {
            return this.Email;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }

    }
}

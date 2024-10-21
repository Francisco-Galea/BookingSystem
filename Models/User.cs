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

        public User(string USERNAME, string EMAIL)
        {
            this.UserName = USERNAME;
            this.Email = EMAIL;
        }

        public User()
        {
        }
        
        public int USERID
        {
            get { return UserId; }
            set { UserId = value; }
        }

        public string USERNAME
        {
            get { return UserName; }
            set 
            {
                if(string.IsNullOrEmpty(UserName))
                {
                    throw new ArgumentNullException("El valor no puede estar vacio");
                }
                UserName = value;
            }
        }

        public string EMAIL
        {
            get { return Email; }
            set
            {
                if (string.IsNullOrEmpty(Email))
                {
                    throw new ArgumentNullException("El valor no puede estar vacio");
                }
                Email = value;
            }
        }
        

    }
}

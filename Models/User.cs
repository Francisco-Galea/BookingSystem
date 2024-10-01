using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class User
    {  
        private int UserId { get; set; }
        private string UserName { get; set; }
        private string Email { get; set; }

        public User(string userName, string email)
        {
            this.UserName = userName;
            this.Email = email;
        }

    }
}

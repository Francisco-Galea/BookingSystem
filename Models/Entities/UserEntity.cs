namespace Booking.Models.Entities
{
    public class UserEntity
    {
        private int UserId;
        private string UserName;
        private string Email;

        public UserEntity(string USERNAME, string EMAIL)
        {
            UserName = USERNAME;
            Email = EMAIL;
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
                if (string.IsNullOrEmpty(UserName))
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

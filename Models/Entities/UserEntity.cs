namespace Booking.Models.Entities
{
    public class UserEntity
    {
        private int UserDni;
        private string UserName;
        private string LastName;
        private string Email;

        public UserEntity(string USERNAME, string EMAIL)
        {
            UserName = USERNAME;
            Email = EMAIL;
        }

    }
}

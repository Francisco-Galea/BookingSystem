namespace Booking.Models.Entities
{
    public class UserEntity
    {
        private int userDni;
        private string userName;
        private string lastName;
        private string email;
        private bool isAdmin;

        public UserEntity(string USERNAME, string EMAIL, string LASTNAME)
        {
            this.userName = USERNAME;
            this.lastName = LASTNAME;
            this.email = EMAIL;
        }

    }
}

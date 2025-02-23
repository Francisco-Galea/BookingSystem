
namespace Boocking.Models.Entities
{
    public class ClientEntity
    {
        private int clientDni;
        private string name;
        private string lastName;
        private string phoneNumber;
        private DateTime CreatedAt;
        private bool isDeleted;

        public ClientEntity(string NAME, string LASTNAME, string PHONENUMBER)
        {
            this.name = NAME;
            this.lastName = LASTNAME;
            this.phoneNumber = PHONENUMBER;
        }

        public string NAME
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string LASTNAME
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string PHONENUMBER
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

    }
}

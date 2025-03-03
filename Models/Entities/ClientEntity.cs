namespace Boocking.Models.Entities
{
    public class ClientEntity
    {
        private int clientId;
        private string name;
        private string lastName;
        private string phoneNumber;
        private DateTime createdAt;
        private bool isDeleted;


        #pragma warning disable CS8618 
        public ClientEntity()
        #pragma warning restore CS8618 
        {

        }

        public int CLIENTID
        {
            get { return this.clientId; }
            set { this.clientId = value; }
        }

        public string NAME
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                this.name = value.Trim();
            }
        }

        public string LASTNAME
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El apellido no puede estar vacío.");
                }
                this.lastName = value.Trim();
            }
        }

        public string PHONENUMBER
        {
            get { return this.phoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El número de teléfono no puede estar vacío.");
                }
                this.phoneNumber = value.Trim();
            }
        }

        public DateTime CREATEDAT
        {
            get { return this.createdAt; }
            set { this.createdAt = value; }
        }

        public override string ToString()
        {
            return $"{name} {lastName} - {phoneNumber}";
        }

    }
}

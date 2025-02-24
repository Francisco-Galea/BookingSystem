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


        public ClientEntity()
        {

        }

        public ClientEntity(string NAME, string LASTNAME, string PHONENUMBER)
        {
            this.name = NAME;
            this.lastName = LASTNAME;
            this.phoneNumber = PHONENUMBER;
        }

        public int CLIENTID
        {
            get { return clientId; }
            set { clientId = value; }
        }

        public string NAME
        {
            get { return this.name; }
            set
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("El nombre no puede estar vacío.");
                    }
                    this.name = value.Trim();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        public string LASTNAME
        {
            get { return this.lastName; }
            set
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("El apellido no puede estar vacío.");
                    }
                    this.lastName = value.Trim();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        public string PHONENUMBER
        {
            get { return this.phoneNumber; }
            set
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("El celular no puede estar vacío.");
                    }
                    this.phoneNumber = value.Trim();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        public DateTime CREATEDAT
        {
            get { return this.createdAt; }
            set { this.createdAt = value; }
        }

    }
}

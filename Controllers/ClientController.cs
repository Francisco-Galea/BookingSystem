using Boocking.Models.Entities;
using Booking.Models.Dao.ClientDao;

namespace Booking.Controllers
{
    public class ClientController
    {

        private readonly IClientDao clientDao = new ClientDaoSQLSERVER();

        public void CreateClient(string clientName, string lastName, string phoneNumber)
        {
            try
            {
                DateTime createdAt = DateTime.Now;
                ClientEntity client = new ClientEntity(clientName, lastName, phoneNumber);
                client.CREATEDAT = createdAt;
                clientDao.InsertEntity(client);
            }
            catch
            {

            }
        }

        public void UpdateClient(int clientId, string name, string lastName, string phoneNumber)
        {
            try
            {
                ClientEntity client = new ClientEntity(name, lastName, phoneNumber);
                clientDao.UpdateEntity(clientId, client);
            }
            catch
            {

            }
        }

        public void DeleteClient(int clientId)
        {
            clientDao.DeleteEntity(clientId);
        }

        public ClientEntity GetClient(int clientId)
        {
            return clientDao.GetEntityById(clientId);
        }

        public List<ClientEntity> GetClients()
        {
            return clientDao.GetAllEntities();
        }

    }
}

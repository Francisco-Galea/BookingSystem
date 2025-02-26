using Boocking.Models.Entities;
using Booking.Models.Dao.ClientDao;
using Microsoft.Data.SqlClient;

namespace Booking.Controllers
{
    public class ClientController
    {

        private readonly IClientDao clientDao = new ClientDaoSQLSERVER();

        #region Create Client
        public void CreateClient(string clientName, string lastName, string phoneNumber)
        {
            try
            {
                DateTime createdAt = DateTime.Now;
                ClientEntity client = new ClientEntity();
                client.NAME = clientName;
                client.LASTNAME = lastName;
                client.PHONENUMBER = phoneNumber;
                client.CREATEDAT = createdAt;
                clientDao.InsertEntity(client);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar el cliente.", ex);
            }
        }
        #endregion

        #region Update Client
        public void UpdateClient(int clientId, string name, string lastName, string phoneNumber)
        {
            try
            {
                ClientEntity client = new ClientEntity();
                client.NAME = name;
                client.LASTNAME = lastName;
                client.PHONENUMBER = phoneNumber;
                clientDao.UpdateEntity(clientId, client);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al actualizar el cliente: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar el cliente.", ex);
            }
        }
        #endregion

        #region Delete Client
        public void DeleteClient(int clientId, DialogResult result)
        {
            try
            {
                if(result == DialogResult.Yes)
                {
                    clientDao.DeleteEntity(clientId);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el cliente.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al eliminar el cliente.", ex);
            }
        }
        #endregion

        #region Get Client Methods
        public ClientEntity GetClient(int clientId)
        {
            try
            {
                return clientDao.GetEntityById(clientId);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener el cliente.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener el cliente.", ex);
            }
        }

        public List<ClientEntity> GetClients()
        {
            try
            {
                return clientDao.GetAllEntities();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener la lista de clientes.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener la lista de clientes.", ex);
            }
        }
        #endregion

    }
}

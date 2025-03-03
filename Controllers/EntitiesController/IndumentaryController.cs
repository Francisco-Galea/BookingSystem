using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Dao.IndumentaryDao;
using Booking.Utility;
using Microsoft.Data.SqlClient;

namespace Booking.Controllers.EntitiesController
{
    public class IndumentaryController
    {

        private readonly IIndumentaryFactory indumentaryFactory = new IndumentaryFactory();
        private readonly IIndumentaryDao indumentaryDao =new IndumentaryDaoSQLSERVER();

        public void CreateIndumentary(string indumentaryType, string description, string costUsage, string size, string genre)
        {
            try
            {
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);

                IndumentaryEntity indumentary = indumentaryFactory.CreateIndumentaryEntity();
                indumentary.NAME = indumentaryType;
                indumentary.DESCRIPTION = description;
                indumentary.COSTUSAGEPERDAY = parsedCostUsage;
                indumentary.SIZE = size;
                indumentary.GENRE = genre;
                indumentaryDao.InsertEntity(indumentary);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al crear la indumentaria: " + ex.Message);
            }
        }

        public List<IndumentaryEntity> GetAllIndumentaries()
        {
            return indumentaryDao.GetAllEntities();
        }

        public void DeleteIndumentary(int rentableId, DialogResult result)
        {
            try
            {
                if (result == DialogResult.Yes)
                {
                    indumentaryDao.DeleteEntity(rentableId);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar la indumentaria.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al eliminar la indumentaria.", ex);
            }
        }

        public void UpdateIndumentary(int rentableId, string indumentaryType, string description, string costUsage, string size, string genre)
        {
            try
            {
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);

                IndumentaryEntity indumentary = indumentaryFactory.CreateIndumentaryEntity();
                indumentary.NAME = indumentaryType;
                indumentary.DESCRIPTION = description;
                indumentary.COSTUSAGEPERDAY = parsedCostUsage;
                indumentary.SIZE = size;
                indumentary.GENRE = genre;
                indumentaryDao.UpdateEntity(rentableId, indumentary);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al modificar la indumentaria: " + ex.Message);
            }
        }

        public IndumentaryEntity GetIndumentaryById(int rentableId)
        {
            return indumentaryDao.GetEntityById(rentableId);
        }

    }
}

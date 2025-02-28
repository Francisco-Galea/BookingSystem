using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ElectronicDao;
using Booking.Models.Factory;
using Booking.Models.Factory.Interface;
using Booking.Utility;

namespace Booking.Controllers.EntitiesController
{
    public class ElectronicController
    {

        private readonly IElectronicFactory electronicFactory = new ElectronicFactory();
        private readonly IElectronicDao electronicDao = new ElectronicDao();

        public void CreateElectronic(string electronicType, string description, string costUsage, string brand, string model, string serialNumber)
        {
            try
            {
                ElectronicEntity electronic = electronicFactory.CreateElectronicEntity();
                electronic.NAME = electronicType;
                electronic.DESCRIPTION = description;
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);
                electronic.COSTUSAGEPERDAY = parsedCostUsage;
                electronic.BRAND = brand;
                electronic.MODEL = model;
                electronic.SERIALNUMBER = serialNumber;
                electronicDao.InsertEntity(electronic);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al crear un dispositivo electronico: " + ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrio un error al agregar un dispositivo electronico: " + e.Message);
            }
        }

        public List<ElectronicEntity> GetAllElectronics()
        {
            return electronicDao.GetAllEntities();
        }









    }
}

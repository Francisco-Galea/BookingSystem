using Boocking.Models.Entities.RentableEntities;

namespace Boocking.Models.Factory.Interfaces
{
    public interface IPropertyFactory
    {
        PropertyEntity CreatePropertyEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string LOCATION);
    }
}

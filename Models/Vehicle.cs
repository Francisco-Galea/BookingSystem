using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public abstract class Vehicle
    {

        private int VehicleId;
        private string Brand;
        private string Model;
        private decimal CostUsagePerHour;

        protected Vehicle(string BRAND, string MODEL, decimal COSTUSAGEPERHOUR)
        {
            this.Brand = BRAND;
            this.Model = MODEL;
            this.CostUsagePerHour = COSTUSAGEPERHOUR;
        }

        public int VEHICLEID
        {
            get { return VehicleId; }
            set { VehicleId = value; }
        }
        public string BRAND
        {
            get { return Brand; }
            set 
            {
                if (string.IsNullOrEmpty(Brand))
                {
                    throw new ArgumentNullException("El valor no puede ser vacio");
                }
                Brand = value; 
            }
        }

        public string MODEL
        {
            get { return Model; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("El valor no puede ser vacio");
                }
                Model = value; 
            }
        }

        public decimal COSTUSAGEPERHOUR
        {
            get { return CostUsagePerHour; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("No se permite ingresar valores menores a 0");                    
                }
                CostUsagePerHour = value;
            }
        }

    }
}

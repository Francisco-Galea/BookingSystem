using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public abstract class Vehicle
    {
       
        private int VehicleId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal CostUsagePerHour { get; set; }

        protected Vehicle(string brand, string model, decimal costUsagePerHour)
        {
            Brand = brand;
            Model = model;
            CostUsagePerHour = costUsagePerHour;
        }

    }
}

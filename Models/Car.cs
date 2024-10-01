using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class Car : Vehicle
    {
        public Car(string brand, string model, decimal costUsagePerHour) : base(brand, model, costUsagePerHour)
        {
        }
    }
}

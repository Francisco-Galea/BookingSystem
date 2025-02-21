using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models.Dao.GenericDaoInterface;

namespace Booking.Models.Dao.StrategyDao
{
    public interface IStrategyDao 
    {
        int GetPaymentStrategyId(string paymentMethod);

    }
}

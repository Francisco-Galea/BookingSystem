using Booking.Models.Dao.StrategyDao;
using Booking.Models.Strategy;
using Booking.Models.Strategy.Interface;

namespace Booking.Controllers
{
    public class PaymentStrategyController
    {

        private readonly IStrategyDao strategyDao = new StrategyDaoSQLSERVER();

        public IStrategyFinalPriceBooking GetPaymentData(string paymentType)
        {
            IStrategyFinalPriceBooking? strategySelected = null;
            switch (paymentType)
            {
                case "Efectivo":
                    strategySelected = new CashStrategy();
                    break;

                case "Transferencia":
                    strategySelected = new TransferStrategy();
                    break;

                case "Tarjeta de Crédito":
                    strategySelected = new CreditCardStrategy();
                    break;
            }

            return strategySelected;
        }

        

    }
}

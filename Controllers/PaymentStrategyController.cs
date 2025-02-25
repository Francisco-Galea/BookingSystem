using Booking.Models.Strategy;
using Booking.Models.Strategy.Interface;

namespace Booking.Controllers
{
    public class PaymentStrategyController
    {

        //A refactorizar y eliminar
        public IStrategyFinalPriceBooking GetPaymentData(string paymentType)
        {
            IStrategyFinalPriceBooking strategySelected = new CashStrategy();
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

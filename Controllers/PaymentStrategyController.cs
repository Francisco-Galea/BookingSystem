using Booking.Models.Strategy;
using Booking.Models.Strategy.Interface;

namespace Booking.Controllers
{
    public class PaymentStrategyController
    {

        private readonly List<IStrategyFinalPriceBooking> paymentMethods = new List<IStrategyFinalPriceBooking>();
        private static PaymentStrategyController paymentMethodsControllerInstance;

        private PaymentStrategyController() 
        {
            paymentMethods.Add(new CashStrategy());
            paymentMethods.Add(new TransferStrategy());
            paymentMethods.Add(new CreditCardStrategy());
        }

        public static PaymentStrategyController GetInstance()
        {
            if(paymentMethodsControllerInstance == null)
            {
                paymentMethodsControllerInstance = new PaymentStrategyController(); 
            }
            return paymentMethodsControllerInstance;
        }

        public List<IStrategyFinalPriceBooking> GetPaymentMethods()
        {
            return paymentMethods;
        }


    }
}

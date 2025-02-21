﻿using Booking.Models.Strategy;
using Booking.Models.Strategy.Interface;

namespace Booking.Controllers
{
    public class PaymentStrategyController
    {
        public IStrategyFinalPriceBooking GetPaymentData(string paymentType)
        {
            int paymentStrategyId = 0;
            IStrategyFinalPriceBooking strategySelected = null;
            switch (paymentType)
            {
                case "Efectivo":
                    strategySelected = new CashStrategy();
                    break;

                case "Transferencia":
                    strategySelected = new TransferStrategy();
                    break;

                case "Tarjeta de credito":
                    strategySelected = new CreditCardStrategy();
                    break;
            }

            return strategySelected;
        }

    }
}

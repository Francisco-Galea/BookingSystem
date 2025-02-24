using Boocking.Views;
using Boocking.Views.BookingsView;
using Boocking.Views.BookingsView.BookingsHistorialView;
using Boocking.Views.BookingsView.ToReserveView;

namespace Booking
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainView());
            //Application.Run(new RentablesView());
            //Application.Run(new BookingView());
            Application.Run(new BookingsHistoricalView());
        }
    }
}
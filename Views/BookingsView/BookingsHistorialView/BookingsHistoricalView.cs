using Booking.Views.BookingsView.UpdateBookingView;
using Booking.Controllers;
using Booking.Dtos.BookedEntities;

namespace Boocking.Views.BookingsView.BookingsHistorialView
{
    public partial class BookingsHistoricalView : Form
    {
        private readonly BookingController bookingController = new BookingController();

        public BookingsHistoricalView()
        {
            InitializeComponent();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                ClearDataGrid();
                GenerateVehiclesBookedColumns();
                List<BookingVehicleDTO> bookingVehicleDTO = new List<BookingVehicleDTO>();
                bookingVehicleDTO = bookingController.GetVehicleBookings();
                LoadVehiclesBookedData(bookingVehicleDTO);
            }
            catch
            { 
            
            }
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            try
            {
                ClearDataGrid();
                GeneratePropertiesBookedColumns();
                List<BookingPropertyDTO> bookingPropertiesDTO = new List<BookingPropertyDTO>();
                bookingPropertiesDTO = bookingController.GetPropertyBookings();
                LoadPropertiesBookedData(bookingPropertiesDTO);
            }
            catch
            {

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingId = (int)dgvEntities.SelectedRows[0].Cells["bookingId"].Value;
                UpdateBookingView updateBookingView = new UpdateBookingView(bookingId);
                updateBookingView.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingId = (int)dgvEntities.SelectedRows[0].Cells["bookingId"].Value;
                bookingController.DeleteBooking(bookingId);
            }
            catch
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void LoadVehiclesBookedData(List<BookingVehicleDTO> bookingVehicleDTOs)
        {
            try
            {
                foreach(BookingVehicleDTO vehicleBooked in  bookingVehicleDTOs)
                {
                    dgvEntities.Rows.Add(
                        vehicleBooked.rentableName,
                        vehicleBooked.brand,
                        vehicleBooked.model,
                        vehicleBooked.serialNumber,
                        vehicleBooked.initBooking,
                        vehicleBooked.endBooking,
                        $"{vehicleBooked.oClient.NAME} {vehicleBooked.oClient.LASTNAME}",
                        vehicleBooked.oClient.PHONENUMBER,
                        vehicleBooked.daysBooked,
                        vehicleBooked.totalPrice,
                        vehicleBooked.isPaid,
                        vehicleBooked.paymentMethod,
                        vehicleBooked.rentableId,
                        vehicleBooked.bookingId
                        );
                }
            }
            catch
            {

            }
        }

        private void LoadPropertiesBookedData(List<BookingPropertyDTO> bookingPropertiesDTOs)
        {
            try
            {
                foreach (BookingPropertyDTO propertyBooked in bookingPropertiesDTOs)
                {
                    dgvEntities.Rows.Add(
                        propertyBooked.bookingId,
                        propertyBooked.rentableName,
                        propertyBooked.rentableId,
                        propertyBooked.initBooking,
                        propertyBooked.endBooking,
                        propertyBooked.daysBooked,
                        propertyBooked.totalPrice,
                        propertyBooked.isPaid,
                        propertyBooked.paymentMethod,
                        propertyBooked.Location
                        );
                }
            }
            catch
            {

            }
        }

        private void ClearDataGrid()
        {
            ClearColumns();
            ClearRows();
        }

        private void ClearColumns()
        {
            dgvEntities.Columns.Clear();
        }

        private void ClearRows()
        {
            dgvEntities.Rows.Clear();
        }

        private void GenerateVehiclesBookedColumns()
        {
            dgvEntities.Columns.Add("rentableName", "Articulo");
            dgvEntities.Columns.Add("brand", "Marca");
            dgvEntities.Columns.Add("model", "Modelo");
            dgvEntities.Columns.Add("serialNumber", "Número de Serie");
            dgvEntities.Columns.Add("initBooking", "Inicio de reserva");
            dgvEntities.Columns.Add("endBooking", "Fin de reserva");
            dgvEntities.Columns.Add("client", "Cliente");
            dgvEntities.Columns.Add("clientPhoneNumber", "Celular");
            dgvEntities.Columns.Add("daysBooked", "Dias reservado");
            dgvEntities.Columns.Add("totalPrice", "Precio total");
            dgvEntities.Columns.Add("isPaid", "Pagado");
            dgvEntities.Columns.Add("paymentMethod", "Medio de pago");
            dgvEntities.Columns.Add("bookingId", "Id");
            dgvEntities.Columns.Add("rentableId", "Id Articulo");

        }

        private void GeneratePropertiesBookedColumns()
        {
            dgvEntities.Columns.Add("bookinId", "Id");
            dgvEntities.Columns.Add("rentableName", "Articulo");
            dgvEntities.Columns.Add("rentableId", "Id Articulo");
            dgvEntities.Columns.Add("initBooking", "Inicio de reserva");
            dgvEntities.Columns.Add("endBooking", "Fin de reserva");
            dgvEntities.Columns.Add("daysBooked", "Dias reservado");
            dgvEntities.Columns.Add("totalPrice", "Precio total");
            dgvEntities.Columns.Add("isPaid", "Pagado");
            dgvEntities.Columns.Add("paymentMethod", "Medio de pago");
            dgvEntities.Columns.Add("location", "Ubicacion");
        }

    }
}

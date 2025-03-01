using Booking.Views.BookingsView.UpdateBookingView;
using Booking.Controllers;
using Booking.Dtos.BookedEntities;

namespace Boocking.Views.BookingsView.BookingsHistorialView
{
    public partial class BookingsHistoricalView : Form
    {
        private readonly BookingController bookingController = new BookingController();
        private readonly BookingView bookingView;

        public BookingsHistoricalView(BookingView bookingView)
        {
            InitializeComponent();
            this.bookingView = bookingView;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingId = (int)dgvEntities.SelectedRows[0].Cells["bookingId"].Value;
                UpdateBookingView updateBookingView = new UpdateBookingView(bookingId);
                updateBookingView.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una reserva a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingId = (int)dgvEntities.SelectedRows[0].Cells["bookingId"].Value;
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta reserva?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                bookingController.DeleteBooking(bookingId, result);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una reserva a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingView.Show();
        }


        #region Utility Methods

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

        #endregion

        #region Vehicle Methods

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            GenerateVehiclesBookedColumns();
            List<BookingVehicleDTO> bookingVehicleDTO = new List<BookingVehicleDTO>();
            bookingVehicleDTO = bookingController.GetVehicleBookings();
            LoadVehiclesBookedData(bookingVehicleDTO);
        }

        private void GenerateVehiclesBookedColumns()
        {
            dgvEntities.Columns.Add("bookingId", "Id de reserva");
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
        }

        private void LoadVehiclesBookedData(List<BookingVehicleDTO> bookingVehicleDTOs)
        {
            foreach (BookingVehicleDTO vehicleBooked in bookingVehicleDTOs)
            {
                dgvEntities.Rows.Add
                    (
                    vehicleBooked.bookingId,
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
                    vehicleBooked.paymentMethod
                    );
            }
        }

        #endregion

        #region Property Methods

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            GeneratePropertiesBookedColumns();
            List<BookingPropertyDTO> bookingPropertiesDTO = new List<BookingPropertyDTO>();
            bookingPropertiesDTO = bookingController.GetPropertyBookings();
            LoadPropertiesBookedData(bookingPropertiesDTO);
        }

        private void GeneratePropertiesBookedColumns()
        {
            dgvEntities.Columns.Add("bookingId", "Id de reserva");
            dgvEntities.Columns.Add("rentableName", "Articulo");
            dgvEntities.Columns.Add("description", "Descripcion");
            dgvEntities.Columns.Add("initBooking", "Inicio de reserva");
            dgvEntities.Columns.Add("endBooking", "Fin de reserva");
            dgvEntities.Columns.Add("daysBooked", "Dias reservado");
            dgvEntities.Columns.Add("location", "Ubicacion");
            dgvEntities.Columns.Add("client", "Cliente");
            dgvEntities.Columns.Add("phoneNumber", "Celular");
            dgvEntities.Columns.Add("totalPrice", "Precio total");
            dgvEntities.Columns.Add("isPaid", "Pagado");
            dgvEntities.Columns.Add("paymentMethod", "Medio de pago");
        }

        private void LoadPropertiesBookedData(List<BookingPropertyDTO> bookingPropertiesDTOs)
        {
            foreach (BookingPropertyDTO propertyBooked in bookingPropertiesDTOs)
            {
                dgvEntities.Rows.Add
                    (
                    propertyBooked.bookingId,
                    propertyBooked.rentableName,
                    propertyBooked.description,
                    propertyBooked.initBooking,
                    propertyBooked.endBooking,
                    propertyBooked.daysBooked,
                    propertyBooked.Location,
                    $"{propertyBooked.oClient.NAME} {propertyBooked.oClient.LASTNAME}",
                    propertyBooked.oClient.PHONENUMBER,
                    propertyBooked.totalPrice,
                    propertyBooked.isPaid,
                    propertyBooked.paymentMethod
                    );
            }
        }

        #endregion

        #region Indumentary Methods

        private void btnIndumentary_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            GenerateIndumentariesBookedColumns();
            List<BookingIndumentaryDto> bookingIndumentaryDto = bookingController.GetIndumentaryBookings();
            LoadIndumentaryBookedData(bookingIndumentaryDto);
        }

        private void LoadIndumentaryBookedData(List<BookingIndumentaryDto> indumentaries)
        {
            foreach (BookingIndumentaryDto indumentaryBooked in indumentaries)
            {
                dgvEntities.Rows.Add
                    (
                    indumentaryBooked.bookingId,
                    indumentaryBooked.rentableName,
                    indumentaryBooked.description,
                    indumentaryBooked.size,
                    indumentaryBooked.genre,
                    indumentaryBooked.initBooking,
                    indumentaryBooked.endBooking,
                    $"{indumentaryBooked.oClient.NAME} {indumentaryBooked.oClient.LASTNAME}",
                    indumentaryBooked.oClient.PHONENUMBER,
                    indumentaryBooked.daysBooked,
                    indumentaryBooked.totalPrice,
                    indumentaryBooked.isPaid,
                    indumentaryBooked.paymentMethod
                    );

            }
        }

        private void GenerateIndumentariesBookedColumns()
        {
            dgvEntities.Columns.Add("bookingId", "Id reserva");
            dgvEntities.Columns.Add("rentableName", "Articulo");
            dgvEntities.Columns.Add("description", "Descripcion");
            dgvEntities.Columns.Add("size", "Talle");
            dgvEntities.Columns.Add("genre", "Genero");
            dgvEntities.Columns.Add("initBooking", "Inicio de reserva");
            dgvEntities.Columns.Add("endBooking", "Fin de reserva");
            dgvEntities.Columns.Add("client", "Cliente");
            dgvEntities.Columns.Add("clientPhoneNumber", "Celular");
            dgvEntities.Columns.Add("daysBooked", "Dias reservado");
            dgvEntities.Columns.Add("totalPrice", "Precio total");
            dgvEntities.Columns.Add("isPaid", "Pagado");
            dgvEntities.Columns.Add("paymentMethod", "Medio de pago");
        }

        #endregion

        #region Electronic Methods

        private void btnElectronics_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            GenerateElectronicsBookedColumns();
            List<BookingElectronicDto> bookingElectronicDto = bookingController.GetElectronicBookings();
            LoadElectronicBookedData(bookingElectronicDto);
        }

        private void GenerateElectronicsBookedColumns()
        {
            dgvEntities.Columns.Add("bookingId", "Id");
            dgvEntities.Columns.Add("rentableName", "Dispositivo");
            dgvEntities.Columns.Add("initBooking", "Inicio de reserva");
            dgvEntities.Columns.Add("endBooking", "Fin de reserva");
            dgvEntities.Columns.Add("daysBooked", "Dias reservado");
            dgvEntities.Columns.Add("brand", "Marca");
            dgvEntities.Columns.Add("model", "Modelo");
            dgvEntities.Columns.Add("serialNumber", "Número de serie");
            dgvEntities.Columns.Add("client", "Cliente");
            dgvEntities.Columns.Add("phoneNumber", "Celular");
            dgvEntities.Columns.Add("totalPrice", "Precio final");
            dgvEntities.Columns.Add("isPaid", "Pagado");
            dgvEntities.Columns.Add("paymentMethod", "Medio de pago");
        }

        private void LoadElectronicBookedData(List<BookingElectronicDto> bookingElectronicDto)
        {
            foreach (BookingElectronicDto electronic in bookingElectronicDto)
            {
                dgvEntities.Rows.Add
                (
                    electronic.rentableId,
                    electronic.rentableName,
                    electronic.initBooking,
                    electronic.endBooking,
                    electronic.daysBooked,
                    electronic.brand,
                    electronic.model,
                    electronic.serialNumber,
                    $"{electronic.oClient.NAME} {electronic.oClient.LASTNAME}",
                    electronic.oClient.PHONENUMBER,
                    electronic.totalPrice,
                    electronic.isPaid,
                    electronic.paymentMethod
                );
            }
        }

        #endregion

    }
}

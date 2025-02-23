﻿
using System.Diagnostics;
using Booking.Controllers;
using Booking.Dtos;

namespace Boocking.Views.BookingsView.BookingsHistorialView
{
    public partial class BookingsHistoricalView : Form
    {

        private readonly string? entityTypeSelected;
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
                        vehicleBooked.bookingId,
                        vehicleBooked.rentableName,
                        vehicleBooked.rentableId,
                        vehicleBooked.initBooking,
                        vehicleBooked.endBooking,
                        vehicleBooked.daysBooked,
                        vehicleBooked.totalPrice,
                        vehicleBooked.isPaid,
                        vehicleBooked.paymentMethod,
                        vehicleBooked.brand,
                        vehicleBooked.model,
                        vehicleBooked.serialNumber
                        );
                }
            }
            catch
            {

            }
        }

        private void LoadPropertiesBookedData(List<BookingPropertyDTO> bookingPropertiesDTOs)
        {

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
            dgvEntities.Columns.Add("bookinId", "Id");
            dgvEntities.Columns.Add("rentableName", "Articulo");
            dgvEntities.Columns.Add("rentableId", "Id Articulo");
            dgvEntities.Columns.Add("initBooking", "Inicio de reserva");
            dgvEntities.Columns.Add("endBooking", "Fin de reserva");
            dgvEntities.Columns.Add("daysBooked", "Dias reservado");
            dgvEntities.Columns.Add("totalPrice", "Precio total");
            dgvEntities.Columns.Add("isPaid", "Pagado");
            dgvEntities.Columns.Add("paymentMethod", "Medio de pago");
            dgvEntities.Columns.Add("Brand", "Marca");
            dgvEntities.Columns.Add("Model", "Modelo");
            dgvEntities.Columns.Add("SerialNumber", "Número de Serie");
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

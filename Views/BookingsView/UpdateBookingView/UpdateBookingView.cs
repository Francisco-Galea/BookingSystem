﻿using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Booking.Controllers;
using Booking.Dtos.CoreDataBooking;

namespace Booking.Views.BookingsView.UpdateBookingView
{
    public partial class UpdateBookingView : Form
    {

        private readonly int bookingEntityId;
        private readonly BookingController bookingController = new BookingController();
        private readonly VehicleController vehicleController = new VehicleController();

        public UpdateBookingView(int bookingId)
        {
            InitializeComponent();
            this.bookingEntityId = bookingId;
            GetOldBookingData(bookingEntityId);
        }

        private void GetOldBookingData(int bookingEntityId)
        {
            try
            {
                BookingCoreDataDto bookingData = new BookingCoreDataDto();
                bookingData = bookingController.GetBookingCoreData(bookingEntityId);
                LoadOldBookingData(bookingData);
            }
            catch
            {

            }
        }

        private void LoadOldBookingData(BookingCoreDataDto bookingData)
        {
            try
            {
                dtpInitBooking.Value = bookingData.initBooking;
                dtpEndBooking.Value = bookingData.endBooking;
                txtOldPaymentMethod.Text = bookingData.paymentMethod;
                checkBoxOldIsPaid.Checked = bookingData.isPaid;
            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                ClearDataGrid();
                CreateVehicleDataGridColumns();
                List<VehicleEntity> vehicles = vehicleController.GetAllVehicles();
                LoadVehiclesData(vehicles);
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadVehiclesData(List<VehicleEntity> vehicles)
        {
            try
            {
                foreach (VehicleEntity vehicle in vehicles)
                {
                    dgvEntities.Rows.Add(
                        vehicle.VEHICLEID,
                        vehicle.NAME,
                        vehicle.DESCRIPTION,
                        vehicle.COSTUSAGEPERDAY,
                        vehicle.BRAND,
                        vehicle.MODEL,
                        vehicle.SERIALNUMBER,
                        vehicle.PASSENGERCAPACITY
                        );
                }
            }
            catch
            {

            }
        }

        private void CreateVehicleDataGridColumns()
        {
            dgvEntities.Columns.Add("id", "Id");
            dgvEntities.Columns.Add("Name", "Nombre");
            dgvEntities.Columns.Add("Description", "Descripción");
            dgvEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvEntities.Columns.Add("Brand", "Marca");
            dgvEntities.Columns.Add("Model", "Modelo");
            dgvEntities.Columns.Add("SerialNumber", "Número de Serie");
            dgvEntities.Columns.Add("PassengerCapacity", "Capacidad de Pasajeros");
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

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            dgvEntities.ClearSelection();
        }
    }
}

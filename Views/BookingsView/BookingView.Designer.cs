namespace Boocking.Views.BookingsView
{
    partial class BookingView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnToReserve = new Button();
            btnBack = new Button();
            btnMyBookings = new Button();
            btnVehicles = new Button();
            btnIndumentaries = new Button();
            btnProperties = new Button();
            btnElectronics = new Button();
            dgvEntities = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar por";
            // 
            // btnToReserve
            // 
            btnToReserve.Location = new Point(575, 199);
            btnToReserve.Name = "btnToReserve";
            btnToReserve.Size = new Size(124, 29);
            btnToReserve.TabIndex = 4;
            btnToReserve.Text = "Reservar";
            btnToReserve.UseVisualStyleBackColor = true;
            btnToReserve.Click += btnToReserve_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(575, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(124, 29);
            btnBack.TabIndex = 21;
            btnBack.Text = "Volver";
            btnBack.Click += btnBack_Click;
            // 
            // btnMyBookings
            // 
            btnMyBookings.Location = new Point(575, 234);
            btnMyBookings.Name = "btnMyBookings";
            btnMyBookings.Size = new Size(124, 29);
            btnMyBookings.TabIndex = 8;
            btnMyBookings.Text = "Mis reservas";
            btnMyBookings.UseVisualStyleBackColor = true;
            btnMyBookings.Click += btnMyBookings_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Location = new Point(12, 32);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(106, 29);
            btnVehicles.TabIndex = 15;
            btnVehicles.Text = "Vehiculos";
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnIndumentaries
            // 
            btnIndumentaries.Location = new Point(124, 31);
            btnIndumentaries.Name = "btnIndumentaries";
            btnIndumentaries.Size = new Size(106, 29);
            btnIndumentaries.TabIndex = 16;
            btnIndumentaries.Text = "Indumentaria";
            btnIndumentaries.UseVisualStyleBackColor = true;
            btnIndumentaries.Click += btnIndumentaries_Click;
            // 
            // btnProperties
            // 
            btnProperties.Location = new Point(236, 31);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(106, 29);
            btnProperties.TabIndex = 17;
            btnProperties.Text = "Propiedades";
            btnProperties.UseVisualStyleBackColor = true;
            btnProperties.Click += btnProperties_Click;
            // 
            // btnElectronics
            // 
            btnElectronics.Location = new Point(348, 31);
            btnElectronics.Name = "btnElectronics";
            btnElectronics.Size = new Size(106, 29);
            btnElectronics.TabIndex = 18;
            btnElectronics.Text = "Electronica";
            btnElectronics.UseVisualStyleBackColor = true;
            btnElectronics.Click += btnElectronics_Click;
            // 
            // dgvEntities
            // 
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Location = new Point(12, 66);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowHeadersWidth = 51;
            dgvEntities.Size = new Size(557, 372);
            dgvEntities.TabIndex = 2;
            // 
            // BookingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 445);
            Controls.Add(btnElectronics);
            Controls.Add(btnProperties);
            Controls.Add(btnIndumentaries);
            Controls.Add(btnVehicles);
            Controls.Add(btnMyBookings);
            Controls.Add(btnBack);
            Controls.Add(btnToReserve);
            Controls.Add(dgvEntities);
            Controls.Add(label1);
            Name = "BookingView";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)dgvEntities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnToReserve;
        private Button btnBack;
        private Button btnMyBookings;
        private Button btnVehicles;
        private Button btnIndumentaries;
        private Button btnProperties;
        private Button btnElectronics;
        private DataGridView dgvEntities;
    }
}
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
            button1 = new Button();
            dgvEntities = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Buscar por";
            // 
            // btnToReserve
            // 
            btnToReserve.Location = new Point(719, 249);
            btnToReserve.Margin = new Padding(4, 4, 4, 4);
            btnToReserve.Name = "btnToReserve";
            btnToReserve.Size = new Size(155, 36);
            btnToReserve.TabIndex = 4;
            btnToReserve.Text = "Reservar";
            btnToReserve.UseVisualStyleBackColor = true;
            btnToReserve.Click += btnToReserve_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(719, 511);
            btnBack.Margin = new Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 36);
            btnBack.TabIndex = 21;
            btnBack.Text = "Volver";
            btnBack.Click += btnBack_Click;
            // 
            // btnMyBookings
            // 
            btnMyBookings.Location = new Point(719, 292);
            btnMyBookings.Margin = new Padding(4, 4, 4, 4);
            btnMyBookings.Name = "btnMyBookings";
            btnMyBookings.Size = new Size(155, 36);
            btnMyBookings.TabIndex = 8;
            btnMyBookings.Text = "Mis reservas";
            btnMyBookings.UseVisualStyleBackColor = true;
            btnMyBookings.Click += btnMyBookings_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Location = new Point(15, 40);
            btnVehicles.Margin = new Padding(4, 4, 4, 4);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(132, 36);
            btnVehicles.TabIndex = 15;
            btnVehicles.Text = "Vehiculos";
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnIndumentaries
            // 
            btnIndumentaries.Location = new Point(155, 39);
            btnIndumentaries.Margin = new Padding(4, 4, 4, 4);
            btnIndumentaries.Name = "btnIndumentaries";
            btnIndumentaries.Size = new Size(132, 36);
            btnIndumentaries.TabIndex = 16;
            btnIndumentaries.Text = "Indumentaria";
            btnIndumentaries.UseVisualStyleBackColor = true;
            btnIndumentaries.Click += btnIndumentaries_Click;
            // 
            // btnProperties
            // 
            btnProperties.Location = new Point(295, 39);
            btnProperties.Margin = new Padding(4, 4, 4, 4);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(132, 36);
            btnProperties.TabIndex = 17;
            btnProperties.Text = "Propiedades";
            btnProperties.UseVisualStyleBackColor = true;
            btnProperties.Click += btnProperties_Click;
            // 
            // button1
            // 
            button1.Location = new Point(435, 39);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(132, 36);
            button1.TabIndex = 18;
            button1.Text = "Electronica";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvEntities
            // 
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Location = new Point(15, 82);
            dgvEntities.Margin = new Padding(4, 4, 4, 4);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowHeadersWidth = 51;
            dgvEntities.Size = new Size(696, 465);
            dgvEntities.TabIndex = 2;
            // 
            // BookingView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 556);
            Controls.Add(button1);
            Controls.Add(btnProperties);
            Controls.Add(btnIndumentaries);
            Controls.Add(btnVehicles);
            Controls.Add(btnMyBookings);
            Controls.Add(btnBack);
            Controls.Add(btnToReserve);
            Controls.Add(dgvEntities);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
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
        private Button button1;
        private DataGridView dgvEntities;
    }
}
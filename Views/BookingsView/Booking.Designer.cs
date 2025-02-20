namespace Boocking.Views.BookingsView
{
    partial class Booking
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
            cbOptions = new ComboBox();
            dgvEntities = new DataGridView();
            btnSearch = new Button();
            btnToReserve = new Button();
            btnBack = new Button();
            btnMyBookings = new Button();
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
            // cbOptions
            // 
            cbOptions.FormattingEnabled = true;
            cbOptions.Items.AddRange(new object[] { "Vehiculo", "Propiedad", "Indumentaria", "Electronica" });
            cbOptions.Location = new Point(12, 32);
            cbOptions.Name = "cbOptions";
            cbOptions.Size = new Size(292, 28);
            cbOptions.TabIndex = 1;
            // 
            // dgvEntities
            // 
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Location = new Point(12, 66);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowHeadersWidth = 51;
            dgvEntities.Size = new Size(565, 372);
            dgvEntities.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(310, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(181, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnToReserve
            // 
            btnToReserve.Location = new Point(583, 223);
            btnToReserve.Name = "btnToReserve";
            btnToReserve.Size = new Size(124, 29);
            btnToReserve.TabIndex = 4;
            btnToReserve.Text = "Reservar";
            btnToReserve.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(805, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnMyBookings
            // 
            btnMyBookings.Location = new Point(583, 409);
            btnMyBookings.Name = "btnMyBookings";
            btnMyBookings.Size = new Size(124, 29);
            btnMyBookings.TabIndex = 8;
            btnMyBookings.Text = "Mis reservas";
            btnMyBookings.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 450);
            Controls.Add(btnMyBookings);
            Controls.Add(btnBack);
            Controls.Add(btnToReserve);
            Controls.Add(btnSearch);
            Controls.Add(dgvEntities);
            Controls.Add(cbOptions);
            Controls.Add(label1);
            Name = "Booking";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)dgvEntities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbOptions;
        private DataGridView dgvEntities;
        private Button btnSearch;
        private Button btnToReserve;
        private Button btnBack;
        private Button btnMyBookings;
    }
}
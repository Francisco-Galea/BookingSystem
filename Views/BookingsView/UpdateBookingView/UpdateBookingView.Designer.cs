namespace Booking.Views.BookingsView.UpdateBookingView
{
    partial class UpdateBookingView
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
            dgvEntities = new DataGridView();
            btnVehicles = new Button();
            btnProperties = new Button();
            btnIndumentary = new Button();
            btnElectronic = new Button();
            dtpInitBooking = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpEndBooking = new DateTimePicker();
            label4 = new Label();
            checkBoxOldIsPaid = new CheckBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            label5 = new Label();
            dtpNewInitBooking = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpNewEndBooking = new DateTimePicker();
            cbNewPaymentMethod = new ComboBox();
            label9 = new Label();
            checkBoxNewIsPaid = new CheckBox();
            txtOldPaymentMethod = new TextBox();
            label8 = new Label();
            btnUnselect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            SuspendLayout();
            // 
            // dgvEntities
            // 
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Location = new Point(445, 71);
            dgvEntities.Margin = new Padding(2);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowHeadersWidth = 62;
            dgvEntities.Size = new Size(668, 557);
            dgvEntities.TabIndex = 0;
            // 
            // btnVehicles
            // 
            btnVehicles.Location = new Point(673, 40);
            btnVehicles.Margin = new Padding(2);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(110, 27);
            btnVehicles.TabIndex = 1;
            btnVehicles.Text = "Vehiculos";
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnProperties
            // 
            btnProperties.Location = new Point(445, 40);
            btnProperties.Margin = new Padding(2);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(110, 27);
            btnProperties.TabIndex = 2;
            btnProperties.Text = "Propiedades";
            btnProperties.UseVisualStyleBackColor = true;
            // 
            // btnIndumentary
            // 
            btnIndumentary.Location = new Point(559, 40);
            btnIndumentary.Margin = new Padding(2);
            btnIndumentary.Name = "btnIndumentary";
            btnIndumentary.Size = new Size(110, 27);
            btnIndumentary.TabIndex = 3;
            btnIndumentary.Text = "Indumentaria";
            btnIndumentary.UseVisualStyleBackColor = true;
            // 
            // btnElectronic
            // 
            btnElectronic.Location = new Point(787, 40);
            btnElectronic.Margin = new Padding(2);
            btnElectronic.Name = "btnElectronic";
            btnElectronic.Size = new Size(110, 27);
            btnElectronic.TabIndex = 4;
            btnElectronic.Text = "Electronica";
            btnElectronic.UseVisualStyleBackColor = true;
            // 
            // dtpInitBooking
            // 
            dtpInitBooking.Enabled = false;
            dtpInitBooking.Location = new Point(11, 61);
            dtpInitBooking.Margin = new Padding(2);
            dtpInitBooking.Name = "dtpInitBooking";
            dtpInitBooking.Size = new Size(280, 27);
            dtpInitBooking.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 7;
            label1.Text = "Datos de la vieja reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 38);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 8;
            label2.Text = "Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 9;
            label3.Text = "Fin";
            // 
            // dtpEndBooking
            // 
            dtpEndBooking.Enabled = false;
            dtpEndBooking.Location = new Point(11, 110);
            dtpEndBooking.Margin = new Padding(2);
            dtpEndBooking.Name = "dtpEndBooking";
            dtpEndBooking.Size = new Size(280, 27);
            dtpEndBooking.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 137);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 12;
            label4.Text = "Medio de pago";
            // 
            // checkBoxOldIsPaid
            // 
            checkBoxOldIsPaid.AutoSize = true;
            checkBoxOldIsPaid.Enabled = false;
            checkBoxOldIsPaid.Location = new Point(14, 191);
            checkBoxOldIsPaid.Margin = new Padding(2);
            checkBoxOldIsPaid.Name = "checkBoxOldIsPaid";
            checkBoxOldIsPaid.Size = new Size(97, 24);
            checkBoxOldIsPaid.TabIndex = 14;
            checkBoxOldIsPaid.Text = "Está pago";
            checkBoxOldIsPaid.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 632);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 27);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1018, 633);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 285);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 19;
            label5.Text = "Nuevos datos";
            // 
            // dtpNewInitBooking
            // 
            dtpNewInitBooking.Location = new Point(14, 328);
            dtpNewInitBooking.Name = "dtpNewInitBooking";
            dtpNewInitBooking.Size = new Size(279, 27);
            dtpNewInitBooking.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 305);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 21;
            label6.Text = "Inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 358);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 22;
            label7.Text = "Fin";
            // 
            // dtpNewEndBooking
            // 
            dtpNewEndBooking.Location = new Point(14, 381);
            dtpNewEndBooking.Name = "dtpNewEndBooking";
            dtpNewEndBooking.Size = new Size(279, 27);
            dtpNewEndBooking.TabIndex = 23;
            // 
            // cbNewPaymentMethod
            // 
            cbNewPaymentMethod.FormattingEnabled = true;
            cbNewPaymentMethod.Items.AddRange(new object[] { "Tarjeta de Crédito", "Transferencia", "Efectivo" });
            cbNewPaymentMethod.Location = new Point(14, 434);
            cbNewPaymentMethod.Name = "cbNewPaymentMethod";
            cbNewPaymentMethod.Size = new Size(279, 28);
            cbNewPaymentMethod.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 411);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 27;
            label9.Text = "Medio de pago";
            // 
            // checkBoxNewIsPaid
            // 
            checkBoxNewIsPaid.AutoSize = true;
            checkBoxNewIsPaid.Location = new Point(14, 468);
            checkBoxNewIsPaid.Name = "checkBoxNewIsPaid";
            checkBoxNewIsPaid.Size = new Size(97, 24);
            checkBoxNewIsPaid.TabIndex = 28;
            checkBoxNewIsPaid.Text = "Está pago";
            checkBoxNewIsPaid.UseVisualStyleBackColor = true;
            // 
            // txtOldPaymentMethod
            // 
            txtOldPaymentMethod.Enabled = false;
            txtOldPaymentMethod.Location = new Point(12, 159);
            txtOldPaymentMethod.Name = "txtOldPaymentMethod";
            txtOldPaymentMethod.Size = new Size(279, 27);
            txtOldPaymentMethod.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 18);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 30;
            label8.Text = "Seleccione un articulo";
            // 
            // btnUnselect
            // 
            btnUnselect.Location = new Point(445, 633);
            btnUnselect.Name = "btnUnselect";
            btnUnselect.Size = new Size(110, 29);
            btnUnselect.TabIndex = 31;
            btnUnselect.Text = "Deseleccionar";
            btnUnselect.UseVisualStyleBackColor = true;
            btnUnselect.Click += btnUnselect_Click;
            // 
            // UpdateBookingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 670);
            Controls.Add(btnUnselect);
            Controls.Add(label8);
            Controls.Add(txtOldPaymentMethod);
            Controls.Add(checkBoxNewIsPaid);
            Controls.Add(label9);
            Controls.Add(cbNewPaymentMethod);
            Controls.Add(dtpNewEndBooking);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpNewInitBooking);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(checkBoxOldIsPaid);
            Controls.Add(label4);
            Controls.Add(dtpEndBooking);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpInitBooking);
            Controls.Add(btnElectronic);
            Controls.Add(btnIndumentary);
            Controls.Add(btnProperties);
            Controls.Add(btnVehicles);
            Controls.Add(dgvEntities);
            Margin = new Padding(2);
            Name = "UpdateBookingView";
            Text = "UpdateBookingView";
            ((System.ComponentModel.ISupportInitialize)dgvEntities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEntities;
        private Button btnVehicles;
        private Button btnProperties;
        private Button btnIndumentary;
        private Button btnElectronic;
        private DateTimePicker dtpInitBooking;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpEndBooking;
        private Label label4;
        private CheckBox checkBoxOldIsPaid;
        private Button btnUpdate;
        private Button btnCancel;
        private Label label5;
        private DateTimePicker dtpNewInitBooking;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpNewEndBooking;
        private ComboBox cbNewPaymentMethod;
        private Label label9;
        private CheckBox checkBoxNewIsPaid;
        private TextBox txtOldPaymentMethod;
        private Label label8;
        private Button btnUnselect;
    }
}
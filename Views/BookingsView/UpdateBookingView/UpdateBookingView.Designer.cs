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
            txtOldClient = new TextBox();
            label10 = new Label();
            cbNewClient = new ComboBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            SuspendLayout();
            // 
            // dgvEntities
            // 
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Location = new Point(556, 89);
            dgvEntities.Margin = new Padding(2);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowHeadersWidth = 62;
            dgvEntities.Size = new Size(835, 696);
            dgvEntities.TabIndex = 0;
            // 
            // btnVehicles
            // 
            btnVehicles.Location = new Point(841, 50);
            btnVehicles.Margin = new Padding(2);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(138, 34);
            btnVehicles.TabIndex = 1;
            btnVehicles.Text = "Vehiculos";
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnProperties
            // 
            btnProperties.Location = new Point(556, 50);
            btnProperties.Margin = new Padding(2);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(138, 34);
            btnProperties.TabIndex = 2;
            btnProperties.Text = "Propiedades";
            btnProperties.UseVisualStyleBackColor = true;
            // 
            // btnIndumentary
            // 
            btnIndumentary.Location = new Point(699, 50);
            btnIndumentary.Margin = new Padding(2);
            btnIndumentary.Name = "btnIndumentary";
            btnIndumentary.Size = new Size(138, 34);
            btnIndumentary.TabIndex = 3;
            btnIndumentary.Text = "Indumentaria";
            btnIndumentary.UseVisualStyleBackColor = true;
            // 
            // btnElectronic
            // 
            btnElectronic.Location = new Point(984, 50);
            btnElectronic.Margin = new Padding(2);
            btnElectronic.Name = "btnElectronic";
            btnElectronic.Size = new Size(138, 34);
            btnElectronic.TabIndex = 4;
            btnElectronic.Text = "Electronica";
            btnElectronic.UseVisualStyleBackColor = true;
            // 
            // dtpInitBooking
            // 
            dtpInitBooking.Enabled = false;
            dtpInitBooking.Location = new Point(14, 76);
            dtpInitBooking.Margin = new Padding(2);
            dtpInitBooking.Name = "dtpInitBooking";
            dtpInitBooking.Size = new Size(349, 31);
            dtpInitBooking.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 7;
            label1.Text = "Datos de la vieja reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 8;
            label2.Text = "Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 25);
            label3.TabIndex = 9;
            label3.Text = "Fin";
            // 
            // dtpEndBooking
            // 
            dtpEndBooking.Enabled = false;
            dtpEndBooking.Location = new Point(14, 138);
            dtpEndBooking.Margin = new Padding(2);
            dtpEndBooking.Name = "dtpEndBooking";
            dtpEndBooking.Size = new Size(349, 31);
            dtpEndBooking.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 171);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 12;
            label4.Text = "Medio de pago";
            // 
            // checkBoxOldIsPaid
            // 
            checkBoxOldIsPaid.AutoSize = true;
            checkBoxOldIsPaid.Enabled = false;
            checkBoxOldIsPaid.Location = new Point(18, 239);
            checkBoxOldIsPaid.Margin = new Padding(2);
            checkBoxOldIsPaid.Name = "checkBoxOldIsPaid";
            checkBoxOldIsPaid.Size = new Size(117, 29);
            checkBoxOldIsPaid.TabIndex = 14;
            checkBoxOldIsPaid.Text = "Está pago";
            checkBoxOldIsPaid.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 790);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 34);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1272, 791);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 353);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 19;
            label5.Text = "Nuevos datos";
            // 
            // dtpNewInitBooking
            // 
            dtpNewInitBooking.Location = new Point(18, 407);
            dtpNewInitBooking.Margin = new Padding(4);
            dtpNewInitBooking.Name = "dtpNewInitBooking";
            dtpNewInitBooking.Size = new Size(348, 31);
            dtpNewInitBooking.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 378);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 21;
            label6.Text = "Inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 445);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(35, 25);
            label7.TabIndex = 22;
            label7.Text = "Fin";
            // 
            // dtpNewEndBooking
            // 
            dtpNewEndBooking.Location = new Point(18, 473);
            dtpNewEndBooking.Margin = new Padding(4);
            dtpNewEndBooking.Name = "dtpNewEndBooking";
            dtpNewEndBooking.Size = new Size(348, 31);
            dtpNewEndBooking.TabIndex = 23;
            // 
            // cbNewPaymentMethod
            // 
            cbNewPaymentMethod.FormattingEnabled = true;
            cbNewPaymentMethod.Items.AddRange(new object[] { "Tarjeta de Crédito", "Transferencia", "Efectivo" });
            cbNewPaymentMethod.Location = new Point(18, 539);
            cbNewPaymentMethod.Margin = new Padding(4);
            cbNewPaymentMethod.Name = "cbNewPaymentMethod";
            cbNewPaymentMethod.Size = new Size(348, 33);
            cbNewPaymentMethod.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 511);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(135, 25);
            label9.TabIndex = 27;
            label9.Text = "Medio de pago";
            // 
            // checkBoxNewIsPaid
            // 
            checkBoxNewIsPaid.AutoSize = true;
            checkBoxNewIsPaid.Location = new Point(18, 582);
            checkBoxNewIsPaid.Margin = new Padding(4);
            checkBoxNewIsPaid.Name = "checkBoxNewIsPaid";
            checkBoxNewIsPaid.Size = new Size(117, 29);
            checkBoxNewIsPaid.TabIndex = 28;
            checkBoxNewIsPaid.Text = "Está pago";
            checkBoxNewIsPaid.UseVisualStyleBackColor = true;
            // 
            // txtOldPaymentMethod
            // 
            txtOldPaymentMethod.Location = new Point(15, 199);
            txtOldPaymentMethod.Margin = new Padding(4);
            txtOldPaymentMethod.Name = "txtOldPaymentMethod";
            txtOldPaymentMethod.ReadOnly = true;
            txtOldPaymentMethod.Size = new Size(348, 31);
            txtOldPaymentMethod.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(559, 22);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(182, 25);
            label8.TabIndex = 30;
            label8.Text = "Seleccione un articulo";
            // 
            // btnUnselect
            // 
            btnUnselect.Location = new Point(556, 791);
            btnUnselect.Margin = new Padding(4);
            btnUnselect.Name = "btnUnselect";
            btnUnselect.Size = new Size(138, 36);
            btnUnselect.TabIndex = 31;
            btnUnselect.Text = "Deseleccionar";
            btnUnselect.UseVisualStyleBackColor = true;
            btnUnselect.Click += btnUnselect_Click;
            // 
            // txtOldClient
            // 
            txtOldClient.Location = new Point(18, 298);
            txtOldClient.Name = "txtOldClient";
            txtOldClient.ReadOnly = true;
            txtOldClient.Size = new Size(345, 31);
            txtOldClient.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 270);
            label10.Name = "label10";
            label10.Size = new Size(65, 25);
            label10.TabIndex = 33;
            label10.Text = "Cliente";
            // 
            // cbNewClient
            // 
            cbNewClient.FormattingEnabled = true;
            cbNewClient.Location = new Point(18, 643);
            cbNewClient.Name = "cbNewClient";
            cbNewClient.Size = new Size(348, 33);
            cbNewClient.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 615);
            label11.Name = "label11";
            label11.Size = new Size(119, 25);
            label11.TabIndex = 35;
            label11.Text = "Nuevo cliente";
            // 
            // UpdateBookingView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 838);
            Controls.Add(label11);
            Controls.Add(cbNewClient);
            Controls.Add(label10);
            Controls.Add(txtOldClient);
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
        private TextBox txtOldClient;
        private Label label10;
        private ComboBox cbNewClient;
        private Label label11;
    }
}
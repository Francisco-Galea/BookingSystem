namespace Boocking.Views.BookingsView.ToReserveView
{
    partial class CreateBookingView
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
            dtpInitReservation = new DateTimePicker();
            dtpEndReservation = new DateTimePicker();
            label2 = new Label();
            btnCreateBooking = new Button();
            btnCancel = new Button();
            cbPaymentMethod = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Desde";
            // 
            // dtpInitReservation
            // 
            dtpInitReservation.Location = new Point(12, 92);
            dtpInitReservation.Name = "dtpInitReservation";
            dtpInitReservation.Size = new Size(269, 27);
            dtpInitReservation.TabIndex = 3;
            // 
            // dtpEndReservation
            // 
            dtpEndReservation.Location = new Point(12, 38);
            dtpEndReservation.Name = "dtpEndReservation";
            dtpEndReservation.Size = new Size(269, 27);
            dtpEndReservation.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "Hasta";
            // 
            // btnCreateBooking
            // 
            btnCreateBooking.Location = new Point(187, 209);
            btnCreateBooking.Name = "btnCreateBooking";
            btnCreateBooking.Size = new Size(94, 29);
            btnCreateBooking.TabIndex = 12;
            btnCreateBooking.Text = "Crear";
            btnCreateBooking.Click += btnCreateBooking_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(87, 209);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.Click += btnCancel_Click;
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Items.AddRange(new object[] { "Tarjeta de credito", "Transferencia / Deposito", "Efectivo" });
            cbPaymentMethod.Location = new Point(13, 145);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(268, 28);
            cbPaymentMethod.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 122);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 14;
            label3.Text = "Medio de pago";
            // 
            // CreateBookingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 252);
            Controls.Add(label3);
            Controls.Add(cbPaymentMethod);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateBooking);
            Controls.Add(label2);
            Controls.Add(dtpEndReservation);
            Controls.Add(dtpInitReservation);
            Controls.Add(label1);
            Name = "CreateBookingView";
            Text = "ToReserveView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dtpInitReservation;
        private DateTimePicker dtpEndReservation;
        private Label label2;
        private Button btnCreateBooking;
        private Button btnCancel;
        private ComboBox cbPaymentMethod;
        private Label label3;
    }
}
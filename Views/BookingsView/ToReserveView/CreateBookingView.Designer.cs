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
            dtpInitReseservation = new DateTimePicker();
            dtpEndReservation = new DateTimePicker();
            label2 = new Label();
            btnCreateBooking = new Button();
            btnCancel = new Button();
            cbPaymentMethod = new ComboBox();
            label3 = new Label();
            checkBoxIsPayed = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 2;
            label1.Text = "Desde";
            // 
            // dtpInitReseservation
            // 
            dtpInitReseservation.Location = new Point(13, 39);
            dtpInitReseservation.Margin = new Padding(4);
            dtpInitReseservation.Name = "dtpInitReseservation";
            dtpInitReseservation.Size = new Size(335, 31);
            dtpInitReseservation.TabIndex = 3;
            // 
            // dtpEndReservation
            // 
            dtpEndReservation.Location = new Point(16, 103);
            dtpEndReservation.Margin = new Padding(4);
            dtpEndReservation.Name = "dtpEndReservation";
            dtpEndReservation.Size = new Size(335, 31);
            dtpEndReservation.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 5;
            label2.Text = "Hasta";
            // 
            // btnCreateBooking
            // 
            btnCreateBooking.Location = new Point(234, 311);
            btnCreateBooking.Margin = new Padding(4);
            btnCreateBooking.Name = "btnCreateBooking";
            btnCreateBooking.Size = new Size(118, 36);
            btnCreateBooking.TabIndex = 12;
            btnCreateBooking.Text = "Crear";
            btnCreateBooking.Click += btnCreateBooking_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(109, 311);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.Click += btnCancel_Click;
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Items.AddRange(new object[] { "Tarjeta de Crédito", "Transferencia", "Efectivo" });
            cbPaymentMethod.Location = new Point(16, 181);
            cbPaymentMethod.Margin = new Padding(4);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(334, 33);
            cbPaymentMethod.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 14;
            label3.Text = "Medio de pago";
            // 
            // checkBoxIsPayed
            // 
            checkBoxIsPayed.AutoSize = true;
            checkBoxIsPayed.Location = new Point(16, 224);
            checkBoxIsPayed.Margin = new Padding(4);
            checkBoxIsPayed.Name = "checkBoxIsPayed";
            checkBoxIsPayed.Size = new Size(117, 29);
            checkBoxIsPayed.TabIndex = 15;
            checkBoxIsPayed.Text = "Está pago";
            checkBoxIsPayed.UseVisualStyleBackColor = true;
            // 
            // CreateBookingView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 362);
            Controls.Add(checkBoxIsPayed);
            Controls.Add(label3);
            Controls.Add(cbPaymentMethod);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateBooking);
            Controls.Add(label2);
            Controls.Add(dtpEndReservation);
            Controls.Add(dtpInitReseservation);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "CreateBookingView";
            Text = "ToReserveView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dtpInitReseservation;
        private DateTimePicker dtpEndReservation;
        private Label label2;
        private Button btnCreateBooking;
        private Button btnCancel;
        private ComboBox cbPaymentMethod;
        private Label label3;
        private CheckBox checkBoxIsPayed;
    }
}
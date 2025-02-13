namespace Boocking.Views.BookingsView.ToReserveView
{
    partial class ToReserveView
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
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            label1 = new Label();
            dtpInitReservation = new DateTimePicker();
            dtpEndReservation = new DateTimePicker();
            label2 = new Label();
            btnCreateBooking = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(492, 18);
            monthCalendar2.MaxSelectionCount = 1;
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 276);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Desde";
            // 
            // dtpInitReservation
            // 
            dtpInitReservation.Location = new Point(18, 299);
            dtpInitReservation.Name = "dtpInitReservation";
            dtpInitReservation.Size = new Size(290, 27);
            dtpInitReservation.TabIndex = 3;
            // 
            // dtpEndReservation
            // 
            dtpEndReservation.Location = new Point(498, 299);
            dtpEndReservation.Name = "dtpEndReservation";
            dtpEndReservation.Size = new Size(290, 27);
            dtpEndReservation.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 276);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "Hasta";
            // 
            // btnCreateBooking
            // 
            btnCreateBooking.Location = new Point(694, 409);
            btnCreateBooking.Name = "btnCreateBooking";
            btnCreateBooking.Size = new Size(94, 29);
            btnCreateBooking.TabIndex = 6;
            btnCreateBooking.Text = "Crear";
            btnCreateBooking.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(494, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(594, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Cancelar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ToReserveView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreateBooking);
            Controls.Add(label2);
            Controls.Add(dtpEndReservation);
            Controls.Add(dtpInitReservation);
            Controls.Add(label1);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Name = "ToReserveView";
            Text = "ToReserveView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Label label1;
        private DateTimePicker dtpInitReservation;
        private DateTimePicker dtpEndReservation;
        private Label label2;
        private Button btnCreateBooking;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
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
            comboBox1 = new ComboBox();
            dataGridViewEntities = new DataGridView();
            btnSearch = new Button();
            btnToReserve = new Button();
            mcInitReservation = new MonthCalendar();
            mcEndReservation = new MonthCalendar();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntities).BeginInit();
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 28);
            comboBox1.TabIndex = 1;
            // 
            // dataGridViewEntities
            // 
            dataGridViewEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntities.Location = new Point(12, 101);
            dataGridViewEntities.Name = "dataGridViewEntities";
            dataGridViewEntities.RowHeadersWidth = 51;
            dataGridViewEntities.Size = new Size(292, 337);
            dataGridViewEntities.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 66);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnToReserve
            // 
            btnToReserve.Location = new Point(310, 409);
            btnToReserve.Name = "btnToReserve";
            btnToReserve.Size = new Size(94, 29);
            btnToReserve.TabIndex = 4;
            btnToReserve.Text = "Reservar";
            btnToReserve.UseVisualStyleBackColor = true;
            // 
            // mcInitReservation
            // 
            mcInitReservation.Location = new Point(316, 32);
            mcInitReservation.MaxSelectionCount = 1;
            mcInitReservation.Name = "mcInitReservation";
            mcInitReservation.TabIndex = 5;
            // 
            // mcEndReservation
            // 
            mcEndReservation.Location = new Point(614, 32);
            mcEndReservation.MaxSelectionCount = 1;
            mcEndReservation.Name = "mcEndReservation";
            mcEndReservation.TabIndex = 6;
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
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 450);
            Controls.Add(btnBack);
            Controls.Add(mcEndReservation);
            Controls.Add(mcInitReservation);
            Controls.Add(btnToReserve);
            Controls.Add(btnSearch);
            Controls.Add(dataGridViewEntities);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Booking";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridViewEntities;
        private Button btnSearch;
        private Button btnToReserve;
        private MonthCalendar mcInitReservation;
        private MonthCalendar mcEndReservation;
        private Button btnBack;
    }
}
namespace Boocking.Views.BookingsView
{
    partial class ItemsView
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
            dataGridViewRentableEntities = new DataGridView();
            cbbRentableEntities = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentableEntities).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRentableEntities
            // 
            dataGridViewRentableEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRentableEntities.Location = new Point(211, 12);
            dataGridViewRentableEntities.Margin = new Padding(2);
            dataGridViewRentableEntities.Name = "dataGridViewRentableEntities";
            dataGridViewRentableEntities.RowHeadersWidth = 62;
            dataGridViewRentableEntities.Size = new Size(578, 426);
            dataGridViewRentableEntities.TabIndex = 0;
            // 
            // cbbRentableEntities
            // 
            cbbRentableEntities.FormattingEnabled = true;
            cbbRentableEntities.Items.AddRange(new object[] { "Vehiculo", "Dispositivo electronico", "Indumentaria", "Propiedad", "Vehiculo" });
            cbbRentableEntities.Location = new Point(12, 12);
            cbbRentableEntities.Margin = new Padding(2);
            cbbRentableEntities.Name = "cbbRentableEntities";
            cbbRentableEntities.Size = new Size(193, 33);
            cbbRentableEntities.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 51);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(192, 34);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 91);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(192, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(15, 135);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ItemsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbbRentableEntities);
            Controls.Add(dataGridViewRentableEntities);
            Margin = new Padding(2);
            Name = "ItemsView";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentableEntities).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRentableEntities;
        private ComboBox cbbRentableEntities;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
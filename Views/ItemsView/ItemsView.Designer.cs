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
            cbbRentableEntities = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnShowVehicles = new Button();
            btnShowProperties = new Button();
            btnShowIndumentary = new Button();
            btnShowElectronics = new Button();
            dataGridViewEntities = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntities).BeginInit();
            SuspendLayout();
            // 
            // cbbRentableEntities
            // 
            cbbRentableEntities.FormattingEnabled = true;
            cbbRentableEntities.Items.AddRange(new object[] { "Vehiculo", "Dispositivo electronico", "Indumentaria", "Propiedad", "Vehiculo" });
            cbbRentableEntities.Location = new Point(11, 81);
            cbbRentableEntities.Margin = new Padding(2);
            cbbRentableEntities.Name = "cbbRentableEntities";
            cbbRentableEntities.Size = new Size(193, 33);
            cbbRentableEntities.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 118);
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
            btnUpdate.Location = new Point(12, 158);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(192, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(15, 202);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShowVehicles
            // 
            btnShowVehicles.Location = new Point(370, 41);
            btnShowVehicles.Name = "btnShowVehicles";
            btnShowVehicles.Size = new Size(137, 34);
            btnShowVehicles.TabIndex = 9;
            btnShowVehicles.Text = "Vehiculos";
            btnShowVehicles.UseVisualStyleBackColor = true;
            btnShowVehicles.Click += btnShowVehicles_Click;
            // 
            // btnShowProperties
            // 
            btnShowProperties.Location = new Point(513, 41);
            btnShowProperties.Name = "btnShowProperties";
            btnShowProperties.Size = new Size(137, 34);
            btnShowProperties.TabIndex = 10;
            btnShowProperties.Text = "Propiedades";
            btnShowProperties.UseVisualStyleBackColor = true;
            btnShowProperties.Click += btnShowProperties_Click;
            // 
            // btnShowIndumentary
            // 
            btnShowIndumentary.Location = new Point(227, 41);
            btnShowIndumentary.Name = "btnShowIndumentary";
            btnShowIndumentary.Size = new Size(137, 34);
            btnShowIndumentary.TabIndex = 11;
            btnShowIndumentary.Text = "Indumentaria";
            btnShowIndumentary.UseVisualStyleBackColor = true;
            btnShowIndumentary.Click += btnShowIndumentary_Click;
            // 
            // btnShowElectronics
            // 
            btnShowElectronics.Location = new Point(656, 41);
            btnShowElectronics.Name = "btnShowElectronics";
            btnShowElectronics.Size = new Size(137, 34);
            btnShowElectronics.TabIndex = 12;
            btnShowElectronics.Text = "Electronica";
            btnShowElectronics.UseVisualStyleBackColor = true;
            btnShowElectronics.Click += btnShowElectronics_Click;
            // 
            // dataGridViewEntities
            // 
            dataGridViewEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntities.Location = new Point(227, 81);
            dataGridViewEntities.Name = "dataGridViewEntities";
            dataGridViewEntities.RowHeadersWidth = 62;
            dataGridViewEntities.Size = new Size(566, 454);
            dataGridViewEntities.TabIndex = 13;
            // 
            // ItemsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 547);
            Controls.Add(dataGridViewEntities);
            Controls.Add(btnShowElectronics);
            Controls.Add(btnShowIndumentary);
            Controls.Add(btnShowProperties);
            Controls.Add(btnShowVehicles);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbbRentableEntities);
            Margin = new Padding(2);
            Name = "ItemsView";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntities).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbbRentableEntities;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnShowVehicles;
        private Button btnShowProperties;
        private Button btnShowIndumentary;
        private Button btnShowElectronics;
        private DataGridView dataGridViewEntities;
        private Button btnUpdate;
    }
}
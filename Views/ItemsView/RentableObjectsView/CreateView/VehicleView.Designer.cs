namespace Boocking.Views.RentableObjectsView
{
    partial class VehicleView
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
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtPassengerCapacity = new TextBox();
            txtSerialNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            txtCostUsage = new TextBox();
            label5 = new Label();
            lblBrand = new Label();
            lblModel = new Label();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtVehicleName = new TextBox();
            dgvVehicles = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(16, 458);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(184, 34);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(15, 506);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 34);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(16, 556);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(184, 34);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPassengerCapacity
            // 
            txtPassengerCapacity.Location = new Point(16, 398);
            txtPassengerCapacity.Margin = new Padding(2);
            txtPassengerCapacity.Name = "txtPassengerCapacity";
            txtPassengerCapacity.Size = new Size(188, 31);
            txtPassengerCapacity.TabIndex = 19;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(16, 338);
            txtSerialNumber.Margin = new Padding(2);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(188, 31);
            txtSerialNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 4;
            label1.Text = "Tipo de vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 370);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de pasajeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 310);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 6;
            label3.Text = "Número de serie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 190);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 7;
            label4.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(16, 218);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(188, 31);
            txtDescription.TabIndex = 8;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(16, 278);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(188, 31);
            txtCostUsage.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 250);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 10;
            label5.Text = "Tarifa diaria";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(12, 70);
            lblBrand.Margin = new Padding(2, 0, 2, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(60, 25);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Marca";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(16, 130);
            lblModel.Margin = new Padding(2, 0, 2, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(74, 25);
            lblModel.TabIndex = 15;
            lblModel.Text = "Modelo";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(16, 98);
            txtBrand.Margin = new Padding(2);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(184, 31);
            txtBrand.TabIndex = 16;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(16, 158);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(184, 31);
            txtModel.TabIndex = 17;
            // 
            // txtVehicleName
            // 
            txtVehicleName.BackColor = SystemColors.Window;
            txtVehicleName.Location = new Point(16, 38);
            txtVehicleName.Margin = new Padding(2);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.Size = new Size(188, 31);
            txtVehicleName.TabIndex = 0;
            // 
            // dgvVehicles
            // 
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Location = new Point(210, 9);
            dgvVehicles.Margin = new Padding(2);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.RowHeadersWidth = 62;
            dgvVehicles.Size = new Size(809, 581);
            dgvVehicles.TabIndex = 22;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(902, 596);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 23;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // VehicleView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 640);
            Controls.Add(btnBack);
            Controls.Add(dgvVehicles);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassengerCapacity);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(btnCreate);
            Controls.Add(label5);
            Controls.Add(txtCostUsage);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSerialNumber);
            Controls.Add(txtVehicleName);
            Margin = new Padding(2);
            Name = "VehicleView";
            Text = "VehicleView";
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtPassengerCapacity;
        private TextBox txtSerialNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDescription;
        private TextBox txtCostUsage;
        private Label label5;
        private Label lblBrand;
        private Label lblModel;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtVehicleName;
        private DataGridView dgvVehicles;
        private Button btnBack;
    }
}
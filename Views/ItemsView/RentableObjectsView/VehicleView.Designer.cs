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
            txtVehicleName = new TextBox();
            txtSerialNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            txtCostUsage = new TextBox();
            label5 = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            lblBrand = new Label();
            lblModel = new Label();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            btnUpdate = new Button();
            txtPassengerCapacity = new TextBox();
            SuspendLayout();
            // 
            // txtVehicleName
            // 
            txtVehicleName.BackColor = SystemColors.Window;
            txtVehicleName.Location = new Point(80, 36);
            txtVehicleName.Margin = new Padding(2);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.Size = new Size(188, 31);
            txtVehicleName.TabIndex = 0;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(80, 404);
            txtSerialNumber.Margin = new Padding(2);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(188, 31);
            txtSerialNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 4;
            label1.Text = "Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 452);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de pasajeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 376);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 6;
            label3.Text = "Número de serie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 225);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 7;
            label4.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(80, 252);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(188, 31);
            txtDescription.TabIndex = 8;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(80, 322);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(188, 31);
            txtCostUsage.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 295);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 10;
            label5.Text = "Tarifa diaria";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 578);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(287, 578);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(80, 80);
            lblBrand.Margin = new Padding(2, 0, 2, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(60, 25);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Marca";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(80, 154);
            lblModel.Margin = new Padding(2, 0, 2, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(74, 25);
            lblModel.TabIndex = 15;
            lblModel.Text = "Modelo";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(84, 108);
            txtBrand.Margin = new Padding(2);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(184, 31);
            txtBrand.TabIndex = 16;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(84, 182);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(184, 31);
            txtModel.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 576);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 36);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtPassengerCapacity
            // 
            txtPassengerCapacity.Location = new Point(84, 480);
            txtPassengerCapacity.Name = "txtPassengerCapacity";
            txtPassengerCapacity.Size = new Size(184, 31);
            txtPassengerCapacity.TabIndex = 19;
            // 
            // VehicleView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 622);
            Controls.Add(txtPassengerCapacity);
            Controls.Add(btnUpdate);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVehicleName;
        private TextBox txtSerialNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDescription;
        private TextBox txtCostUsage;
        private Label label5;
        private Button btnCancel;
        private Button btnCreate;
        private Label lblBrand;
        private Label lblModel;
        private TextBox txtBrand;
        private TextBox txtModel;
        private Button btnUpdate;
        private TextBox txtPassengerCapacity;
    }
}
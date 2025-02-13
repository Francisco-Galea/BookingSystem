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
            numPassengerCapacity = new NumericUpDown();
            lblBrand = new Label();
            lblModel = new Label();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)numPassengerCapacity).BeginInit();
            SuspendLayout();
            // 
            // txtVehicleName
            // 
            txtVehicleName.BackColor = SystemColors.Window;
            txtVehicleName.Location = new Point(64, 29);
            txtVehicleName.Margin = new Padding(2, 2, 2, 2);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.Size = new Size(151, 27);
            txtVehicleName.TabIndex = 0;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(64, 323);
            txtSerialNumber.Margin = new Padding(2, 2, 2, 2);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(151, 27);
            txtSerialNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 362);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de pasajeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 301);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 6;
            label3.Text = "Número de serie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 180);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(64, 202);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(151, 27);
            txtDescription.TabIndex = 8;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(64, 258);
            txtCostUsage.Margin = new Padding(2, 2, 2, 2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(151, 27);
            txtCostUsage.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 236);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 10;
            label5.Text = "Costo de uso por dia";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(10, 462);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(220, 463);
            btnCreate.Margin = new Padding(2, 2, 2, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(90, 27);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // numPassengerCapacity
            // 
            numPassengerCapacity.Location = new Point(64, 384);
            numPassengerCapacity.Margin = new Padding(2, 2, 2, 2);
            numPassengerCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPassengerCapacity.Name = "numPassengerCapacity";
            numPassengerCapacity.Size = new Size(150, 27);
            numPassengerCapacity.TabIndex = 13;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(64, 64);
            lblBrand.Margin = new Padding(2, 0, 2, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(50, 20);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Marca";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(64, 123);
            lblModel.Margin = new Padding(2, 0, 2, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(61, 20);
            lblModel.TabIndex = 15;
            lblModel.Text = "Modelo";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(67, 86);
            txtBrand.Margin = new Padding(2, 2, 2, 2);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(148, 27);
            txtBrand.TabIndex = 16;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(67, 146);
            txtModel.Margin = new Padding(2, 2, 2, 2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(148, 27);
            txtModel.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(220, 461);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // VehicleView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 498);
            Controls.Add(btnUpdate);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(numPassengerCapacity);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "VehicleView";
            Text = "VehicleView";
            ((System.ComponentModel.ISupportInitialize)numPassengerCapacity).EndInit();
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
        private NumericUpDown numPassengerCapacity;
        private Label lblBrand;
        private Label lblModel;
        private TextBox txtBrand;
        private TextBox txtModel;
        private Button btnUpdate;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)numPassengerCapacity).BeginInit();
            SuspendLayout();
            // 
            // txtVehicleName
            // 
            txtVehicleName.BackColor = SystemColors.Menu;
            txtVehicleName.Location = new Point(80, 36);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.Size = new Size(188, 31);
            txtVehicleName.TabIndex = 0;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(80, 261);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(188, 31);
            txtSerialNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 8);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 4;
            label1.Text = "Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 309);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de pasajeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 233);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 6;
            label3.Text = "Número de serie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 82);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 7;
            label4.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(80, 110);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(188, 31);
            txtDescription.TabIndex = 8;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(80, 180);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(188, 31);
            txtCostUsage.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 152);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 10;
            label5.Text = "Costo de uso por dia";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(217, 409);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // numPassengerCapacity
            // 
            numPassengerCapacity.Location = new Point(80, 337);
            numPassengerCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPassengerCapacity.Name = "numPassengerCapacity";
            numPassengerCapacity.Size = new Size(188, 31);
            numPassengerCapacity.TabIndex = 13;
            // 
            // VehicleView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 455);
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
    }
}
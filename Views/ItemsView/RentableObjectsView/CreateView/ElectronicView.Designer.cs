namespace Boocking.Views.RentableObjectsView
{
    partial class ElectronicView
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtCostUsage = new TextBox();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtSerialNumber = new TextBox();
            btnCreate = new Button();
            btnBack = new Button();
            dgvElectronics = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvElectronics).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Dispositivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 139);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Tarifa diaria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 202);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 266);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 4;
            label5.Text = "Modelo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 330);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 5;
            label6.Text = "Número de serie";
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 39);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 31);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(14, 102);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(219, 31);
            txtDescription.TabIndex = 7;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(14, 166);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(219, 31);
            txtCostUsage.TabIndex = 8;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(14, 230);
            txtBrand.Margin = new Padding(2);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(219, 31);
            txtBrand.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(14, 294);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(219, 31);
            txtModel.TabIndex = 10;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(14, 358);
            txtSerialNumber.Margin = new Padding(2);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(219, 31);
            txtSerialNumber.TabIndex = 11;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(14, 416);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(220, 34);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(958, 564);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 14;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvElectronics
            // 
            dgvElectronics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElectronics.Location = new Point(250, 15);
            dgvElectronics.Margin = new Padding(4, 4, 4, 4);
            dgvElectronics.Name = "dgvElectronics";
            dgvElectronics.RowHeadersWidth = 51;
            dgvElectronics.Size = new Size(819, 521);
            dgvElectronics.TabIndex = 15;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(15, 456);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(219, 36);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(15, 500);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(219, 36);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ElectronicView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvElectronics);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(txtSerialNumber);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(txtCostUsage);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ElectronicView";
            Text = "ElectronicView";
            ((System.ComponentModel.ISupportInitialize)dgvElectronics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtCostUsage;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtSerialNumber;
        private Button btnCreate;
        private Button btnBack;
        private DataGridView dgvElectronics;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
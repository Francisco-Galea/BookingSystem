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
            dgvElectronic = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvElectronic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Dispositivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 111);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Tarifa diaria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 162);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 213);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Modelo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 264);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 5;
            label6.Text = "Número de serie";
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 31);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 27);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(11, 82);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(176, 27);
            txtDescription.TabIndex = 7;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(11, 133);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(176, 27);
            txtCostUsage.TabIndex = 8;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(11, 184);
            txtBrand.Margin = new Padding(2);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(176, 27);
            txtBrand.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(11, 235);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(176, 27);
            txtModel.TabIndex = 10;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(11, 286);
            txtSerialNumber.Margin = new Padding(2);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(176, 27);
            txtSerialNumber.TabIndex = 11;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(11, 333);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(176, 27);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(766, 451);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 27);
            btnBack.TabIndex = 14;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvElectronic
            // 
            dgvElectronic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElectronic.Location = new Point(200, 12);
            dgvElectronic.Name = "dgvElectronic";
            dgvElectronic.RowHeadersWidth = 51;
            dgvElectronic.Size = new Size(655, 417);
            dgvElectronic.TabIndex = 15;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 365);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ElectronicView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 489);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvElectronic);
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
            ((System.ComponentModel.ISupportInitialize)dgvElectronic).EndInit();
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
        private DataGridView dgvElectronic;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
﻿namespace Boocking.Views.RentableObjectsView
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
            btnCancel = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Dispositivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Costo de uso por dia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 209);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 272);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Modelo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 334);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 5;
            label6.Text = "Numero de serie";
            // 
            // txtName
            // 
            txtName.Location = new Point(71, 37);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(142, 27);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(71, 99);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(142, 27);
            txtDescription.TabIndex = 7;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(71, 163);
            txtCostUsage.Margin = new Padding(2, 2, 2, 2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(142, 27);
            txtCostUsage.TabIndex = 8;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(71, 231);
            txtBrand.Margin = new Padding(2, 2, 2, 2);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(142, 27);
            txtBrand.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(71, 294);
            txtModel.Margin = new Padding(2, 2, 2, 2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(142, 27);
            txtModel.TabIndex = 10;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(71, 357);
            txtSerialNumber.Margin = new Padding(2, 2, 2, 2);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(142, 27);
            txtSerialNumber.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(10, 421);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(200, 421);
            btnCreate.Margin = new Padding(2, 2, 2, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(90, 27);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(200, 419);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // ElectronicView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 458);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "ElectronicView";
            Text = "ElectronicView";
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
        private Button btnCancel;
        private Button btnCreate;
        private Button btnUpdate;
    }
}
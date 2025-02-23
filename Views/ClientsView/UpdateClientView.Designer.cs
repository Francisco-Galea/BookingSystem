namespace Booking.Views.ClientsView
{
    partial class UpdateClientView
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtOldName = new TextBox();
            txtOldLastName = new TextBox();
            txtOldNumber = new TextBox();
            txtNewName = new TextBox();
            txtNewLastName = new TextBox();
            txtNewNumber = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Datos a modificar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 3;
            label4.Text = "Celular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 34);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 5;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 90);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 6;
            label7.Text = "Apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 152);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 7;
            label8.Text = "Celular";
            // 
            // txtOldName
            // 
            txtOldName.Location = new Point(12, 56);
            txtOldName.Name = "txtOldName";
            txtOldName.ReadOnly = true;
            txtOldName.Size = new Size(150, 31);
            txtOldName.TabIndex = 8;
            // 
            // txtOldLastName
            // 
            txtOldLastName.Location = new Point(12, 118);
            txtOldLastName.Name = "txtOldLastName";
            txtOldLastName.ReadOnly = true;
            txtOldLastName.Size = new Size(150, 31);
            txtOldLastName.TabIndex = 9;
            // 
            // txtOldNumber
            // 
            txtOldNumber.Location = new Point(12, 180);
            txtOldNumber.Name = "txtOldNumber";
            txtOldNumber.ReadOnly = true;
            txtOldNumber.Size = new Size(150, 31);
            txtOldNumber.TabIndex = 10;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(209, 56);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(150, 31);
            txtNewName.TabIndex = 11;
            // 
            // txtNewLastName
            // 
            txtNewLastName.Location = new Point(209, 118);
            txtNewLastName.Name = "txtNewLastName";
            txtNewLastName.Size = new Size(150, 31);
            txtNewLastName.TabIndex = 12;
            // 
            // txtNewNumber
            // 
            txtNewNumber.Location = new Point(209, 180);
            txtNewNumber.Name = "txtNewNumber";
            txtNewNumber.Size = new Size(150, 31);
            txtNewNumber.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(247, 255);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 255);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateClientView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 302);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtNewNumber);
            Controls.Add(txtNewLastName);
            Controls.Add(txtNewName);
            Controls.Add(txtOldNumber);
            Controls.Add(txtOldLastName);
            Controls.Add(txtOldName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateClientView";
            Text = "UpdateClientView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtOldName;
        private TextBox txtOldLastName;
        private TextBox txtOldNumber;
        private TextBox txtNewName;
        private TextBox txtNewLastName;
        private TextBox txtNewNumber;
        private Button btnUpdate;
        private Button btnCancel;
    }
}
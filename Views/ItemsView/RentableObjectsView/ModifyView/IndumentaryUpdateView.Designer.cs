namespace Booking.Views.ItemsView.RentableObjectsView.ModifyView
{
    partial class IndumentaryUpdateView
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
            txtOldIndumentaryType = new TextBox();
            txtOldDescription = new TextBox();
            txtOldSize = new TextBox();
            txtOldGenre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNewIndumentaryType = new TextBox();
            txtNewDescription = new TextBox();
            txtNewSize = new TextBox();
            txtNewGenre = new TextBox();
            label9 = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            label10 = new Label();
            label11 = new Label();
            txtOldCostUsage = new TextBox();
            txtNewCostUsage = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipo de indumentaria";
            // 
            // txtOldIndumentaryType
            // 
            txtOldIndumentaryType.Location = new Point(12, 83);
            txtOldIndumentaryType.Name = "txtOldIndumentaryType";
            txtOldIndumentaryType.ReadOnly = true;
            txtOldIndumentaryType.Size = new Size(181, 31);
            txtOldIndumentaryType.TabIndex = 1;
            // 
            // txtOldDescription
            // 
            txtOldDescription.Location = new Point(12, 145);
            txtOldDescription.Name = "txtOldDescription";
            txtOldDescription.ReadOnly = true;
            txtOldDescription.Size = new Size(181, 31);
            txtOldDescription.TabIndex = 2;
            // 
            // txtOldSize
            // 
            txtOldSize.Location = new Point(13, 269);
            txtOldSize.Name = "txtOldSize";
            txtOldSize.ReadOnly = true;
            txtOldSize.Size = new Size(181, 31);
            txtOldSize.TabIndex = 3;
            // 
            // txtOldGenre
            // 
            txtOldGenre.Location = new Point(13, 331);
            txtOldGenre.Name = "txtOldGenre";
            txtOldGenre.ReadOnly = true;
            txtOldGenre.Size = new Size(181, 31);
            txtOldGenre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 5;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 241);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 6;
            label3.Text = "Talle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 303);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 7;
            label4.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 55);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 8;
            label5.Text = "Tipo de indumentaria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 117);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 9;
            label6.Text = "Descripcion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 241);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 10;
            label7.Text = "Talle";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(277, 303);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 11;
            label8.Text = "Genero";
            // 
            // txtNewIndumentaryType
            // 
            txtNewIndumentaryType.Location = new Point(276, 83);
            txtNewIndumentaryType.Name = "txtNewIndumentaryType";
            txtNewIndumentaryType.Size = new Size(181, 31);
            txtNewIndumentaryType.TabIndex = 12;
            // 
            // txtNewDescription
            // 
            txtNewDescription.Location = new Point(276, 145);
            txtNewDescription.Name = "txtNewDescription";
            txtNewDescription.Size = new Size(181, 31);
            txtNewDescription.TabIndex = 13;
            // 
            // txtNewSize
            // 
            txtNewSize.Location = new Point(277, 269);
            txtNewSize.Name = "txtNewSize";
            txtNewSize.Size = new Size(181, 31);
            txtNewSize.TabIndex = 14;
            // 
            // txtNewGenre
            // 
            txtNewGenre.Location = new Point(277, 331);
            txtNewGenre.Name = "txtNewGenre";
            txtNewGenre.Size = new Size(181, 31);
            txtNewGenre.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 16;
            label9.Text = "Datos a actualizar";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(343, 436);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 436);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 179);
            label10.Name = "label10";
            label10.Size = new Size(101, 25);
            label10.TabIndex = 19;
            label10.Text = "Tarifa diaria";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(276, 179);
            label11.Name = "label11";
            label11.Size = new Size(101, 25);
            label11.TabIndex = 20;
            label11.Text = "Tarifa diaria";
            // 
            // txtOldCostUsage
            // 
            txtOldCostUsage.Location = new Point(13, 207);
            txtOldCostUsage.Name = "txtOldCostUsage";
            txtOldCostUsage.ReadOnly = true;
            txtOldCostUsage.Size = new Size(178, 31);
            txtOldCostUsage.TabIndex = 21;
            // 
            // txtNewCostUsage
            // 
            txtNewCostUsage.Location = new Point(276, 207);
            txtNewCostUsage.Name = "txtNewCostUsage";
            txtNewCostUsage.Size = new Size(179, 31);
            txtNewCostUsage.TabIndex = 22;
            // 
            // IndumentaryUpdateView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 482);
            Controls.Add(txtNewCostUsage);
            Controls.Add(txtOldCostUsage);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label9);
            Controls.Add(txtNewGenre);
            Controls.Add(txtNewSize);
            Controls.Add(txtNewDescription);
            Controls.Add(txtNewIndumentaryType);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtOldGenre);
            Controls.Add(txtOldSize);
            Controls.Add(txtOldDescription);
            Controls.Add(txtOldIndumentaryType);
            Controls.Add(label1);
            Name = "IndumentaryUpdateView";
            Text = "IndumentaryUpdateView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOldIndumentaryType;
        private TextBox txtOldDescription;
        private TextBox txtOldSize;
        private TextBox txtOldGenre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNewIndumentaryType;
        private TextBox txtNewDescription;
        private TextBox txtNewSize;
        private TextBox txtNewGenre;
        private Label label9;
        private Button btnUpdate;
        private Button btnCancel;
        private Label label10;
        private Label label11;
        private TextBox txtOldCostUsage;
        private TextBox txtNewCostUsage;
    }
}
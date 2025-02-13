namespace Boocking.Views.ItemsView.RentableObjectsView
{
    partial class IndumentaryView
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
            txtIndimentaryType = new TextBox();
            txtDescription = new TextBox();
            txtCostUsage = new TextBox();
            txtSize = new TextBox();
            txtGenre = new TextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de indumentaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 113);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Costo de uso por dia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 162);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Talle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 212);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Genero";
            // 
            // txtIndimentaryType
            // 
            txtIndimentaryType.Location = new Point(58, 36);
            txtIndimentaryType.Margin = new Padding(2);
            txtIndimentaryType.Name = "txtIndimentaryType";
            txtIndimentaryType.Size = new Size(145, 27);
            txtIndimentaryType.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(58, 86);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(145, 27);
            txtDescription.TabIndex = 6;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(58, 135);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(145, 27);
            txtCostUsage.TabIndex = 7;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(58, 185);
            txtSize.Margin = new Padding(2);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(147, 27);
            txtSize.TabIndex = 8;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(58, 234);
            txtGenre.Margin = new Padding(2);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(145, 27);
            txtGenre.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(10, 294);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(157, 294);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(90, 27);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(157, 292);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // IndumentaryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 338);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(txtGenre);
            Controls.Add(txtSize);
            Controls.Add(txtCostUsage);
            Controls.Add(txtDescription);
            Controls.Add(txtIndimentaryType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "IndumentaryView";
            Text = "IndumentaryView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIndimentaryType;
        private TextBox txtDescription;
        private TextBox txtCostUsage;
        private TextBox txtSize;
        private TextBox txtGenre;
        private Button btnCancel;
        private Button btnCreate;
        private Button btnUpdate;
    }
}
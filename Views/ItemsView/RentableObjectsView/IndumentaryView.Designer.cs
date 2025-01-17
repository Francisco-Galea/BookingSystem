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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 17);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipo de indumentaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 79);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 141);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 2;
            label3.Text = "Costo de uso por dia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 203);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 3;
            label4.Text = "Talle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 265);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 4;
            label5.Text = "Genero";
            // 
            // txtIndimentaryType
            // 
            txtIndimentaryType.Location = new Point(72, 45);
            txtIndimentaryType.Name = "txtIndimentaryType";
            txtIndimentaryType.Size = new Size(150, 31);
            txtIndimentaryType.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(72, 107);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 6;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(72, 169);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(150, 31);
            txtCostUsage.TabIndex = 7;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(72, 231);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(150, 31);
            txtSize.TabIndex = 8;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(72, 293);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(150, 31);
            txtGenre.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(170, 368);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // IndumentaryView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 423);
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
    }
}
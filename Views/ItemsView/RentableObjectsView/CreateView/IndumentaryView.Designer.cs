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
            btnCreate = new Button();
            btnBack = new Button();
            dgvIndumentary = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIndumentary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipo de indumentaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 129);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Tarifa diaria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 189);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 3;
            label4.Text = "Talle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 249);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 4;
            label5.Text = "Genero";
            // 
            // txtIndimentaryType
            // 
            txtIndimentaryType.Location = new Point(12, 36);
            txtIndimentaryType.Margin = new Padding(2);
            txtIndimentaryType.Name = "txtIndimentaryType";
            txtIndimentaryType.Size = new Size(180, 31);
            txtIndimentaryType.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(11, 96);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(180, 31);
            txtDescription.TabIndex = 6;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(11, 156);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(180, 31);
            txtCostUsage.TabIndex = 7;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(12, 216);
            txtSize.Margin = new Padding(2);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(183, 31);
            txtSize.TabIndex = 8;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(12, 276);
            txtGenre.Margin = new Padding(2);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(180, 31);
            txtGenre.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 322);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(179, 34);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(588, 436);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 12;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvIndumentary
            // 
            dgvIndumentary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIndumentary.Location = new Point(200, 9);
            dgvIndumentary.Name = "dgvIndumentary";
            dgvIndumentary.RowHeadersWidth = 62;
            dgvIndumentary.Size = new Size(500, 421);
            dgvIndumentary.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 361);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(179, 34);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(179, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // IndumentaryView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 476);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvIndumentary);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
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
            ((System.ComponentModel.ISupportInitialize)dgvIndumentary).EndInit();
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
        private Button btnCreate;
        private Button btnBack;
        private DataGridView dgvIndumentary;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
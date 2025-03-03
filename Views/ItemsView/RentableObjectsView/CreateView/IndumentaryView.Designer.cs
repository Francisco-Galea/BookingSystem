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
            rentableId = new DataGridViewTextBoxColumn();
            indumentaryType = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            CostUsage = new DataGridViewTextBoxColumn();
            size = new DataGridViewTextBoxColumn();
            genre = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIndumentary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de indumentaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Tarifa diaria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 151);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Talle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 199);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Genero";
            // 
            // txtIndimentaryType
            // 
            txtIndimentaryType.Location = new Point(10, 29);
            txtIndimentaryType.Margin = new Padding(2);
            txtIndimentaryType.Name = "txtIndimentaryType";
            txtIndimentaryType.Size = new Size(145, 27);
            txtIndimentaryType.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(9, 77);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(145, 27);
            txtDescription.TabIndex = 6;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(9, 125);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(145, 27);
            txtCostUsage.TabIndex = 7;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(10, 173);
            txtSize.Margin = new Padding(2);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(147, 27);
            txtSize.TabIndex = 8;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(10, 221);
            txtGenre.Margin = new Padding(2);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(145, 27);
            txtGenre.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(10, 258);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(143, 27);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(888, 348);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 27);
            btnBack.TabIndex = 12;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvIndumentary
            // 
            dgvIndumentary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIndumentary.Columns.AddRange(new DataGridViewColumn[] { rentableId, indumentaryType, description, CostUsage, size, genre });
            dgvIndumentary.Location = new Point(160, 7);
            dgvIndumentary.Margin = new Padding(2);
            dgvIndumentary.Name = "dgvIndumentary";
            dgvIndumentary.RowHeadersWidth = 62;
            dgvIndumentary.Size = new Size(818, 337);
            dgvIndumentary.TabIndex = 13;
            // 
            // rentableId
            // 
            rentableId.HeaderText = "Id";
            rentableId.MinimumWidth = 6;
            rentableId.Name = "rentableId";
            rentableId.Width = 125;
            // 
            // indumentaryType
            // 
            indumentaryType.HeaderText = "Tipo de indumentaria";
            indumentaryType.MinimumWidth = 6;
            indumentaryType.Name = "indumentaryType";
            indumentaryType.Width = 125;
            // 
            // description
            // 
            description.HeaderText = "Descripcion";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.Width = 125;
            // 
            // CostUsage
            // 
            CostUsage.HeaderText = "Tarifa diaria";
            CostUsage.MinimumWidth = 6;
            CostUsage.Name = "CostUsage";
            CostUsage.Width = 125;
            // 
            // size
            // 
            size.HeaderText = "Talle";
            size.MinimumWidth = 6;
            size.Name = "size";
            size.Width = 125;
            // 
            // genre
            // 
            genre.HeaderText = "Género";
            genre.MinimumWidth = 6;
            genre.Name = "genre";
            genre.Width = 125;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 289);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 27);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 321);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 27);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // IndumentaryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 381);
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
        private DataGridViewTextBoxColumn rentableId;
        private DataGridViewTextBoxColumn indumentaryType;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn CostUsage;
        private DataGridViewTextBoxColumn size;
        private DataGridViewTextBoxColumn genre;
    }
}
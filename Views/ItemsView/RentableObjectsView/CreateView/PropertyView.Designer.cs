namespace Boocking.Views.RentableObjectsView
{
    partial class PropertyView
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
            txtProperty = new TextBox();
            txtDescription = new TextBox();
            txtCostUsage = new TextBox();
            txtLocation = new TextBox();
            btnCreate = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgvProperties = new DataGridView();
            rentableId = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            location = new DataGridViewTextBoxColumn();
            costUsage = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de propiedad";
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
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // txtProperty
            // 
            txtProperty.Location = new Point(10, 29);
            txtProperty.Margin = new Padding(2);
            txtProperty.Name = "txtProperty";
            txtProperty.Size = new Size(145, 27);
            txtProperty.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(10, 77);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(145, 27);
            txtDescription.TabIndex = 5;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(10, 125);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(145, 27);
            txtCostUsage.TabIndex = 6;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(10, 173);
            txtLocation.Margin = new Padding(2);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(145, 27);
            txtLocation.TabIndex = 7;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(10, 234);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(144, 27);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(758, 350);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 27);
            btnBack.TabIndex = 11;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(9, 320);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 27);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 278);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 27);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvProperties
            // 
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { rentableId, name, description, location, costUsage });
            dgvProperties.Location = new Point(158, 7);
            dgvProperties.Margin = new Padding(2, 2, 2, 2);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.RowHeadersWidth = 62;
            dgvProperties.Size = new Size(690, 340);
            dgvProperties.TabIndex = 15;
            // 
            // rentableId
            // 
            rentableId.HeaderText = "Id";
            rentableId.MinimumWidth = 6;
            rentableId.Name = "rentableId";
            rentableId.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "Tipo de propiedad";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // description
            // 
            description.HeaderText = "Descripcion";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.Width = 125;
            // 
            // location
            // 
            location.HeaderText = "Ubicacion";
            location.MinimumWidth = 6;
            location.Name = "location";
            location.Width = 125;
            // 
            // costUsage
            // 
            costUsage.HeaderText = "Tarifa diaria";
            costUsage.MinimumWidth = 6;
            costUsage.Name = "costUsage";
            costUsage.Width = 125;
            // 
            // PropertyView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 388);
            Controls.Add(dgvProperties);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(txtLocation);
            Controls.Add(txtCostUsage);
            Controls.Add(txtDescription);
            Controls.Add(txtProperty);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "PropertyView";
            Text = "PropertyView";
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProperty;
        private TextBox txtDescription;
        private TextBox txtCostUsage;
        private TextBox txtLocation;
        private Button btnCreate;
        private Button btnBack;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgvProperties;
        private DataGridViewTextBoxColumn rentableId;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn costUsage;
    }
}
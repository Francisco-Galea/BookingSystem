namespace Booking.Views.ClientsView
{
    partial class ClientsView
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
            dgvClients = new DataGridView();
            ClientId = new DataGridViewTextBoxColumn();
            ClientName = new DataGridViewTextBoxColumn();
            ClientLastName = new DataGridViewTextBoxColumn();
            ClientPhoneNumber = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            btnCreateClient = new Button();
            btnUpdateClient = new Button();
            btnDeleteClient = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { ClientId, ClientName, ClientLastName, ClientPhoneNumber });
            dgvClients.Location = new Point(292, 15);
            dgvClients.Margin = new Padding(4);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 51;
            dgvClients.Size = new Size(692, 488);
            dgvClients.TabIndex = 0;
            // 
            // ClientId
            // 
            ClientId.HeaderText = "Id";
            ClientId.MinimumWidth = 6;
            ClientId.Name = "ClientId";
            ClientId.Width = 125;
            // 
            // ClientName
            // 
            ClientName.HeaderText = "Nombre";
            ClientName.MinimumWidth = 6;
            ClientName.Name = "ClientName";
            ClientName.Width = 125;
            // 
            // ClientLastName
            // 
            ClientLastName.HeaderText = "Apellido";
            ClientLastName.MinimumWidth = 6;
            ClientLastName.Name = "ClientLastName";
            ClientLastName.Width = 125;
            // 
            // ClientPhoneNumber
            // 
            ClientPhoneNumber.HeaderText = "Celular";
            ClientPhoneNumber.MinimumWidth = 6;
            ClientPhoneNumber.Name = "ClientPhoneNumber";
            ClientPhoneNumber.Width = 125;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(868, 511);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 36);
            btnBack.TabIndex = 1;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCreateClient
            // 
            btnCreateClient.Location = new Point(15, 234);
            btnCreateClient.Margin = new Padding(4);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new Size(118, 36);
            btnCreateClient.TabIndex = 2;
            btnCreateClient.Text = "Crear";
            btnCreateClient.UseVisualStyleBackColor = true;
            btnCreateClient.Click += btnCreateClient_Click;
            // 
            // btnUpdateClient
            // 
            btnUpdateClient.Location = new Point(15, 296);
            btnUpdateClient.Margin = new Padding(4);
            btnUpdateClient.Name = "btnUpdateClient";
            btnUpdateClient.Size = new Size(118, 36);
            btnUpdateClient.TabIndex = 3;
            btnUpdateClient.Text = "Modificar";
            btnUpdateClient.UseVisualStyleBackColor = true;
            btnUpdateClient.Click += btnUpdateClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(15, 361);
            btnDeleteClient.Margin = new Padding(4);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(118, 36);
            btnDeleteClient.TabIndex = 4;
            btnDeleteClient.Text = "Eliminar";
            btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 7;
            label3.Text = "Número de telefono";
            // 
            // txtName
            // 
            txtName.Location = new Point(18, 40);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(266, 31);
            txtName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(18, 106);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(266, 31);
            txtLastName.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(18, 172);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(266, 31);
            txtPhoneNumber.TabIndex = 10;
            // 
            // ClientsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnUpdateClient);
            Controls.Add(btnCreateClient);
            Controls.Add(btnBack);
            Controls.Add(dgvClients);
            Margin = new Padding(4);
            Name = "ClientsView";
            Text = "ClientsView";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClients;
        private Button btnBack;
        private Button btnCreateClient;
        private Button btnUpdateClient;
        private Button btnDeleteClient;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn ClientLastName;
        private DataGridViewTextBoxColumn ClientPhoneNumber;
    }
}
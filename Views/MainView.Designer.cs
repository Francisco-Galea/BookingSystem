namespace Boocking.Views
{
    partial class MainView
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
            btnArticles = new Button();
            label1 = new Label();
            btnClients = new Button();
            btnBookings = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnArticles
            // 
            btnArticles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnArticles.Location = new Point(466, 170);
            btnArticles.Margin = new Padding(2);
            btnArticles.Name = "btnArticles";
            btnArticles.Size = new Size(148, 96);
            btnArticles.TabIndex = 1;
            btnArticles.Text = "Gestion de articulos";
            btnArticles.UseVisualStyleBackColor = true;
            btnArticles.Click += btnArticles_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(251, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 2;
            label1.Text = "Booking System";
            // 
            // btnClients
            // 
            btnClients.Location = new Point(3, 171);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(146, 95);
            btnClients.TabIndex = 3;
            btnClients.Text = "Clientes";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnBookings
            // 
            btnBookings.Anchor = AnchorStyles.Top;
            btnBookings.Location = new Point(236, 170);
            btnBookings.Margin = new Padding(2);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(146, 96);
            btnBookings.TabIndex = 4;
            btnBookings.Text = "Reservas";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.75472F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.24528F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnClients, 0, 1);
            tableLayoutPanel1.Controls.Add(btnBookings, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnArticles, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 11);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(616, 336);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(640, 358);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnArticles;
        private Label label1;
        private Button btnClients;
        private Button btnBookings;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
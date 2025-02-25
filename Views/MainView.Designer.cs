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
            SuspendLayout();
            // 
            // btnArticles
            // 
            btnArticles.Location = new Point(604, 192);
            btnArticles.Margin = new Padding(2);
            btnArticles.Name = "btnArticles";
            btnArticles.Size = new Size(185, 34);
            btnArticles.TabIndex = 1;
            btnArticles.Text = "Gestion de articulos";
            btnArticles.UseVisualStyleBackColor = true;
            btnArticles.Click += btnArticles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 2;
            label1.Text = "Booking System";
            // 
            // btnClients
            // 
            btnClients.Location = new Point(325, 192);
            btnClients.Margin = new Padding(4);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(182, 36);
            btnClients.TabIndex = 3;
            btnClients.Text = "Clientes";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnBookings
            // 
            btnBookings.Location = new Point(12, 194);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(182, 34);
            btnBookings.TabIndex = 4;
            btnBookings.Text = "Reservas";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBookings);
            Controls.Add(btnClients);
            Controls.Add(label1);
            Controls.Add(btnArticles);
            Margin = new Padding(2);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnArticles;
        private Label label1;
        private Button btnClients;
        private Button btnBookings;
    }
}
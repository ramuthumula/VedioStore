namespace VedioStore
{
    partial class CustomerRentals
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
            this.label1 = new System.Windows.Forms.Label();
            this.RentalsGridView = new System.Windows.Forms.DataGridView();
            this.ActiveCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(459, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Rentals";
            // 
            // RentalsGridView
            // 
            this.RentalsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentalsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalsGridView.Location = new System.Drawing.Point(12, 160);
            this.RentalsGridView.Name = "RentalsGridView";
            this.RentalsGridView.Size = new System.Drawing.Size(1016, 433);
            this.RentalsGridView.TabIndex = 1;
            this.RentalsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalsGridView_CellContentClick);
            // 
            // ActiveCustomer
            // 
            this.ActiveCustomer.FormattingEnabled = true;
            this.ActiveCustomer.Location = new System.Drawing.Point(429, 106);
            this.ActiveCustomer.Name = "ActiveCustomer";
            this.ActiveCustomer.Size = new System.Drawing.Size(213, 24);
            this.ActiveCustomer.TabIndex = 2;
            this.ActiveCustomer.SelectedIndexChanged += new System.EventHandler(this.ActiveCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter Customers";
            // 
            // CustomerRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActiveCustomer);
            this.Controls.Add(this.RentalsGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerRentals";
            this.Text = "CustomerRentals";
            this.Load += new System.EventHandler(this.CustomerRentals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentalsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RentalsGridView;
        private System.Windows.Forms.ComboBox ActiveCustomer;
        private System.Windows.Forms.Label label2;
    }
}
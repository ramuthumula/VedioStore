namespace VedioStore
{
    partial class TapeUI
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
            this.txtQuantityRented = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.Label();
            this.UpdateTape = new System.Windows.Forms.Button();
            this.RemoveTape = new System.Windows.Forms.Button();
            this.AddTape = new System.Windows.Forms.Button();
            this.ActiveTape = new System.Windows.Forms.ComboBox();
            this.txtQuantityAvailable = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTapeId = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.CustAddress = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.TapeId = new System.Windows.Forms.Label();
            this.TapeGridView = new System.Windows.Forms.DataGridView();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TapeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuantityRented
            // 
            this.txtQuantityRented.Location = new System.Drawing.Point(619, 163);
            this.txtQuantityRented.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityRented.Name = "txtQuantityRented";
            this.txtQuantityRented.Size = new System.Drawing.Size(191, 21);
            this.txtQuantityRented.TabIndex = 41;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip.Location = new System.Drawing.Point(497, 171);
            this.Zip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(98, 16);
            this.Zip.TabIndex = 40;
            this.Zip.Text = "Quantity Rented";
            // 
            // UpdateTape
            // 
            this.UpdateTape.AutoSize = true;
            this.UpdateTape.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateTape.Location = new System.Drawing.Point(569, 275);
            this.UpdateTape.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateTape.Name = "UpdateTape";
            this.UpdateTape.Size = new System.Drawing.Size(129, 26);
            this.UpdateTape.TabIndex = 37;
            this.UpdateTape.Text = "Update Tape Details";
            this.UpdateTape.UseVisualStyleBackColor = true;
            this.UpdateTape.Click += new System.EventHandler(this.UpdateTape_Click);
            // 
            // RemoveTape
            // 
            this.RemoveTape.Location = new System.Drawing.Point(204, 275);
            this.RemoveTape.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveTape.Name = "RemoveTape";
            this.RemoveTape.Size = new System.Drawing.Size(152, 28);
            this.RemoveTape.TabIndex = 36;
            this.RemoveTape.Text = "Remove Tape";
            this.RemoveTape.UseVisualStyleBackColor = true;
            this.RemoveTape.Click += new System.EventHandler(this.RemoveCustomer_Click);
            // 
            // AddTape
            // 
            this.AddTape.Location = new System.Drawing.Point(370, 213);
            this.AddTape.Margin = new System.Windows.Forms.Padding(4);
            this.AddTape.Name = "AddTape";
            this.AddTape.Size = new System.Drawing.Size(192, 28);
            this.AddTape.TabIndex = 35;
            this.AddTape.Text = "Add New Tape";
            this.AddTape.UseVisualStyleBackColor = true;
            this.AddTape.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // ActiveTape
            // 
            this.ActiveTape.FormattingEnabled = true;
            this.ActiveTape.Location = new System.Drawing.Point(386, 275);
            this.ActiveTape.Margin = new System.Windows.Forms.Padding(4);
            this.ActiveTape.Name = "ActiveTape";
            this.ActiveTape.Size = new System.Drawing.Size(140, 24);
            this.ActiveTape.TabIndex = 34;
            this.ActiveTape.SelectedIndexChanged += new System.EventHandler(this.ActiveTape_SelectedIndexChanged);
            // 
            // txtQuantityAvailable
            // 
            this.txtQuantityAvailable.Location = new System.Drawing.Point(619, 112);
            this.txtQuantityAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityAvailable.Name = "txtQuantityAvailable";
            this.txtQuantityAvailable.Size = new System.Drawing.Size(191, 21);
            this.txtQuantityAvailable.TabIndex = 33;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(193, 159);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(221, 21);
            this.txtCost.TabIndex = 31;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(193, 116);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(221, 21);
            this.txtTitle.TabIndex = 30;
            // 
            // txtTapeId
            // 
            this.txtTapeId.Location = new System.Drawing.Point(193, 65);
            this.txtTapeId.Margin = new System.Windows.Forms.Padding(4);
            this.txtTapeId.Name = "txtTapeId";
            this.txtTapeId.Size = new System.Drawing.Size(221, 21);
            this.txtTapeId.TabIndex = 29;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(497, 116);
            this.State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(110, 16);
            this.State.TabIndex = 28;
            this.State.Text = "Quantity Available";
            // 
            // CustAddress
            // 
            this.CustAddress.AutoSize = true;
            this.CustAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddress.Location = new System.Drawing.Point(118, 162);
            this.CustAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustAddress.Name = "CustAddress";
            this.CustAddress.Size = new System.Drawing.Size(31, 16);
            this.CustAddress.TabIndex = 27;
            this.CustAddress.Text = "Cost";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(118, 116);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 16);
            this.Title.TabIndex = 25;
            this.Title.Text = "Title";
            // 
            // TapeId
            // 
            this.TapeId.AutoSize = true;
            this.TapeId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapeId.Location = new System.Drawing.Point(118, 69);
            this.TapeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TapeId.Name = "TapeId";
            this.TapeId.Size = new System.Drawing.Size(49, 16);
            this.TapeId.TabIndex = 24;
            this.TapeId.Text = "Tape ID";
            // 
            // TapeGridView
            // 
            this.TapeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TapeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TapeGridView.Location = new System.Drawing.Point(23, 334);
            this.TapeGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TapeGridView.Name = "TapeGridView";
            this.TapeGridView.Size = new System.Drawing.Size(879, 271);
            this.TapeGridView.TabIndex = 23;
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(619, 65);
            this.txtRentalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(191, 21);
            this.txtRentalPrice.TabIndex = 43;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(499, 69);
            this.City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(71, 16);
            this.City.TabIndex = 42;
            this.City.Text = "Rental Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(410, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Manage Tapes";
            // 
            // TapeUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(922, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.City);
            this.Controls.Add(this.txtQuantityRented);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.UpdateTape);
            this.Controls.Add(this.RemoveTape);
            this.Controls.Add(this.AddTape);
            this.Controls.Add(this.ActiveTape);
            this.Controls.Add(this.txtQuantityAvailable);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtTapeId);
            this.Controls.Add(this.State);
            this.Controls.Add(this.CustAddress);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TapeId);
            this.Controls.Add(this.TapeGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TapeUI";
            this.Text = "Tapes";
            this.Load += new System.EventHandler(this.Tapes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TapeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantityRented;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Button UpdateTape;
        private System.Windows.Forms.Button RemoveTape;
        private System.Windows.Forms.Button AddTape;
        private System.Windows.Forms.ComboBox ActiveTape;
        private System.Windows.Forms.TextBox txtQuantityAvailable;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtTapeId;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label CustAddress;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TapeId;
        private System.Windows.Forms.DataGridView TapeGridView;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label label2;
    }
}
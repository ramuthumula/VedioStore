namespace VedioStore
{
    partial class ManageCustomers
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
            this.CustGridView = new System.Windows.Forms.DataGridView();
            this.CustId = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.CustAddress = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.ActiveCustomer = new System.Windows.Forms.ComboBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.RemoveCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberSince = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustGridView
            // 
            this.CustGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustGridView.Location = new System.Drawing.Point(13, 403);
            this.CustGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CustGridView.Name = "CustGridView";
            this.CustGridView.Size = new System.Drawing.Size(919, 292);
            this.CustGridView.TabIndex = 0;
            // 
            // CustId
            // 
            this.CustId.AutoSize = true;
            this.CustId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustId.Location = new System.Drawing.Point(156, 104);
            this.CustId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustId.Name = "CustId";
            this.CustId.Size = new System.Drawing.Size(72, 16);
            this.CustId.TabIndex = 1;
            this.CustId.Text = "Customer ID";
            // 
            // CustName
            // 
            this.CustName.AutoSize = true;
            this.CustName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.Location = new System.Drawing.Point(156, 151);
            this.CustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(40, 16);
            this.CustName.TabIndex = 2;
            this.CustName.Text = "Name";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(156, 242);
            this.City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(28, 16);
            this.City.TabIndex = 3;
            this.City.Text = "City";
            // 
            // CustAddress
            // 
            this.CustAddress.AutoSize = true;
            this.CustAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddress.Location = new System.Drawing.Point(156, 197);
            this.CustAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustAddress.Name = "CustAddress";
            this.CustAddress.Size = new System.Drawing.Size(48, 16);
            this.CustAddress.TabIndex = 4;
            this.CustAddress.Text = "Address";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(544, 104);
            this.State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(36, 16);
            this.State.TabIndex = 5;
            this.State.Text = "State";
            this.State.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(231, 100);
            this.txtCustId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(221, 21);
            this.txtCustId.TabIndex = 7;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(231, 151);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(221, 21);
            this.txtCustName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(231, 194);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(221, 21);
            this.txtAddress.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(231, 238);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(221, 21);
            this.txtCity.TabIndex = 10;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(639, 100);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(200, 21);
            this.txtState.TabIndex = 11;
            // 
            // ActiveCustomer
            // 
            this.ActiveCustomer.FormattingEnabled = true;
            this.ActiveCustomer.Location = new System.Drawing.Point(408, 353);
            this.ActiveCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.ActiveCustomer.Name = "ActiveCustomer";
            this.ActiveCustomer.Size = new System.Drawing.Size(140, 24);
            this.ActiveCustomer.TabIndex = 12;
            this.ActiveCustomer.SelectedIndexChanged += new System.EventHandler(this.ActiveCustomer_SelectedIndexChanged);
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(408, 297);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(192, 28);
            this.AddCustomer.TabIndex = 13;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // RemoveCustomer
            // 
            this.RemoveCustomer.Location = new System.Drawing.Point(218, 350);
            this.RemoveCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveCustomer.Name = "RemoveCustomer";
            this.RemoveCustomer.Size = new System.Drawing.Size(152, 28);
            this.RemoveCustomer.TabIndex = 14;
            this.RemoveCustomer.Text = "Remove Customer";
            this.RemoveCustomer.UseVisualStyleBackColor = true;
            this.RemoveCustomer.Click += new System.EventHandler(this.RemoveCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.Location = new System.Drawing.Point(587, 350);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(153, 28);
            this.UpdateCustomer.TabIndex = 15;
            this.UpdateCustomer.Text = "Update Details";
            this.UpdateCustomer.UseVisualStyleBackColor = true;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(639, 197);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 21);
            this.txtPhone.TabIndex = 17;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(544, 202);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(42, 16);
            this.Phone.TabIndex = 16;
            this.Phone.Text = "Phone";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(639, 151);
            this.txtZip.Margin = new System.Windows.Forms.Padding(4);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(200, 21);
            this.txtZip.TabIndex = 19;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip.Location = new System.Drawing.Point(544, 159);
            this.Zip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(23, 16);
            this.Zip.TabIndex = 18;
            this.Zip.Text = "Zip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Member Since";
            // 
            // MemberSince
            // 
            this.MemberSince.Location = new System.Drawing.Point(639, 247);
            this.MemberSince.Name = "MemberSince";
            this.MemberSince.Size = new System.Drawing.Size(200, 21);
            this.MemberSince.TabIndex = 22;
            this.MemberSince.Value = new System.DateTime(2022, 8, 1, 17, 27, 33, 0);
            this.MemberSince.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(428, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Manage Customers";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 705);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MemberSince);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.UpdateCustomer);
            this.Controls.Add(this.RemoveCustomer);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.ActiveCustomer);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.State);
            this.Controls.Add(this.CustAddress);
            this.Controls.Add(this.City);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.CustId);
            this.Controls.Add(this.CustGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageCustomers";
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustGridView;
        private System.Windows.Forms.Label CustId;
        private System.Windows.Forms.Label CustName;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label CustAddress;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.ComboBox ActiveCustomer;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Button RemoveCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker MemberSince;
        private System.Windows.Forms.Label label2;
    }
}
namespace VedioStore
{
    partial class RentVedio
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
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedCustomer = new System.Windows.Forms.ComboBox();
            this.SelectedTape = new System.Windows.Forms.ComboBox();
            this.RentalDate = new System.Windows.Forms.DateTimePicker();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Purchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Tape";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Customer";
            // 
            // SelectedCustomer
            // 
            this.SelectedCustomer.FormattingEnabled = true;
            this.SelectedCustomer.Location = new System.Drawing.Point(235, 104);
            this.SelectedCustomer.Name = "SelectedCustomer";
            this.SelectedCustomer.Size = new System.Drawing.Size(200, 24);
            this.SelectedCustomer.TabIndex = 2;
            // 
            // SelectedTape
            // 
            this.SelectedTape.FormattingEnabled = true;
            this.SelectedTape.Location = new System.Drawing.Point(658, 116);
            this.SelectedTape.Name = "SelectedTape";
            this.SelectedTape.Size = new System.Drawing.Size(200, 24);
            this.SelectedTape.TabIndex = 3;
            // 
            // RentalDate
            // 
            this.RentalDate.Location = new System.Drawing.Point(235, 200);
            this.RentalDate.Name = "RentalDate";
            this.RentalDate.Size = new System.Drawing.Size(200, 21);
            this.RentalDate.TabIndex = 4;
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(658, 200);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(200, 21);
            this.DueDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rental Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(480, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vedio Rental";
            // 
            // Purchase
            // 
            this.Purchase.BackColor = System.Drawing.Color.Red;
            this.Purchase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase.ForeColor = System.Drawing.SystemColors.Window;
            this.Purchase.Location = new System.Drawing.Point(502, 258);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(103, 35);
            this.Purchase.TabIndex = 9;
            this.Purchase.Text = "Buy";
            this.Purchase.UseVisualStyleBackColor = false;
            this.Purchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // RentVedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 650);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.RentalDate);
            this.Controls.Add(this.SelectedTape);
            this.Controls.Add(this.SelectedCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RentVedio";
            this.Text = "RentVedio";
            this.Load += new System.EventHandler(this.RentVedio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectedCustomer;
        private System.Windows.Forms.ComboBox SelectedTape;
        private System.Windows.Forms.DateTimePicker RentalDate;
        private System.Windows.Forms.DateTimePicker DueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Purchase;
    }
}
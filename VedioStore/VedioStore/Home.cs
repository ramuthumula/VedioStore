using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VedioStore
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            formload(new TapeUI());
        }

        public void formload(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            formload(new TapeUI());
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            formload(new ManageCustomers());
        }

        private void Rentals_Click(object sender, EventArgs e)
        {
            formload(new CustomerRentals());
        }

        private void RentVideos_Click(object sender, EventArgs e)
        {
            formload(new RentVedio());
        }
    }
}

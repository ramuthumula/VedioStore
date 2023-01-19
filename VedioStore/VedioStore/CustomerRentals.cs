using System;
using System.Collections.Generic;
using VedioStoreBussLayer;
using VedioStoreDataLayer;
using System.Data;
using System.Windows.Forms;

namespace VedioStore
{
    public partial class CustomerRentals : Form
    {
        public CustomerRentals()
        {
            InitializeComponent();
        }

        private void RentalsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActiveCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            RentalsBusinessLayer buss = new RentalsBusinessLayer();
            DataTable dt = buss.GridViewSoryByName(ActiveCustomer.Text.ToString());
            RentalsGridView.DataSource = dt;
        }

        private void CustomerRentals_Load(object sender, EventArgs e)
        {
            RentalsBusinessLayer buss = new RentalsBusinessLayer();
            List<string> list = buss.DropDown();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    ActiveCustomer.Items.Clear();
                }
                ActiveCustomer.Items.Add(list[i]);
            }
            DataTable dt = buss.GridView();
            RentalsGridView.DataSource = dt;
        }
    }
}

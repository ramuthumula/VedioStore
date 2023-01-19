using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using VedioStoreDataLayer;
using VedioStoreBussLayer;

namespace VedioStore
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customers data = new Customers
                {
                    CustId = Convert.ToInt32(txtCustId.Text),
                    CustName = txtCustName.Text,
                    CustAddress = txtAddress.Text,
                    City = txtCity.Text,
                    State = txtState.Text,
                    Zip = txtZip.Text,
                    Phone = txtPhone.Text,
                    MemberSince = MemberSince.Value
                };
                CustomersBussLayer buss = new CustomersBussLayer();
                buss.Insert(data);
                ManageCustomers_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                txtCustId.ReadOnly = false;
                CustomersBussLayer buss = new CustomersBussLayer();
                Customers data = new Customers
                {

                    CustId = Convert.ToInt32(txtCustId.Text),
                    CustName = txtCustName.Text,
                    CustAddress = txtAddress.Text,
                    City = txtCity.Text,
                    State = txtState.Text,
                    Zip = txtZip.Text,
                    Phone = txtPhone.Text,
                    MemberSince = MemberSince.Value
                };
                buss.Delete(data);
                ManageCustomers_Load(sender, e);
                txtCustId.Text = "";
                txtCustName.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                txtZip.Text = "";
                txtPhone.Text = "";
                MemberSince.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("you cannot delete this customer, since the customer has already taken some tapes for rent");
            }

        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            try { 
            CustomersBussLayer buss = new CustomersBussLayer();
            Customers data = new Customers
            {
                CustId = Convert.ToInt32(txtCustId.Text),
                CustName = txtCustName.Text,
                CustAddress = txtAddress.Text,
                City = txtCity.Text,
                State = txtState.Text,
                Zip = txtZip.Text,
                Phone = txtPhone.Text,
                MemberSince = MemberSince.Value
            };
            buss.Update(data);
            ManageCustomers_Load(sender, e);
            txtCustId.ReadOnly = false;
            txtCustId.Text = "";
            txtCustName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtPhone.Text = "";
            MemberSince.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


}

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            CustomersBussLayer cust = new CustomersBussLayer();
            List<string> list = cust.DropDown();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    ActiveCustomer.Items.Clear();
                }
                ActiveCustomer.Items.Add(list[i]);
            }
            DataTable dt = cust.GridView();
            CustGridView.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ActiveCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CustomersBussLayer buss = new CustomersBussLayer();
                List<string> list = buss.GetDetailsById(Convert.ToInt32(ActiveCustomer.Text.Split(' ')[0]));
                txtCustId.Text = list[0];
                txtCustName.Text = list[1];
                txtAddress.Text = list[2];
                txtCity.Text = list[3];
                txtState.Text = list[4];
                txtZip.Text = list[5];
                txtPhone.Text = list[6];
                MemberSince.Text = list[7];
                txtCustId.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using VedioStoreBussLayer;
using VedioStoreDataLayer;
using System.Drawing;

namespace VedioStore
{
    public partial class TapeUI : Form
    {
        public TapeUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VideosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tapes_Load(object sender, EventArgs e)
        {
            TapeBusinessLayer cust = new TapeBusinessLayer();
            List<string> list = cust.DropDown();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    ActiveTape.Items.Clear();
                }
                ActiveTape.Items.Add(list[i]);
            }
            DataTable dt = cust.GridView();
            TapeGridView.DataSource = dt;
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Tapes data = new Tapes
                {
                    TapeId = Convert.ToInt32(txtTapeId.Text),
                    Title = txtTitle.Text,
                    Cost = Convert.ToDouble(txtCost.Text),
                    RentalPrice = Convert.ToDouble(txtRentalPrice.Text),
                    QuantityAvailable = Convert.ToInt32(txtQuantityAvailable.Text),
                    QuantityRented = Convert.ToInt32(txtQuantityRented.Text)

                };
                TapeBusinessLayer buss = new TapeBusinessLayer();
                buss.Insert(data);
                Tapes_Load(sender, e);
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
                TapeBusinessLayer buss = new TapeBusinessLayer();
                Tapes data = new Tapes
                {
                    TapeId = Convert.ToInt32(txtTapeId.Text),
                    Title = txtTitle.Text,
                    Cost = Convert.ToDouble(txtCost.Text),
                    RentalPrice = Convert.ToDouble(txtRentalPrice.Text),
                    QuantityAvailable = Convert.ToInt32(txtQuantityAvailable.Text),
                    QuantityRented = Convert.ToInt32(txtQuantityRented.Text)

                };
                buss.Delete(data);
                Tapes_Load(sender, e);
                txtTapeId.ReadOnly = false;
                txtTapeId.Text = "";
                txtTitle.Text = "";
                txtCost.Text = "";
                txtRentalPrice.Text = "";
                txtQuantityAvailable.Text = "";
                txtQuantityRented.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("you cannot delete this customer, since the customer has already taken some tapes for rent");
            }
        }

        //private void UpdateCustomer_Click(object sender, EventArgs e)
        //{

        //}

        private void ActiveTape_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TapeBusinessLayer buss = new TapeBusinessLayer();
                List<string> list = buss.GetDetailsById(Convert.ToInt32(ActiveTape.Text.Split(' ')[0]));
                txtTapeId.Text = list[0];
                txtTitle.Text = list[1];
                txtCost.Text = list[2];
                txtRentalPrice.Text = list[3];
                txtQuantityAvailable.Text = list[4];
                txtQuantityRented.Text = list[5];
                txtTapeId.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTape_Click(object sender, EventArgs e)
        {
            try
            {
                TapeBusinessLayer buss = new TapeBusinessLayer();
                Tapes data = new Tapes
                {
                    TapeId = Convert.ToInt32(txtTapeId.Text),
                    Title = txtTitle.Text,
                    Cost = Convert.ToDouble(txtCost.Text),
                    RentalPrice = Convert.ToDouble(txtRentalPrice.Text),
                    QuantityAvailable = Convert.ToInt32(txtQuantityAvailable.Text),
                    QuantityRented = Convert.ToInt32(txtQuantityRented.Text)
                };
                buss.Update(data);
                Tapes_Load(sender, e);
                txtTapeId.ReadOnly = false;
                txtTapeId.Text = "";
                txtTitle.Text = "";
                txtCost.Text = "";
                txtRentalPrice.Text = "";
                txtQuantityAvailable.Text = "";
                txtQuantityRented.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

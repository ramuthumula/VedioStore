using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using VedioStoreBussLayer;

namespace VedioStore
{
    public partial class RentVedio : Form
    {
        public RentVedio()
        {
            InitializeComponent();
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            try
            {
                RentVedioBusinessLayer buss = new RentVedioBusinessLayer();
                buss.RentVedio(Convert.ToInt32(SelectedCustomer.Text.Split(' ')[0]), Convert.ToInt32(SelectedTape.Text.Split(' ')[0]), RentalDate.Value, DueDate.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RentVedio_Load(object sender, EventArgs e)
        {
            
           
            RentVedioBusinessLayer buss = new RentVedioBusinessLayer();
            List<string> Cust = buss.LoadCustomers();
            for (int i = 0; i < Cust.Count; i++)
            {
                if (i == 0)
                {
                    SelectedCustomer.Items.Clear();
                }
                SelectedCustomer.Items.Add(Cust[i]);
            }
            List<string> Tapes = buss.LoadTapes();
            for (int i = 0; i < Tapes.Count; i++)
            {
                if (i == 0)
                {
                    SelectedTape.Items.Clear();
                }
                SelectedTape.Items.Add(Tapes[i]);
            }
            
        }
    }
}

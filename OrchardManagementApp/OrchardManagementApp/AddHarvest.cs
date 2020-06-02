using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrchardManagementApp
{
    public partial class AddHarvest : Form
    {
        private string ConnectionString = "Server = localhost; Port = 3306; Database = orchardmanagement; Uid = root; Pwd = ;";  //CHANGE PORT IF NEEDED
        int section_id;

        public AddHarvest(int sectionid)
        {
            InitializeComponent();
            section_id = sectionid;
        }

        private void addSectionToDB(Harvest harvest)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = $"INSERT INTO harvests(section_id,kg_harvested,date,pricekg,totalincome,comment) VALUES(@id,@kgharvested,@date,@pricekg,@totalincome,@comment)";
            comm.Parameters.AddWithValue("@id", section_id);
            comm.Parameters.AddWithValue("@kgharvested", harvest.Kg_Harvested);
            comm.Parameters.AddWithValue("@date", harvest.Date);
            comm.Parameters.AddWithValue("@pricekg", harvest.PriceKg);
            comm.Parameters.AddWithValue("@totalincome", harvest.TotalIncome);
            comm.Parameters.AddWithValue("@comment", harvest.Comment);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void btnAddHarvest_Click(object sender, EventArgs e)
        {
            Harvest harvest = new Harvest();
            //check for valid inputs
            if (txtKgHarvested.Text != "")
            {
                try
                {
                    harvest.Kg_Harvested = Convert.ToInt32(txtKgHarvested.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a valid Number (Kg Harvested)!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Number (Kg Harvested)!");
                return;
            }

            if (txtPricePerKg.Text != "")
            {
                try
                {
                    harvest.PriceKg = Convert.ToDouble(txtPricePerKg.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a valid Number (Price Per Kg)!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Number (Total Income)!");
                return;
            }
            if (txtTotalIncome.Text != "")
            {
                try
                {
                    harvest.TotalIncome = Convert.ToDouble(txtTotalIncome.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a valid Number (Total Income)!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Number (Total Income)!");
                return;
            }
            harvest.Date = dtpHarvest.Value.ToString("yyyy-MM-dd");        //check date format later
            harvest.Comment = txtComment.Text;
            addSectionToDB(harvest);
            //back to main page
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

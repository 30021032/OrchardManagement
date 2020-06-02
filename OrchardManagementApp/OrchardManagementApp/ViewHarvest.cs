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
    public partial class ViewHarvest : Form
    {
        int HarvestID;
        private string ConnectionString = "Server = localhost; Port = 3306; Database = orchardmanagement; Uid = root; Pwd = ;";  //CHANGE PORT IF NEEDED

        public ViewHarvest(int id)
        {
            HarvestID = id;
            InitializeComponent();
            loadHarvest();
        }

        private void loadHarvest()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT kg_harvested, date, pricekg, totalincome, comment FROM harvests WHERE harvest_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", HarvestID);
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);
                        txtKgHarvested.Text = table.Rows[0][0].ToString();

                        string[] time = table.Rows[0][1].ToString().Split('/');
                        time[2] = time[2].Split()[0];
                        dtpHarvest.Value = new DateTime(Convert.ToInt32(time[2]), Convert.ToInt32(time[1]), Convert.ToInt32(time[0]));

                        txtPricePerKg.Text = table.Rows[0][2].ToString();

                        txtTotalIncome.Text = table.Rows[0][3].ToString();

                        txtComment.Text = table.Rows[0][4].ToString();
                        da.Dispose();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                txtKgHarvested.Enabled = true;
                dtpHarvest.Enabled = true;
                txtPricePerKg.Enabled = true;
                txtTotalIncome.Enabled = true;
                txtComment.Enabled = true;
                btnEdit.Text = "Save";
                btnCancel.Visible = true;
            }
            else
            {
                txtKgHarvested.Enabled = false;
                dtpHarvest.Enabled = false;
                txtPricePerKg.Enabled = false;
                txtTotalIncome.Enabled = false;
                txtComment.Enabled = false;
                btnEdit.Text = "Edit";
                btnCancel.Visible = false;
                saveHarvest();
            }
        }

        private void saveHarvest()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"UPDATE harvests SET kg_harvested=@kgharvested, date=@date, pricekg=@pricekg, totalincome=@totalincome, comment=@comment WHERE harvest_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@kgharvested", txtKgHarvested.Text);
                    cmd.Parameters.AddWithValue("@date", dtpHarvest.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@pricekg", txtPricePerKg.Text);
                    cmd.Parameters.AddWithValue("@totalincome", txtTotalIncome.Text);
                    cmd.Parameters.AddWithValue("@comment", txtComment.Text);
                    cmd.Parameters.AddWithValue("@id", HarvestID);
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);
                        da.Dispose();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtKgHarvested.Enabled = false;
            dtpHarvest.Enabled = false;
            txtPricePerKg.Enabled = false;
            txtTotalIncome.Enabled = false;
            txtComment.Enabled = false;
            loadHarvest();
            btnEdit.Text = "Edit";
            btnCancel.Visible = false;
        }
    }
}

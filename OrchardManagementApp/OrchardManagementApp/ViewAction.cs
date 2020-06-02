using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrchardManagementApp
{
    public partial class ViewAction : Form
    {
        int ActionID;
        private string ConnectionString = "Server = localhost; Port = 3306; Database = orchardmanagement; Uid = root; Pwd = ;";  //CHANGE PORT IF NEEDED

        public ViewAction(int id)
        {
            InitializeComponent();
            ActionID = id;
            loadAction();
        }

        private void loadAction()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT action_type, date, hours_invested, comment FROM actions WHERE action_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", ActionID);
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);
                        txtActionType.Text = table.Rows[0][0].ToString();
                        string[] time = table.Rows[0][1].ToString().Split('/');
                        time[2] = time[2].Split()[0];
                        dtpAction.Value = new DateTime(Convert.ToInt32(time[2]), Convert.ToInt32(time[1]), Convert.ToInt32(time[0]));
                        txtHoursInvested.Text = table.Rows[0][2].ToString();
                        txtComment.Text = table.Rows[0][3].ToString();
                        da.Dispose();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                txtActionType.Enabled = true;
                txtComment.Enabled = true;
                txtHoursInvested.Enabled = true;
                dtpAction.Enabled = true;
                btnEdit.Text = "Save";
                btnCancel.Visible = true;
            } else
            {
                txtActionType.Enabled = false;
                txtComment.Enabled = false;
                txtHoursInvested.Enabled = false;
                dtpAction.Enabled = false;
                btnEdit.Text = "Edit";
                btnCancel.Visible = false;
                saveAction();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtActionType.Enabled = false;
            txtComment.Enabled = false;
            txtHoursInvested.Enabled = false;
            dtpAction.Enabled = false;
            loadAction();
            btnEdit.Text = "Edit";
            btnCancel.Visible = false;
        }

        private void saveAction()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"UPDATE actions SET action_type=@type, date=@date, hours_invested=@hours_invested,comment=@comment WHERE action_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@type", txtActionType.Text);
                    cmd.Parameters.AddWithValue("@date", dtpAction.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@hours_invested", txtHoursInvested.Text);
                    cmd.Parameters.AddWithValue("@comment", txtComment.Text);
                    cmd.Parameters.AddWithValue("@id", ActionID);
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
    }
}

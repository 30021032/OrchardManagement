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
    public partial class AddAction : Form
    {
        private string ConnectionString = "Server = localhost; Port = 3306; Database = orchardmanagement; Uid = root; Pwd = ;";  //CHANGE PORT IF NEEDED
        int section_id;

        public AddAction(int id)
        {
            InitializeComponent();
            section_id = id;
        }

        private void addActionToDB(Action action)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = $"INSERT INTO actions(section_id, action_type, date, hours_invested, comment) VALUES(@id,@actiontype,@date,@hoursinvested,@comment)";
            comm.Parameters.AddWithValue("@id", section_id);
            comm.Parameters.AddWithValue("@actiontype", action.ActionType);
            comm.Parameters.AddWithValue("@date", action.Date);
            comm.Parameters.AddWithValue("@hoursinvested", action.HoursInvested);
            comm.Parameters.AddWithValue("@comment", action.Comment);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Action action = new Action();
            //check for valid inputs
            if (txtActionType.Text != "")
            {
                action.ActionType = txtActionType.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid Name!");
                return;
            }
            if (txtHoursInvested.Text != "")
            {
                try
                {
                    action.HoursInvested = Convert.ToInt32(txtHoursInvested.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a valid Number!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Number!");
                return;
            }
            if (txtComment.Text != "")
            {
                action.Comment = txtComment.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid Comment!");
                return;
            }
            action.Date = dtpAction.Value.ToString("yyyy-MM-dd");        //check date format later
            addActionToDB(action);
            //back to main page
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

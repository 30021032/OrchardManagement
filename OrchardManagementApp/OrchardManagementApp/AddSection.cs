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
    public partial class AddSection : Form
    {
        private string ConnectionString = "Server = localhost; Port = 3306; Database = orchardmanagement; Uid = root; Pwd = ;";  //CHANGE PORT IF NEEDED
        int orchard_id;

        public AddSection(int orchardID)
        {
            InitializeComponent();
            orchard_id = orchardID;
        }

        private void addSectionToDB(Section section)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = $"INSERT INTO sections(orchard_id,name,tree_type,size,date_planted,comment) VALUES(@id,@name,@treetype,@size,@date,@comment)";
            comm.Parameters.AddWithValue("@id", orchard_id);
            comm.Parameters.AddWithValue("@name", section.Name);
            comm.Parameters.AddWithValue("@treetype", section.TreeType);
            comm.Parameters.AddWithValue("@size", section.Size);
            comm.Parameters.AddWithValue("@date", section.DatePlanted);
            comm.Parameters.AddWithValue("@comment", section.Comment);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            //check for valid inputs
            if (txtName.Text != "")
            {
                section.Name = txtName.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid Name!");
                return;
            }
            if (txtType.Text != "")
            {
                section.TreeType = txtType.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid Type!");
                return;
            }
            if (txtSize.Text != "")
            {
                try
                {
                    section.Size = Convert.ToDouble(txtSize.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a valid Number!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Size!");
                return;
            }
            section.DatePlanted = datePlanted.Value.ToString("yyyy-MM-dd");        //check date format later
            section.Comment = txtComments.Text;
            addSectionToDB(section);
            //back to main page
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

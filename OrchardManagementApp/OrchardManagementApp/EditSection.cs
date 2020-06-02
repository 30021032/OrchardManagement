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
    public partial class EditSection : Form
    {
        int SectionID;
        private string ConnectionString = "Server = localhost; Port = 3306; Database = orchardmanagement; Uid = root; Pwd = ;";  //CHANGE PORT IF NEEDED

        public EditSection(int section_id)
        {
            SectionID = section_id;
            InitializeComponent();
            loadSection();
        }

        private void loadSection()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT name, tree_type, size, date_planted, comment FROM sections WHERE section_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", SectionID);
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);
                        txtName.Text = table.Rows[0][0].ToString();

                        txtTreeType.Text = table.Rows[0][1].ToString();

                        txtSize.Text = table.Rows[0][2].ToString();

                        string[] time = table.Rows[0][3].ToString().Split('/');
                        time[2] = time[2].Split()[0];
                        dtpDatePlanted.Value = new DateTime(Convert.ToInt32(time[2]), Convert.ToInt32(time[1]), Convert.ToInt32(time[0]));

                        txtComment.Text = table.Rows[0][4].ToString();
                        da.Dispose();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveSection();
            this.Close();
        }

        private void saveSection()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"UPDATE sections SET name=@name, tree_type=@tree_type, size=@size, date_planted=@date_planted, comment=@comment WHERE section_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@tree_type", txtTreeType.Text);
                    cmd.Parameters.AddWithValue("@size", txtSize.Text);
                    cmd.Parameters.AddWithValue("@date_planted", dtpDatePlanted.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@comment", txtComment.Text);
                    cmd.Parameters.AddWithValue("@id", SectionID);
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
            this.Close();
        }
    }
}

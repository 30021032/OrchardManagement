using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrchardManagementApp
{
    public partial class frmOrchardManagement : Form
    {
        private string ConnectionString = "Server = localhost; Port = 3306; Database = orchardmanagement; Uid = root; Pwd = ;";  //CHANGE PORT IF NEEDED
        private MySqlConnection connect;
        int panelControl = 0;
        private int orchardID = 1; //dynamic from login
        private bool sectionEditMode = false;
        private int currentSection = 0;

        public frmOrchardManagement()
        {
            InitializeComponent();
            showLogin();
        }

        public void changeFormSize(int width, int height)
        {
            pnlLogin.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            pnlMainPage.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            this.ClientSize = new Size(width, height);
            pnlLogin.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            pnlMainPage.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
        }
        private bool db_connection()
        {
            try
            {
                connect = new MySqlConnection(ConnectionString);
                connect.Open();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
        private void MainPage_Activated(object sender, System.EventArgs e)
        {
            if (pnlMainPage.Visible == true)
            {
                loadSections(sectionEditMode);
            }
            else if (pnlActions.Visible == true)
            {
                loadActions();
            }
            else if (pnlHarvests.Visible == true)
            {
                loadHarvests();
            }
        }

        //Panel Controllers
        public void hideAllPanels()
        {
            //add all panels
            pnlLogin.Visible = false;
            pnlMainPage.Visible = false;
            pnlActions.Visible = false;
            pnlHarvests.Visible = false;
        }
        public void showLogin()
        {
            //login size is 500,300
            hideAllPanels();
            changeFormSize(500, 300);
            pnlLogin.Visible = true;
        }
        public void showMainPage()
        {
            //Main Page size is 784, 661
            hideAllPanels();
            changeFormSize(784, 661);
            populateMainPage();
            pnlMainPage.Visible = true;
        }
        public void showActions(int section)
        {
            currentSection = section;
            hideAllPanels();
            populateActionsPage();
            pnlActions.Visible = true;
        }
        public void showHarvests(int section)
        {
            currentSection = section;
            hideAllPanels();
            populateHarvestsPage();
            pnlHarvests.Visible = true;
        }

        //Login Page
        private bool validate_login(string user, string pass)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = $"SELECT * FROM orchards WHERE username=@user AND password=@password";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.HasRows)
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtLoginUsername.Text;
            string pass = txtLoginPassword.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected! Please fill in all the fields and try again.");
            } else
            {
                if (db_connection() is true)
                {
                    bool login = validate_login(user, pass);
                    if (login)
                    {
                        showMainPage();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Login Credentials");
                    }
                }
                else
                {
                    MessageBox.Show("There has been an issue connecting to the database, please check your internet!");
                }
            }
        }

        //Main Page
        private void populateMainPage()
        {
            //poulate main page
            loadMap(orchardID);
            loadSections(false);
        }
        private void btnMainPageAddSection_Click(object sender, EventArgs e)
        {
            //add section
            AddSection ad = new AddSection(orchardID);
            ad.Show();
        }
        private void btnMainPageChangeMap_Click(object sender, EventArgs e)
        {
            //change map
            string imagePath;
            try
            {
                OpenFileDialog openNewMainMap = new OpenFileDialog();
                openNewMainMap.Filter = "Image files | *.jpg";
                if (openNewMainMap.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openNewMainMap.FileName;
                    picMainPageMap.Image = Image.FromFile(openNewMainMap.FileName);
                    //save the image
                    saveMap(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnMainPageEditSections_Click(object sender, EventArgs e)
        {
            //show edit sections buttons
            if (btnMainPageEditSections.Text == "Edit Sections")
            {
                sectionEditMode = true;
                btnMainPageEditSections.Text = "Finish Editing";
            } else
            {
                sectionEditMode = false;
                btnMainPageEditSections.Text = "Edit Sections";
            }
            loadSections(sectionEditMode);
        }
        private void saveMap(string imagePath)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;
            FileStream fs;
            BinaryReader br;
            try
            {
                byte[] ImageData;
                fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                string CmdString = $"UPDATE orchards SET map=@Image WHERE orchard_id=@id";
                cmd = new MySqlCommand(CmdString, con);
                cmd.Parameters.AddWithValue("@id", orchardID);
                cmd.Parameters.Add("@Image", MySqlDbType.Blob);
                cmd.Parameters["@Image"].Value = ImageData;
                con.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Image saved sucessfully!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void loadMap(int id)
        {
            //load map from database
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT map FROM orchards WHERE orchard_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        try
                        {
                            DataTable table = new DataTable();
                            da.Fill(table);
                            byte[] img = (byte[])table.Rows[0][0];
                            MemoryStream ms = new MemoryStream(img);
                            picMainPageMap.Image = Image.FromStream(ms);
                            da.Dispose();
                        }
                        catch
                        {
                            MessageBox.Show("No Image!");
                        }
                    }
                }
            }
        }
        private void loadSections(bool editMode)
        {
            clearPnlMainPageSections();
            panelControl = 0;
            //pnlMainPageSections.
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT section_id, name, tree_type, size, date_planted FROM sections WHERE orchard_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", orchardID);
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataSet dt = new DataSet()) //dataset
                        {
                            sda.Fill(dt);
                            foreach (DataTable table in dt.Tables)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    Section section = new Section(Convert.ToInt32(row["section_id"]), row["name"].ToString(), row["tree_type"].ToString(), Convert.ToDouble(row["size"]), row["date_planted"].ToString());
                                    createSection(section, editMode);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void clearPnlMainPageSections()
        {
            List<Control> panels = new List<Control>();
            foreach (Control item in pnlMainPageSections.Controls.OfType<Panel>())
            {
                panels.Add(item);
            }
            foreach (Control item in panels)
            {
                pnlMainPageSections.Controls.Remove(item);
            }
        }
        private void createSection(Section section, bool editMode)
        {
            //int id, string name, string treetype, double size, string date
            panelControl += 1;
            Panel p1 = new Panel();
            this.Controls.Add(p1);
            p1.Parent = pnlMainPageSections;
            p1.Top = (panelControl - 1) * 52;
            p1.Height = 40;
            p1.Width = pnlMainPageSections.Width;
            p1.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            p1.Name = "Panel" + section.SectionID;

            //name label
            Label lblname = new Label();
            this.Controls.Add(lblname);
            lblname.Parent = p1;
            lblname.Top = 9;
            lblname.Left = 20;
            lblname.Text = section.Name;
            lblname.Font = new Font(lblname.Font.Name, 12);
            lblname.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            lblname.AutoSize = true;

            //treeType label
            Label lbltreeType = new Label();
            this.Controls.Add(lbltreeType);
            lbltreeType.Parent = p1;
            lbltreeType.Top = 14;
            if (lblname.Width < 150)
                lbltreeType.Left = 200;
            else
                lbltreeType.Left = 50 + lblname.Width;
            lbltreeType.Text = section.TreeType;
            lbltreeType.Anchor = (AnchorStyles.Left | AnchorStyles.Top);

            //Size label
            Label lblSize = new Label();
            this.Controls.Add(lblSize);
            lblSize.Parent = p1;
            lblSize.Top = 14;
            lblSize.Left = p1.Width - 400;
            lblSize.Text = section.Size.ToString() + " ha";
            lblSize.Anchor = (AnchorStyles.Right | AnchorStyles.Top);

            //Date label
            Label lblDate = new Label();
            this.Controls.Add(lblDate);
            lblDate.Parent = p1;
            lblDate.Top = 14;
            lblDate.Left = p1.Width - 300;
            lblDate.Text = section.DatePlanted;
            lblDate.Anchor = (AnchorStyles.Right | AnchorStyles.Top);

            if (editMode == false)
            {
                //Action button
                Button btnAction = new Button();
                this.Controls.Add(btnAction);
                btnAction.Parent = p1;
                btnAction.Text = "Actions";
                btnAction.Top = 9;
                btnAction.Left = p1.Width - 200;
                btnAction.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
                btnAction.Name = "btn" + (section.SectionID).ToString();
                btnAction.Click += new EventHandler(this.section_action_click);

                //Harvest button
                Button btnHarvest = new Button();
                this.Controls.Add(btnHarvest);
                btnHarvest.Parent = p1;
                btnHarvest.Text = "Harvests";
                btnHarvest.Top = 9;
                btnHarvest.Left = p1.Width - 100;
                btnHarvest.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
                btnHarvest.Name = "btn" + (section.SectionID).ToString();
                btnHarvest.Click += new EventHandler(this.section_harvest_click);
            } else
            {
                //edit section
                Button btnHarvest = new Button();
                this.Controls.Add(btnHarvest);
                btnHarvest.Parent = p1;
                btnHarvest.Text = "Edit Section";
                btnHarvest.Top = 9;
                btnHarvest.Left = p1.Width - 100;
                btnHarvest.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
                btnHarvest.Name = "btn" + (section.SectionID).ToString();
                btnHarvest.Click += new EventHandler(this.section_edit_click);
            }
        }
        private void section_action_click(object sender, EventArgs e)
        {
            //get the button clicked
            Button btn = sender as Button;
            int id = Convert.ToInt32(Regex.Match(btn.Name, @"\d+").Value);
            //show actions
            showActions(id);
        }
        private void section_harvest_click(object sender, EventArgs e)
        {
            //get the button clicked
            Button btn = sender as Button;
            int id = Convert.ToInt32(Regex.Match(btn.Name, @"\d+").Value);
            //show harvests
            showHarvests(id);
        }
        private void section_edit_click(object sender, EventArgs e)
        {
            //get the button clicked
            Button btn = sender as Button;
            int id = Convert.ToInt32(Regex.Match(btn.Name, @"\d+").Value);
            //show edit section
            EditSection es = new EditSection(id);
            es.Show();

        }

        //Actions Page
        private void populateActionsPage()
        {
            loadActions();
        }
        private void loadActions()
        {
            clearPnlActions();
            panelControl = 0;
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT action_id, action_type, date, hours_invested FROM actions WHERE section_id=@currentsection", con))
                {
                    cmd.Parameters.AddWithValue("@currentsection", currentSection);
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataSet dt = new DataSet()) //dataset
                        {
                            //if empty -> displayActionMessage("No Actions Recorded Yet!");
                            sda.Fill(dt);
                            foreach (DataTable table in dt.Tables)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    Action action = new Action(Convert.ToInt32(row["action_id"]), row["action_type"].ToString(), row["date"].ToString(), Convert.ToInt32(row["hours_invested"]));
                                    createAction(action);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void createAction(Action action)
        {
            //int id, string action_type, string date, int hours_invested
            panelControl += 1;
            Panel p1 = new Panel();
            this.Controls.Add(p1);
            p1.Parent = pnlActionContent;
            p1.Top = (panelControl - 1) * 52;
            p1.Height = 40;
            p1.Width = pnlActionContent.Width;
            p1.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            p1.Name = "ActionPanel" + action.ActionID;

            //action_type label
            Label lblActionType = new Label();
            this.Controls.Add(lblActionType);
            lblActionType.Parent = p1;
            lblActionType.Top = 9;
            lblActionType.Left = 20;
            lblActionType.Text = action.ActionType;
            lblActionType.Font = new Font(lblActionType.Font.Name, 12);
            lblActionType.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            lblActionType.AutoSize = true;

            //date label
            Label lblDate = new Label();
            this.Controls.Add(lblDate);
            lblDate.Parent = p1;
            lblDate.Top = 14;
            if (lblActionType.Width < 150)
                lblDate.Left = 200;
            else
                lblDate.Left = 50 + lblActionType.Width;
            lblDate.Text = action.Date;
            lblDate.Anchor = (AnchorStyles.Left | AnchorStyles.Top);

            //hours_invested label
            Label lblHoursInvested = new Label();
            this.Controls.Add(lblHoursInvested);
            lblHoursInvested.Parent = p1;
            lblHoursInvested.Top = 14;
            lblHoursInvested.Left = p1.Width - 400;
            lblHoursInvested.Text = action.HoursInvested.ToString() + " hours";
            lblHoursInvested.Anchor = (AnchorStyles.Right | AnchorStyles.Top);

            //View button
            Button btnViewAction = new Button();
            this.Controls.Add(btnViewAction);
            btnViewAction.Parent = p1;
            btnViewAction.Text = "View";
            btnViewAction.Top = 9;
            btnViewAction.Left = p1.Width - 200;
            btnViewAction.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
            btnViewAction.Name = "btnViewAction" + (action.ActionID).ToString();
            btnViewAction.Click += new EventHandler(this.view_action_click);
        }
        private void displayActionMessage(string message)
        {
            //int id, string action_type, string date, int hours_invested
            panelControl += 1;
            Panel p1 = new Panel();
            this.Controls.Add(p1);
            p1.Parent = pnlActionContent;
            p1.Top = (panelControl - 1) * 52;
            p1.Height = 40;
            p1.Width = pnlActionContent.Width;
            p1.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            p1.Name = "ActionPanel";

            //action_type label
            Label lblActionMessage = new Label();
            this.Controls.Add(lblActionMessage);
            lblActionMessage.Parent = p1;
            lblActionMessage.Top = 9;
            lblActionMessage.Left = 20;
            lblActionMessage.Text = message;
            lblActionMessage.Font = new Font(lblActionMessage.Font.Name, 12);
            lblActionMessage.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            lblActionMessage.AutoSize = true;
        }
        private void view_action_click(object sender, EventArgs e)
        {
            //get the button clicked
            Button btn = sender as Button;
            int id = Convert.ToInt32(Regex.Match(btn.Name, @"\d+").Value);
            //show single Action
            ViewAction va = new ViewAction(id);
            va.Show();
        }
        private void clearPnlActions()
        {
            List<Control> panels = new List<Control>();
            foreach (Control item in pnlActionContent.Controls.OfType<Panel>())
            {
                panels.Add(item);
            }
            foreach (Control item in panels)
            {
                pnlActionContent.Controls.Remove(item);
            }
        }
        private void btnActionsAddAction_Click(object sender, EventArgs e)
        {
            AddAction aa = new AddAction(currentSection);
            aa.Show();
        }
        private void btnActionsBack_Click(object sender, EventArgs e)
        {
            showMainPage();
        }

        //Harvests Page
        private void populateHarvestsPage()
        {
            loadHarvests();
        }
        private void loadHarvests()
        {
            clearPnlHarvests();
            panelControl = 0;
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT harvest_id, kg_harvested, date, pricekg, totalincome, comment FROM harvests WHERE section_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", currentSection);
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataSet dt = new DataSet()) //dataset
                        {
                            //if empty -> displayActionMessage("No Actions Recorded Yet!");
                            sda.Fill(dt);
                            foreach (DataTable table in dt.Tables)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    Harvest harvest = new Harvest(Convert.ToInt32(row["harvest_id"]), Convert.ToInt32(row["kg_harvested"]), row["date"].ToString(), Convert.ToDouble(row["pricekg"]), Convert.ToDouble(row["totalincome"]), row["comment"].ToString());
                                    createHarvest(harvest);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void createHarvest(Harvest harvest)
        {
            panelControl += 1;
            Panel p1 = new Panel();
            this.Controls.Add(p1);
            p1.Parent = pnlHarvestsContent;
            p1.Top = (panelControl - 1) * 52;
            p1.Height = 40;
            p1.Width = pnlHarvestsContent.Width;
            p1.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            p1.Name = "HarvestPanel" + harvest.HarvestID;

            //date label
            Label lblDate = new Label();
            this.Controls.Add(lblDate);
            lblDate.Parent = p1;
            lblDate.Top = 9;
            lblDate.Left = 20;
            lblDate.Text = harvest.Date;
            lblDate.Font = new Font(lblDate.Font.Name, 12);
            lblDate.Anchor = (AnchorStyles.Left | AnchorStyles.Top);

            //kg_harvested label label
            Label lblKgHarvested = new Label();
            this.Controls.Add(lblKgHarvested);
            lblKgHarvested.Parent = p1;
            lblKgHarvested.Top = 14;
            lblKgHarvested.Left = 200;
            lblKgHarvested.Text = harvest.Kg_Harvested.ToString() + " Kg";
            lblKgHarvested.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            lblKgHarvested.AutoSize = true;

            //price per kg label
            Label lblPriceKg = new Label();
            this.Controls.Add(lblPriceKg);
            lblPriceKg.Parent = p1;
            lblPriceKg.Top = 14;
            lblPriceKg.Left = 250;
            lblPriceKg.Text = "$" + harvest.PriceKg.ToString() + " Per Kg";
            lblPriceKg.Anchor = (AnchorStyles.Right | AnchorStyles.Top);

            //total income label
            Label lblTotalIncome = new Label();
            this.Controls.Add(lblTotalIncome);
            lblTotalIncome.Parent = p1;
            lblTotalIncome.Top = 14;
            lblTotalIncome.Left = 350;
            lblTotalIncome.Text = "$" + harvest.TotalIncome.ToString() + " Total";
            lblTotalIncome.Anchor = (AnchorStyles.Right | AnchorStyles.Top);

            //View button
            Button btnViewHarvest = new Button();
            this.Controls.Add(btnViewHarvest);
            btnViewHarvest.Parent = p1;
            btnViewHarvest.Text = "View";
            btnViewHarvest.Top = 9;
            btnViewHarvest.Left = p1.Width - 100;
            btnViewHarvest.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
            btnViewHarvest.Name = "btnViewAction" + (harvest.HarvestID).ToString();
            btnViewHarvest.Click += new EventHandler(this.view_harvest_click);
        }
        private void clearPnlHarvests()
        {
            List<Control> panels = new List<Control>();
            foreach (Control item in pnlHarvestsContent.Controls.OfType<Panel>())
            {
                panels.Add(item);
            }
            foreach (Control item in panels)
            {
                pnlHarvestsContent.Controls.Remove(item);
            }
        }
        private void view_harvest_click(object sender, EventArgs e)
        {
            //get the button clicked
            Button btn = sender as Button;
            int id = Convert.ToInt32(Regex.Match(btn.Name, @"\d+").Value);
            //show single Action
            ViewHarvest vh = new ViewHarvest(id);
            vh.Show();
        }
        private void displayHarvestMessage(string message)
        {
            panelControl += 1;
            Panel p1 = new Panel();
            this.Controls.Add(p1);
            p1.Parent = pnlHarvestsContent;
            p1.Top = (panelControl - 1) * 52;
            p1.Height = 40;
            p1.Width = pnlHarvestsContent.Width;
            p1.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            p1.Name = "ActionPanel";

            //action_type label
            Label lblHarvestMessage = new Label();
            this.Controls.Add(lblHarvestMessage);
            lblHarvestMessage.Parent = p1;
            lblHarvestMessage.Top = 9;
            lblHarvestMessage.Left = 20;
            lblHarvestMessage.Text = message;
            lblHarvestMessage.Font = new Font(lblHarvestMessage.Font.Name, 12);
            lblHarvestMessage.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            lblHarvestMessage.AutoSize = true;
        }
        private void btnHarvestsAddHarvests_Click(object sender, EventArgs e)
        {
            AddHarvest ah = new AddHarvest(currentSection);
            ah.Show();
        }
        private void btnHarvestsBack_Click(object sender, EventArgs e)
        {
            showMainPage();
        }
    }
}

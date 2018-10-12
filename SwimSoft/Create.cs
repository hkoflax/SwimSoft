using PoolLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimSoft
{
    public partial class Create : Form
    {
        private Welcome welcome = null;
        public Create()
        {
            InitializeComponent();
        }
        public Create(Form aForm)
        {
            welcome = aForm as Welcome;
            InitializeComponent();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region create Swimmer
            if (btnCreate.Text == "Create Swimmer")
            {
                long tel = 0;
                if (txtName.Text == "")
                {
                    MessageBox.Show("Enter a valid Name");
                }
                else if (txtStreetLine.Text == "" && txtCity.Text == "" && txtState.Text == "" && txtZipCode.Text == "")
                {
                    MessageBox.Show("Enter a complete Address");
                }
                else if (long.TryParse(txtTel.Text, out tel) == false)
                {
                    MessageBox.Show("Enter a valid Telephone Number");
                }
                else
                {
                    var name = txtName.Text;
                    var doB = dtpDOB.Value;
                    var adress = new Address(txtStreetLine.Text, txtCity.Text, txtState.Text, txtZipCode.Text);
                    Swimmer aSwimmer = new Swimmer(name, doB, adress, tel);
                    welcome.SwimmersList.Add(aSwimmer);
                    welcome.myManager.Add(aSwimmer);

                    welcome.lbSwimmerList.DataSource = null;
                    welcome.lbSwimmerList.DataSource = welcome.SwimmersList;
                    welcome.lbSwimmerList.DisplayMember = "Name";
                    
                    MessageBox.Show("Swimmer " + txtName.Text + " Created");
                    if (welcome.lbSwimmerList.Items.Count > 0)
                    {
                        welcome.lbSwimmerList.Visible = true;
                        welcome.lblSwimmerList.Visible = true;
                        welcome.lbSwimmerList.Height = (welcome.lbSwimmerList.Items.Count + 1) * welcome.lbSwimmerList.ItemHeight;
                    }
                    this.Close();
                }
            }
            #endregion
            #region create Coach
            if (btnCreate.Text == "Create Coach")
            {
                long tel = 0;
                if (txtName.Text == "")
                {
                    MessageBox.Show("Enter a valid Name");
                }
                else if (txtStreetLine.Text == "" && txtCity.Text == "" && txtState.Text == "" && txtZipCode.Text == "")
                {
                    MessageBox.Show("Enter a complete Address");
                }
                else if (long.TryParse(txtTel.Text, out tel) == false)
                {
                    MessageBox.Show("Enter a valid Telephone Number");
                }
                else
                {
                    var name = txtName.Text;
                    var doB = dtpDOB.Value;
                    var adress = new Address(txtStreetLine.Text, txtCity.Text, txtState.Text, txtZipCode.Text);
                    Coach aCoach = new Coach(name, doB, adress, tel);
                    aCoach.Credentials = txtCredentials.Text;
                    welcome.CoachsList.Add(aCoach);
                    welcome.lbCoachList.DataSource = null;
                    welcome.lbCoachList.DataSource = welcome.CoachsList;
                    welcome.lbCoachList.DisplayMember = "Name";
                    MessageBox.Show("Coach " + txtName.Text + " Created");
                    if (welcome.lbCoachList.Items.Count > 0)
                    {
                        welcome.lbCoachList.Visible = true;
                        welcome.lblCoachList.Visible = true;
                        welcome.lbCoachList.Height = (welcome.lbCoachList.Items.Count + 1) * welcome.lbCoachList.ItemHeight;
                    }
                    this.Close();
                }
            }
            #endregion
            #region create club
            if (btnCreate.Text == "Create Club")
            {
                long tel = 0;
                if (txtName.Text == "")
                {
                    MessageBox.Show("Enter a valid Name");
                }
                else if (txtStreetLine.Text == "" && txtCity.Text == "" && txtState.Text == "" && txtZipCode.Text == "")
                {
                    MessageBox.Show("Enter a complete Address");
                }
                else if (long.TryParse(txtTel.Text, out tel) == false)
                {
                    MessageBox.Show("Enter a valid Telephone Number");
                }
                else
                {
                    var name = txtName.Text;
                    var adress = new Address(txtStreetLine.Text, txtCity.Text, txtState.Text, txtZipCode.Text);
                    Club aClub = new Club(name, adress, tel);
                    welcome.ClubsList.Add(aClub);
                    welcome.myManager.ClubManager.Add(aClub);

                    welcome.lbClubsList.DataSource = null;
                    welcome.lbClubsList.DataSource = welcome.ClubsList;
                    welcome.lbClubsList.DisplayMember = "Name";
                    if (welcome.lbClubsList.Items.Count > 0)
                    {
                        welcome.lbClubsList.Visible = true;
                        welcome.lblClubList.Visible = true;
                        welcome.lbClubsList.Height = (welcome.lbClubsList.Items.Count + 1) * welcome.lbClubsList.ItemHeight;
                    }
                    MessageBox.Show("Club " + txtName.Text + " Created");
                    this.Close();
                }
            }
            #endregion
            #region Update Swimmer info
            if (btnCreate.Text == "Update Swimmer")
            {
                var aswimmer = welcome.lbSwimmerList.SelectedItem as Swimmer;
                UpdateSwimmer(aswimmer);
                this.Close();
            }
            #endregion
            #region Assign Club for Swimmer
            if (btnCreate.Text == "Assign Club")
            {
                var aSwimmer = welcome.lbSwimmerList.SelectedItem as Swimmer;
                var update = welcome.SwimmersList.Where(result => result.RegistrationNumber == aSwimmer.RegistrationNumber).FirstOrDefault();
                try
                {
                    update.Club = cbClub.SelectedItem as Club;
                }
                catch(Exception errot)
                {
                    MessageBox.Show(errot.Message);
                    return;
                }
                welcome.lbSwimmerList.DataSource = null;
                welcome.lbSwimmerList.DataSource = welcome.SwimmersList;
                welcome.lbSwimmerList.DisplayMember = "Name";
                this.Close();
            }
            #endregion
            #region Assign Coach for Swimmer
            if (btnCreate.Text == "Assign Coach")
            {
                var aSwimmer = welcome.lbSwimmerList.SelectedItem as Swimmer;
                var update = welcome.SwimmersList.Where(result => result.RegistrationNumber == aSwimmer.RegistrationNumber).FirstOrDefault();
                try
                {
                    update.Coach = cbCoach.SelectedItem as Coach;
                }
                catch (Exception errot)
                {
                    MessageBox.Show(errot.Message);
                    return;
                }
                welcome.lbSwimmerList.DataSource = null;
                welcome.lbSwimmerList.DataSource = welcome.SwimmersList;
                welcome.lbSwimmerList.DisplayMember = "Name";
                this.Close();
            }
            #endregion
            #region update Coach Info    
            if (btnCreate.Text == "Update Coach")
            {
                var aCoach = welcome.lbCoachList.SelectedItem as Coach;
                UpdateCoach(aCoach);
                this.Close();
            }
            #endregion
            #region Assign Club for Coach
            if (btnCreate.Text == "Assign Coach Club")
            {
                var aCoach = welcome.lbCoachList.SelectedItem as Coach;
                var update = welcome.CoachsList.Where(result => result.RegistrationNumber == aCoach.RegistrationNumber).FirstOrDefault();
                try
                {
                    update.Club = cbClub.SelectedItem as Club;
                }
                catch (Exception errot)
                {
                    MessageBox.Show(errot.Message);
                    return;
                }
                welcome.lbCoachList.DataSource = null;
                welcome.lbCoachList.DataSource = welcome.CoachsList;
                welcome.lbCoachList.DisplayMember = "Name";
                this.Close();
            }
            #endregion
            #region Assign Swimmer to Coach
            if (btnCreate.Text == "Assign Swimmer")
            {
                var aCoach = welcome.lbCoachList.SelectedItem as Coach;
                var update = welcome.CoachsList.Where(result => result.RegistrationNumber == aCoach.RegistrationNumber).FirstOrDefault();
                try
                {
                    update.AddSwimmer(cbSwimmersInClub.SelectedItem as Swimmer);
                }
                catch (Exception errot)
                {
                    MessageBox.Show(errot.Message);
                    return;
                }
                welcome.lbCoachList.DataSource = null;
                welcome.lbCoachList.DataSource = welcome.CoachsList;
                welcome.lbCoachList.DisplayMember = "Name";
                this.Close();
            }
            #endregion
            #region Update Club Info 
            if (btnCreate.Text == "Update Club")
            {
                var aClub = welcome.lbClubsList.SelectedItem as Club;
                UpdateClub(aClub);
                this.Close();
            }
            #endregion
        }
        private void UpdateCoach(Coach aCoach)
        {
            long tel = 0;
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter a valid Name");
            }
            else if (txtStreetLine.Text == "" && txtCity.Text == "" && txtState.Text == "" && txtZipCode.Text == "")
            {
                MessageBox.Show("Enter a complete Address");
            }
            else if (long.TryParse(txtTel.Text, out tel) == false)
            {
                MessageBox.Show("Enter a valid Telephone Number");
            }
            else
            {
                var credentials = txtCredentials.Text;
                var name = txtName.Text;
                var doB = dtpDOB.Value;
                var adress = new Address(txtStreetLine.Text, txtCity.Text, txtState.Text, txtZipCode.Text);
                var update = welcome.CoachsList.Where(result => result.RegistrationNumber == aCoach.RegistrationNumber).FirstOrDefault();
                update.Name = name;
                update.DateOfBirth = doB;
                update.Address = adress;
                update.PhoneNumber = tel;
                update.Credentials = credentials;
                welcome.lbCoachList.DataSource = null;
                welcome.lbCoachList.DataSource = welcome.CoachsList;
                welcome.lbCoachList.DisplayMember = "Name";
            }
        }
        internal void UpdateSwimmer(Swimmer aSwimmer)
        {
            long tel = 0;
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter a valid Name");
            }
            else if (txtStreetLine.Text == "" && txtCity.Text == "" && txtState.Text == "" && txtZipCode.Text == "")
            {
                MessageBox.Show("Enter a complete Address");
            }
            else if (long.TryParse(txtTel.Text, out tel) == false)
            {
                MessageBox.Show("Enter a valid Telephone Number");
            }
            else
            {
                var name = txtName.Text;
                var doB = dtpDOB.Value;
                var adress = new Address(txtStreetLine.Text, txtCity.Text, txtState.Text, txtZipCode.Text);
                var update = welcome.SwimmersList.Where(result => result.RegistrationNumber == aSwimmer.RegistrationNumber).FirstOrDefault();
                update.Name=name;
                update.DateOfBirth = doB;
                update.Address = adress;
                update.PhoneNumber = tel;
                welcome.lbSwimmerList.DataSource = null;
                welcome.lbSwimmerList.DataSource = welcome.SwimmersList;
                welcome.lbSwimmerList.DisplayMember = "Name";
            }
        }
        internal void UpdateClub(Club aClub)
        {
            long tel = 0;
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter a valid Name");
            }
            else if (txtStreetLine.Text == "" && txtCity.Text == "" && txtState.Text == "" && txtZipCode.Text == "")
            {
                MessageBox.Show("Enter a complete Address");
            }
            else if (long.TryParse(txtTel.Text, out tel) == false)
            {
                MessageBox.Show("Enter a valid Telephone Number");
            }
            else
            {
                var name = txtName.Text;
                var doB = dtpDOB.Value;
                var adress = new Address(txtStreetLine.Text, txtCity.Text, txtState.Text, txtZipCode.Text);
                var update = welcome.ClubsList.Where(result => result.ClubRegistrationNumber == aClub.ClubRegistrationNumber).FirstOrDefault();
                update.Name = name;
                update.Address = adress;
                update.PhoneNumber = tel;
                welcome.lbClubsList.DataSource = null;
                welcome.lbClubsList.DataSource = welcome.ClubsList;
                welcome.lbClubsList.DisplayMember = "Name";
            }
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate_Click(this, new EventArgs());
            }
        }
        private void Create_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today;
        }
    }
}

using PoolLib;
using PoolLib.Managers;
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
    public partial class Welcome : Form
    {
        public List<Swimmer> SwimmersList = new List<Swimmer>();
        public List<Coach> CoachsList = new List<Coach>();
        public List<Club> ClubsList = new List<Club>();
        public List<SwimMeet> MeetsList = new List<SwimMeet>();
        public List<Event> EventsList = new List<Event>();
        public static IClubsRepository myclubManager = new ClubsManager();
        public IRegistrantsRepository myManager = new SwimmersManager((ClubsManager)myclubManager);
        public Welcome()
        {
            InitializeComponent();
        }
        private void btnCreateSwimmer_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.lblCredentials.Visible = false;
            myCreateForm.txtCredentials.Visible = false;
            myCreateForm.btnCreate.Text = "Create Swimmer";
            myCreateForm.Text = "Create Swimmer";
            myCreateForm.ShowDialog();
        }

        private void btnCreateCoach_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.lblCredentials.Visible = true;
            myCreateForm.txtCredentials.Visible = true;
            myCreateForm.lblCoach.Visible = false;
            myCreateForm.cbCoach.Visible = false;
            myCreateForm.btnCreate.Text = "Create Coach";
            myCreateForm.Text = "Create Coach";
            myCreateForm.ShowDialog();
        }

        private void btnCreateClub_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.btnCreate.Text = "Create Club";
            myCreateForm.Text = "Create Club";
            myCreateForm.lblDOB.Visible = false;
            myCreateForm.dtpDOB.Visible = false;
            myCreateForm.lblCredentials.Visible = false;
            myCreateForm.txtCredentials.Visible = false;
            myCreateForm.lblCoach.Visible = false;
            myCreateForm.lblClub.Visible = false;
            myCreateForm.lblSwimmersList.Visible = false;
            myCreateForm.cbCoach.Visible = false;
            myCreateForm.cbClub.Visible = false;
            myCreateForm.cbSwimmersInClub.Visible = false;
            myCreateForm.ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Title = "Load Clubs";
            openFile.Filter = "Text file| *.txt";
            DialogResult result= openFile.ShowDialog();
            if (result==DialogResult.OK)
            {
                try
                {
                    myclubManager.Load(openFile.FileName, ",");
                    for (int i = 0; i < myclubManager.Number; i++)
                    {
                        int count = 0;
                        int found = 0;
                        foreach (Club c in ClubsList)
                        {
                            if (c.ClubRegistrationNumber == myclubManager.Clubs[i].ClubRegistrationNumber)
                            {
                                ClubsList.RemoveAt(count);
                                ClubsList.Insert(count, myclubManager.Clubs[i]);
                                found++;
                                break;
                            }
                            count++;
                        }
                        if (found == 0)
                        {
                            ClubsList.Add(myclubManager.Clubs[i]);
                        }
                    }
                    lbClubsList.DataSource = null;
                    lbClubsList.DataSource = ClubsList;
                    lbClubsList.DisplayMember = "Name";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    if (lbClubsList.Items.Count > 0)
                    {
                        lbClubsList.Visible = true;
                        lblClubList.Visible = true;
                        lbClubsList.Height = (lbClubsList.Items.Count + 1) * lbClubsList.ItemHeight;
                    }
                } 
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.Title = "Save Clubs";
            saveFile.Filter = "Text file| *.txt";
            saveFile.FileName = "ClubsOut.txt";
            DialogResult result = saveFile.ShowDialog();
            if (result==DialogResult.OK)
            {
                myclubManager.Save(saveFile.FileName, ","); 
            }
        }

        private void btnCreateSwimMeet_Click(object sender, EventArgs e)
        {
            Meets myMeetForm = new Meets(this);
            myMeetForm.cbPoolType.DataSource = Enum.GetNames(typeof(PoolType));
            myMeetForm.btnCreate.Text = "Create Meet";
            myMeetForm.Text = "Create Meet";
            myMeetForm.ShowDialog();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            if (MeetsList.Count>0)
            {
                Events myEventForm = new Events(this);
                myEventForm.cbDistance.DataSource = Enum.GetNames(typeof(EventDistance));
                myEventForm.cbStroke.DataSource = Enum.GetNames(typeof(Stroke));
                myEventForm.cbMeets.DataSource = null;
                myEventForm.cbMeets.DataSource = MeetsList;
                myEventForm.cbMeets.DisplayMember = "Name";
                myEventForm.btnCreate.Text = "Create event";
                myEventForm.Text = "Create event";
                myEventForm.ShowDialog(); 
            }else
            {
                MessageBox.Show("There is no Meet to create and event for");
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            tabCreate.SelectedTab = tabPage4;
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.lblCredentials.Visible = false;
            myCreateForm.txtCredentials.Visible = false;
            myCreateForm.btnCreate.Text = "Update Swimmer";
            myCreateForm.Text = "Modify Swimmer";

            var aswimmer = lbSwimmerList.SelectedItem as Swimmer;
            myCreateForm.txtName.Text = aswimmer.Name;
            myCreateForm.dtpDOB.Value = aswimmer.DateOfBirth;
            myCreateForm.txtTel.Text = Convert.ToString(aswimmer.PhoneNumber);
            myCreateForm.txtStreetLine.Text =aswimmer.Address.StreetLine;
            myCreateForm.txtCity.Text = aswimmer.Address.City;
            myCreateForm.txtState.Text = aswimmer.Address.State;
            myCreateForm.txtZipCode.Text = aswimmer.Address.ZipCode;
            myCreateForm.ShowDialog();
        }

        private void assignClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.lblCredentials.Visible = false;
            myCreateForm.txtCredentials.Visible = false;
            myCreateForm.btnCreate.Text = "Assign Club";
            myCreateForm.Text = "Assign Club";
            myCreateForm.txtCity.Enabled = false;
            myCreateForm.txtName.Enabled = false;
            myCreateForm.txtState.Enabled = false;
            myCreateForm.txtStreetLine.Enabled = false;
            myCreateForm.txtTel.Enabled = false;
            myCreateForm.txtZipCode.Enabled = false;
            myCreateForm.dtpDOB.Enabled = false;
            myCreateForm.cbClub.Enabled = true;

            var aswimmer = lbSwimmerList.SelectedItem as Swimmer;
            myCreateForm.txtName.Text = aswimmer.Name;
            myCreateForm.dtpDOB.Value = aswimmer.DateOfBirth;
            myCreateForm.txtTel.Text = Convert.ToString(aswimmer.PhoneNumber);
            myCreateForm.txtStreetLine.Text = aswimmer.Address.StreetLine;
            myCreateForm.txtCity.Text = aswimmer.Address.City;
            myCreateForm.txtState.Text = aswimmer.Address.State;
            myCreateForm.txtZipCode.Text = aswimmer.Address.ZipCode;

            myCreateForm.cbClub.DataSource = null;
            myCreateForm.cbClub.DataSource = ClubsList;
            myCreateForm.cbClub.DisplayMember = "Name";

            myCreateForm.ShowDialog();
        }

        private void assignCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.lblCredentials.Visible = false;
            myCreateForm.txtCredentials.Visible = false;
            myCreateForm.btnCreate.Text = "Assign Coach";
            myCreateForm.Text = "Assign Coach";
            myCreateForm.txtCity.Enabled = false;
            myCreateForm.txtName.Enabled = false;
            myCreateForm.txtState.Enabled = false;
            myCreateForm.txtStreetLine.Enabled = false;
            myCreateForm.txtTel.Enabled = false;
            myCreateForm.txtZipCode.Enabled = false;
            myCreateForm.dtpDOB.Enabled = false;
            myCreateForm.cbCoach.Enabled = true;

            var aswimmer = lbSwimmerList.SelectedItem as Swimmer;
            myCreateForm.txtName.Text = aswimmer.Name;
            myCreateForm.dtpDOB.Value = aswimmer.DateOfBirth;
            myCreateForm.txtTel.Text = Convert.ToString(aswimmer.PhoneNumber);
            myCreateForm.txtStreetLine.Text = aswimmer.Address.StreetLine;
            myCreateForm.txtCity.Text = aswimmer.Address.City;
            myCreateForm.txtState.Text = aswimmer.Address.State;
            myCreateForm.txtZipCode.Text = aswimmer.Address.ZipCode;
            if (aswimmer.Club.Name != null)
            {
                myCreateForm.cbClub.SelectedValue = aswimmer.Club.Name;
                myCreateForm.cbCoach.DataSource = null;
                myCreateForm.cbCoach.DataSource = aswimmer.Club.CoachList;
                myCreateForm.cbCoach.DisplayMember = "Name";
            }
            myCreateForm.ShowDialog();
        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.lblCoach.Visible = false;
            myCreateForm.cbCoach.Visible = false;
            myCreateForm.lblCredentials.Visible = true;
            myCreateForm.txtCredentials.Visible = true;
            myCreateForm.btnCreate.Text = "Update Coach";
            myCreateForm.Text = "Modify Coach";

            var aCoach = lbCoachList.SelectedItem as Coach;
            myCreateForm.txtName.Text = aCoach.Name;
            myCreateForm.dtpDOB.Value = aCoach.DateOfBirth;
            myCreateForm.txtTel.Text = Convert.ToString(aCoach.PhoneNumber);
            myCreateForm.txtStreetLine.Text = aCoach.Address.StreetLine;
            myCreateForm.txtCity.Text = aCoach.Address.City;
            myCreateForm.txtState.Text = aCoach.Address.State;
            myCreateForm.txtZipCode.Text = aCoach.Address.ZipCode;
            myCreateForm.txtCredentials.Text = aCoach.Credentials;
            myCreateForm.ShowDialog();
        }

        private void assignClubToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.lblCredentials.Visible = true;
            myCreateForm.txtCredentials.Visible = true;
            myCreateForm.txtCredentials.Enabled = false;
            myCreateForm.lblCoach.Visible = false;
            myCreateForm.cbCoach.Visible = false;
            myCreateForm.btnCreate.Text = "Assign Coach Club";
            myCreateForm.Text = "Assign Coach Club";
            myCreateForm.txtCity.Enabled = false;
            myCreateForm.txtName.Enabled = false;
            myCreateForm.txtState.Enabled = false;
            myCreateForm.txtStreetLine.Enabled = false;
            myCreateForm.txtTel.Enabled = false;
            myCreateForm.txtZipCode.Enabled = false;
            myCreateForm.dtpDOB.Enabled = false;
            myCreateForm.cbClub.Enabled = true;

            var acoach = lbCoachList.SelectedItem as Coach;
            myCreateForm.txtCredentials.Text = acoach.Credentials;
            myCreateForm.txtName.Text = acoach.Name;
            myCreateForm.dtpDOB.Value = acoach.DateOfBirth;
            myCreateForm.txtTel.Text = Convert.ToString(acoach.PhoneNumber);
            myCreateForm.txtStreetLine.Text = acoach.Address.StreetLine;
            myCreateForm.txtCity.Text = acoach.Address.City;
            myCreateForm.txtState.Text = acoach.Address.State;
            myCreateForm.txtZipCode.Text = acoach.Address.ZipCode;

            myCreateForm.cbClub.DataSource = null;
            myCreateForm.cbClub.DataSource = ClubsList;
            myCreateForm.cbClub.DisplayMember = "Name";
            myCreateForm.ShowDialog();
        }

        private void addSwimmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.lblCredentials.Visible = true;
            myCreateForm.txtCredentials.Visible = true;
            myCreateForm.txtCredentials.Enabled = false;
            myCreateForm.lblCoach.Visible = false;
            myCreateForm.cbCoach.Visible = false;
            myCreateForm.cbSwimmersInClub.Visible = true;
            myCreateForm.lblSwimmersList.Visible = true;
            myCreateForm.btnCreate.Text = "Assign Swimmer";
            myCreateForm.Text = "Assign Swimmer";
            myCreateForm.txtCity.Enabled = false;
            myCreateForm.txtName.Enabled = false;
            myCreateForm.txtState.Enabled = false;
            myCreateForm.txtStreetLine.Enabled = false;
            myCreateForm.txtTel.Enabled = false;
            myCreateForm.txtZipCode.Enabled = false;
            myCreateForm.dtpDOB.Enabled = false;

            var acoach = lbCoachList.SelectedItem as Coach;
            myCreateForm.txtCredentials.Text = acoach.Credentials;
            myCreateForm.txtName.Text = acoach.Name;
            myCreateForm.dtpDOB.Value = acoach.DateOfBirth;
            myCreateForm.txtTel.Text = Convert.ToString(acoach.PhoneNumber);
            myCreateForm.txtStreetLine.Text = acoach.Address.StreetLine;
            myCreateForm.txtCity.Text = acoach.Address.City;
            myCreateForm.txtState.Text = acoach.Address.State;
            myCreateForm.txtZipCode.Text = acoach.Address.ZipCode;
            if(acoach.Club.Name!=null)
            {
                myCreateForm.cbClub.SelectedValue = acoach.Club.Name;
                myCreateForm.cbSwimmersInClub.DataSource = null;
                myCreateForm.cbSwimmersInClub.DataSource = acoach.Club.RegistrantList;
                myCreateForm.cbSwimmersInClub.DisplayMember = "Name";
            }
            myCreateForm.ShowDialog();
        }

        private void loadSwimmersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Title = "Load Swimmers";
            openFile.Filter = "Text file| *.txt";
            DialogResult answer = openFile.ShowDialog();
            if (answer==DialogResult.OK)
            {
                try
                {
                    myManager.Load(openFile.FileName, ",");
                    for (int i = 0; i < myManager.Number; i++)
                    {
                        Swimmer result = new Swimmer();
                        Registrant.NoOfRegistrant--;
                        var ex = myManager.Swimmers[i];
                        result.Name = ex.Name;
                        result.PhoneNumber = ex.PhoneNumber;
                        result.RegistrationNumber = ex.RegistrationNumber;
                        result.Address = ex.Address;
                        result.DateOfBirth = ex.DateOfBirth;
                        if (result.Club.Name == "Not assigned")
                        {
                            result.Club = ex.Club;
                        }
                        int count = 0;
                        int found = 0;
                        foreach (Swimmer s in SwimmersList)
                        {
                            if (s.RegistrationNumber == ex.RegistrationNumber)
                            {
                                SwimmersList.RemoveAt(count);
                                SwimmersList.Insert(count, result);
                                found++;
                                break;
                            }
                            count++;
                        }
                        if (found == 0)
                        {
                            SwimmersList.Add(result);
                        }
                    }
                    lbSwimmerList.DataSource = null;
                    lbSwimmerList.DataSource = SwimmersList;
                    lbSwimmerList.DisplayMember = "Name";

                    lbClubsList.DataSource = null;
                    lbClubsList.DataSource = ClubsList;
                    lbClubsList.DisplayMember = "Name";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    if (lbSwimmerList.Items.Count > 0)
                    {
                        lbSwimmerList.Visible = true;
                        lblSwimmerList.Visible = true;
                        lbSwimmerList.Height = (lbSwimmerList.Items.Count + 1) * lbSwimmerList.ItemHeight;
                    }
                } 
            }
        }

        private void lbClubsList_DoubleClick(object sender, EventArgs e)
        {
            lblSwimmerDetails.Visible = false;
            lblCoachDetails.Visible = false;
            lbClubSwimers.DataSource = null;
            lbClubCoaches.DataSource = null;
            var result = lbClubsList.SelectedItem as Club;
            lvClubDetails.Items.Clear();
            if (result != null)
            {
                ListViewItem name = new ListViewItem("Name");
                name.SubItems.Add(result.Name);
                ListViewItem regNum = new ListViewItem("RegNum");
                regNum.SubItems.Add(Convert.ToString(result.ClubRegistrationNumber));
                ListViewItem address = new ListViewItem("Address");
                address.SubItems.Add(Convert.ToString(result.Address));
                ListViewItem phone = new ListViewItem("Phone");
                phone.SubItems.Add(Convert.ToString(result.PhoneNumber));
                lvClubDetails.Items.Add(name);
                lvClubDetails.Items.Add(regNum);
                lvClubDetails.Items.Add(address);
                lvClubDetails.Items.Add(phone);

                if (result.RegistrantList.Count>0)
                {                 
                    lbClubSwimers.DataSource = result.RegistrantList;
                    lbClubSwimers.DisplayMember = "Name";
                    lbClubSwimers.Height = (lbClubSwimers.Items.Count + 1) * lbClubSwimers.ItemHeight;
                }else
                {
                    lbClubSwimers.Height = 17;
                    lbClubSwimers.Items.Clear();
                    lbClubSwimers.Items.Add("Not Assigned");
                }
                if (result.CoachList.Count>0)
                {               
                    lbClubCoaches.DataSource = result.CoachList;
                    lbClubCoaches.DisplayMember = "Name";
                    lbClubCoaches.Height = (lbClubCoaches.Items.Count + 1) * lbClubCoaches.ItemHeight;
                }else
                {
                    lbClubCoaches.Height = 17;
                    lbClubCoaches.Items.Clear();
                    lbClubCoaches.Items.Add("Not Assigned");
                }
                lvClubDetails.Visible = true;
                lblClubDetails.Visible = true;
                lblClubsCoaches.Visible = true;
                lblClubSwimmers.Visible = true;
                lbClubCoaches.Visible = true;
                lbClubSwimers.Visible = true;
            }
            else
            {
                lvClubDetails.Visible = false;
                lblClubDetails.Visible = false;
                lblClubsCoaches.Visible = false;
                lblClubSwimmers.Visible = false;
                lbClubCoaches.Visible = false;
                lbClubSwimers.Visible = false;
            }
        }

        private void saveSwimmersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.Title = "Save Swimmers";
            saveFile.Filter = "Text file| *.txt";
            saveFile.FileName = "SwimmersOut.txt";
            DialogResult result = saveFile.ShowDialog();
            if (result==DialogResult.OK)
            {
                myManager.Save(saveFile.FileName, ","); 
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbClubSwimers_DoubleClick(object sender, EventArgs e)
        {
            if (lbClubSwimers.SelectedItem.ToString() != "Not Assigned")
            {
                lblSwimmerDetails.Visible = true;
                lblSwimmerDetails.Text = lbClubSwimers.SelectedItem.ToString();
            }
        }

        private void lbClubCoaches_DoubleClick(object sender, EventArgs e)
        {
            if (lbClubCoaches.SelectedItem.ToString() != "Not Assigned")
            {
                lblCoachDetails.Visible = true;
                lblCoachDetails.Text = lbClubCoaches.SelectedItem.ToString();
            }
        }

        private void lbClubsList_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbClubsList.Items.Count>0)
            {
                if (e.Button != MouseButtons.Right) return;
                var index = lbClubsList.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    lbClubsList.SelectedIndex = lbClubsList.IndexFromPoint(e.X, e.Y);
                    rightClickMenuClub.Show(Cursor.Position);
                    rightClickMenuClub.Visible = true;
                }
                else
                {
                    rightClickMenuClub.Visible = false;
                } 
            }
        }

        private void modifyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Create myCreateForm = new Create(this);
            myCreateForm.btnCreate.Text = "Update Club";
            myCreateForm.Text = "Modify Club";
            myCreateForm.lblDOB.Visible = false;
            myCreateForm.dtpDOB.Visible = false;
            myCreateForm.lblCredentials.Visible = false;
            myCreateForm.txtCredentials.Visible = false;
            myCreateForm.lblCoach.Visible = false;
            myCreateForm.lblClub.Visible = false;
            myCreateForm.lblSwimmersList.Visible = false;
            myCreateForm.cbCoach.Visible = false;
            myCreateForm.cbClub.Visible = false;
            myCreateForm.cbSwimmersInClub.Visible = false;

            var aClub = lbClubsList.SelectedItem as Club;
            myCreateForm.txtName.Text = aClub.Name;
            myCreateForm.txtTel.Text = Convert.ToString(aClub.PhoneNumber);
            myCreateForm.txtStreetLine.Text = aClub.Address.StreetLine;
            myCreateForm.txtCity.Text = aClub.Address.City;
            myCreateForm.txtState.Text = aClub.Address.State;
            myCreateForm.txtZipCode.Text = aClub.Address.ZipCode;
            myCreateForm.ShowDialog();
        }

        private void addSwimmerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbSwimmerList.Items.Count>0)
            {
                Add myAddForm = new Add(this);
                myAddForm.lbSwimmersList.Visible = true;
                myAddForm.btnAddSwimmer.Visible = true;
                myAddForm.ShowDialog(); 
            }else
            {
                MessageBox.Show("There is no Swimmer");
            }
        }

        private void addCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbCoachList.Items.Count > 0)
            {
                Add myAddForm = new Add(this);
                myAddForm.lbCoachesList.Visible = true;
                myAddForm.btnAddCoach.Visible = true;
                myAddForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no Coach");
            }
        }

        private void lbSwimmerList_Click(object sender, EventArgs e)
        {
            if (lbSwimmerList.Items.Count>0)
            {
                lblSwimmerInfo.Text = lbSwimmerList.SelectedItem.ToString(); 
            }
        }
        private void lbCoachList_Click(object sender, EventArgs e)
        {
            if (lbCoachList.Items.Count>0)
            {
                lblCoachInfo.Text = lbCoachList.SelectedItem.ToString(); 
            }
        }
        private void lbSwimmerList_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbSwimmerList.Items.Count>0)
            {
                if (e.Button != MouseButtons.Right) return;
                var index = lbSwimmerList.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    lbSwimmerList.SelectedIndex = lbSwimmerList.IndexFromPoint(e.X, e.Y);
                    rigtClickMenuSwimmer.Show(Cursor.Position);
                    rigtClickMenuSwimmer.Visible = true;
                }
                else
                {
                    rigtClickMenuSwimmer.Visible = false;
                } 
            }
        }
        private void lbCoachList_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (lbCoachList.Items.Count>0)
            {
                if (e.Button != MouseButtons.Right) return;
                var index = lbCoachList.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    lbCoachList.SelectedIndex = lbCoachList.IndexFromPoint(e.X, e.Y);
                    rightClickMenuCoach.Show(Cursor.Position);
                    rightClickMenuCoach.Visible = true;
                }
                else
                {
                    rightClickMenuCoach.Visible = false;
                } 
            }
        }
        private void lbMeetsList_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbMeetsList.Items.Count > 0)
            {
                if (e.Button != MouseButtons.Right) return;
                var index = lbMeetsList.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    lbMeetsList.SelectedIndex = lbMeetsList.IndexFromPoint(e.X, e.Y);
                    rightClickMenuMeet.Show(Cursor.Position);
                    rightClickMenuMeet.Visible = true;
                }
                else
                {
                    rightClickMenuMeet.Visible = false;
                }
            }
        }
        private void lbMeetsList_Click(object sender, EventArgs e)
        {
            if (lbMeetsList.Items.Count>0)
            {
                lblMeetsEventsSwimmers.Visible = false;
                var result = lbMeetsList.SelectedItem as SwimMeet;
                lvMeetDetails.Items.Clear();
                lbMeetsEvents.DataSource = null;
                if (result != null)
                {
                    lvMeetDetails.Visible = true;
                    lblMeetDetails.Visible = true;
                    lbMeetsEvents.Visible = true;
                    lblMeetsEvents.Visible = true;

                    ListViewItem name = new ListViewItem("Name");
                    name.SubItems.Add(result.Name);

                    ListViewItem From = new ListViewItem("From");
                    From.SubItems.Add(result.StartDate.ToLongDateString()+" to "+ result.EndDate.ToLongDateString());

                    ListViewItem PoolType = new ListViewItem("pool Type");
                    PoolType.SubItems.Add(Convert.ToString(result.PType));

                    ListViewItem NoOfLanes = new ListViewItem("No Of Lanes");
                    NoOfLanes.SubItems.Add(Convert.ToString(result.NumberOfLane));

                    lvMeetDetails.Items.Add(name);
                    lvMeetDetails.Items.Add(From);
                    lvMeetDetails.Items.Add(PoolType);
                    lvMeetDetails.Items.Add(NoOfLanes);

                    if (result.EventList.Count > 0)
                    {
                        lbMeetsEvents.DataSource = result.EventList;
                        lbMeetsEvents.DisplayMember = "Name";
                        lbMeetsEvents.Height = (lbMeetsEvents.Items.Count + 1) * lbMeetsEvents.ItemHeight;
                    }
                    else
                    {
                        lbMeetsEvents.Height = 17;
                        lbMeetsEvents.Items.Clear();
                        lbMeetsEvents.Items.Add("Not Assigned");
                    }
                }
                else
                {
                    lvMeetDetails.Visible = false;
                    lblMeetDetails.Visible = false;
                }
            }
        }
        private void seedMeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aMeet = lbMeetsList.SelectedItem as SwimMeet;
            if (aMeet.EventList.Count>0)
            {
                aMeet.Seed(); 
            }else
            {
                MessageBox.Show("There is no event in the meet");
            }
        }
        private void lbMeetsEvents_Click(object sender, EventArgs e)
        {
            if (lbMeetsEvents.SelectedItem.ToString() != "Not Assigned")
            {
                var result = lbMeetsEvents.SelectedItem as Event;
                lblMeetsEventsSwimmers.Visible = true;
                if (result != null && result.ListOfRegistrantSwim.Count > 0)
                {
                    lblMeetsEventsSwimmers.Location = new Point(204, 150);
                    lblMeetsEventsSwimmers.Text = "                " + result.DisplayEventList();
                }else
                {
                    lblMeetsEventsSwimmers.Location = new Point(251, 150);
                    lblMeetsEventsSwimmers.Text = "No Swimmers";
                }
            }
        }
        private void lbEventsList_Click(object sender, EventArgs e)
        {
            var result = lbEventsList.SelectedItem as Event;
            if (lbEventsList.Items.Count>0)
            {
                lblEventSwimmers.Visible = true;
                if (result != null && result.ListOfRegistrantSwim.Count > 0)
                {
                    lblEventSwimmers.Text = "                " + result.DisplayEventList();
                }
                else
                {
                    lblEventSwimmers.Text = "No Swimmers";
                } 
            }
        }
        private void addSwimmerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var result = lbMeetsEvents.SelectedItem as Event;
            if (result.EventSeed!=true)
            {
                if (result.SwimMeet.Name!="")
                {
                    if (lbSwimmerList.Items.Count > 0)
                    {
                        Add myAddForm = new Add(this);
                        myAddForm.lbSwimmersList.Visible = true;
                        myAddForm.btnAddSwimmerToEvent.Visible = true;
                        myAddForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("There is no Swimmer");
                    }  
                }else
                {
                    MessageBox.Show("Ther Event Does not belong to any meet");
                }
            }else
            {
                MessageBox.Show("The Event is seed");
            }
        }
        private void enterTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = lbMeetsEvents.SelectedItem as Event;
            if (result.EventSeed==true)
            {
                if (result.ListOfRegistrantSwim.Count > 0)
                {
                    Events myEventForm = new Events(this);
                    myEventForm.cbSwimmer.DataSource = result.ListOfRegistrantSwim.Keys.ToList();
                    myEventForm.cbSwimmer.DisplayMember = "Name";

                    myEventForm.cbDistance.Visible = false;
                    myEventForm.cbStroke.Visible = false;
                    myEventForm.lblDistance.Visible = false;
                    myEventForm.lblStroke.Visible = false;
                    myEventForm.lblMeet.Visible = false;
                    myEventForm.cbMeets.Visible = false;

                    myEventForm.cbSwimmer.Visible = true;
                    myEventForm.lblSwimmer.Visible = true;
                    myEventForm.txtTime.Visible = true;
                    myEventForm.lblTime.Visible = true;

                    myEventForm.btnCreate.Text = "Add Time";
                    myEventForm.Text = "Add Time";
                    myEventForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There is no Swimmer in the Event");
                } 
            }else
            {
                MessageBox.Show("The event is not seed yet");
            }
        }
        private void lbMeetsEvents_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbEventsList.Items.Count > 0)
            {
                if (e.Button != MouseButtons.Right) return;
                var index = lbEventsList.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    lbEventsList.SelectedIndex = lbEventsList.IndexFromPoint(e.X, e.Y);
                    rightClickMenuEvent.Show(Cursor.Position);
                    rightClickMenuEvent.Visible = true;
                }
                else
                {
                    rightClickMenuEvent.Visible = false;
                }
            }
        }

        private void getBestTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeetsList.Count > 0)
            {
                Events myEventForm = new Events(this);
                myEventForm.cbDistance.DataSource = Enum.GetNames(typeof(EventDistance));
                myEventForm.cbStroke.DataSource = Enum.GetNames(typeof(Stroke));
                myEventForm.cbMeets.DataSource = Enum.GetNames(typeof(PoolType));
                myEventForm.lblMeet.Text = "Type :";

                myEventForm.cbMeets.DisplayMember = "Name";
                myEventForm.btnCreate.Text = "Get";
                myEventForm.Text = "Get Best Time";
                myEventForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is not meet to get time from");
            }
        }
    }
}

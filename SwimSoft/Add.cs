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
    public partial class Add : Form
    {
        private Welcome welcome = null;
        public Add()
        {
            InitializeComponent();
        }
        public Add(Form aForm)
        {
            welcome = aForm as Welcome;
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Add_Load(object sender, EventArgs e)
        {
            lbSwimmersList.DataSource = null;
            lbCoachesList.DataSource = null;
            lbSwimmersList.DataSource = welcome.SwimmersList;
            lbCoachesList.DataSource = welcome.CoachsList;
            lbSwimmersList.DisplayMember = "Name";
            lbCoachesList.DisplayMember = "Name";
        }
        private void btnAddSwimmer_Click(object sender, EventArgs e)
        {
            try
            {
                var aSwimmer = lbSwimmersList.SelectedItem as Swimmer;
                var aclub = welcome.lbClubsList.SelectedItem as Club;
                aclub.AddSwimmer(aSwimmer);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            try
            {
                var aCoach = lbCoachesList.SelectedItem as Coach;
                var aclub = welcome.lbClubsList.SelectedItem as Club;
                aclub.AddCoach(aCoach);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnAddSwimmerToEvent_Click(object sender, EventArgs e)
        {
            try
            {
                var meet = welcome.lbMeetsList.SelectedItem as SwimMeet;
                var aSwimmer = lbSwimmersList.SelectedItem as Swimmer;
                var anEvent = welcome.lbMeetsEvents.SelectedItem as Event;
                anEvent.AddSwimmer(aSwimmer);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

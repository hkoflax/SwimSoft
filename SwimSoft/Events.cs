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
    public partial class Events : Form
    {
        private Welcome welcome = null;
        public Events()
        {
            InitializeComponent();
        }
        public Events(Form aForm)
        {
            welcome = aForm as Welcome;
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region create Event
            if (btnCreate.Text == "Create event")
            {
                int match = 0; ;

                var anEvent = new Event();
                anEvent.Stroke = (Stroke)Enum.Parse(typeof(Stroke), cbStroke.Text);
                anEvent.Distance = (EventDistance)Enum.Parse(typeof(EventDistance), cbDistance.Text);
                anEvent.Name = anEvent.Distance + Convert.ToString(anEvent.Stroke);
                anEvent.SwimMeet = cbMeets.SelectedItem as SwimMeet;
                foreach (Event a in anEvent.SwimMeet.EventList)
                {
                    if (a.Name == anEvent.Name)
                    {
                        match++;
                        break;
                    }
                }
                if (match == 0)
                {
                    welcome.EventsList.Add(anEvent);
                    anEvent.SwimMeet.AddEvent(anEvent);

                    welcome.lbEventsList.DataSource = null;
                    welcome.lbEventsList.DataSource = welcome.EventsList;
                    welcome.lbEventsList.DisplayMember = "Name";

                    MessageBox.Show("Event " + anEvent.Name + " Created");
                    if (welcome.lbEventsList.Items.Count > 0)
                    {
                        welcome.lbEventsList.Height = (welcome.lbEventsList.Items.Count + 1) * welcome.lbEventsList.ItemHeight;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Meet already have the Event");
                }
            }
            #endregion
            #region Add time
            if (btnCreate.Text == "Add Time")
            {
                var result = welcome.lbMeetsEvents.SelectedItem as Event;
                var swimmer = cbSwimmer.SelectedItem as Swimmer;
                try
                {
                    result.EnterSwimmersTime(swimmer, txtTime.Text);
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            #endregion
            #region Get Best Time
            if (btnCreate.Text == "Get")
            {
                var aswimmer = welcome.lbSwimmerList.SelectedItem as Swimmer;
                var ptype = (PoolType)Enum.Parse(typeof(PoolType), cbMeets.Text);
                var stroke = (Stroke)Enum.Parse(typeof(Stroke), cbStroke.Text);
                var distance = (EventDistance)Enum.Parse(typeof(EventDistance), cbDistance.Text);
                var result = aswimmer.GetBestTime(ptype, stroke, distance);
                if (result!=new TimeSpan(0,0,0))
                {
                    txtTime.Visible = true;
                    lblTime.Visible = true;
                    txtTime.Text = result.ToString(@"mm\:ss\.ff"); 
                }else
                {
                    txtTime.Visible = false;
                    lblTime.Visible = false;
                    MessageBox.Show("The Swimmer has no record for this event");
                }
            }
            #endregion
        }
    }
}

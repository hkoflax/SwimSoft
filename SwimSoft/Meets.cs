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
    public partial class Meets : Form
    {
        private Welcome welcome = null;
        public Meets()
        {
            InitializeComponent();
        }
        public Meets(Form aForm)
        {
            welcome = aForm as Welcome;
            InitializeComponent();
        }

        private void Meets_Load(object sender, EventArgs e)
        {
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region Create Meet
            if (btnCreate.Text == "Create Meet")
            {
                if (txtName.Text != "")
                {
                    var meet = new SwimMeet(txtName.Text);
                    meet.StartDate = dtpStartDate.Value;
                    meet.EndDate = dtpEndDate.Value;
                    meet.PType = (PoolType)Enum.Parse(typeof(PoolType), cbPoolType.Text);
                    meet.NumberOfLane = (int)udNoOfLanes.Value;
                    welcome.MeetsList.Add(meet);
                    welcome.lbMeetsList.DataSource = null;
                    welcome.lbMeetsList.DataSource = welcome.MeetsList;
                    welcome.lbMeetsList.DisplayMember = "Name";
                    MessageBox.Show("Meet " + txtName.Text + " Created");
                    if (welcome.lbMeetsList.Items.Count > 0)
                    {
                        welcome.lbMeetsList.Height = (welcome.lbMeetsList.Items.Count + 1) * welcome.lbMeetsList.ItemHeight;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter a Name for the Meet");
                }
            }
            #endregion
            #region End
            if (btnCreate.Text == "Ok")
            {
                this.Close();
            }
            #endregion
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }
    }
}

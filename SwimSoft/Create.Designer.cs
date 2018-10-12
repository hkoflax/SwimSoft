namespace SwimSoft
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreetLine = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cbCoach = new System.Windows.Forms.ComboBox();
            this.lblCoach = new System.Windows.Forms.Label();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.txtCredentials = new System.Windows.Forms.TextBox();
            this.cbSwimmersInClub = new System.Windows.Forms.ComboBox();
            this.lblSwimmersList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(462, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(100, 364);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "koflax";
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(100, 60);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(156, 20);
            this.dtpDOB.TabIndex = 4;
            this.dtpDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(52, 66);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(41, 13);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "DOB :";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(5, 113);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(88, 13);
            this.lblStreet.TabIndex = 6;
            this.lblStreet.Text = "Street Line 1 :";
            // 
            // txtStreetLine
            // 
            this.txtStreetLine.Location = new System.Drawing.Point(100, 110);
            this.txtStreetLine.Name = "txtStreetLine";
            this.txtStreetLine.Size = new System.Drawing.Size(156, 20);
            this.txtStreetLine.TabIndex = 7;
            this.txtStreetLine.Text = "76 Willamere";
            this.txtStreetLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(26, 164);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(66, 13);
            this.lblZip.TabIndex = 8;
            this.lblZip.Text = "Zip Code :";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(47, 209);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 13);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(56, 258);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City :";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(100, 164);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(156, 20);
            this.txtZipCode.TabIndex = 11;
            this.txtZipCode.Text = "M1M1W8";
            this.txtZipCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(100, 206);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(156, 20);
            this.txtState.TabIndex = 12;
            this.txtState.Text = "ON";
            this.txtState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(100, 255);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 20);
            this.txtCity.TabIndex = 13;
            this.txtCity.Text = "Toronto";
            this.txtCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(18, 296);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(75, 13);
            this.lblTelephone.TabIndex = 14;
            this.lblTelephone.Text = "Telephone :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(100, 293);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(156, 20);
            this.txtTel.TabIndex = 15;
            this.txtTel.Text = "6472237521";
            this.txtTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // cbCoach
            // 
            this.cbCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoach.Enabled = false;
            this.cbCoach.FormattingEnabled = true;
            this.cbCoach.Location = new System.Drawing.Point(443, 10);
            this.cbCoach.Name = "cbCoach";
            this.cbCoach.Size = new System.Drawing.Size(192, 21);
            this.cbCoach.TabIndex = 16;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(387, 13);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(51, 13);
            this.lblCoach.TabIndex = 17;
            this.lblCoach.Text = "Coach :";
            // 
            // cbClub
            // 
            this.cbClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClub.Enabled = false;
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(443, 66);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(192, 21);
            this.cbClub.TabIndex = 18;
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(394, 69);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(44, 13);
            this.lblClub.TabIndex = 19;
            this.lblClub.Text = "CLub :";
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.Location = new System.Drawing.Point(360, 119);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(78, 13);
            this.lblCredentials.TabIndex = 20;
            this.lblCredentials.Text = "Credentials :";
            // 
            // txtCredentials
            // 
            this.txtCredentials.Location = new System.Drawing.Point(443, 113);
            this.txtCredentials.Multiline = true;
            this.txtCredentials.Name = "txtCredentials";
            this.txtCredentials.Size = new System.Drawing.Size(192, 26);
            this.txtCredentials.TabIndex = 21;
            this.txtCredentials.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // cbSwimmersInClub
            // 
            this.cbSwimmersInClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwimmersInClub.FormattingEnabled = true;
            this.cbSwimmersInClub.Location = new System.Drawing.Point(443, 162);
            this.cbSwimmersInClub.Name = "cbSwimmersInClub";
            this.cbSwimmersInClub.Size = new System.Drawing.Size(192, 21);
            this.cbSwimmersInClub.TabIndex = 22;
            this.cbSwimmersInClub.Visible = false;
            // 
            // lblSwimmersList
            // 
            this.lblSwimmersList.AutoSize = true;
            this.lblSwimmersList.Location = new System.Drawing.Point(304, 167);
            this.lblSwimmersList.Name = "lblSwimmersList";
            this.lblSwimmersList.Size = new System.Drawing.Size(135, 13);
            this.lblSwimmersList.TabIndex = 23;
            this.lblSwimmersList.Text = "Swimmers in the Club :";
            this.lblSwimmersList.Visible = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(656, 422);
            this.ControlBox = false;
            this.Controls.Add(this.lblSwimmersList);
            this.Controls.Add(this.cbSwimmersInClub);
            this.Controls.Add(this.txtCredentials);
            this.Controls.Add(this.lblCredentials);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.cbClub);
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.cbCoach);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtStreetLine);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.DateTimePicker dtpDOB;
        public System.Windows.Forms.Label lblDOB;
        public System.Windows.Forms.Label lblStreet;
        public System.Windows.Forms.TextBox txtStreetLine;
        public System.Windows.Forms.Label lblZip;
        public System.Windows.Forms.Label lblState;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.TextBox txtZipCode;
        public System.Windows.Forms.TextBox txtState;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.Label lblTelephone;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.ComboBox cbCoach;
        public System.Windows.Forms.Label lblCoach;
        public System.Windows.Forms.ComboBox cbClub;
        public System.Windows.Forms.Label lblClub;
        public System.Windows.Forms.Label lblCredentials;
        public System.Windows.Forms.TextBox txtCredentials;
        public System.Windows.Forms.ComboBox cbSwimmersInClub;
        public System.Windows.Forms.Label lblSwimmersList;
    }
}
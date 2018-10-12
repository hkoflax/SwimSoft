namespace SwimSoft
{
    partial class Events
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
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblStroke = new System.Windows.Forms.Label();
            this.cbDistance = new System.Windows.Forms.ComboBox();
            this.cbStroke = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSwimmer = new System.Windows.Forms.Label();
            this.cbSwimmer = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cbMeets = new System.Windows.Forms.ComboBox();
            this.lblMeet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(15, 45);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(65, 13);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Distance :";
            // 
            // lblStroke
            // 
            this.lblStroke.AutoSize = true;
            this.lblStroke.Location = new System.Drawing.Point(28, 86);
            this.lblStroke.Name = "lblStroke";
            this.lblStroke.Size = new System.Drawing.Size(52, 13);
            this.lblStroke.TabIndex = 1;
            this.lblStroke.Text = "Stroke :";
            // 
            // cbDistance
            // 
            this.cbDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistance.FormattingEnabled = true;
            this.cbDistance.Location = new System.Drawing.Point(87, 43);
            this.cbDistance.Name = "cbDistance";
            this.cbDistance.Size = new System.Drawing.Size(178, 21);
            this.cbDistance.TabIndex = 2;
            // 
            // cbStroke
            // 
            this.cbStroke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStroke.FormattingEnabled = true;
            this.cbStroke.Location = new System.Drawing.Point(87, 85);
            this.cbStroke.Name = "cbStroke";
            this.cbStroke.Size = new System.Drawing.Size(178, 21);
            this.cbStroke.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(19, 200);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSwimmer
            // 
            this.lblSwimmer.AutoSize = true;
            this.lblSwimmer.Location = new System.Drawing.Point(16, 125);
            this.lblSwimmer.Name = "lblSwimmer";
            this.lblSwimmer.Size = new System.Drawing.Size(64, 13);
            this.lblSwimmer.TabIndex = 6;
            this.lblSwimmer.Text = "Swimmer :";
            this.lblSwimmer.Visible = false;
            // 
            // cbSwimmer
            // 
            this.cbSwimmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwimmer.FormattingEnabled = true;
            this.cbSwimmer.Location = new System.Drawing.Point(87, 123);
            this.cbSwimmer.Name = "cbSwimmer";
            this.cbSwimmer.Size = new System.Drawing.Size(178, 21);
            this.cbSwimmer.TabIndex = 7;
            this.cbSwimmer.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(35, 163);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time : ";
            this.lblTime.Visible = false;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(87, 160);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(178, 20);
            this.txtTime.TabIndex = 9;
            this.txtTime.Text = "00:30.13";
            this.txtTime.Visible = false;
            // 
            // cbMeets
            // 
            this.cbMeets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeets.FormattingEnabled = true;
            this.cbMeets.Location = new System.Drawing.Point(87, 12);
            this.cbMeets.Name = "cbMeets";
            this.cbMeets.Size = new System.Drawing.Size(176, 21);
            this.cbMeets.TabIndex = 10;
            // 
            // lblMeet
            // 
            this.lblMeet.AutoSize = true;
            this.lblMeet.Location = new System.Drawing.Point(38, 15);
            this.lblMeet.Name = "lblMeet";
            this.lblMeet.Size = new System.Drawing.Size(47, 13);
            this.lblMeet.TabIndex = 11;
            this.lblMeet.Text = "Meet : ";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(275, 235);
            this.ControlBox = false;
            this.Controls.Add(this.lblMeet);
            this.Controls.Add(this.cbMeets);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cbSwimmer);
            this.Controls.Add(this.lblSwimmer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbStroke);
            this.Controls.Add(this.cbDistance);
            this.Controls.Add(this.lblStroke);
            this.Controls.Add(this.lblDistance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDistance;
        public System.Windows.Forms.Label lblStroke;
        public System.Windows.Forms.ComboBox cbDistance;
        public System.Windows.Forms.ComboBox cbStroke;
        public System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ComboBox cbSwimmer;
        public System.Windows.Forms.TextBox txtTime;
        public System.Windows.Forms.Label lblSwimmer;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.ComboBox cbMeets;
        public System.Windows.Forms.Label lblMeet;
    }
}
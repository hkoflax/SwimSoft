namespace SwimSoft
{
    partial class Add
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
            this.lbSwimmersList = new System.Windows.Forms.ListBox();
            this.lbCoachesList = new System.Windows.Forms.ListBox();
            this.btnAddSwimmer = new System.Windows.Forms.Button();
            this.btnAddCoach = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddSwimmerToEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSwimmersList
            // 
            this.lbSwimmersList.FormattingEnabled = true;
            this.lbSwimmersList.Location = new System.Drawing.Point(14, 12);
            this.lbSwimmersList.Name = "lbSwimmersList";
            this.lbSwimmersList.Size = new System.Drawing.Size(161, 238);
            this.lbSwimmersList.TabIndex = 0;
            this.lbSwimmersList.Visible = false;
            // 
            // lbCoachesList
            // 
            this.lbCoachesList.FormattingEnabled = true;
            this.lbCoachesList.Location = new System.Drawing.Point(14, 12);
            this.lbCoachesList.Name = "lbCoachesList";
            this.lbCoachesList.Size = new System.Drawing.Size(161, 238);
            this.lbCoachesList.TabIndex = 1;
            this.lbCoachesList.Visible = false;
            // 
            // btnAddSwimmer
            // 
            this.btnAddSwimmer.Location = new System.Drawing.Point(183, 117);
            this.btnAddSwimmer.Name = "btnAddSwimmer";
            this.btnAddSwimmer.Size = new System.Drawing.Size(72, 23);
            this.btnAddSwimmer.TabIndex = 2;
            this.btnAddSwimmer.Text = "Add";
            this.btnAddSwimmer.UseVisualStyleBackColor = true;
            this.btnAddSwimmer.Visible = false;
            this.btnAddSwimmer.Click += new System.EventHandler(this.btnAddSwimmer_Click);
            // 
            // btnAddCoach
            // 
            this.btnAddCoach.Location = new System.Drawing.Point(182, 117);
            this.btnAddCoach.Name = "btnAddCoach";
            this.btnAddCoach.Size = new System.Drawing.Size(72, 23);
            this.btnAddCoach.TabIndex = 3;
            this.btnAddCoach.Text = "Add";
            this.btnAddCoach.UseVisualStyleBackColor = true;
            this.btnAddCoach.Visible = false;
            this.btnAddCoach.Click += new System.EventHandler(this.btnAddCoach_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddSwimmerToEvent
            // 
            this.btnAddSwimmerToEvent.Location = new System.Drawing.Point(183, 117);
            this.btnAddSwimmerToEvent.Name = "btnAddSwimmerToEvent";
            this.btnAddSwimmerToEvent.Size = new System.Drawing.Size(71, 23);
            this.btnAddSwimmerToEvent.TabIndex = 5;
            this.btnAddSwimmerToEvent.Text = "Add";
            this.btnAddSwimmerToEvent.UseVisualStyleBackColor = true;
            this.btnAddSwimmerToEvent.Visible = false;
            this.btnAddSwimmerToEvent.Click += new System.EventHandler(this.btnAddSwimmerToEvent_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(257, 291);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddSwimmerToEvent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddCoach);
            this.Controls.Add(this.btnAddSwimmer);
            this.Controls.Add(this.lbCoachesList);
            this.Controls.Add(this.lbSwimmersList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbSwimmersList;
        public System.Windows.Forms.ListBox lbCoachesList;
        public System.Windows.Forms.Button btnAddSwimmer;
        public System.Windows.Forms.Button btnAddCoach;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnAddSwimmerToEvent;
    }
}
namespace SwimSoft
{
    partial class Meets
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbPoolType = new System.Windows.Forms.ComboBox();
            this.udNoOfLanes = new System.Windows.Forms.NumericUpDown();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblPoolType = new System.Windows.Forms.Label();
            this.lblNoOfLanes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udNoOfLanes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(67, 227);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(87, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Meet";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Winter Splash";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(117, 51);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(117, 94);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 5;
            // 
            // cbPoolType
            // 
            this.cbPoolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoolType.FormattingEnabled = true;
            this.cbPoolType.Location = new System.Drawing.Point(117, 137);
            this.cbPoolType.Name = "cbPoolType";
            this.cbPoolType.Size = new System.Drawing.Size(200, 21);
            this.cbPoolType.TabIndex = 6;
            // 
            // udNoOfLanes
            // 
            this.udNoOfLanes.Location = new System.Drawing.Point(117, 183);
            this.udNoOfLanes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.udNoOfLanes.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udNoOfLanes.Name = "udNoOfLanes";
            this.udNoOfLanes.Size = new System.Drawing.Size(200, 20);
            this.udNoOfLanes.TabIndex = 7;
            this.udNoOfLanes.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(39, 54);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(73, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(43, 97);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(68, 13);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "End Date :";
            // 
            // lblPoolType
            // 
            this.lblPoolType.AutoSize = true;
            this.lblPoolType.Location = new System.Drawing.Point(39, 140);
            this.lblPoolType.Name = "lblPoolType";
            this.lblPoolType.Size = new System.Drawing.Size(72, 13);
            this.lblPoolType.TabIndex = 10;
            this.lblPoolType.Text = "Pool Type :";
            // 
            // lblNoOfLanes
            // 
            this.lblNoOfLanes.AutoSize = true;
            this.lblNoOfLanes.Location = new System.Drawing.Point(26, 185);
            this.lblNoOfLanes.Name = "lblNoOfLanes";
            this.lblNoOfLanes.Size = new System.Drawing.Size(86, 13);
            this.lblNoOfLanes.TabIndex = 11;
            this.lblNoOfLanes.Text = "No Of Lanes :";
            // 
            // Meets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblNoOfLanes);
            this.Controls.Add(this.lblPoolType);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.udNoOfLanes);
            this.Controls.Add(this.cbPoolType);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(610, 300);
            this.MinimumSize = new System.Drawing.Size(347, 300);
            this.Name = "Meets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Meet";
            this.Load += new System.EventHandler(this.Meets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udNoOfLanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.DateTimePicker dtpStartDate;
        public System.Windows.Forms.DateTimePicker dtpEndDate;
        public System.Windows.Forms.ComboBox cbPoolType;
        public System.Windows.Forms.NumericUpDown udNoOfLanes;
        public System.Windows.Forms.Label lblStartDate;
        public System.Windows.Forms.Label lblEndDate;
        public System.Windows.Forms.Label lblPoolType;
        public System.Windows.Forms.Label lblNoOfLanes;
    }
}
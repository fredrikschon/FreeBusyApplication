using System.Windows.Forms;
namespace FreeBusyApplication
{
    partial class FreeBusyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeBusyForm));
            this.txtEmpNr = new System.Windows.Forms.TextBox();
            this.lblEmpNr = new System.Windows.Forms.Label();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.lblEarliest = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBookTime = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.lblLatest = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.numOfficeHourStart = new System.Windows.Forms.NumericUpDown();
            this.numOfficeHourEnd = new System.Windows.Forms.NumericUpDown();
            this.lblOfficeStart = new System.Windows.Forms.Label();
            this.lblOfficeEnd = new System.Windows.Forms.Label();
            this.lblTitleEmp = new System.Windows.Forms.Label();
            this.lblTitleMeeting = new System.Windows.Forms.Label();
            this.lblTitleOffice = new System.Windows.Forms.Label();
            this.dataGridSuggestedMeetings = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfficeHourStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfficeHourEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuggestedMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpNr
            // 
            this.txtEmpNr.Location = new System.Drawing.Point(98, 97);
            this.txtEmpNr.Name = "txtEmpNr";
            this.txtEmpNr.Size = new System.Drawing.Size(178, 20);
            this.txtEmpNr.TabIndex = 0;
            // 
            // lblEmpNr
            // 
            this.lblEmpNr.AutoSize = true;
            this.lblEmpNr.Location = new System.Drawing.Point(34, 100);
            this.lblEmpNr.Name = "lblEmpNr";
            this.lblEmpNr.Size = new System.Drawing.Size(39, 13);
            this.lblEmpNr.TabIndex = 1;
            this.lblEmpNr.Text = "EmpNr\r\n";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "M\'/\'d\'/\'yyyy h\':\'m\':\'ss tt";
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(76, 177);
            this.dateTimeFrom.MinDate = new System.DateTime(2015, 3, 22, 18, 15, 41, 27);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFrom.TabIndex = 2;
            this.dateTimeFrom.Value = new System.DateTime(2015, 3, 22, 18, 15, 41, 27);
            // 
            // lblEarliest
            // 
            this.lblEarliest.AutoSize = true;
            this.lblEarliest.Location = new System.Drawing.Point(31, 177);
            this.lblEarliest.Name = "lblEarliest";
            this.lblEarliest.Size = new System.Drawing.Size(44, 13);
            this.lblEarliest.TabIndex = 4;
            this.lblEarliest.Text = "Earliest:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(163, 236);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 13);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(145, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Get suggested time";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBookTime
            // 
            this.btnBookTime.Enabled = false;
            this.btnBookTime.Location = new System.Drawing.Point(504, 421);
            this.btnBookTime.Name = "btnBookTime";
            this.btnBookTime.Size = new System.Drawing.Size(75, 23);
            this.btnBookTime.TabIndex = 8;
            this.btnBookTime.Text = "Book meeting";
            this.btnBookTime.UseVisualStyleBackColor = true;
            this.btnBookTime.Click += new System.EventHandler(this.btnBookTime_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(13, 430);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 9;
            // 
            // numDuration
            // 
            this.numDuration.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDuration.Location = new System.Drawing.Point(219, 233);
            this.numDuration.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(57, 20);
            this.numDuration.TabIndex = 10;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "M\'/\'d\'/\'yyyy h\':\'m\':\'ss tt";
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(76, 207);
            this.dateTimeTo.MinDate = new System.DateTime(2015, 3, 22, 18, 15, 41, 40);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTo.TabIndex = 11;
            this.dateTimeTo.Value = new System.DateTime(2015, 3, 22, 18, 15, 41, 40);
            // 
            // lblLatest
            // 
            this.lblLatest.AutoSize = true;
            this.lblLatest.Location = new System.Drawing.Point(31, 209);
            this.lblLatest.Name = "lblLatest";
            this.lblLatest.Size = new System.Drawing.Size(39, 13);
            this.lblLatest.TabIndex = 4;
            this.lblLatest.Text = "Latest:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTitle.Location = new System.Drawing.Point(150, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 25);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Buffel och Båg Meeting Planner";
            // 
            // numOfficeHourStart
            // 
            this.numOfficeHourStart.Location = new System.Drawing.Point(181, 320);
            this.numOfficeHourStart.Name = "numOfficeHourStart";
            this.numOfficeHourStart.Size = new System.Drawing.Size(41, 20);
            this.numOfficeHourStart.TabIndex = 13;
            this.numOfficeHourStart.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numOfficeHourStart.ValueChanged += new System.EventHandler(this.numOfficeHourStart_ValueChanged);
            // 
            // numOfficeHourEnd
            // 
            this.numOfficeHourEnd.Location = new System.Drawing.Point(228, 320);
            this.numOfficeHourEnd.Name = "numOfficeHourEnd";
            this.numOfficeHourEnd.Size = new System.Drawing.Size(39, 20);
            this.numOfficeHourEnd.TabIndex = 13;
            this.numOfficeHourEnd.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numOfficeHourEnd.ValueChanged += new System.EventHandler(this.numOfficeHourEnd_ValueChanged);
            // 
            // lblOfficeStart
            // 
            this.lblOfficeStart.AutoSize = true;
            this.lblOfficeStart.Location = new System.Drawing.Point(181, 304);
            this.lblOfficeStart.Name = "lblOfficeStart";
            this.lblOfficeStart.Size = new System.Drawing.Size(33, 13);
            this.lblOfficeStart.TabIndex = 4;
            this.lblOfficeStart.Text = "From:";
            // 
            // lblOfficeEnd
            // 
            this.lblOfficeEnd.AutoSize = true;
            this.lblOfficeEnd.Location = new System.Drawing.Point(225, 304);
            this.lblOfficeEnd.Name = "lblOfficeEnd";
            this.lblOfficeEnd.Size = new System.Drawing.Size(23, 13);
            this.lblOfficeEnd.TabIndex = 4;
            this.lblOfficeEnd.Text = "To:";
            // 
            // lblTitleEmp
            // 
            this.lblTitleEmp.AutoSize = true;
            this.lblTitleEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTitleEmp.Location = new System.Drawing.Point(30, 60);
            this.lblTitleEmp.Name = "lblTitleEmp";
            this.lblTitleEmp.Size = new System.Drawing.Size(183, 25);
            this.lblTitleEmp.TabIndex = 12;
            this.lblTitleEmp.Text = "Participant details";
            // 
            // lblTitleMeeting
            // 
            this.lblTitleMeeting.AutoSize = true;
            this.lblTitleMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTitleMeeting.Location = new System.Drawing.Point(30, 137);
            this.lblTitleMeeting.Name = "lblTitleMeeting";
            this.lblTitleMeeting.Size = new System.Drawing.Size(158, 25);
            this.lblTitleMeeting.TabIndex = 12;
            this.lblTitleMeeting.Text = "Meeting details";
            // 
            // lblTitleOffice
            // 
            this.lblTitleOffice.AutoSize = true;
            this.lblTitleOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTitleOffice.Location = new System.Drawing.Point(30, 266);
            this.lblTitleOffice.Name = "lblTitleOffice";
            this.lblTitleOffice.Size = new System.Drawing.Size(184, 25);
            this.lblTitleOffice.TabIndex = 12;
            this.lblTitleOffice.Text = "Timespan per day";
            // 
            // dataGridSuggestedMeetings
            // 
            this.dataGridSuggestedMeetings.AllowUserToAddRows = false;
            this.dataGridSuggestedMeetings.AllowUserToDeleteRows = false;
            this.dataGridSuggestedMeetings.AllowUserToResizeColumns = false;
            this.dataGridSuggestedMeetings.AllowUserToResizeRows = false;
            this.dataGridSuggestedMeetings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSuggestedMeetings.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSuggestedMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuggestedMeetings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date});
            this.dataGridSuggestedMeetings.Location = new System.Drawing.Point(322, 60);
            this.dataGridSuggestedMeetings.MultiSelect = false;
            this.dataGridSuggestedMeetings.Name = "dataGridSuggestedMeetings";
            this.dataGridSuggestedMeetings.ReadOnly = true;
            this.dataGridSuggestedMeetings.RowHeadersVisible = false;
            this.dataGridSuggestedMeetings.Size = new System.Drawing.Size(257, 335);
            this.dataGridSuggestedMeetings.TabIndex = 14;
            // 
            // Date
            // 
            dataGridViewCellStyle1.Format = "\"d/M/yyy h:m:ff tt\"";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Suggested Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(97, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to create a new employee";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FreeBusyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(223)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(613, 481);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridSuggestedMeetings);
            this.Controls.Add(this.numOfficeHourEnd);
            this.Controls.Add(this.numOfficeHourStart);
            this.Controls.Add(this.lblTitleOffice);
            this.Controls.Add(this.lblTitleMeeting);
            this.Controls.Add(this.lblTitleEmp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnBookTime);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblOfficeEnd);
            this.Controls.Add(this.lblOfficeStart);
            this.Controls.Add(this.lblLatest);
            this.Controls.Add(this.lblEarliest);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.lblEmpNr);
            this.Controls.Add(this.txtEmpNr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FreeBusyForm";
            this.Text = "Lemon Meeting Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfficeHourStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfficeHourEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuggestedMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpNr;
        private System.Windows.Forms.Label lblEmpNr;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label lblEarliest;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBookTime;
        private Label lblError;
        private NumericUpDown numDuration;
        private DateTimePicker dateTimeTo;
        private Label lblLatest;
        private Label lblTitle;
        private NumericUpDown numOfficeHourStart;
        private NumericUpDown numOfficeHourEnd;
        private Label lblOfficeStart;
        private Label lblOfficeEnd;
        private Label lblTitleEmp;
        private Label lblTitleMeeting;
        private Label lblTitleOffice;
        private DataGridView dataGridSuggestedMeetings;
        private DataGridViewTextBoxColumn Date;
        private LinkLabel linkLabel1;
    }
}
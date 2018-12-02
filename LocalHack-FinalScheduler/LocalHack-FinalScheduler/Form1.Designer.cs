namespace LocalHack_FinalScheduler
{
    partial class SchdlFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchdlFRM));
            this.CMBcourse = new System.Windows.Forms.ComboBox();
            this.LBLselectExam = new System.Windows.Forms.Label();
            this.calendarDGV = new System.Windows.Forms.DataGridView();
            this.AddBTN = new System.Windows.Forms.Button();
            this.LBXcourseList = new System.Windows.Forms.ListBox();
            this.LBLselectedCoursesList = new System.Windows.Forms.Label();
            this.CoursesDS = new System.Data.DataSet();
            this.selectedDS = new System.Data.DataSet();
            this.startOverBTN = new System.Windows.Forms.Button();
            this.LBLcourseName = new System.Windows.Forms.Label();
            this.TXTcourse = new System.Windows.Forms.TextBox();
            this.TXTtime = new System.Windows.Forms.TextBox();
            this.LBLtime = new System.Windows.Forms.Label();
            this.LBXstudy = new System.Windows.Forms.ListBox();
            this.GBdifficulty = new System.Windows.Forms.GroupBox();
            this.RBeasy = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RBmoderate = new System.Windows.Forms.RadioButton();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.RBHard = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblFinalTime = new System.Windows.Forms.Label();
            this.lblScheduleConflict = new System.Windows.Forms.Label();
            this.gbLegend = new System.Windows.Forms.GroupBox();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDS)).BeginInit();
            this.GBdifficulty.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.gbLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMBcourse
            // 
            this.CMBcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBcourse.FormattingEnabled = true;
            this.CMBcourse.Location = new System.Drawing.Point(12, 82);
            this.CMBcourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CMBcourse.Name = "CMBcourse";
            this.CMBcourse.Size = new System.Drawing.Size(215, 28);
            this.CMBcourse.TabIndex = 0;
            this.CMBcourse.SelectedIndexChanged += new System.EventHandler(this.CourseCMB_SelectedIndexChanged);
            // 
            // LBLselectExam
            // 
            this.LBLselectExam.AutoSize = true;
            this.LBLselectExam.BackColor = System.Drawing.Color.Green;
            this.LBLselectExam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLselectExam.ForeColor = System.Drawing.Color.White;
            this.LBLselectExam.Location = new System.Drawing.Point(9, 54);
            this.LBLselectExam.Name = "LBLselectExam";
            this.LBLselectExam.Size = new System.Drawing.Size(177, 18);
            this.LBLselectExam.TabIndex = 1;
            this.LBLselectExam.Text = "Select an Course to Add";
            // 
            // calendarDGV
            // 
            this.calendarDGV.AllowUserToAddRows = false;
            this.calendarDGV.AllowUserToDeleteRows = false;
            this.calendarDGV.BackgroundColor = System.Drawing.Color.White;
            this.calendarDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.calendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Saturday,
            this.Sunday,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday});
            this.calendarDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calendarDGV.Location = new System.Drawing.Point(358, 54);
            this.calendarDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calendarDGV.Name = "calendarDGV";
            this.calendarDGV.ReadOnly = true;
            this.calendarDGV.Size = new System.Drawing.Size(658, 617);
            this.calendarDGV.TabIndex = 4;
            // 
            // AddBTN
            // 
            this.AddBTN.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBTN.Location = new System.Drawing.Point(12, 297);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(154, 36);
            this.AddBTN.TabIndex = 5;
            this.AddBTN.Text = "Add This Course";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // LBXcourseList
            // 
            this.LBXcourseList.BackColor = System.Drawing.Color.Green;
            this.LBXcourseList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBXcourseList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBXcourseList.ForeColor = System.Drawing.Color.White;
            this.LBXcourseList.FormattingEnabled = true;
            this.LBXcourseList.ItemHeight = 17;
            this.LBXcourseList.Location = new System.Drawing.Point(12, 379);
            this.LBXcourseList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBXcourseList.Name = "LBXcourseList";
            this.LBXcourseList.Size = new System.Drawing.Size(253, 223);
            this.LBXcourseList.TabIndex = 7;
            this.LBXcourseList.SelectedIndexChanged += new System.EventHandler(this.courseList_SelectedIndexChanged);
            // 
            // LBLselectedCoursesList
            // 
            this.LBLselectedCoursesList.AutoSize = true;
            this.LBLselectedCoursesList.BackColor = System.Drawing.Color.Green;
            this.LBLselectedCoursesList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLselectedCoursesList.ForeColor = System.Drawing.Color.White;
            this.LBLselectedCoursesList.Location = new System.Drawing.Point(13, 347);
            this.LBLselectedCoursesList.Name = "LBLselectedCoursesList";
            this.LBLselectedCoursesList.Size = new System.Drawing.Size(320, 16);
            this.LBLselectedCoursesList.TabIndex = 8;
            this.LBLselectedCoursesList.Text = "Your Selected Course Finals and Advised Study Time:";
            this.LBLselectedCoursesList.Click += new System.EventHandler(this.label3_Click);
            // 
            // CoursesDS
            // 
            this.CoursesDS.DataSetName = "CoursesDS";
            // 
            // selectedDS
            // 
            this.selectedDS.DataSetName = "NewDataSet";
            // 
            // startOverBTN
            // 
            this.startOverBTN.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOverBTN.Location = new System.Drawing.Point(172, 297);
            this.startOverBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startOverBTN.Name = "startOverBTN";
            this.startOverBTN.Size = new System.Drawing.Size(153, 36);
            this.startOverBTN.TabIndex = 9;
            this.startOverBTN.Text = "Start Over";
            this.startOverBTN.UseVisualStyleBackColor = true;
            this.startOverBTN.Click += new System.EventHandler(this.startOverBTN_Click);
            // 
            // LBLcourseName
            // 
            this.LBLcourseName.AutoSize = true;
            this.LBLcourseName.BackColor = System.Drawing.Color.Green;
            this.LBLcourseName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLcourseName.ForeColor = System.Drawing.Color.White;
            this.LBLcourseName.Location = new System.Drawing.Point(9, 135);
            this.LBLcourseName.Name = "LBLcourseName";
            this.LBLcourseName.Size = new System.Drawing.Size(103, 17);
            this.LBLcourseName.TabIndex = 10;
            this.LBLcourseName.Text = "Course Name:";
            // 
            // TXTcourse
            // 
            this.TXTcourse.Location = new System.Drawing.Point(110, 131);
            this.TXTcourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTcourse.Name = "TXTcourse";
            this.TXTcourse.ReadOnly = true;
            this.TXTcourse.Size = new System.Drawing.Size(215, 26);
            this.TXTcourse.TabIndex = 11;
            // 
            // TXTtime
            // 
            this.TXTtime.Location = new System.Drawing.Point(110, 165);
            this.TXTtime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTtime.Name = "TXTtime";
            this.TXTtime.ReadOnly = true;
            this.TXTtime.Size = new System.Drawing.Size(215, 26);
            this.TXTtime.TabIndex = 13;
            // 
            // LBLtime
            // 
            this.LBLtime.AutoSize = true;
            this.LBLtime.BackColor = System.Drawing.Color.Green;
            this.LBLtime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtime.ForeColor = System.Drawing.Color.White;
            this.LBLtime.Location = new System.Drawing.Point(9, 169);
            this.LBLtime.Name = "LBLtime";
            this.LBLtime.Size = new System.Drawing.Size(79, 17);
            this.LBLtime.TabIndex = 12;
            this.LBLtime.Text = "Final Time:";
            // 
            // LBXstudy
            // 
            this.LBXstudy.BackColor = System.Drawing.Color.Green;
            this.LBXstudy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBXstudy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBXstudy.ForeColor = System.Drawing.Color.White;
            this.LBXstudy.FormattingEnabled = true;
            this.LBXstudy.ItemHeight = 17;
            this.LBXstudy.Location = new System.Drawing.Point(271, 379);
            this.LBXstudy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBXstudy.Name = "LBXstudy";
            this.LBXstudy.Size = new System.Drawing.Size(75, 223);
            this.LBXstudy.TabIndex = 14;
            // 
            // GBdifficulty
            // 
            this.GBdifficulty.Controls.Add(this.RBeasy);
            this.GBdifficulty.Controls.Add(this.RB2);
            this.GBdifficulty.Controls.Add(this.RBmoderate);
            this.GBdifficulty.Controls.Add(this.RB4);
            this.GBdifficulty.Controls.Add(this.RBHard);
            this.GBdifficulty.Location = new System.Drawing.Point(6, 211);
            this.GBdifficulty.Name = "GBdifficulty";
            this.GBdifficulty.Size = new System.Drawing.Size(340, 66);
            this.GBdifficulty.TabIndex = 15;
            this.GBdifficulty.TabStop = false;
            this.GBdifficulty.Text = "Class Difficulty";
            // 
            // RBeasy
            // 
            this.RBeasy.AutoSize = true;
            this.RBeasy.Location = new System.Drawing.Point(256, 25);
            this.RBeasy.Name = "RBeasy";
            this.RBeasy.Size = new System.Drawing.Size(76, 24);
            this.RBeasy.TabIndex = 4;
            this.RBeasy.TabStop = true;
            this.RBeasy.Text = "Easy (1)";
            this.RBeasy.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(216, 26);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(34, 24);
            this.RB2.TabIndex = 3;
            this.RB2.TabStop = true;
            this.RB2.Text = "2";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RBmoderate
            // 
            this.RBmoderate.AutoSize = true;
            this.RBmoderate.Checked = true;
            this.RBmoderate.Location = new System.Drawing.Point(121, 25);
            this.RBmoderate.Name = "RBmoderate";
            this.RBmoderate.Size = new System.Drawing.Size(94, 24);
            this.RBmoderate.TabIndex = 2;
            this.RBmoderate.TabStop = true;
            this.RBmoderate.Text = "Medium (3)";
            this.RBmoderate.UseVisualStyleBackColor = true;
            // 
            // RB4
            // 
            this.RB4.AutoSize = true;
            this.RB4.Location = new System.Drawing.Point(83, 25);
            this.RB4.Name = "RB4";
            this.RB4.Size = new System.Drawing.Size(34, 24);
            this.RB4.TabIndex = 1;
            this.RB4.TabStop = true;
            this.RB4.Text = "4";
            this.RB4.UseVisualStyleBackColor = true;
            // 
            // RBHard
            // 
            this.RBHard.AutoSize = true;
            this.RBHard.Location = new System.Drawing.Point(9, 25);
            this.RBHard.Name = "RBHard";
            this.RBHard.Size = new System.Drawing.Size(74, 24);
            this.RBHard.TabIndex = 0;
            this.RBHard.TabStop = true;
            this.RBHard.Text = "Hard (5)";
            this.RBHard.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 51);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::LocalHack_FinalScheduler.Properties.Resources.MissouriS_T_Horizontal_DigitalMinerGreen;
            this.pbLogo.InitialImage = global::LocalHack_FinalScheduler.Properties.Resources.MissouriS_T_Horizontal_DigitalMinerGreen;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(286, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 17;
            this.pbLogo.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::LocalHack_FinalScheduler.Properties.Resources.iconfinder_close2_1814078;
            this.pbClose.InitialImage = global::LocalHack_FinalScheduler.Properties.Resources.iconfinder_close2_1814078;
            this.pbClose.Location = new System.Drawing.Point(928, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(100, 50);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 16;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Green;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(352, 684);
            this.splitter1.TabIndex = 18;
            this.splitter1.TabStop = false;
            // 
            // lblFinalTime
            // 
            this.lblFinalTime.BackColor = System.Drawing.Color.Red;
            this.lblFinalTime.ForeColor = System.Drawing.Color.Black;
            this.lblFinalTime.Location = new System.Drawing.Point(6, 22);
            this.lblFinalTime.Name = "lblFinalTime";
            this.lblFinalTime.Size = new System.Drawing.Size(129, 35);
            this.lblFinalTime.TabIndex = 19;
            this.lblFinalTime.Text = "Final Time";
            this.lblFinalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScheduleConflict
            // 
            this.lblScheduleConflict.BackColor = System.Drawing.Color.Yellow;
            this.lblScheduleConflict.ForeColor = System.Drawing.Color.Black;
            this.lblScheduleConflict.Location = new System.Drawing.Point(199, 22);
            this.lblScheduleConflict.Name = "lblScheduleConflict";
            this.lblScheduleConflict.Size = new System.Drawing.Size(129, 35);
            this.lblScheduleConflict.TabIndex = 20;
            this.lblScheduleConflict.Text = "Schedule Conflict";
            this.lblScheduleConflict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbLegend
            // 
            this.gbLegend.BackColor = System.Drawing.Color.Green;
            this.gbLegend.Controls.Add(this.lblFinalTime);
            this.gbLegend.Controls.Add(this.lblScheduleConflict);
            this.gbLegend.ForeColor = System.Drawing.Color.White;
            this.gbLegend.Location = new System.Drawing.Point(12, 607);
            this.gbLegend.Name = "gbLegend";
            this.gbLegend.Size = new System.Drawing.Size(334, 65);
            this.gbLegend.TabIndex = 21;
            this.gbLegend.TabStop = false;
            this.gbLegend.Text = "Legend";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 70;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Saturday";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.Width = 75;
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Sunday";
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            this.Sunday.Width = 75;
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Monday";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Width = 75;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Tuesday";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Width = 75;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Wednesday";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Width = 90;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Thursday";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Width = 75;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Friday";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Width = 75;
            // 
            // SchdlFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 684);
            this.Controls.Add(this.gbLegend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GBdifficulty);
            this.Controls.Add(this.LBXstudy);
            this.Controls.Add(this.TXTtime);
            this.Controls.Add(this.LBLtime);
            this.Controls.Add(this.TXTcourse);
            this.Controls.Add(this.LBLcourseName);
            this.Controls.Add(this.startOverBTN);
            this.Controls.Add(this.LBLselectedCoursesList);
            this.Controls.Add(this.LBXcourseList);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.calendarDGV);
            this.Controls.Add(this.LBLselectExam);
            this.Controls.Add(this.CMBcourse);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SchdlFRM";
            this.Text = "Final Schedule Planner";
            this.Load += new System.EventHandler(this.SchdlFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDS)).EndInit();
            this.GBdifficulty.ResumeLayout(false);
            this.GBdifficulty.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.gbLegend.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBcourse;
        private System.Windows.Forms.Label LBLselectExam;
        private System.Windows.Forms.DataGridView calendarDGV;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.ListBox LBXcourseList;
        private System.Windows.Forms.Label LBLselectedCoursesList;
        private System.Data.DataSet CoursesDS;
        private System.Data.DataSet selectedDS;
        private System.Windows.Forms.Button startOverBTN;
        private System.Windows.Forms.Label LBLcourseName;
        private System.Windows.Forms.TextBox TXTcourse;
        private System.Windows.Forms.TextBox TXTtime;
        private System.Windows.Forms.Label LBLtime;
        private System.Windows.Forms.ListBox LBXstudy;
        private System.Windows.Forms.GroupBox GBdifficulty;
        private System.Windows.Forms.RadioButton RBeasy;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RBmoderate;
        private System.Windows.Forms.RadioButton RB4;
        private System.Windows.Forms.RadioButton RBHard;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblFinalTime;
        private System.Windows.Forms.Label lblScheduleConflict;
        private System.Windows.Forms.GroupBox gbLegend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
    }
}


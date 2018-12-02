using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace LocalHack_FinalScheduler
{
    public partial class SchdlFRM : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        OleDbConnection Mainconnection = new OleDbConnection();

        //Connect the database to the project---------------------------------------------------------------------------------------------------------------------
        private void database()
        {
            try
            {
                string connect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FinalsWeek.accdb; Persist Security Info = False; ";
                Mainconnection.ConnectionString = connect;
                Mainconnection.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Database connection is wack" + err.Message,
                    "DATABASE ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //For the current course
        string selectedCourse = "";

        //Global strings to hold course info
        string courseName = "";
        string courseTime = "";
        string courseDay = "";
        string courseAMPM = "";
        string coursePosition = "";

        //Fill the combobox for courses---------------------------------------------------------------------------------------------------------------------------
        private void fillCourseComboBox()
        {
            try
            {
                //SQL to get the courses
                string courseList = "Select FinalsWeek.[Course Name] FROM FinalsWeek order by FinalsWeek.[Course Name]";

                //Get the info from the database
                OleDbDataAdapter DAforCourses = new OleDbDataAdapter(courseList, Mainconnection);

                DAforCourses.Fill(CoursesDS, "Course Name");
                CMBcourse.DataSource = CoursesDS.Tables[0];
                CMBcourse.DisplayMember = "Course Name";
                CMBcourse.ValueMember = "Course Name";
            }
            catch (Exception err)
            {
                MessageBox.Show("Combo Box Load Error" + err.Message,
                    "ComboBox ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public SchdlFRM()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //for creating the top bar
        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;

        //**********************************************************************
        //top border panel
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }
        }

        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }

        //Method to change specific cell in calendar----------------------------------------------------------------------------------------------------------------
        private void blockCalendar(string Name, string pos, string day)
        {
            try
            {
                //convert position into a number
                int position = Convert.ToInt32(pos);
                //See if there is already a final scheduled during the time slot
                bool doubleBooked = false;

                if(calendarDGV.Rows[position].Cells[day].Value != null && calendarDGV.Rows[position].Cells[day].Value.ToString() == Name + " ")
                {
                    //Do nothing, because we do not want to keep adding the same name into the calendar
                }
                if (calendarDGV.Rows[position].Cells[day].Value != null && calendarDGV.Rows[position].Cells[day].Value.ToString() != Name + " ")//If there is already a final scheduled for that time, do not add 
                {
                    doubleBooked = true;//Set doublebooked to true
                    //Let the user know that there is a conflict and they will need to resolve it
                    MessageBox.Show( Name + " " + calendarDGV.Rows[position].Cells[day].Value.ToString() + " are scheduled at the same time. Contact your professor or Registrar to reschedule.",
                        "Final Conflict", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Change cell to include the name of the final at that time slot
                    for (int i = 0; i < 4; i++)//blocks 4, 30 min time slots becuase each final is always 2 hours
                    {
                        calendarDGV.Rows[position].Cells[day].Value += Name + " ";//Add the name to the cell
                        calendarDGV.Rows[position].Cells[day].Style.BackColor = Color.Red;//Change the backcolor to red to indicate final is during time

                        if (doubleBooked == true)//If there are two finals change the backcolor to yellow to notify user
                        {
                            calendarDGV.Rows[position].Cells[day].Style.BackColor = Color.Yellow;
                        }
                        position++;//increment position to get to the next row in the datagridview
                    }
                }
                else if(calendarDGV.Rows[position].Cells[day].Value == null)
                {
                    for (int i = 0; i < 4; i++)//blocks 4, 30 min time slots becuase each final is always 2 hours
                    {
                        calendarDGV.Rows[position].Cells[day].Value += Name + " ";//Add the name to the cell
                        calendarDGV.Rows[position].Cells[day].Style.BackColor = Color.Red;//Change the backcolor to red to indicate final is during time
                        position++;
                    }
                }
               

            }
            catch (Exception err)
            {
                MessageBox.Show("Error in block calendar method: " + err.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to delete final from calendar-------------------------------------------------------------------------------------------------------------------
        private void removeCalendar()
        {
            try
            {
                calendarDGV.Rows.Clear();//Clears all the rows in the calendar

            }
            catch (Exception err)
            {
                MessageBox.Show("Error in remove block from calendar method: " + err.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to populate datagrid view with times---------------------------------------------------------------------------------------------------------------
        private void addTimes()
        {
            try
            {
                int time = 7;//Times start at 7am
                while (time != 12)//go until afternoon
                {
                    calendarDGV.Rows.Add(time.ToString() + ":00 AM");//populate first row
                    calendarDGV.Rows.Add(time.ToString() + ":30 AM");//populate second row with the half hour
                    time++;//increment the hour
                }

                calendarDGV.Rows.Add("12:00 PM");//populate first row
                calendarDGV.Rows.Add("12:30 PM");//populate second row with the half hour

                time = 1;//Reset time to 1 to signal after noon
                while (time != 8)//go until 8pm, because last final ends at 7pm
                {
                    calendarDGV.Rows.Add(time + ":00 PM");//populate first row
                    calendarDGV.Rows.Add(time + ":30 PM");//populate second row with the half hour
                    time++;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in add times method: " + err.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to calculate recommended time to study----------------------------------------------------------------------------------------------------------
        private string calStudyTime()
        {
            string timeStudy = "";
            try
            {
                if(RBHard.Checked == true)
                {
                    timeStudy = "6+ hours";
                }
                else if (RB4.Checked == true)
                {
                    timeStudy = "5-6 hours";
                }
                else if (RBmoderate.Checked == true)
                {
                    timeStudy = "3-5 hours";
                }
                else if (RB2.Checked == true)
                {
                    timeStudy = "2-3 hours";
                }
                else
                {
                    timeStudy = "0-2 hours";

                }
                return timeStudy;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in cal study time method: " + err.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return timeStudy;
        }

        //Form loading-------------------------------------------------------------------------------------------------------------------------------------------
        private void SchdlFRM_Load(object sender, EventArgs e)
        {
            try
            {
                //Disable add button until index change
                AddBTN.Enabled = false;
                //Access database
                database();
                //Fill the course combo box to 
                fillCourseComboBox();
                //Populate the datagridview with times
                addTimes();
            }
            catch (Exception err)
            {
                MessageBox.Show("Form Load Error" + err.Message,
                    "Form ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void majorCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Change index in courses combo box-------------------------------------------------------------------------------------------------------------------------
        private void CourseCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //String to hold current course selected
                selectedCourse = CMBcourse.SelectedValue.ToString();

                if (selectedCourse != "System.Data.DataRowView" || selectedCourse == "")
                {
                    //Enable add button
                    AddBTN.Enabled = true;

                    //string qry to get the courses
                    string coursesSQL = "SELECT FinalsWeek.[Course Name], FinalsWeek.[Day of Week], FinalsWeek.[Start Time], "
                        + " FinalsWeek.[AM/PM], FinalsWeek.[DayPosition] FROM FinalsWeek "
                        + "where FinalsWeek.[Course Name] = '" + selectedCourse + "'";

                    OleDbCommand coursesCommand = new OleDbCommand(coursesSQL, Mainconnection);

                    //Read the data
                    OleDbDataReader courseInfoReader = null;
                    courseInfoReader = coursesCommand.ExecuteReader();
                    courseInfoReader.Read();

                    //Assign the strings values
                    courseName = courseInfoReader[0].ToString();
                    courseDay = courseInfoReader[1].ToString();
                    courseTime = courseInfoReader[2].ToString();
                    courseAMPM = courseInfoReader[3].ToString();
                    coursePosition = courseInfoReader[4].ToString();

                    //Access current item in row and put into form
                    TXTcourse.Text = courseName;
                    TXTtime.Text = courseDay + ", " + courseTime
                        + " " + courseAMPM;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Error in change index: " + err.Message,
                    "Form ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //When the add button is clicked----------------------------------------------------------------------------------------------------------------------
        private void AddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //String to hold the course info to be put in the list box
                string currentAddition = courseName + ", " + courseDay + ", " + courseTime + " " + courseAMPM;
                //string to hold study time
                string studyTime = "";
                //Check to make sure the list box doesn't already have the same course
                if (LBXcourseList.Items.Contains(currentAddition))//Course is already in list
                {
                    MessageBox.Show("You've already added that course.", "Course Already Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Get study time and insert into same index that the course is stored in, in the course list box
                    int index = LBXcourseList.Items.IndexOf(currentAddition);
                    studyTime = calStudyTime();
                    LBXstudy.Items[index] = studyTime;
                }
                else//Add the course to the list
                {
                    //block out slots in the calendar for the final exam time
                    blockCalendar(courseName, coursePosition, courseDay);

                    LBXcourseList.Items.Add(courseName+ ", " + courseDay + ", " + courseTime + " " + courseAMPM);
                    studyTime = calStudyTime();
                    LBXstudy.Items.Add(studyTime);

                }

                
            }
            catch(Exception err)
            {
                MessageBox.Show("Error in add button: " + err.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void courseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Start over Method-------------------------------------------------------------------------------------------------------------------------------------
        private void startOverBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //Disable the user from adding a blank course
                AddBTN.Enabled = false;

                //Clear the form and necessary variables
                removeCalendar();
                addTimes();
                LBXcourseList.Items.Clear();
                LBXstudy.Items.Clear();
                TXTcourse.Clear();
                TXTtime.Clear();
                selectedCourse = "";
                courseName = "";
                courseTime = "";
                courseDay = "";
                courseAMPM = "";
                coursePosition = "";
                RBmoderate.Checked = true;
            }
            catch(Exception err)
            {
                MessageBox.Show("Error in start over button: " + err.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //mouse movements
        int mov;
        int movX;
        int movY;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

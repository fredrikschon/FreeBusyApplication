using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeBusyApplication
{
    public partial class FreeBusyForm : Form
    {

        Controller controller;
        DateTime dateStart;
        DateTime dateTo;
        string[] meeters;
        int officeHourStart;
        int officeHourEnd;
        double duration;

        HashSet<DateTime> hashDates = new HashSet<DateTime>();

        

        public FreeBusyForm()
        {
            InitializeComponent();
            controller = new Controller();
            controller.LoadData();
        }

        //Suggest Times button clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {           
            //get the values from View
            duration = (double)numDuration.Value;
            dateStart = dateTimeFrom.Value;
            dateTo = dateTimeTo.Value;
            meeters = txtEmpNr.Text.Split(',');
            officeHourStart = (int)numOfficeHourStart.Value;
            officeHourEnd = (int)numOfficeHourEnd.Value;

            GetAvailableDates();
        }

        //Book button clicked
        private void btnBookTime_Click(object sender, EventArgs e)
        {
            //get selected time and convert to DateTime
            DateTime selectedDate = DateTime.ParseExact(dataGridSuggestedMeetings.SelectedCells[0].Value.ToString(), "M/d/yyyy h:m:00 tt", CultureInfo.CreateSpecificCulture("en-US"));

            //create the time span of the meeting
            DateTime[] selectedDateArray = new DateTime[2] {selectedDate, selectedDate.AddMinutes(duration) };
            string names = "Meething with: ";
            foreach(string meeter in meeters){
                //add date time span to each of the Employees schedule
                controller.GetEmployee(meeter).AddToSchedule(selectedDateArray);
                names += controller.GetEmployee(meeter).GetName() + "; ";
            }

            GetAvailableDates();
            MessageBox.Show(names + "booked");
        }

        //make sure you can't go over the officeHours end-time with start-time
        private void numOfficeHourStart_ValueChanged(object sender, EventArgs e)
        {
            if (this.numOfficeHourStart.Value >= this.numOfficeHourEnd.Value)
            {
                this.numOfficeHourStart.Value -= 1;
            }
        }
        //make sure you can't go below the officeHours start-time with end-time
        private void numOfficeHourEnd_ValueChanged(object sender, EventArgs e)
        {
            if (this.numOfficeHourStart.Value >= this.numOfficeHourEnd.Value)
            {
                this.numOfficeHourEnd.Value += 1;
            }

        }

        private void GetAvailableDates()
        {
            //try get matching available times
            try
            {
                hashDates = controller.CheckTime(dateStart, dateTo, duration, meeters, officeHourStart, officeHourEnd);
            }
            catch (Exception err)
            {
                //feedback, empty grid and disable book-button! That emplyee doesn't exist if you're in this catch clause
                MessageBox.Show("No Employee with that ID");
                dataGridSuggestedMeetings.Rows.Clear();
                btnBookTime.Enabled = false;
                return;
            }

            //Some feedback if no times are found in the time span
            if (hashDates.Count == 0)
            {
                MessageBox.Show("No available times");
                dataGridSuggestedMeetings.Rows.Clear();
                btnBookTime.Enabled = false;
                return;
            }
            else
            {

                //empty grid
                dataGridSuggestedMeetings.Rows.Clear();
                //fill grid with available times
                foreach (DateTime date in hashDates)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridSuggestedMeetings);
                    row.Cells[0].Value = date.ToString("M/d/yyyy h:m:00 tt", CultureInfo.CreateSpecificCulture("en-US"));
                    dataGridSuggestedMeetings.Rows.Add(row);
                }
                //enable the book date button
                btnBookTime.Enabled = true;
            }
        }

        //label link clicked
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //popup InputBox from VB with a prompt to create a new user, primarily added for testing
            string input = Microsoft.VisualBasic.Interaction.InputBox("Create a new employee for system. Separate ID and NAME with a comma, like so: ID,NAME", "Create Employee", "NumericID,FirstName LastName", -1, -1);
            if (input.Length > 1)
            {
                String[] inputArray = input.Split(',');
                //create a new Emplyee from user input
                controller.CreateEmployee(new Employee(inputArray[0],inputArray[1]));

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace _421_Jail
{
    public partial class Inmate : Form
    {
        public Inmate()
        {
            InitializeComponent();
            this.inmateGrid.Columns.Add("Inmate ID", "Inmate ID");
            this.inmateGrid.Columns.Add("ISSN", "ISSN");
            this.inmateGrid.Columns.Add("Fname", "Fname");
            this.inmateGrid.Columns.Add("Lname", "Lname");
            this.inmateGrid.Columns.Add("Birthday", "ESSN");
            this.inmateGrid.Columns.Add("Health Status", "Health Status");
            this.inmateGrid.Columns.Add("Arrival Date", "Arrival Date");
            this.inmateGrid.Columns.Add("Years Left", "Years Left");
            this.inmateGrid.Columns.Add("Block ID", "Block ID");
            this.inmateGrid.Columns.Add("Crime ID", "Crime ID");
            this.ResetGrid();
            List<int> fillingC = InmateQueries.FillCrimeIDDropDown();
            List<int> fillingB = InmateQueries.FillBlockIDDropDown();
            foreach (var x in fillingC)
            {
                crimeIDDropDwn.Items.Add(x);
                editCrimeIDDropDwn.Items.Add(x);
            }
            foreach (var x in fillingB)
            {
                blockIDDropDown.Items.Add(x);
                editBlockIDDropDwn.Items.Add(x);
            }
        }

        private void ResetGrid()
        {
            this.inmateGrid.Rows.Clear();
            var inmates = InmateQueries.GetInmates();
            foreach (var x in inmates)
            {
                this.inmateGrid.Rows.Add(
                    x.InmateID,
                    x.ISSN,
                    x.Fname,
                    x.Lname,
                    x.Birthday,
                    x.HealthStatus,
                    x.ArrivalDate,
                    x.YearsLeft,
                    x.BlockID,
                    x.Crime_ID
                    );
            }
        }

        private bool CheckEntries(string inmateID, string issn, string fname, string lname, string healthStatus)
        {
            int holdInt;
            bool checkInts = int.TryParse(inmateID, out holdInt);
            var basicCheck = Regex.IsMatch(issn, @"^[0-9]{9}$") && Regex.IsMatch(fname, @"^[a-zA-Z]{1,20}$") 
                && Regex.IsMatch(lname, @"^[a-zA-Z]{1,20}$") && Regex.IsMatch(healthStatus, @"^[a-zA-Z]{1,4}$");
            return basicCheck && checkInts;
        }

        private void addInmateBtn_Click(object sender, EventArgs e)
        {
            bool check = CheckEntries(addIDTxt.Text, addSSNTxt.Text, addFnameTxt.Text, addLnameTxt.Text, addHealthTxt.Text);
            if (check == true)
            {
                InmateQueries.InmateAddition(Convert.ToInt32(addIDTxt.Text), addSSNTxt.Text, addFnameTxt.Text, addLnameTxt.Text, 
                    birthdayCalendar.SelectionRange.Start, addHealthTxt.Text, arrivalCalendar.SelectionRange.Start, Convert.ToInt32(yrsLeftDropDwn.Value), 
                    Convert.ToInt32(blockIDDropDown.SelectedItem.ToString()), Convert.ToInt32(crimeIDDropDwn.SelectedItem.ToString()));
                this.ResetGrid();
            }
            else
                tryAgainLbl.Text = "Please make sure all fields are valid";
        }

        private void findInmateBtn_Click(object sender, EventArgs e)
        {
            InmatesModel foundInmate = InmateQueries.InmateDisplayOne(Convert.ToInt32(editIDTxt.Text));
            if (foundInmate != null)
            {
                editSSNTxt.Text = foundInmate.ISSN;
                editFnameTxt.Text = foundInmate.Fname;
                editLnameTxt.Text = foundInmate.Lname;
                editBirthdayCalendar.SetDate(foundInmate.Birthday);
                editHealthTxt.Text = foundInmate.HealthStatus;
                editArrivalCalendar.SetDate(foundInmate.ArrivalDate);
                editYrsLeftDropDwn.Value = foundInmate.YearsLeft; //FIXME: DOUBLE?
                editCrimeIDDropDwn.SelectedItem = foundInmate.Crime_ID; //FIXME: DOUBLE?
                editBlockIDDropDwn.SelectedItem = foundInmate.BlockID; //FIXME: DOUBLE?
            }
            else
            {
                editSSNTxt.Text = "";
                editFnameTxt.Text = "";
                editLnameTxt.Text = "";
                editBirthdayCalendar.SetDate(DateTime.Now);
                editHealthTxt.Text = "";
                editArrivalCalendar.SetDate(DateTime.Now);
                editYrsLeftDropDwn.Value = 0; //FIXME: DOUBLE?
                editCrimeIDDropDwn.SelectedItem = 0; //FIXME: DOUBLE?
                editBlockIDDropDwn.SelectedItem = 0; //FIXME: DOUBLE?
            }
            this.ResetGrid();
        }

        private void editInmateBtn_Click(object sender, EventArgs e)
        {
            bool check = CheckEntries(addIDTxt.Text, addSSNTxt.Text, addFnameTxt.Text, addLnameTxt.Text, addHealthTxt.Text);
            if (check == true)
            {
                InmateQueries.InmateEdit(Convert.ToInt32(editIDTxt.Text), editFnameTxt.Text, editLnameTxt.Text, editBirthdayCalendar.SelectionRange.Start,
                    editHealthTxt.Text, editArrivalCalendar.SelectionRange.Start, Convert.ToInt32(editYrsLeftDropDwn.Value), Convert.ToInt32(editBlockIDDropDwn.SelectedItem.ToString()), Convert.ToInt32(editCrimeIDDropDwn.SelectedItem.ToString()));
                this.ResetGrid();
            }
            else
                tryAgainLbl.Text = "Please make sure all fields are valid";
        }

        private void deleteInmateBtn_Click(object sender, EventArgs e)
        {
            InmateQueries.InmateDeletion(Convert.ToInt32(deleteIDTxt.Text));
            this.ResetGrid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _421_Jail
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            this.EmployeeGrid.Columns.Add("Essn", "Essn");
            this.EmployeeGrid.Columns.Add("Fname", "Fname");
            this.EmployeeGrid.Columns.Add("Lname", "Lname");
            this.EmployeeGrid.Columns.Add("Birthday", "Birthday");
            this.EmployeeGrid.Columns.Add("Payroll", "Payroll");
            this.EmployeeGrid.Columns.Add("Street Address", "Street Address");
            this.EmployeeGrid.Columns.Add("City", "City");
            this.EmployeeGrid.Columns.Add("State", "State");
            this.EmployeeGrid.Columns.Add("Zip", "Zip");
            this.EmployeeGrid.Columns.Add("Employee Type", "Employee Type");
            this.EmployeeGrid.Columns.Add("Employee Type Info", "Employee Type Info");
            this.birthdayCal.MaxSelectionCount = 1;
            this.ResetGrid();
            typeTimer.Start();
        }

        private void ResetGrid()
        {
            this.EmployeeGrid.Rows.Clear();
            var employees = Queries.GetEmployees();
            foreach (var x in employees)
            {
                this.EmployeeGrid.Rows.Add(
                    x.ESSN,
                    x.Fname,
                    x.Lname,
                    x.Birthday,
                    x.Payroll,
                    x.StreetAddress,
                    x.City,
                    x.State,
                    x.Zip,
                    x.EmpType,
                    x.TypeInfo
                    );
            }
        }

        private bool CheckEntries(string essn, string fname, string lname, decimal payroll, string street, string city, string state, string zip, string type, string info)
        {
            var basicCheck = Regex.IsMatch(essn, @"^[0-9]{9}$") && Regex.IsMatch(fname, @"^[a-zA-Z]{1,20}$") && Regex.IsMatch(lname, @"^[a-zA-Z]{1,20}$")
                && Regex.IsMatch(street, @"^[a-zA-Z0-9\s]{1,50}$") && Regex.IsMatch(state, @"^[A-Z]{2}$") && Regex.IsMatch(zip, @"^[0-9]{5}$")
                && Regex.IsMatch(city, @"^[a-zA-Z]{1,20}$") && payroll > Decimal.Parse(0.0.ToString()) && type != "" && info != "";

            bool typeCheck = false;
            if ((type == "GUARD" || type == "DESK") && Regex.IsMatch(info, @"^[0-9]+$"))
            {
                typeCheck = true;
            }
            if(type == "CARE" && Regex.IsMatch(info, @"^[a-zA-Z]{1,20}$"))
            {
                typeCheck = true;
            }

            return basicCheck && typeCheck;
        }

        private void AddEButton_Click(object sender, EventArgs e)
        {
            bool check = CheckEntries(essnTxt.Text, fnameTxt.Text, lnameTxt.Text, payrollTxt.Value, streetTxt.Text,
                cityTxt.Text, stateTxt.Text, zipTxt.Text, empTypeComboBox.SelectedItem?.ToString(), empTypeInfoTxt.Text);
            
            if (check == true)
            {
                tryAgainLbl.Text = "";
                Queries.EmpAddition(essnTxt.Text, fnameTxt.Text, lnameTxt.Text, birthdayCal.SelectionRange.Start, payrollTxt.Value, streetTxt.Text,
                  cityTxt.Text, stateTxt.Text, zipTxt.Text, empTypeComboBox.SelectedItem?.ToString(), empTypeInfoTxt.Text);
                this.ResetGrid();
            }
            else
                tryAgainLbl.Text = "Please make sure all fields are valid";
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Employees emp = Queries.EmpDisplayOne(searchESSNTxt.Text);
            if (emp != null)
            {
                fnameEditTxt.Text = emp.Fname;
                lnameEditTxt.Text = emp.Lname;
                birthdayEditTxt.SetDate(emp.Birthday);
                payrollEditTxt.Value = emp.Payroll;
                streetEditTxt.Text = emp.StreetAddress;
                cityEditTxt.Text = emp.City;
                stateEditTxt.Text = emp.State;
                zipEditTxt.Text = emp.Zip;
                empTypeEditComboBox.SelectedItem = emp.EmpType;
                empInfoEditCombobox.Items.Add(emp.TypeInfo);
                empInfoEditCombobox.SelectedItem = emp.TypeInfo;
            }
            else
            {
                fnameEditTxt.Text = "";
                lnameEditTxt.Text = "";
                birthdayEditTxt.SetDate(DateTime.Now);
                payrollEditTxt.Value = 0;
                streetEditTxt.Text = "";
                cityEditTxt.Text = "";
                stateEditTxt.Text = "";
                zipEditTxt.Text = "";
                empTypeEditComboBox.SelectedItem = null;
                empInfoEditCombobox.SelectedItem = null;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Queries.EmpDeletion(deleteTxtbox.Text);
            this.ResetGrid();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            bool check = CheckEntries(searchESSNTxt.Text, fnameEditTxt.Text, lnameEditTxt.Text, payrollEditTxt.Value, streetEditTxt.Text,
                cityEditTxt.Text, stateEditTxt.Text, zipEditTxt.Text, empTypeEditComboBox.SelectedItem?.ToString(), empInfoEditCombobox.SelectedItem?.ToString());
            //bool checkGuard = Queries.CheckGuardsBlock(Convert.ToInt32(empInfoEditCombobox.SelectedItem?.ToString()));
            if (check == true )//&& checkGuard == true)
            {
                tryAgainLbl.Text = "";
                Queries.EmpEdit(searchESSNTxt.Text, fnameEditTxt.Text, lnameEditTxt.Text,
                  birthdayEditTxt.SelectionRange.Start, payrollEditTxt.Value, streetEditTxt.Text, cityEditTxt.Text,
                  stateEditTxt.Text, zipEditTxt.Text, empTypeEditComboBox.SelectedItem?.ToString(), empInfoEditCombobox.SelectedItem?.ToString());
                this.ResetGrid();
            }
            else
                tryAgainLbl.Text = "Please make sure all fields are valid";
        }

        private void typeTimer_Tick(object sender, EventArgs e)
        {
            string type = empTypeComboBox.SelectedItem?.ToString();
            string editType = empTypeEditComboBox.SelectedItem?.ToString();

            //checks first column
            if (type == "GUARD")
            {
                empTypeInfoLbl.Text = "Block ID";
            }
            else if (type == "DESK")
            {
                empTypeInfoLbl.Text = "Desk #";
            }
            else if (type == "CARE")
            {
                empTypeInfoLbl.Text = "Care Type";
            }

            //checks 2nd column
            if (editType == "GUARD")
            {
                editEmpTypeInfoLbl.Text = "Block ID";
                empInfoEditCombobox.Items.Clear();
                List<int> blockslist = Queries.GrabAssignedBlocks();
                foreach (var x in blockslist)
                    empInfoEditCombobox.Items.Add(x);
                typeTimer.Stop();
            }
            else if (editType == "DESK")
            {
                editEmpTypeInfoLbl.Text = "Desk #";
                empInfoEditCombobox.Items.Clear();
                List<int> deskslist = Queries.GrabDeskNumbers();
                foreach (var x in deskslist)
                    empInfoEditCombobox.Items.Add(x);
                typeTimer.Stop();

            }
            else if (editType == "CARE")
            {
                editEmpTypeInfoLbl.Text = "Care Type";
                empInfoEditCombobox.Items.Clear();
                List<string> carelist = Queries.GrabCareTypes();
                foreach (var x in carelist)
                    empInfoEditCombobox.Items.Add(x);
                typeTimer.Stop();
            }
            
        }

        private void empTypeBtn_Click(object sender, EventArgs e)
        {
            typeTimer.Start();
        }
    }
}

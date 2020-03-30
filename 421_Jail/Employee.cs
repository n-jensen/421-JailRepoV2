using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            this.EmployeeGrid.Columns.Add("Jail ID", "JailID");
            this.EmployeeGrid.Columns.Add("Street Address", "Street Address");
            this.EmployeeGrid.Columns.Add("City", "City");
            this.EmployeeGrid.Columns.Add("State", "State");
            this.EmployeeGrid.Columns.Add("Zip", "Zip");
            this.birthdayCal.MaxSelectionCount = 1;
            this.ResetGrid();
        }

        private void AddEButton_Click(object sender, EventArgs e)
        {
            Queries.EmpAddition(essnTxt.Text, fnameTxt.Text, lnameTxt.Text,
                birthdayCal.SelectionRange.Start, payrollTxt.Value, Int32.Parse(jailIDTxt.Value.ToString()),
                streetTxt.Text, cityTxt.Text, stateTxt.Text, zipTxt.Text);
            this.ResetGrid();
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
                    x.JailID,
                    x.StreetAddress,
                    x.City,
                    x.State,
                    x.Zip
                    );
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Employees emp = Queries.EmpDisplayOne(searchESSNTxt.Text);
            fnameEditTxt.Text = emp.Fname;
            lnameEditTxt.Text = emp.Lname;
            birthdayEditTxt.SetDate(emp.Birthday); 
            payrollEditTxt.Value = emp.Payroll;
            jailIDEditTxt.Value = emp.JailID;
            streetEditTxt.Text = emp.StreetAddress;
            cityEditTxt.Text = emp.City;
            stateEditTxt.Text = emp.State;
            zipEditTxt.Text = emp.Zip;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Queries.EmpDeletion(deleteTxtbox.Text);
            this.ResetGrid();
        }
    }
}

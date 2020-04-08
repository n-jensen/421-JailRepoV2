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
            this.EmployeeGrid.Columns.Add("Street Address", "Street Address");
            this.EmployeeGrid.Columns.Add("City", "City");
            this.EmployeeGrid.Columns.Add("State", "State");
            this.EmployeeGrid.Columns.Add("Zip", "Zip");
            this.EmployeeGrid.Columns.Add("Employee Type", "Employee Type");
            this.EmployeeGrid.Columns.Add("Employee Type Info", "Employee Type Info");
            this.birthdayCal.MaxSelectionCount = 1;
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
            return essn != "" && fname != "" && lname != "" && payroll > Decimal.Parse(0.0.ToString()) && street != "" && city != "" && state != "" && zip != "" && type != "" && info != ""
                && essn.Length == 9 && fname.Length <= 20 && lname.Length <= 20 && street.Length < 50 && city.Length < 20 && state.Length == 2 && zip.Length == 5;
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
                tryAgainLbl.Text = "Try Again :((";
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Employees emp = Queries.EmpDisplayOne(searchESSNTxt.Text);
            fnameEditTxt.Text = emp.Fname;
            lnameEditTxt.Text = emp.Lname;
            birthdayEditTxt.SetDate(emp.Birthday);
            payrollEditTxt.Value = emp.Payroll;
            streetEditTxt.Text = emp.StreetAddress;
            cityEditTxt.Text = emp.City;
            stateEditTxt.Text = emp.State;
            zipEditTxt.Text = emp.Zip;
            empTypeEditComboBox.SelectedItem = emp.EmpType;
            empInfoEditTxt.Text = emp.TypeInfo.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Queries.EmpDeletion(deleteTxtbox.Text);
            this.ResetGrid();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            bool check = CheckEntries(searchESSNTxt.Text, fnameEditTxt.Text, lnameEditTxt.Text, payrollEditTxt.Value, streetEditTxt.Text,
                cityEditTxt.Text, stateEditTxt.Text, zipEditTxt.Text, empTypeEditComboBox.SelectedItem?.ToString(), empInfoEditTxt.Text);
            if (check == true)
            {
                tryAgainLbl.Text = "";
                Queries.EmpEdit(searchESSNTxt.Text, fnameEditTxt.Text, lnameEditTxt.Text,
                  birthdayEditTxt.SelectionRange.Start, payrollEditTxt.Value, streetEditTxt.Text, cityEditTxt.Text,
                  stateEditTxt.Text, zipEditTxt.Text, empTypeEditComboBox.SelectedItem?.ToString(), empInfoEditTxt.Text);
                this.ResetGrid();
            }
            else
                tryAgainLbl.Text = "Try Again :(";
        }
<<<<<<< HEAD

          private void EmployeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }
     }
=======
    }
>>>>>>> be7c2e9c12f998197df94185d2c1fe517e99d25b
}

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
    public partial class Crime : Form
    {
        public Crime()
        {
            InitializeComponent();
            this.crimeGridView.Columns.Add("CrimeID", "Crime ID");
            this.crimeGridView.Columns.Add("Cname", "Cname");
            this.crimeGridView.Columns.Add("Severity", "Severity");
            this.ResetGrid();
        }

        public void ResetGrid()
        {
            this.crimeGridView.Rows.Clear();
            var crime = Queries.GetCrimeInfo();
            foreach (var x in crime)
            {
                this.crimeGridView.Rows.Add(
                    x.CrimeID,
                    x.CrimeName,
                    x.Severity
                    );
            }
        }

        private bool CheckEntries(string CrimeID, string CName, int Severity)
        {
            return CrimeID != "" && CName != "" && Severity > Decimal.Parse(0.0.ToString())
                && CrimeID.Length == 9 && CName.Length <= 20;
        }

        private void findCrimeButton_Click(object sender, EventArgs e)
        {
            int crimeIDVal = int.Parse(findCrimeIDTextbox.Text);
            Crimes crime1 = Queries.DisplayCrimeInfo(crimeIDVal);
            editCrimeNameTextBox.Text = crime1.CrimeName;
            Console.WriteLine(editCrimeNameTextBox.Text);
            editSeverityTextBox.Text = crime1.Severity.ToString();
            Console.WriteLine(editSeverityTextBox);
        }

        private void crimeDeleteButton_Click(object sender, EventArgs e)
        {
            int crimeIDVal = int.Parse(deleteCrimeTextBox.Text);
            Queries.CrimeDeletion(crimeIDVal);
            this.ResetGrid();
        }

       private void addCrimeButton(object sender, EventArgs e)
        {
           int crimeIDVal = int.Parse(addCrimeIDTextBox.Text);
            int userVal = int.Parse(addSeverity.Text);
            bool check = CheckEntries(addCrimeIDTextBox.Text, crimeTextbox.Text, userVal);
            if (check == true)
            {
                tryAgainLabel.Text = "";
                Queries.CrimeAddition(crimeIDVal, crimeTextbox.Text, userVal);
                this.ResetGrid();
            }
            else
            {
                tryAgainLabel.Text = "Try Again: ((";
            }

        }

        private void crimeEditButton_Click(object sender, EventArgs e)
        {
            int userVal = int.Parse(editSeverityTextBox.Text);
            int crimeIDVal = int.Parse(findCrimeIDTextbox.Text);
            bool check = CheckEntries(findCrimeIDTextbox.Text, editCrimeNameTextBox.Text, userVal);
            if(check == true)
            {
                tryAgainLabel.Text = "";
                Queries.CrimeEdit(crimeIDVal, editCrimeNameTextBox.Text, userVal);
                this.ResetGrid();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Crime_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addSeverityTextbox(object sender, EventArgs e)
        {

        }

        

        private void addMaximumYearsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addMinimumYearsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCrimeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void crimeGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addCrimeIDTextbox(object sender, EventArgs e)
        {

        }

        private void tryAgainLabel_Click(object sender, EventArgs e)
        {

        }

        private void addCrimeTextbox(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void findCrimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void findCrimeIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void editCrimeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void editSeverityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void deleteCrimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

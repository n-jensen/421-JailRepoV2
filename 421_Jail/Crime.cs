using System;
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

        private bool CheckEntries(int CrimeID, string CName, string Severity)
        {
            return CrimeID >= 0 && CName != "" && Severity != ""
                && CName.Length <= 20 && Severity.Length <= 20;
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
            string userVal = addSeverity.Text;
            bool check = CheckEntries(crimeIDVal, crimeTextbox.Text, userVal);
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
    }
}

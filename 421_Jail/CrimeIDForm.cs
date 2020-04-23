using System;
using System.Windows.Forms;

namespace _421_Jail
{
    public partial class CrimeIDForm : Form
    {
        public CrimeIDForm()
        {
            InitializeComponent();
            this.crimeIDGrid.Columns.Add("ID", "ID");
            this.crimeIDGrid.Columns.Add("Crime ID", "Crime ID");
            this.crimeIDGrid.Columns.Add("Inmate ID", "Inmate ID");
            this.crimeIDGrid.Columns.Add("Crime Name", "Crime Name");

            var IDs = CrimeIDQueries.PopulateDropDowns();
            foreach(string x in IDs)
            {
                FindInmateCombo.Items.Add(x);
                AddCrimeToInmateComboBox.Items.Add(x);
            }

            var crimes = CrimeIDQueries.getAllIdsOfCrimes();
            foreach(int x in crimes)
            {
                crimeDropDown.Items.Add(x);
            }
        }

        private void ResetGrid(int inmateId)
        {
            this.crimeIDGrid.Rows.Clear();
            var crimeids = CrimeIDQueries.GetOneCrimeID(inmateId);
            foreach (var x in crimeids)
            {
                this.crimeIDGrid.Rows.Add(
                    x.ID,
                    x.CrimeID,
                    x.InmateID,
                    x.CrimeName
                    );
            }
        }

        private void findIDBtn_Click(object sender, EventArgs e)
        {
            int inmateId;
            if(Int32.TryParse(FindInmateCombo?.SelectedItem?.ToString(), out inmateId))
            {
                this.ResetGrid(inmateId);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            int inmateID;
            if (Int32.TryParse(deleteTxt.Text, out id) && Int32.TryParse(deleteInmateIdTxt.Text, out inmateID))
            {
                CrimeIDQueries.DeleteCrimeID(id, inmateID);
                this.ResetGrid(inmateID);
            }
        }

        private void addCrime_Click(object sender, EventArgs e)
        {
            int crimeId;
            int inmateId;
            if(Int32.TryParse(crimeDropDown?.SelectedItem?.ToString(), out crimeId) && Int32.TryParse(AddCrimeToInmateComboBox?.SelectedItem?.ToString(), out inmateId))
            {
                CrimeIDQueries.AddCrimeID(crimeId, inmateId);
                this.ResetGrid(inmateId);
            }
        }
    }
}

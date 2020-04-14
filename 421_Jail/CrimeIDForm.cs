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
    public partial class CrimeIDForm : Form
    {
        public CrimeIDForm()
        {
            InitializeComponent();
            this.crimeIDGrid.Columns.Add("ID", "ID");
            this.crimeIDGrid.Columns.Add("CrimeID", "CrimeID");
            this.crimeIDGrid.Columns.Add("InmateID", "InmateID");
        }

        private void ResetGrid()
        {
            this.crimeIDGrid.Rows.Clear();
            var crimeids = CrimeIDQueries.GetAllCrimeIDs();
            foreach (var x in crimeids)
            {
                this.crimeIDGrid.Rows.Add(
                    x.ID,
                    x.CrimeID,
                    x.InmateID
                    );
            }
        }

        private void findIDBtn_Click(object sender, EventArgs e)
        {
            List<CrimeIDModel> crimeIdList = CrimeIDQueries.GetOneCrimeID(Convert.ToInt32(inmateIDTxt.Text));
            this.crimeIDGrid.Rows.Clear();
            foreach (var x in crimeIdList)
            {
                this.crimeIDGrid.Rows.Add(
                    x.ID,
                    x.CrimeID,
                    x.InmateID
                    );
            }
        }


    }
}

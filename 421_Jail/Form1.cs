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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void IButton_Click(object sender, EventArgs e)
        {
            Inmate inmate = new Inmate();
            inmate.Show();
        }

          private void BButton_Click_1(object sender, EventArgs e)
          {
               Block block = new Block();
               block.Show();
          }

        private void crimeIdBtn_Click(object sender, EventArgs e)
        {
            CrimeIDForm cid = new CrimeIDForm();
            cid.Show();
        }
    }
}

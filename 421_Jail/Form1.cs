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
    }
}

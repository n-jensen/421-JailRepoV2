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
     public partial class Block : Form
     {
          public Block()
          {
               InitializeComponent();
               this.BlockGrid.Columns.Add("BlockID", "BlockID");
               this.BlockGrid.Columns.Add("Bname", "Bname");
               this.BlockGrid.Columns.Add("Location", "Location");
               this.BlockGrid.Columns.Add("NumOfInmates", "NumOfInmates");
               this.ResetGrid();
               
          }
          public void ResetGrid()
          {
               this.BlockGrid.Rows.Clear();
               var block = Queries.GetBlockInfo();
               foreach (var x in block)
               {
                    this.BlockGrid.Rows.Add(
                         x.BlockID,
                         x.BName,
                         x.Location,
                         x.NumOfInmates
                         );
               }
          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void label1_Click_1(object sender, EventArgs e)
          {

          }

          private void label3_Click(object sender, EventArgs e)
          {

          }

          private void label5_Click(object sender, EventArgs e)
          {

          }

          private void label6_Click(object sender, EventArgs e)
          {

          }

          private void label8_Click(object sender, EventArgs e)
          {

          }

          private void label12_Click(object sender, EventArgs e)
          {

          }

          private void button3_Click(object sender, EventArgs e)
          {

          }


          private void BlockGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }
     }
}

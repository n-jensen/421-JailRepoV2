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

          private bool CheckEntries(string BlockID, string BName, string Location, int NumOfInmates)
          {
               return BlockID != "" && BName != "" && Location != "" && NumOfInmates > Decimal.Parse(0.0.ToString())   
                   && BlockID.Length == 9 && BName.Length <= 20 && Location.Length <= 20;
          }


          private void findBlockButton_Click(object sender, EventArgs e)
          {
               int blockIDVal = int.Parse(editBlockID.Text);
               BlockModel block1 = Queries.DisplayBlockInfo(blockIDVal);
               updateBlockName.Text = block1.BName;
               Console.WriteLine(updateBlockName.Text);
               updateBlockLocation.Text = block1.Location;
               Console.WriteLine(updateBlockLocation.Text);
               updateNumberOfInmates.Text = block1.NumOfInmates.ToString();
               Console.WriteLine(updateNumberOfInmates);
          }


          private void deleteBlockButton_Click(object sender, EventArgs e)
          {
               int blockIDVal = int.Parse(deleteBlockID.Text);
               Queries.BlockDeletion(blockIDVal);
               this.ResetGrid();
          }


          private void addBlockButton_Click_1(object sender, EventArgs e)
          {
               int userVal = int.Parse(addNumOfInmates.Text);
               int blockIDVal = int.Parse(addBlockID.Text);
               //int.TryParse(addNumOfInmates.Text, out userVal);`
               bool check = CheckEntries(addBlockID.Text, addBlockName.Text, addBlockLocation.Text, userVal);
               if (check == true)
               {
                    tryAgainLb2.Text = "";
                    Queries.BlockAddition(blockIDVal, addBlockName.Text, addBlockLocation.Text, userVal);
                    this.ResetGrid();
               }
               else
               {
                    tryAgainLb2.Text = "Try Again :((";
               }
          }

          private void editBlockButton_Click_1(object sender, EventArgs e)
          {
               int userVal = int.Parse(updateNumberOfInmates.Text);
               int blockIDVal = int.Parse(editBlockID.Text);
               //int.TryParse(addNumOfInmates.Text, out userVal);`
               bool check = CheckEntries(editBlockID.Text, updateBlockName.Text, updateBlockLocation.Text, userVal);
               if (check == true)
               {
                    tryAgainLb2.Text = "";
                    Queries.BlockEdit(blockIDVal, updateBlockName.Text, updateBlockLocation.Text, userVal);
                    this.ResetGrid();
               }
               else
               {
                    tryAgainLb2.Text = "Try Again :((";
               }
          }
     }
}

namespace _421_Jail
{
    partial class CrimeIDForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crimeIDGrid = new System.Windows.Forms.DataGridView();
            this.inmateIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findIDBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changesTxt = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.crimeIDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // crimeIDGrid
            // 
            this.crimeIDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crimeIDGrid.Location = new System.Drawing.Point(23, 120);
            this.crimeIDGrid.Name = "crimeIDGrid";
            this.crimeIDGrid.Size = new System.Drawing.Size(275, 232);
            this.crimeIDGrid.TabIndex = 0;
            // 
            // inmateIDTxt
            // 
            this.inmateIDTxt.Location = new System.Drawing.Point(23, 57);
            this.inmateIDTxt.Name = "inmateIDTxt";
            this.inmateIDTxt.Size = new System.Drawing.Size(100, 20);
            this.inmateIDTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter an inmate\'s ID to see all of his/her charges";
            // 
            // findIDBtn
            // 
            this.findIDBtn.Location = new System.Drawing.Point(23, 84);
            this.findIDBtn.Name = "findIDBtn";
            this.findIDBtn.Size = new System.Drawing.Size(100, 23);
            this.findIDBtn.TabIndex = 3;
            this.findIDBtn.Text = "Find Inmate";
            this.findIDBtn.UseVisualStyleBackColor = true;
            this.findIDBtn.Click += new System.EventHandler(this.findIDBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(283, 84);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(100, 23);
            this.changeBtn.TabIndex = 6;
            this.changeBtn.Text = "Find Inmate";
            this.changeBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter an inmate\'s ID to make changes??";
            // 
            // changesTxt
            // 
            this.changesTxt.Location = new System.Drawing.Point(283, 57);
            this.changesTxt.Name = "changesTxt";
            this.changesTxt.Size = new System.Drawing.Size(100, 20);
            this.changesTxt.TabIndex = 4;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(501, 84);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete Inmate";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter an inmate\'s ID to delete .....";
            // 
            // deleteTxt
            // 
            this.deleteTxt.Location = new System.Drawing.Point(501, 57);
            this.deleteTxt.Name = "deleteTxt";
            this.deleteTxt.Size = new System.Drawing.Size(100, 20);
            this.deleteTxt.TabIndex = 7;
            // 
            // CrimeIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 374);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteTxt);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changesTxt);
            this.Controls.Add(this.findIDBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inmateIDTxt);
            this.Controls.Add(this.crimeIDGrid);
            this.Name = "CrimeIDForm";
            this.Text = "CrimeIDForm";
            ((System.ComponentModel.ISupportInitialize)(this.crimeIDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView crimeIDGrid;
        private System.Windows.Forms.TextBox inmateIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findIDBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox changesTxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deleteTxt;
    }
}
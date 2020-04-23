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
            this.label1 = new System.Windows.Forms.Label();
            this.findIDBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteTxt = new System.Windows.Forms.TextBox();
            this.deleteInmateIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crimeDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addCrime = new System.Windows.Forms.Button();
            this.FindInmateCombo = new System.Windows.Forms.ComboBox();
            this.AddCrimeToInmateComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.crimeIDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // crimeIDGrid
            // 
            this.crimeIDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crimeIDGrid.Location = new System.Drawing.Point(23, 169);
            this.crimeIDGrid.Name = "crimeIDGrid";
            this.crimeIDGrid.Size = new System.Drawing.Size(585, 248);
            this.crimeIDGrid.TabIndex = 0;
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
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(304, 109);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete Crime Inmate";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter ID of the crime you wish to remove from the Inmate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // deleteTxt
            // 
            this.deleteTxt.Location = new System.Drawing.Point(306, 57);
            this.deleteTxt.Name = "deleteTxt";
            this.deleteTxt.Size = new System.Drawing.Size(100, 20);
            this.deleteTxt.TabIndex = 7;
            // 
            // deleteInmateIdTxt
            // 
            this.deleteInmateIdTxt.Location = new System.Drawing.Point(306, 83);
            this.deleteInmateIdTxt.Name = "deleteInmateIdTxt";
            this.deleteInmateIdTxt.Size = new System.Drawing.Size(100, 20);
            this.deleteInmateIdTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inmate ID";
            // 
            // crimeDropDown
            // 
            this.crimeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crimeDropDown.FormattingEnabled = true;
            this.crimeDropDown.Location = new System.Drawing.Point(603, 57);
            this.crimeDropDown.Name = "crimeDropDown";
            this.crimeDropDown.Size = new System.Drawing.Size(121, 21);
            this.crimeDropDown.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID of crime to add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Inmate ID";
            // 
            // addCrime
            // 
            this.addCrime.Location = new System.Drawing.Point(596, 109);
            this.addCrime.Name = "addCrime";
            this.addCrime.Size = new System.Drawing.Size(128, 23);
            this.addCrime.TabIndex = 16;
            this.addCrime.Text = "Add Crime To Inamte";
            this.addCrime.UseVisualStyleBackColor = true;
            this.addCrime.Click += new System.EventHandler(this.addCrime_Click);
            // 
            // FindInmateCombo
            // 
            this.FindInmateCombo.FormattingEnabled = true;
            this.FindInmateCombo.Location = new System.Drawing.Point(23, 57);
            this.FindInmateCombo.Name = "FindInmateCombo";
            this.FindInmateCombo.Size = new System.Drawing.Size(100, 21);
            this.FindInmateCombo.TabIndex = 17;
            // 
            // AddCrimeToInmateComboBox
            // 
            this.AddCrimeToInmateComboBox.FormattingEnabled = true;
            this.AddCrimeToInmateComboBox.Location = new System.Drawing.Point(603, 83);
            this.AddCrimeToInmateComboBox.Name = "AddCrimeToInmateComboBox";
            this.AddCrimeToInmateComboBox.Size = new System.Drawing.Size(100, 21);
            this.AddCrimeToInmateComboBox.TabIndex = 18;
            // 
            // CrimeIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 513);
            this.Controls.Add(this.AddCrimeToInmateComboBox);
            this.Controls.Add(this.FindInmateCombo);
            this.Controls.Add(this.addCrime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crimeDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteInmateIdTxt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteTxt);
            this.Controls.Add(this.findIDBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crimeIDGrid);
            this.Name = "CrimeIDForm";
            this.Text = "CrimeIDForm";
            ((System.ComponentModel.ISupportInitialize)(this.crimeIDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView crimeIDGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findIDBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deleteTxt;
        private System.Windows.Forms.TextBox deleteInmateIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox crimeDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addCrime;
        private System.Windows.Forms.ComboBox FindInmateCombo;
        private System.Windows.Forms.ComboBox AddCrimeToInmateComboBox;
    }
}
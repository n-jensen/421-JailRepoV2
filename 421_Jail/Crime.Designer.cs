namespace _421_Jail
{
    partial class Crime
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
            this.crimeAddButton = new System.Windows.Forms.Button();
            this.crimeNameLabel = new System.Windows.Forms.Label();
            this.crimeTextbox = new System.Windows.Forms.TextBox();
            this.addSeverity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crimeEditButton = new System.Windows.Forms.Button();
            this.crimeDeleteButton = new System.Windows.Forms.Button();
            this.editCrimeNameTextBox = new System.Windows.Forms.TextBox();
            this.findCrimeIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findCrimeLabel = new System.Windows.Forms.Label();
            this.findCrimeButton = new System.Windows.Forms.Button();
            this.addCrimeIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.crimeGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editSeverityTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteCrimeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tryAgainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crimeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // crimeAddButton
            // 
            this.crimeAddButton.Location = new System.Drawing.Point(43, 116);
            this.crimeAddButton.Name = "crimeAddButton";
            this.crimeAddButton.Size = new System.Drawing.Size(87, 21);
            this.crimeAddButton.TabIndex = 0;
            this.crimeAddButton.Text = "Add Crime";
            this.crimeAddButton.UseVisualStyleBackColor = true;
            this.crimeAddButton.Click += new System.EventHandler(this.addCrimeButton);
            // 
            // crimeNameLabel
            // 
            this.crimeNameLabel.AutoSize = true;
            this.crimeNameLabel.Location = new System.Drawing.Point(149, 67);
            this.crimeNameLabel.Name = "crimeNameLabel";
            this.crimeNameLabel.Size = new System.Drawing.Size(64, 13);
            this.crimeNameLabel.TabIndex = 1;
            this.crimeNameLabel.Text = "Crime Name";
            // 
            // crimeTextbox
            // 
            this.crimeTextbox.Location = new System.Drawing.Point(43, 64);
            this.crimeTextbox.Name = "crimeTextbox";
            this.crimeTextbox.Size = new System.Drawing.Size(100, 20);
            this.crimeTextbox.TabIndex = 2;
            // 
            // addSeverity
            // 
            this.addSeverity.Location = new System.Drawing.Point(43, 90);
            this.addSeverity.Name = "addSeverity";
            this.addSeverity.Size = new System.Drawing.Size(100, 20);
            this.addSeverity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Severity (1-5 rating)";
            // 
            // crimeEditButton
            // 
            this.crimeEditButton.Location = new System.Drawing.Point(305, 158);
            this.crimeEditButton.Name = "crimeEditButton";
            this.crimeEditButton.Size = new System.Drawing.Size(87, 21);
            this.crimeEditButton.TabIndex = 9;
            this.crimeEditButton.Text = "Edit";
            this.crimeEditButton.UseVisualStyleBackColor = true;
            this.crimeEditButton.Click += new System.EventHandler(this.crimeEditButton_Click_1);
            // 
            // crimeDeleteButton
            // 
            this.crimeDeleteButton.Location = new System.Drawing.Point(578, 64);
            this.crimeDeleteButton.Name = "crimeDeleteButton";
            this.crimeDeleteButton.Size = new System.Drawing.Size(87, 20);
            this.crimeDeleteButton.TabIndex = 10;
            this.crimeDeleteButton.Text = "Delete";
            this.crimeDeleteButton.UseVisualStyleBackColor = true;
            this.crimeDeleteButton.Click += new System.EventHandler(this.crimeDeleteButton_Click);
            // 
            // editCrimeNameTextBox
            // 
            this.editCrimeNameTextBox.Location = new System.Drawing.Point(305, 106);
            this.editCrimeNameTextBox.Name = "editCrimeNameTextBox";
            this.editCrimeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.editCrimeNameTextBox.TabIndex = 13;
            // 
            // findCrimeIDTextbox
            // 
            this.findCrimeIDTextbox.Location = new System.Drawing.Point(305, 38);
            this.findCrimeIDTextbox.Name = "findCrimeIDTextbox";
            this.findCrimeIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.findCrimeIDTextbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add a crime type:";
            // 
            // findCrimeLabel
            // 
            this.findCrimeLabel.AutoSize = true;
            this.findCrimeLabel.Location = new System.Drawing.Point(302, 9);
            this.findCrimeLabel.Name = "findCrimeLabel";
            this.findCrimeLabel.Size = new System.Drawing.Size(138, 13);
            this.findCrimeLabel.TabIndex = 17;
            this.findCrimeLabel.Text = "Enter Crime ID to edit crime:";
            // 
            // findCrimeButton
            // 
            this.findCrimeButton.Location = new System.Drawing.Point(305, 64);
            this.findCrimeButton.Name = "findCrimeButton";
            this.findCrimeButton.Size = new System.Drawing.Size(87, 20);
            this.findCrimeButton.TabIndex = 18;
            this.findCrimeButton.Text = "Find Crime";
            this.findCrimeButton.UseVisualStyleBackColor = true;
            this.findCrimeButton.Click += new System.EventHandler(this.findCrimeButton_Click);
            // 
            // addCrimeIDTextBox
            // 
            this.addCrimeIDTextBox.Location = new System.Drawing.Point(43, 38);
            this.addCrimeIDTextBox.Name = "addCrimeIDTextBox";
            this.addCrimeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.addCrimeIDTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Crime ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Choose what information to edit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Crime ID";
            // 
            // crimeGridView
            // 
            this.crimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crimeGridView.Location = new System.Drawing.Point(43, 185);
            this.crimeGridView.Name = "crimeGridView";
            this.crimeGridView.Size = new System.Drawing.Size(684, 232);
            this.crimeGridView.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Enter Crime ID to delete crime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Crime Name";
            // 
            // editSeverityTextBox
            // 
            this.editSeverityTextBox.Location = new System.Drawing.Point(305, 132);
            this.editSeverityTextBox.Name = "editSeverityTextBox";
            this.editSeverityTextBox.Size = new System.Drawing.Size(100, 20);
            this.editSeverityTextBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Severity (1-5 rating)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(411, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "(5 being the worse)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "(5 being the worse)";
            // 
            // deleteCrimeTextBox
            // 
            this.deleteCrimeTextBox.Location = new System.Drawing.Point(578, 38);
            this.deleteCrimeTextBox.Name = "deleteCrimeTextBox";
            this.deleteCrimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.deleteCrimeTextBox.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(684, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Crime ID";
            // 
            // tryAgainLabel
            // 
            this.tryAgainLabel.AutoSize = true;
            this.tryAgainLabel.Location = new System.Drawing.Point(40, 145);
            this.tryAgainLabel.Name = "tryAgainLabel";
            this.tryAgainLabel.Size = new System.Drawing.Size(35, 13);
            this.tryAgainLabel.TabIndex = 34;
            this.tryAgainLabel.Text = "label8";
            // 
            // Crime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tryAgainLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.deleteCrimeTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.editSeverityTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.crimeGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addCrimeIDTextBox);
            this.Controls.Add(this.findCrimeButton);
            this.Controls.Add(this.findCrimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editCrimeNameTextBox);
            this.Controls.Add(this.findCrimeIDTextbox);
            this.Controls.Add(this.crimeDeleteButton);
            this.Controls.Add(this.crimeEditButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addSeverity);
            this.Controls.Add(this.crimeTextbox);
            this.Controls.Add(this.crimeNameLabel);
            this.Controls.Add(this.crimeAddButton);
            this.Name = "Crime";
            this.Text = "Crime";
            ((System.ComponentModel.ISupportInitialize)(this.crimeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crimeAddButton;
        private System.Windows.Forms.Label crimeNameLabel;
        private System.Windows.Forms.TextBox crimeTextbox;
        private System.Windows.Forms.TextBox addSeverity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button crimeEditButton;
        private System.Windows.Forms.Button crimeDeleteButton;
        private System.Windows.Forms.TextBox editCrimeNameTextBox;
        private System.Windows.Forms.TextBox findCrimeIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label findCrimeLabel;
        private System.Windows.Forms.Button findCrimeButton;
        private System.Windows.Forms.TextBox addCrimeIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView crimeGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editSeverityTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox deleteCrimeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label tryAgainLabel;
    }
}
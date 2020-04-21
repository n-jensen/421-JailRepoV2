namespace _421_Jail
{
    partial class MainMenu
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
            this.JButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.IButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.BButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.crimeIdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JButton
            // 
            this.JButton.BackColor = System.Drawing.Color.PowderBlue;
            this.JButton.Location = new System.Drawing.Point(60, 150);
            this.JButton.Name = "JButton";
            this.JButton.Size = new System.Drawing.Size(92, 77);
            this.JButton.TabIndex = 0;
            this.JButton.Text = "Jail Information ";
            this.JButton.UseVisualStyleBackColor = false;
            // 
            // EButton
            // 
            this.EButton.BackColor = System.Drawing.Color.PowderBlue;
            this.EButton.Location = new System.Drawing.Point(171, 150);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(92, 77);
            this.EButton.TabIndex = 1;
            this.EButton.Text = "Employee Information";
            this.EButton.UseVisualStyleBackColor = false;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // IButton
            // 
            this.IButton.BackColor = System.Drawing.Color.PowderBlue;
            this.IButton.Location = new System.Drawing.Point(287, 150);
            this.IButton.Name = "IButton";
            this.IButton.Size = new System.Drawing.Size(92, 77);
            this.IButton.TabIndex = 2;
            this.IButton.Text = "Inmate Information";
            this.IButton.UseVisualStyleBackColor = false;
            this.IButton.Click += new System.EventHandler(this.IButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.PowderBlue;
            this.CButton.Location = new System.Drawing.Point(405, 150);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(92, 77);
            this.CButton.TabIndex = 3;
            this.CButton.Text = "Crime Information";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click_1);
            // 
            // BButton
            // 
            this.BButton.BackColor = System.Drawing.Color.PowderBlue;
            this.BButton.Location = new System.Drawing.Point(523, 150);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(92, 77);
            this.BButton.TabIndex = 4;
            this.BButton.Text = "Block Information";
            this.BButton.UseVisualStyleBackColor = false;
            this.BButton.Click += new System.EventHandler(this.BButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(214, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose what you want to view!";
            // 
            // crimeIdBtn
            // 
            this.crimeIdBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.crimeIdBtn.Location = new System.Drawing.Point(644, 150);
            this.crimeIdBtn.Name = "crimeIdBtn";
            this.crimeIdBtn.Size = new System.Drawing.Size(92, 77);
            this.crimeIdBtn.TabIndex = 6;
            this.crimeIdBtn.Text = "Inmate Crimes";
            this.crimeIdBtn.UseVisualStyleBackColor = false;
            this.crimeIdBtn.Click += new System.EventHandler(this.crimeIdBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crimeIdBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.IButton);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.JButton);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button IButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crimeIdBtn;
    }
}


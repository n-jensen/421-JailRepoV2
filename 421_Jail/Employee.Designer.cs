namespace _421_Jail
{
    partial class Employee
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
            this.essnTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addEButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.deleteTxtbox = new System.Windows.Forms.TextBox();
            this.searchESSNTxt = new System.Windows.Forms.TextBox();
            this.fnameEditTxt = new System.Windows.Forms.TextBox();
            this.lnameEditTxt = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.findButton = new System.Windows.Forms.Button();
            this.birthdayCal = new System.Windows.Forms.MonthCalendar();
            this.payrollTxt = new System.Windows.Forms.NumericUpDown();
            this.payrollEditTxt = new System.Windows.Forms.NumericUpDown();
            this.birthdayEditTxt = new System.Windows.Forms.MonthCalendar();
            this.streetTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.stateTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.zipTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.zipEditTxt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.stateEditTxt = new System.Windows.Forms.TextBox();
            this.cityEditTxt = new System.Windows.Forms.TextBox();
            this.streetEditTxt = new System.Windows.Forms.TextBox();
            this.empTypeComboBox = new System.Windows.Forms.ComboBox();
            this.empTypeInfoLbl2 = new System.Windows.Forms.Label();
            this.empTypeInfoTxt = new System.Windows.Forms.TextBox();
            this.empTypeLbl = new System.Windows.Forms.Label();
            this.editEmpTypeInfoLbl = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.empTypeEditComboBox = new System.Windows.Forms.ComboBox();
            this.tryAgainLbl = new System.Windows.Forms.Label();
            this.empInfoEditCombobox = new System.Windows.Forms.ComboBox();
            this.empInfoEditTxt = new System.Windows.Forms.TextBox();
            this.editEmpTypeInfoLbl2 = new System.Windows.Forms.Label();
            this.empTypeInfoLbl = new System.Windows.Forms.Label();
            this.empTypeInfoCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollEditTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // essnTxt
            // 
            this.essnTxt.Location = new System.Drawing.Point(32, 52);
            this.essnTxt.Name = "essnTxt";
            this.essnTxt.Size = new System.Drawing.Size(100, 20);
            this.essnTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add an employee\'s information:";
            // 
            // addEButton
            // 
            this.addEButton.Location = new System.Drawing.Point(31, 537);
            this.addEButton.Name = "addEButton";
            this.addEButton.Size = new System.Drawing.Size(100, 23);
            this.addEButton.TabIndex = 12;
            this.addEButton.Text = "Add Employee";
            this.addEButton.UseVisualStyleBackColor = true;
            this.addEButton.Click += new System.EventHandler(this.AddEButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter an employee\'s SSN to delete them:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ESSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "First name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Payroll";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(321, 587);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 23);
            this.editButton.TabIndex = 30;
            this.editButton.Text = "Edit Employee";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Enter an Employee\'s SSN to edit their information:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(787, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "ESSN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "ESSN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(444, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Payroll";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(548, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Birthday";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(427, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Last name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(427, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "First name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(318, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Choose what information to edit:";
            // 
            // fnameTxt
            // 
            this.fnameTxt.Location = new System.Drawing.Point(32, 80);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(100, 20);
            this.fnameTxt.TabIndex = 43;
            // 
            // lnameTxt
            // 
            this.lnameTxt.Location = new System.Drawing.Point(32, 106);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(100, 20);
            this.lnameTxt.TabIndex = 44;
            // 
            // deleteTxtbox
            // 
            this.deleteTxtbox.Location = new System.Drawing.Point(681, 52);
            this.deleteTxtbox.Name = "deleteTxtbox";
            this.deleteTxtbox.Size = new System.Drawing.Size(100, 20);
            this.deleteTxtbox.TabIndex = 49;
            // 
            // searchESSNTxt
            // 
            this.searchESSNTxt.Location = new System.Drawing.Point(321, 52);
            this.searchESSNTxt.Name = "searchESSNTxt";
            this.searchESSNTxt.Size = new System.Drawing.Size(100, 20);
            this.searchESSNTxt.TabIndex = 51;
            // 
            // fnameEditTxt
            // 
            this.fnameEditTxt.Location = new System.Drawing.Point(321, 132);
            this.fnameEditTxt.Name = "fnameEditTxt";
            this.fnameEditTxt.Size = new System.Drawing.Size(100, 20);
            this.fnameEditTxt.TabIndex = 52;
            // 
            // lnameEditTxt
            // 
            this.lnameEditTxt.Location = new System.Drawing.Point(321, 158);
            this.lnameEditTxt.Name = "lnameEditTxt";
            this.lnameEditTxt.Size = new System.Drawing.Size(100, 20);
            this.lnameEditTxt.TabIndex = 53;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(681, 77);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 58;
            this.deleteButton.Text = "Delete Employee";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Location = new System.Drawing.Point(542, 389);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.Size = new System.Drawing.Size(650, 220);
            this.EmployeeGrid.TabIndex = 60;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(321, 77);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(100, 23);
            this.findButton.TabIndex = 61;
            this.findButton.Text = "Find Employee";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // birthdayCal
            // 
            this.birthdayCal.Location = new System.Drawing.Point(32, 138);
            this.birthdayCal.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.birthdayCal.MaxSelectionCount = 1;
            this.birthdayCal.Name = "birthdayCal";
            this.birthdayCal.ShowToday = false;
            this.birthdayCal.ShowTodayCircle = false;
            this.birthdayCal.TabIndex = 63;
            // 
            // payrollTxt
            // 
            this.payrollTxt.DecimalPlaces = 2;
            this.payrollTxt.Location = new System.Drawing.Point(32, 309);
            this.payrollTxt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.payrollTxt.Name = "payrollTxt";
            this.payrollTxt.Size = new System.Drawing.Size(120, 20);
            this.payrollTxt.TabIndex = 64;
            // 
            // payrollEditTxt
            // 
            this.payrollEditTxt.DecimalPlaces = 2;
            this.payrollEditTxt.Location = new System.Drawing.Point(321, 364);
            this.payrollEditTxt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.payrollEditTxt.Name = "payrollEditTxt";
            this.payrollEditTxt.Size = new System.Drawing.Size(120, 20);
            this.payrollEditTxt.TabIndex = 66;
            // 
            // birthdayEditTxt
            // 
            this.birthdayEditTxt.Location = new System.Drawing.Point(321, 190);
            this.birthdayEditTxt.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.birthdayEditTxt.MaxSelectionCount = 1;
            this.birthdayEditTxt.Name = "birthdayEditTxt";
            this.birthdayEditTxt.ShowToday = false;
            this.birthdayEditTxt.ShowTodayCircle = false;
            this.birthdayEditTxt.TabIndex = 68;
            // 
            // streetTxt
            // 
            this.streetTxt.Location = new System.Drawing.Point(32, 339);
            this.streetTxt.Name = "streetTxt";
            this.streetTxt.Size = new System.Drawing.Size(100, 20);
            this.streetTxt.TabIndex = 69;
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(32, 367);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(100, 20);
            this.cityTxt.TabIndex = 70;
            // 
            // stateTxt
            // 
            this.stateTxt.Location = new System.Drawing.Point(32, 396);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(100, 20);
            this.stateTxt.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Street";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(138, 399);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 73;
            this.label20.Text = "State";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(138, 370);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 13);
            this.label21.TabIndex = 74;
            this.label21.Text = "City";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(138, 428);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 76;
            this.label22.Text = "Zip";
            // 
            // zipTxt
            // 
            this.zipTxt.Location = new System.Drawing.Point(32, 425);
            this.zipTxt.Name = "zipTxt";
            this.zipTxt.Size = new System.Drawing.Size(100, 20);
            this.zipTxt.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Zip";
            // 
            // zipEditTxt
            // 
            this.zipEditTxt.Location = new System.Drawing.Point(321, 479);
            this.zipEditTxt.Name = "zipEditTxt";
            this.zipEditTxt.Size = new System.Drawing.Size(100, 20);
            this.zipEditTxt.TabIndex = 83;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(427, 424);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 13);
            this.label23.TabIndex = 82;
            this.label23.Text = "City";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(427, 453);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 81;
            this.label24.Text = "State";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(424, 396);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 80;
            this.label25.Text = "Street";
            // 
            // stateEditTxt
            // 
            this.stateEditTxt.Location = new System.Drawing.Point(321, 450);
            this.stateEditTxt.Name = "stateEditTxt";
            this.stateEditTxt.Size = new System.Drawing.Size(100, 20);
            this.stateEditTxt.TabIndex = 79;
            // 
            // cityEditTxt
            // 
            this.cityEditTxt.Location = new System.Drawing.Point(321, 421);
            this.cityEditTxt.Name = "cityEditTxt";
            this.cityEditTxt.Size = new System.Drawing.Size(100, 20);
            this.cityEditTxt.TabIndex = 78;
            // 
            // streetEditTxt
            // 
            this.streetEditTxt.Location = new System.Drawing.Point(321, 393);
            this.streetEditTxt.Name = "streetEditTxt";
            this.streetEditTxt.Size = new System.Drawing.Size(100, 20);
            this.streetEditTxt.TabIndex = 77;
            // 
            // empTypeComboBox
            // 
            this.empTypeComboBox.FormattingEnabled = true;
            this.empTypeComboBox.Items.AddRange(new object[] {
            "GUARD",
            "DESK",
            "CARE"});
            this.empTypeComboBox.Location = new System.Drawing.Point(31, 457);
            this.empTypeComboBox.Name = "empTypeComboBox";
            this.empTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.empTypeComboBox.TabIndex = 85;
            this.empTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.empTypeComboBox_SelectedIndexChanged);
            // 
            // empTypeInfoLbl2
            // 
            this.empTypeInfoLbl2.AutoSize = true;
            this.empTypeInfoLbl2.Location = new System.Drawing.Point(137, 514);
            this.empTypeInfoLbl2.Name = "empTypeInfoLbl2";
            this.empTypeInfoLbl2.Size = new System.Drawing.Size(74, 13);
            this.empTypeInfoLbl2.TabIndex = 87;
            this.empTypeInfoLbl2.Text = "Employee Info";
            // 
            // empTypeInfoTxt
            // 
            this.empTypeInfoTxt.Location = new System.Drawing.Point(31, 511);
            this.empTypeInfoTxt.Name = "empTypeInfoTxt";
            this.empTypeInfoTxt.Size = new System.Drawing.Size(100, 20);
            this.empTypeInfoTxt.TabIndex = 86;
            // 
            // empTypeLbl
            // 
            this.empTypeLbl.AutoSize = true;
            this.empTypeLbl.Location = new System.Drawing.Point(158, 465);
            this.empTypeLbl.Name = "empTypeLbl";
            this.empTypeLbl.Size = new System.Drawing.Size(80, 13);
            this.empTypeLbl.TabIndex = 88;
            this.empTypeLbl.Text = "Employee Type";
            // 
            // editEmpTypeInfoLbl
            // 
            this.editEmpTypeInfoLbl.AutoSize = true;
            this.editEmpTypeInfoLbl.Location = new System.Drawing.Point(444, 537);
            this.editEmpTypeInfoLbl.Name = "editEmpTypeInfoLbl";
            this.editEmpTypeInfoLbl.Size = new System.Drawing.Size(74, 13);
            this.editEmpTypeInfoLbl.TabIndex = 92;
            this.editEmpTypeInfoLbl.Text = "Employee Info";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(444, 510);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 13);
            this.label27.TabIndex = 90;
            this.label27.Text = "Employee Type";
            // 
            // empTypeEditComboBox
            // 
            this.empTypeEditComboBox.DropDownHeight = 150;
            this.empTypeEditComboBox.FormattingEnabled = true;
            this.empTypeEditComboBox.IntegralHeight = false;
            this.empTypeEditComboBox.Items.AddRange(new object[] {
            "GUARD",
            "DESK",
            "CARE"});
            this.empTypeEditComboBox.Location = new System.Drawing.Point(321, 507);
            this.empTypeEditComboBox.Name = "empTypeEditComboBox";
            this.empTypeEditComboBox.Size = new System.Drawing.Size(121, 21);
            this.empTypeEditComboBox.TabIndex = 93;
            this.empTypeEditComboBox.SelectedIndexChanged += new System.EventHandler(this.empTypeEditComboBox_SelectedIndexChanged);
            // 
            // tryAgainLbl
            // 
            this.tryAgainLbl.AutoSize = true;
            this.tryAgainLbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgainLbl.Location = new System.Drawing.Point(770, 342);
            this.tryAgainLbl.Name = "tryAgainLbl";
            this.tryAgainLbl.Size = new System.Drawing.Size(0, 24);
            this.tryAgainLbl.TabIndex = 94;
            // 
            // empInfoEditCombobox
            // 
            this.empInfoEditCombobox.FormattingEnabled = true;
            this.empInfoEditCombobox.IntegralHeight = false;
            this.empInfoEditCombobox.Items.AddRange(new object[] {
            "GUARD",
            "DESK",
            "CARE"});
            this.empInfoEditCombobox.Location = new System.Drawing.Point(321, 534);
            this.empInfoEditCombobox.Name = "empInfoEditCombobox";
            this.empInfoEditCombobox.Size = new System.Drawing.Size(121, 21);
            this.empInfoEditCombobox.TabIndex = 95;
            // 
            // empInfoEditTxt
            // 
            this.empInfoEditTxt.Location = new System.Drawing.Point(321, 561);
            this.empInfoEditTxt.Name = "empInfoEditTxt";
            this.empInfoEditTxt.Size = new System.Drawing.Size(100, 20);
            this.empInfoEditTxt.TabIndex = 97;
            // 
            // editEmpTypeInfoLbl2
            // 
            this.editEmpTypeInfoLbl2.AutoSize = true;
            this.editEmpTypeInfoLbl2.Location = new System.Drawing.Point(427, 564);
            this.editEmpTypeInfoLbl2.Name = "editEmpTypeInfoLbl2";
            this.editEmpTypeInfoLbl2.Size = new System.Drawing.Size(74, 13);
            this.editEmpTypeInfoLbl2.TabIndex = 98;
            this.editEmpTypeInfoLbl2.Text = "Employee Info";
            // 
            // empTypeInfoLbl
            // 
            this.empTypeInfoLbl.AutoSize = true;
            this.empTypeInfoLbl.Location = new System.Drawing.Point(154, 487);
            this.empTypeInfoLbl.Name = "empTypeInfoLbl";
            this.empTypeInfoLbl.Size = new System.Drawing.Size(74, 13);
            this.empTypeInfoLbl.TabIndex = 99;
            this.empTypeInfoLbl.Text = "Employee Info";
            // 
            // empTypeInfoCombobox
            // 
            this.empTypeInfoCombobox.FormattingEnabled = true;
            this.empTypeInfoCombobox.Location = new System.Drawing.Point(31, 485);
            this.empTypeInfoCombobox.Name = "empTypeInfoCombobox";
            this.empTypeInfoCombobox.Size = new System.Drawing.Size(121, 21);
            this.empTypeInfoCombobox.TabIndex = 100;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1204, 701);
            this.Controls.Add(this.empTypeInfoCombobox);
            this.Controls.Add(this.empTypeInfoLbl);
            this.Controls.Add(this.editEmpTypeInfoLbl2);
            this.Controls.Add(this.empInfoEditTxt);
            this.Controls.Add(this.empInfoEditCombobox);
            this.Controls.Add(this.tryAgainLbl);
            this.Controls.Add(this.empTypeEditComboBox);
            this.Controls.Add(this.editEmpTypeInfoLbl);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.empTypeLbl);
            this.Controls.Add(this.empTypeInfoLbl2);
            this.Controls.Add(this.empTypeInfoTxt);
            this.Controls.Add(this.empTypeComboBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.zipEditTxt);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.stateEditTxt);
            this.Controls.Add(this.cityEditTxt);
            this.Controls.Add(this.streetEditTxt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.zipTxt);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stateTxt);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.streetTxt);
            this.Controls.Add(this.birthdayEditTxt);
            this.Controls.Add(this.payrollEditTxt);
            this.Controls.Add(this.payrollTxt);
            this.Controls.Add(this.birthdayCal);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.lnameEditTxt);
            this.Controls.Add(this.fnameEditTxt);
            this.Controls.Add(this.searchESSNTxt);
            this.Controls.Add(this.deleteTxtbox);
            this.Controls.Add(this.lnameTxt);
            this.Controls.Add(this.fnameTxt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addEButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.essnTxt);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollEditTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox essnTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.TextBox deleteTxtbox;
        private System.Windows.Forms.TextBox searchESSNTxt;
        private System.Windows.Forms.TextBox fnameEditTxt;
        private System.Windows.Forms.TextBox lnameEditTxt;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.MonthCalendar birthdayCal;
        private System.Windows.Forms.NumericUpDown payrollTxt;
        private System.Windows.Forms.NumericUpDown payrollEditTxt;
        private System.Windows.Forms.MonthCalendar birthdayEditTxt;
        private System.Windows.Forms.TextBox streetTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox stateTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox zipTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox zipEditTxt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox stateEditTxt;
        private System.Windows.Forms.TextBox cityEditTxt;
        private System.Windows.Forms.TextBox streetEditTxt;
        private System.Windows.Forms.ComboBox empTypeComboBox;
        private System.Windows.Forms.Label empTypeInfoLbl2;
        private System.Windows.Forms.TextBox empTypeInfoTxt;
        private System.Windows.Forms.Label empTypeLbl;
        private System.Windows.Forms.Label editEmpTypeInfoLbl;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox empTypeEditComboBox;
        private System.Windows.Forms.Label tryAgainLbl;
        private System.Windows.Forms.ComboBox empInfoEditCombobox;
        private System.Windows.Forms.TextBox empInfoEditTxt;
        private System.Windows.Forms.Label editEmpTypeInfoLbl2;
        private System.Windows.Forms.Label empTypeInfoLbl;
        private System.Windows.Forms.ComboBox empTypeInfoCombobox;
    }
}
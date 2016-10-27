using Model;

namespace GUI
{
    partial class Gui
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnCustClear = new System.Windows.Forms.Button();
            this.txtCustMail = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustAddCour = new System.Windows.Forms.Label();
            this.btnAgCreate = new System.Windows.Forms.Button();
            this.txtCustPnr = new System.Windows.Forms.TextBox();
            this.cbAgCour = new System.Windows.Forms.ComboBox();
            this.btnCustUpdate = new System.Windows.Forms.Button();
            this.btnCustCreate = new System.Windows.Forms.Button();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.txtCustSearch = new System.Windows.Forms.TextBox();
            this.lblCustMail = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustPnr = new System.Windows.Forms.Label();
            this.lblCustSearch = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.panelCourse = new System.Windows.Forms.Panel();
            this.cbCourPreReq = new System.Windows.Forms.ComboBox();
            this.lblCourPreReq = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnCourClear = new System.Windows.Forms.Button();
            this.rbCourInactive = new System.Windows.Forms.RadioButton();
            this.rbCourActive = new System.Windows.Forms.RadioButton();
            this.txtCourName = new System.Windows.Forms.TextBox();
            this.txtCourCode = new System.Windows.Forms.TextBox();
            this.lblCourStatus = new System.Windows.Forms.Label();
            this.lblCourPrice = new System.Windows.Forms.Label();
            this.lblCourName = new System.Windows.Forms.Label();
            this.lblCourCode = new System.Windows.Forms.Label();
            this.btnCourUpdate = new System.Windows.Forms.Button();
            this.btnCourCreate = new System.Windows.Forms.Button();
            this.cbCourSearch = new System.Windows.Forms.ComboBox();
            this.lblCourSearch = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.panelCustomerCourse = new System.Windows.Forms.Panel();
            this.lbAttendedCourses = new System.Windows.Forms.Label();
            this.dgvCustomerAd = new System.Windows.Forms.DataGridView();
            this.btnAgUpdate = new System.Windows.Forms.Button();
            this.btnAgDelete = new System.Windows.Forms.Button();
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.dgvCustomerAg = new System.Windows.Forms.DataGridView();
            this.lbAttendingCourse = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelCourseCustomer = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblAttenedCustomer = new System.Windows.Forms.Label();
            this.dgvCourseAd = new System.Windows.Forms.DataGridView();
            this.lblAdGrade = new System.Windows.Forms.Label();
            this.btnAdCreate = new System.Windows.Forms.Button();
            this.cbAdGrade = new System.Windows.Forms.ComboBox();
            this.dgvCourseAg = new System.Windows.Forms.DataGridView();
            this.lbAttendingCustomer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabctrDanceAcadamy = new System.Windows.Forms.TabControl();
            this.tpDance = new System.Windows.Forms.TabPage();
            this.tpStats = new System.Windows.Forms.TabPage();
            this.btnStatGradeDate = new System.Windows.Forms.Button();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.btnStatCourseFail = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatHighPass = new System.Windows.Forms.Button();
            this.btnStatThroughPut = new System.Windows.Forms.Button();
            this.btnStatRevenuePerCourse = new System.Windows.Forms.Button();
            this.datastatisticchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCourPrice = new Model.NumericTextBox();
            this.panelCustomer.SuspendLayout();
            this.panelCourse.SuspendLayout();
            this.panelCustomerCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerAg)).BeginInit();
            this.panelCourseCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseAg)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabctrDanceAcadamy.SuspendLayout();
            this.tpDance.SuspendLayout();
            this.tpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datastatisticchart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.btnCustClear);
            this.panelCustomer.Controls.Add(this.txtCustMail);
            this.panelCustomer.Controls.Add(this.txtCustPhone);
            this.panelCustomer.Controls.Add(this.txtCustAddress);
            this.panelCustomer.Controls.Add(this.txtCustName);
            this.panelCustomer.Controls.Add(this.lblCustAddCour);
            this.panelCustomer.Controls.Add(this.btnAgCreate);
            this.panelCustomer.Controls.Add(this.txtCustPnr);
            this.panelCustomer.Controls.Add(this.cbAgCour);
            this.panelCustomer.Controls.Add(this.btnCustUpdate);
            this.panelCustomer.Controls.Add(this.btnCustCreate);
            this.panelCustomer.Controls.Add(this.btnCustSearch);
            this.panelCustomer.Controls.Add(this.txtCustSearch);
            this.panelCustomer.Controls.Add(this.lblCustMail);
            this.panelCustomer.Controls.Add(this.lblCustPhone);
            this.panelCustomer.Controls.Add(this.lblCustAddress);
            this.panelCustomer.Controls.Add(this.lblCustName);
            this.panelCustomer.Controls.Add(this.lblCustPnr);
            this.panelCustomer.Controls.Add(this.lblCustSearch);
            this.panelCustomer.Controls.Add(this.lblCustomer);
            this.panelCustomer.Location = new System.Drawing.Point(1, 0);
            this.panelCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(642, 323);
            this.panelCustomer.TabIndex = 0;
            // 
            // btnCustClear
            // 
            this.btnCustClear.Location = new System.Drawing.Point(558, 176);
            this.btnCustClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustClear.Name = "btnCustClear";
            this.btnCustClear.Size = new System.Drawing.Size(66, 24);
            this.btnCustClear.TabIndex = 20;
            this.btnCustClear.Text = "Clear";
            this.btnCustClear.UseVisualStyleBackColor = true;
            this.btnCustClear.Click += new System.EventHandler(this.btnCustClear_Click);
            // 
            // txtCustMail
            // 
            this.txtCustMail.Location = new System.Drawing.Point(114, 210);
            this.txtCustMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustMail.Name = "txtCustMail";
            this.txtCustMail.Size = new System.Drawing.Size(426, 20);
            this.txtCustMail.TabIndex = 17;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(114, 179);
            this.txtCustPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(426, 20);
            this.txtCustPhone.TabIndex = 16;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(114, 149);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(426, 20);
            this.txtCustAddress.TabIndex = 15;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(114, 123);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(426, 20);
            this.txtCustName.TabIndex = 14;
            // 
            // lblCustAddCour
            // 
            this.lblCustAddCour.AutoSize = true;
            this.lblCustAddCour.Location = new System.Drawing.Point(20, 251);
            this.lblCustAddCour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustAddCour.Name = "lblCustAddCour";
            this.lblCustAddCour.Size = new System.Drawing.Size(125, 13);
            this.lblCustAddCour.TabIndex = 19;
            this.lblCustAddCour.Text = "Add customer to course: ";
            // 
            // btnAgCreate
            // 
            this.btnAgCreate.Enabled = false;
            this.btnAgCreate.Location = new System.Drawing.Point(474, 241);
            this.btnAgCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgCreate.Name = "btnAgCreate";
            this.btnAgCreate.Size = new System.Drawing.Size(66, 24);
            this.btnAgCreate.TabIndex = 2;
            this.btnAgCreate.Text = "Add";
            this.btnAgCreate.UseVisualStyleBackColor = true;
            this.btnAgCreate.Click += new System.EventHandler(this.btnAgCreate_Click);
            // 
            // txtCustPnr
            // 
            this.txtCustPnr.Location = new System.Drawing.Point(114, 94);
            this.txtCustPnr.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustPnr.Name = "txtCustPnr";
            this.txtCustPnr.Size = new System.Drawing.Size(426, 20);
            this.txtCustPnr.TabIndex = 12;
            // 
            // cbAgCour
            // 
            this.cbAgCour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgCour.FormattingEnabled = true;
            this.cbAgCour.Location = new System.Drawing.Point(150, 244);
            this.cbAgCour.Margin = new System.Windows.Forms.Padding(2);
            this.cbAgCour.Name = "cbAgCour";
            this.cbAgCour.Size = new System.Drawing.Size(312, 21);
            this.cbAgCour.TabIndex = 1;
            // 
            // btnCustUpdate
            // 
            this.btnCustUpdate.Enabled = false;
            this.btnCustUpdate.Location = new System.Drawing.Point(558, 148);
            this.btnCustUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustUpdate.Name = "btnCustUpdate";
            this.btnCustUpdate.Size = new System.Drawing.Size(66, 24);
            this.btnCustUpdate.TabIndex = 11;
            this.btnCustUpdate.Text = "Update";
            this.btnCustUpdate.UseVisualStyleBackColor = true;
            this.btnCustUpdate.Click += new System.EventHandler(this.btnCustUpdate_Click);
            // 
            // btnCustCreate
            // 
            this.btnCustCreate.Location = new System.Drawing.Point(558, 120);
            this.btnCustCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustCreate.Name = "btnCustCreate";
            this.btnCustCreate.Size = new System.Drawing.Size(66, 24);
            this.btnCustCreate.TabIndex = 10;
            this.btnCustCreate.Text = "Create";
            this.btnCustCreate.UseVisualStyleBackColor = true;
            this.btnCustCreate.Click += new System.EventHandler(this.btnCustCreate_Click);
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.Location = new System.Drawing.Point(474, 47);
            this.btnCustSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(66, 24);
            this.btnCustSearch.TabIndex = 9;
            this.btnCustSearch.Text = "Search";
            this.btnCustSearch.UseVisualStyleBackColor = true;
            this.btnCustSearch.Click += new System.EventHandler(this.btnCustSearch_Click);
            // 
            // txtCustSearch
            // 
            this.txtCustSearch.Location = new System.Drawing.Point(114, 49);
            this.txtCustSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustSearch.Name = "txtCustSearch";
            this.txtCustSearch.Size = new System.Drawing.Size(346, 20);
            this.txtCustSearch.TabIndex = 8;
            // 
            // lblCustMail
            // 
            this.lblCustMail.AutoSize = true;
            this.lblCustMail.Location = new System.Drawing.Point(20, 212);
            this.lblCustMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustMail.Name = "lblCustMail";
            this.lblCustMail.Size = new System.Drawing.Size(32, 13);
            this.lblCustMail.TabIndex = 7;
            this.lblCustMail.Text = "Mail: ";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(20, 183);
            this.lblCustPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(59, 13);
            this.lblCustPhone.TabIndex = 6;
            this.lblCustPhone.Text = "Phone no: ";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Location = new System.Drawing.Point(20, 153);
            this.lblCustAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(51, 13);
            this.lblCustAddress.TabIndex = 5;
            this.lblCustAddress.Text = "Address: ";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(20, 125);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(41, 13);
            this.lblCustName.TabIndex = 4;
            this.lblCustName.Text = "Name: ";
            // 
            // lblCustPnr
            // 
            this.lblCustPnr.AutoSize = true;
            this.lblCustPnr.Location = new System.Drawing.Point(20, 97);
            this.lblCustPnr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustPnr.Name = "lblCustPnr";
            this.lblCustPnr.Size = new System.Drawing.Size(32, 13);
            this.lblCustPnr.TabIndex = 3;
            this.lblCustPnr.Text = "SSN:";
            // 
            // lblCustSearch
            // 
            this.lblCustSearch.AutoSize = true;
            this.lblCustSearch.Location = new System.Drawing.Point(20, 53);
            this.lblCustSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustSearch.Name = "lblCustSearch";
            this.lblCustSearch.Size = new System.Drawing.Size(44, 13);
            this.lblCustSearch.TabIndex = 1;
            this.lblCustSearch.Text = "Search:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(18, 13);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(163, 26);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Find customer";
            // 
            // panelCourse
            // 
            this.panelCourse.Controls.Add(this.cbCourPreReq);
            this.panelCourse.Controls.Add(this.lblCourPreReq);
            this.panelCourse.Controls.Add(this.splitter1);
            this.panelCourse.Controls.Add(this.btnCourClear);
            this.panelCourse.Controls.Add(this.rbCourInactive);
            this.panelCourse.Controls.Add(this.rbCourActive);
            this.panelCourse.Controls.Add(this.txtCourPrice);
            this.panelCourse.Controls.Add(this.txtCourName);
            this.panelCourse.Controls.Add(this.txtCourCode);
            this.panelCourse.Controls.Add(this.lblCourStatus);
            this.panelCourse.Controls.Add(this.lblCourPrice);
            this.panelCourse.Controls.Add(this.lblCourName);
            this.panelCourse.Controls.Add(this.lblCourCode);
            this.panelCourse.Controls.Add(this.btnCourUpdate);
            this.panelCourse.Controls.Add(this.btnCourCreate);
            this.panelCourse.Controls.Add(this.cbCourSearch);
            this.panelCourse.Controls.Add(this.lblCourSearch);
            this.panelCourse.Controls.Add(this.lblCourse);
            this.panelCourse.Location = new System.Drawing.Point(643, 0);
            this.panelCourse.Margin = new System.Windows.Forms.Padding(2);
            this.panelCourse.Name = "panelCourse";
            this.panelCourse.Size = new System.Drawing.Size(642, 323);
            this.panelCourse.TabIndex = 18;
            // 
            // cbCourPreReq
            // 
            this.cbCourPreReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourPreReq.FormattingEnabled = true;
            this.cbCourPreReq.Location = new System.Drawing.Point(100, 238);
            this.cbCourPreReq.Margin = new System.Windows.Forms.Padding(2);
            this.cbCourPreReq.Name = "cbCourPreReq";
            this.cbCourPreReq.Size = new System.Drawing.Size(312, 21);
            this.cbCourPreReq.TabIndex = 21;
            // 
            // lblCourPreReq
            // 
            this.lblCourPreReq.AutoSize = true;
            this.lblCourPreReq.Location = new System.Drawing.Point(26, 241);
            this.lblCourPreReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourPreReq.Name = "lblCourPreReq";
            this.lblCourPreReq.Size = new System.Drawing.Size(55, 13);
            this.lblCourPreReq.TabIndex = 29;
            this.lblCourPreReq.Text = "Kravkurs: ";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 323);
            this.splitter1.TabIndex = 28;
            this.splitter1.TabStop = false;
            // 
            // btnCourClear
            // 
            this.btnCourClear.Location = new System.Drawing.Point(558, 176);
            this.btnCourClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourClear.Name = "btnCourClear";
            this.btnCourClear.Size = new System.Drawing.Size(66, 24);
            this.btnCourClear.TabIndex = 21;
            this.btnCourClear.Text = "Clear";
            this.btnCourClear.UseVisualStyleBackColor = true;
            this.btnCourClear.Click += new System.EventHandler(this.btnCourseClear_Click);
            // 
            // rbCourInactive
            // 
            this.rbCourInactive.AutoSize = true;
            this.rbCourInactive.Location = new System.Drawing.Point(182, 206);
            this.rbCourInactive.Margin = new System.Windows.Forms.Padding(2);
            this.rbCourInactive.Name = "rbCourInactive";
            this.rbCourInactive.Size = new System.Drawing.Size(63, 17);
            this.rbCourInactive.TabIndex = 27;
            this.rbCourInactive.Text = "Inactive";
            this.rbCourInactive.UseVisualStyleBackColor = true;
            // 
            // rbCourActive
            // 
            this.rbCourActive.AutoSize = true;
            this.rbCourActive.Location = new System.Drawing.Point(102, 206);
            this.rbCourActive.Margin = new System.Windows.Forms.Padding(2);
            this.rbCourActive.Name = "rbCourActive";
            this.rbCourActive.Size = new System.Drawing.Size(55, 17);
            this.rbCourActive.TabIndex = 26;
            this.rbCourActive.Text = "Active";
            this.rbCourActive.UseVisualStyleBackColor = true;
            // 
            // txtCourName
            // 
            this.txtCourName.Location = new System.Drawing.Point(102, 146);
            this.txtCourName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourName.Name = "txtCourName";
            this.txtCourName.Size = new System.Drawing.Size(426, 20);
            this.txtCourName.TabIndex = 22;
            // 
            // txtCourCode
            // 
            this.txtCourCode.Location = new System.Drawing.Point(102, 119);
            this.txtCourCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourCode.Name = "txtCourCode";
            this.txtCourCode.Size = new System.Drawing.Size(426, 20);
            this.txtCourCode.TabIndex = 21;
            // 
            // lblCourStatus
            // 
            this.lblCourStatus.AutoSize = true;
            this.lblCourStatus.Location = new System.Drawing.Point(26, 208);
            this.lblCourStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourStatus.Name = "lblCourStatus";
            this.lblCourStatus.Size = new System.Drawing.Size(43, 13);
            this.lblCourStatus.TabIndex = 8;
            this.lblCourStatus.Text = "Status: ";
            // 
            // lblCourPrice
            // 
            this.lblCourPrice.AutoSize = true;
            this.lblCourPrice.Location = new System.Drawing.Point(26, 178);
            this.lblCourPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourPrice.Name = "lblCourPrice";
            this.lblCourPrice.Size = new System.Drawing.Size(37, 13);
            this.lblCourPrice.TabIndex = 7;
            this.lblCourPrice.Text = "Price: ";
            // 
            // lblCourName
            // 
            this.lblCourName.AutoSize = true;
            this.lblCourName.Location = new System.Drawing.Point(26, 149);
            this.lblCourName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourName.Name = "lblCourName";
            this.lblCourName.Size = new System.Drawing.Size(41, 13);
            this.lblCourName.TabIndex = 6;
            this.lblCourName.Text = "Name: ";
            // 
            // lblCourCode
            // 
            this.lblCourCode.AutoSize = true;
            this.lblCourCode.Location = new System.Drawing.Point(26, 122);
            this.lblCourCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourCode.Name = "lblCourCode";
            this.lblCourCode.Size = new System.Drawing.Size(73, 13);
            this.lblCourCode.TabIndex = 5;
            this.lblCourCode.Text = "Course code: ";
            // 
            // btnCourUpdate
            // 
            this.btnCourUpdate.Enabled = false;
            this.btnCourUpdate.Location = new System.Drawing.Point(558, 147);
            this.btnCourUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourUpdate.Name = "btnCourUpdate";
            this.btnCourUpdate.Size = new System.Drawing.Size(66, 24);
            this.btnCourUpdate.TabIndex = 4;
            this.btnCourUpdate.Text = "Update";
            this.btnCourUpdate.UseVisualStyleBackColor = true;
            this.btnCourUpdate.Click += new System.EventHandler(this.btnCourUpdate_Click);
            // 
            // btnCourCreate
            // 
            this.btnCourCreate.Location = new System.Drawing.Point(558, 120);
            this.btnCourCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourCreate.Name = "btnCourCreate";
            this.btnCourCreate.Size = new System.Drawing.Size(66, 24);
            this.btnCourCreate.TabIndex = 3;
            this.btnCourCreate.Text = "Create";
            this.btnCourCreate.UseVisualStyleBackColor = true;
            this.btnCourCreate.Click += new System.EventHandler(this.btnCourCreate_Click);
            // 
            // cbCourSearch
            // 
            this.cbCourSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourSearch.FormattingEnabled = true;
            this.cbCourSearch.Location = new System.Drawing.Point(102, 48);
            this.cbCourSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbCourSearch.Name = "cbCourSearch";
            this.cbCourSearch.Size = new System.Drawing.Size(310, 21);
            this.cbCourSearch.TabIndex = 2;
            this.cbCourSearch.SelectedIndexChanged += new System.EventHandler(this.cbCourSearch_SelectedIndexChanged);
            // 
            // lblCourSearch
            // 
            this.lblCourSearch.AutoSize = true;
            this.lblCourSearch.Location = new System.Drawing.Point(26, 52);
            this.lblCourSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourSearch.Name = "lblCourSearch";
            this.lblCourSearch.Size = new System.Drawing.Size(47, 13);
            this.lblCourSearch.TabIndex = 1;
            this.lblCourSearch.Text = "Search: ";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(24, 11);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(136, 26);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Find course";
            // 
            // panelCustomerCourse
            // 
            this.panelCustomerCourse.Controls.Add(this.lbAttendedCourses);
            this.panelCustomerCourse.Controls.Add(this.dgvCustomerAd);
            this.panelCustomerCourse.Controls.Add(this.btnAgUpdate);
            this.panelCustomerCourse.Controls.Add(this.btnAgDelete);
            this.panelCustomerCourse.Controls.Add(this.calender);
            this.panelCustomerCourse.Controls.Add(this.lblPayDate);
            this.panelCustomerCourse.Controls.Add(this.dgvCustomerAg);
            this.panelCustomerCourse.Controls.Add(this.lbAttendingCourse);
            this.panelCustomerCourse.Location = new System.Drawing.Point(1, 321);
            this.panelCustomerCourse.Margin = new System.Windows.Forms.Padding(2);
            this.panelCustomerCourse.Name = "panelCustomerCourse";
            this.panelCustomerCourse.Size = new System.Drawing.Size(642, 365);
            this.panelCustomerCourse.TabIndex = 5;
            // 
            // lbAttendedCourses
            // 
            this.lbAttendedCourses.AutoSize = true;
            this.lbAttendedCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttendedCourses.Location = new System.Drawing.Point(322, 13);
            this.lbAttendedCourses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAttendedCourses.Name = "lbAttendedCourses";
            this.lbAttendedCourses.Size = new System.Drawing.Size(138, 20);
            this.lbAttendedCourses.TabIndex = 26;
            this.lbAttendedCourses.Text = "Attended Courses";
            // 
            // dgvCustomerAd
            // 
            this.dgvCustomerAd.AllowUserToAddRows = false;
            this.dgvCustomerAd.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerAd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerAd.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerAd.Location = new System.Drawing.Point(326, 35);
            this.dgvCustomerAd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomerAd.MultiSelect = false;
            this.dgvCustomerAd.Name = "dgvCustomerAd";
            this.dgvCustomerAd.ReadOnly = true;
            this.dgvCustomerAd.RowHeadersVisible = false;
            this.dgvCustomerAd.RowTemplate.Height = 17;
            this.dgvCustomerAd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerAd.Size = new System.Drawing.Size(300, 120);
            this.dgvCustomerAd.TabIndex = 23;
            // 
            // btnAgUpdate
            // 
            this.btnAgUpdate.Enabled = false;
            this.btnAgUpdate.Location = new System.Drawing.Point(254, 190);
            this.btnAgUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgUpdate.Name = "btnAgUpdate";
            this.btnAgUpdate.Size = new System.Drawing.Size(66, 24);
            this.btnAgUpdate.TabIndex = 22;
            this.btnAgUpdate.Text = "Add date";
            this.btnAgUpdate.UseVisualStyleBackColor = true;
            this.btnAgUpdate.Click += new System.EventHandler(this.btnAgUpdate_Click);
            // 
            // btnAgDelete
            // 
            this.btnAgDelete.Enabled = false;
            this.btnAgDelete.Location = new System.Drawing.Point(254, 162);
            this.btnAgDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgDelete.Name = "btnAgDelete";
            this.btnAgDelete.Size = new System.Drawing.Size(66, 24);
            this.btnAgDelete.TabIndex = 21;
            this.btnAgDelete.Text = "Remove";
            this.btnAgDelete.UseVisualStyleBackColor = true;
            this.btnAgDelete.Click += new System.EventHandler(this.btnAgDelete_Click);
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(22, 190);
            this.calender.Margin = new System.Windows.Forms.Padding(6);
            this.calender.MaxSelectionCount = 1;
            this.calender.Name = "calender";
            this.calender.TabIndex = 20;
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Location = new System.Drawing.Point(18, 173);
            this.lblPayDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(55, 13);
            this.lblPayDate.TabIndex = 18;
            this.lblPayDate.Text = "Pay date: ";
            // 
            // dgvCustomerAg
            // 
            this.dgvCustomerAg.AllowUserToAddRows = false;
            this.dgvCustomerAg.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerAg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerAg.Location = new System.Drawing.Point(22, 35);
            this.dgvCustomerAg.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomerAg.MultiSelect = false;
            this.dgvCustomerAg.Name = "dgvCustomerAg";
            this.dgvCustomerAg.ReadOnly = true;
            this.dgvCustomerAg.RowHeadersVisible = false;
            this.dgvCustomerAg.RowTemplate.Height = 17;
            this.dgvCustomerAg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerAg.Size = new System.Drawing.Size(300, 120);
            this.dgvCustomerAg.TabIndex = 18;
            // 
            // lbAttendingCourse
            // 
            this.lbAttendingCourse.AutoSize = true;
            this.lbAttendingCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttendingCourse.Location = new System.Drawing.Point(18, 13);
            this.lbAttendingCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAttendingCourse.Name = "lbAttendingCourse";
            this.lbAttendingCourse.Size = new System.Drawing.Size(141, 20);
            this.lbAttendingCourse.TabIndex = 0;
            this.lbAttendingCourse.Text = "Attending Courses";
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(62, 6);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(1174, 13);
            this.txtMessage.TabIndex = 25;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(2, 6);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 24;
            this.lblMessage.Text = "Message:";
            // 
            // panelCourseCustomer
            // 
            this.panelCourseCustomer.Controls.Add(this.splitter2);
            this.panelCourseCustomer.Controls.Add(this.pbLogo);
            this.panelCourseCustomer.Controls.Add(this.lblAttenedCustomer);
            this.panelCourseCustomer.Controls.Add(this.dgvCourseAd);
            this.panelCourseCustomer.Controls.Add(this.lblAdGrade);
            this.panelCourseCustomer.Controls.Add(this.btnAdCreate);
            this.panelCourseCustomer.Controls.Add(this.cbAdGrade);
            this.panelCourseCustomer.Controls.Add(this.dgvCourseAg);
            this.panelCourseCustomer.Controls.Add(this.lbAttendingCustomer);
            this.panelCourseCustomer.Location = new System.Drawing.Point(643, 321);
            this.panelCourseCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.panelCourseCustomer.Name = "panelCourseCustomer";
            this.panelCourseCustomer.Size = new System.Drawing.Size(642, 365);
            this.panelCourseCustomer.TabIndex = 19;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 365);
            this.splitter2.TabIndex = 28;
            this.splitter2.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(282, 203);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(342, 159);
            this.pbLogo.TabIndex = 27;
            this.pbLogo.TabStop = false;
            // 
            // lblAttenedCustomer
            // 
            this.lblAttenedCustomer.AutoSize = true;
            this.lblAttenedCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttenedCustomer.Location = new System.Drawing.Point(320, 13);
            this.lblAttenedCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttenedCustomer.Name = "lblAttenedCustomer";
            this.lblAttenedCustomer.Size = new System.Drawing.Size(156, 20);
            this.lblAttenedCustomer.TabIndex = 26;
            this.lblAttenedCustomer.Text = "Attended Customers";
            // 
            // dgvCourseAd
            // 
            this.dgvCourseAd.AllowUserToAddRows = false;
            this.dgvCourseAd.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourseAd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourseAd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourseAd.Location = new System.Drawing.Point(324, 35);
            this.dgvCourseAd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCourseAd.MultiSelect = false;
            this.dgvCourseAd.Name = "dgvCourseAd";
            this.dgvCourseAd.ReadOnly = true;
            this.dgvCourseAd.RowHeadersVisible = false;
            this.dgvCourseAd.RowTemplate.Height = 17;
            this.dgvCourseAd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseAd.Size = new System.Drawing.Size(300, 120);
            this.dgvCourseAd.TabIndex = 23;
            // 
            // lblAdGrade
            // 
            this.lblAdGrade.AutoSize = true;
            this.lblAdGrade.Location = new System.Drawing.Point(22, 179);
            this.lblAdGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdGrade.Name = "lblAdGrade";
            this.lblAdGrade.Size = new System.Drawing.Size(62, 13);
            this.lblAdGrade.TabIndex = 22;
            this.lblAdGrade.Text = "Add grade: ";
            // 
            // btnAdCreate
            // 
            this.btnAdCreate.Enabled = false;
            this.btnAdCreate.Location = new System.Drawing.Point(254, 174);
            this.btnAdCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdCreate.Name = "btnAdCreate";
            this.btnAdCreate.Size = new System.Drawing.Size(66, 24);
            this.btnAdCreate.TabIndex = 21;
            this.btnAdCreate.Text = "Add";
            this.btnAdCreate.UseVisualStyleBackColor = true;
            this.btnAdCreate.Click += new System.EventHandler(this.btnAdCreate_Click);
            // 
            // cbAdGrade
            // 
            this.cbAdGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdGrade.FormattingEnabled = true;
            this.cbAdGrade.Items.AddRange(new object[] {
            "MVG",
            "VG",
            "G",
            "IG"});
            this.cbAdGrade.Location = new System.Drawing.Point(86, 177);
            this.cbAdGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cbAdGrade.Name = "cbAdGrade";
            this.cbAdGrade.Size = new System.Drawing.Size(158, 21);
            this.cbAdGrade.TabIndex = 20;
            // 
            // dgvCourseAg
            // 
            this.dgvCourseAg.AllowUserToAddRows = false;
            this.dgvCourseAg.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourseAg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseAg.Location = new System.Drawing.Point(20, 35);
            this.dgvCourseAg.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCourseAg.MultiSelect = false;
            this.dgvCourseAg.Name = "dgvCourseAg";
            this.dgvCourseAg.ReadOnly = true;
            this.dgvCourseAg.RowHeadersVisible = false;
            this.dgvCourseAg.RowTemplate.Height = 17;
            this.dgvCourseAg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseAg.Size = new System.Drawing.Size(300, 120);
            this.dgvCourseAg.TabIndex = 18;
            // 
            // lbAttendingCustomer
            // 
            this.lbAttendingCustomer.AutoSize = true;
            this.lbAttendingCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttendingCustomer.Location = new System.Drawing.Point(24, 13);
            this.lbAttendingCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAttendingCustomer.Name = "lbAttendingCustomer";
            this.lbAttendingCustomer.Size = new System.Drawing.Size(159, 20);
            this.lbAttendingCustomer.TabIndex = 0;
            this.lbAttendingCustomer.Text = "Attending Customers";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Location = new System.Drawing.Point(23, 692);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 26);
            this.panel1.TabIndex = 20;
            // 
            // tabctrDanceAcadamy
            // 
            this.tabctrDanceAcadamy.Controls.Add(this.tpDance);
            this.tabctrDanceAcadamy.Controls.Add(this.tpStats);
            this.tabctrDanceAcadamy.Location = new System.Drawing.Point(2, 0);
            this.tabctrDanceAcadamy.Margin = new System.Windows.Forms.Padding(2);
            this.tabctrDanceAcadamy.Name = "tabctrDanceAcadamy";
            this.tabctrDanceAcadamy.SelectedIndex = 0;
            this.tabctrDanceAcadamy.Size = new System.Drawing.Size(1305, 751);
            this.tabctrDanceAcadamy.TabIndex = 21;
            // 
            // tpDance
            // 
            this.tpDance.BackColor = System.Drawing.SystemColors.Control;
            this.tpDance.Controls.Add(this.panelCustomer);
            this.tpDance.Controls.Add(this.panel1);
            this.tpDance.Controls.Add(this.panelCourse);
            this.tpDance.Controls.Add(this.panelCourseCustomer);
            this.tpDance.Controls.Add(this.panelCustomerCourse);
            this.tpDance.Location = new System.Drawing.Point(4, 22);
            this.tpDance.Margin = new System.Windows.Forms.Padding(2);
            this.tpDance.Name = "tpDance";
            this.tpDance.Padding = new System.Windows.Forms.Padding(2);
            this.tpDance.Size = new System.Drawing.Size(1297, 725);
            this.tpDance.TabIndex = 0;
            this.tpDance.Text = "Dance Acadamy";
            // 
            // tpStats
            // 
            this.tpStats.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats.Controls.Add(this.btnStatGradeDate);
            this.tpStats.Controls.Add(this.dgvStats);
            this.tpStats.Controls.Add(this.btnStatCourseFail);
            this.tpStats.Controls.Add(this.pictureBox1);
            this.tpStats.Controls.Add(this.btnStatHighPass);
            this.tpStats.Controls.Add(this.btnStatThroughPut);
            this.tpStats.Controls.Add(this.btnStatRevenuePerCourse);
            this.tpStats.Controls.Add(this.datastatisticchart);
            this.tpStats.Location = new System.Drawing.Point(4, 22);
            this.tpStats.Margin = new System.Windows.Forms.Padding(2);
            this.tpStats.Name = "tpStats";
            this.tpStats.Padding = new System.Windows.Forms.Padding(2);
            this.tpStats.Size = new System.Drawing.Size(1297, 725);
            this.tpStats.TabIndex = 1;
            this.tpStats.Text = "Statistics";
            // 
            // btnStatGradeDate
            // 
            this.btnStatGradeDate.Location = new System.Drawing.Point(60, 383);
            this.btnStatGradeDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatGradeDate.Name = "btnStatGradeDate";
            this.btnStatGradeDate.Size = new System.Drawing.Size(176, 66);
            this.btnStatGradeDate.TabIndex = 31;
            this.btnStatGradeDate.Text = "Date when a grade got set";
            this.btnStatGradeDate.UseVisualStyleBackColor = true;
            this.btnStatGradeDate.Click += new System.EventHandler(this.btnStatGradeDate_Click);
            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AllowUserToDeleteRows = false;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Location = new System.Drawing.Point(420, 429);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.ReadOnly = true;
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.Size = new System.Drawing.Size(706, 223);
            this.dgvStats.TabIndex = 30;
            // 
            // btnStatCourseFail
            // 
            this.btnStatCourseFail.Location = new System.Drawing.Point(60, 313);
            this.btnStatCourseFail.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatCourseFail.Name = "btnStatCourseFail";
            this.btnStatCourseFail.Size = new System.Drawing.Size(176, 66);
            this.btnStatCourseFail.TabIndex = 29;
            this.btnStatCourseFail.Text = "Fail Per Course";
            this.btnStatCourseFail.UseVisualStyleBackColor = true;
            this.btnStatCourseFail.Click += new System.EventHandler(this.btmStatCourseFail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(22, 533);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 167);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnStatHighPass
            // 
            this.btnStatHighPass.Location = new System.Drawing.Point(60, 243);
            this.btnStatHighPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatHighPass.Name = "btnStatHighPass";
            this.btnStatHighPass.Size = new System.Drawing.Size(176, 66);
            this.btnStatHighPass.TabIndex = 3;
            this.btnStatHighPass.Text = "HighPass Per Course";
            this.btnStatHighPass.UseVisualStyleBackColor = true;
            this.btnStatHighPass.Click += new System.EventHandler(this.btnStatHighPass_Click);
            // 
            // btnStatThroughPut
            // 
            this.btnStatThroughPut.Location = new System.Drawing.Point(60, 173);
            this.btnStatThroughPut.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatThroughPut.Name = "btnStatThroughPut";
            this.btnStatThroughPut.Size = new System.Drawing.Size(176, 66);
            this.btnStatThroughPut.TabIndex = 2;
            this.btnStatThroughPut.Text = "ThroughPut Per Course";
            this.btnStatThroughPut.UseVisualStyleBackColor = true;
            this.btnStatThroughPut.Click += new System.EventHandler(this.btnStatThroughPut_Click);
            // 
            // btnStatRevenuePerCourse
            // 
            this.btnStatRevenuePerCourse.Location = new System.Drawing.Point(60, 96);
            this.btnStatRevenuePerCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatRevenuePerCourse.Name = "btnStatRevenuePerCourse";
            this.btnStatRevenuePerCourse.Size = new System.Drawing.Size(176, 73);
            this.btnStatRevenuePerCourse.TabIndex = 1;
            this.btnStatRevenuePerCourse.Text = "Revenue Per Course";
            this.btnStatRevenuePerCourse.UseVisualStyleBackColor = true;
            this.btnStatRevenuePerCourse.Click += new System.EventHandler(this.btnStatRevenuePerCourse_Click);
            // 
            // datastatisticchart
            // 
            this.datastatisticchart.BackColor = System.Drawing.SystemColors.Control;
            this.datastatisticchart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.datastatisticchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.datastatisticchart.Legends.Add(legend1);
            this.datastatisticchart.Location = new System.Drawing.Point(367, 33);
            this.datastatisticchart.Margin = new System.Windows.Forms.Padding(2);
            this.datastatisticchart.Name = "datastatisticchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.datastatisticchart.Series.Add(series1);
            this.datastatisticchart.Size = new System.Drawing.Size(905, 391);
            this.datastatisticchart.TabIndex = 0;
            this.datastatisticchart.Text = "chart1";
            // 
            // txtCourPrice
            // 
            this.txtCourPrice.AllowSpace = false;
            this.txtCourPrice.Location = new System.Drawing.Point(102, 175);
            this.txtCourPrice.Margin = new System.Windows.Forms.Padding(1);
            this.txtCourPrice.Name = "txtCourPrice";
            this.txtCourPrice.Size = new System.Drawing.Size(426, 20);
            this.txtCourPrice.TabIndex = 23;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 761);
            this.Controls.Add(this.tabctrDanceAcadamy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Gui";
            this.Text = "Dance Academy";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelCourse.ResumeLayout(false);
            this.panelCourse.PerformLayout();
            this.panelCustomerCourse.ResumeLayout(false);
            this.panelCustomerCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerAg)).EndInit();
            this.panelCourseCustomer.ResumeLayout(false);
            this.panelCourseCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseAg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabctrDanceAcadamy.ResumeLayout(false);
            this.tpDance.ResumeLayout(false);
            this.tpStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datastatisticchart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericTextBox txtCourPrice;
        private System.Windows.Forms.Button btnAdCreate;
        private System.Windows.Forms.Button btnAgCreate;
        private System.Windows.Forms.Button btnAgDelete;
        private System.Windows.Forms.Button btnAgUpdate;
        private System.Windows.Forms.Button btnCourCreate;
        private System.Windows.Forms.Button btnCourClear;
        private System.Windows.Forms.Button btnCourUpdate;
        private System.Windows.Forms.Button btnCustClear;
        private System.Windows.Forms.Button btnCustCreate;
        private System.Windows.Forms.Button btnCustSearch;
        private System.Windows.Forms.Button btnCustUpdate;
        private System.Windows.Forms.ComboBox cbAdGrade;
        private System.Windows.Forms.ComboBox cbAgCour;
        private System.Windows.Forms.ComboBox cbCourSearch;
        private System.Windows.Forms.DataGridView dgvCourseAd;
        private System.Windows.Forms.DataGridView dgvCourseAg;
        private System.Windows.Forms.DataGridView dgvCustomerAd;
        private System.Windows.Forms.DataGridView dgvCustomerAg;
        private System.Windows.Forms.Label lblAdGrade;
        private System.Windows.Forms.Label lblCourCode;
        private System.Windows.Forms.Label lblCourName;
        private System.Windows.Forms.Label lblCourPrice;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCourSearch;
        private System.Windows.Forms.Label lbAttendingCustomer;
        private System.Windows.Forms.Label lblCourStatus;
        private System.Windows.Forms.Label lblCustAddCour;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.Label lblCustMail;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lbAttendingCourse;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Label lblCustPnr;
        private System.Windows.Forms.Label lblCustSearch;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.Panel panelCourse;
        private System.Windows.Forms.Panel panelCourseCustomer;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Panel panelCustomerCourse;
        private System.Windows.Forms.RadioButton rbCourActive;
        private System.Windows.Forms.RadioButton rbCourInactive;
        private System.Windows.Forms.TextBox txtCourCode;
        private System.Windows.Forms.TextBox txtCourName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustMail;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustPnr;
        private System.Windows.Forms.TextBox txtCustSearch;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lbAttendedCourses;
        private System.Windows.Forms.Label lblAttenedCustomer;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabctrDanceAcadamy;
        private System.Windows.Forms.TabPage tpDance;
        private System.Windows.Forms.TabPage tpStats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStatHighPass;
        private System.Windows.Forms.Button btnStatThroughPut;
        private System.Windows.Forms.Button btnStatRevenuePerCourse;
        private System.Windows.Forms.DataVisualization.Charting.Chart datastatisticchart;
        private System.Windows.Forms.ComboBox cbCourPreReq;
        private System.Windows.Forms.Label lblCourPreReq;
        private System.Windows.Forms.Button btnStatCourseFail;
        private System.Windows.Forms.Button btnStatGradeDate;
        private System.Windows.Forms.DataGridView dgvStats;
    }
}


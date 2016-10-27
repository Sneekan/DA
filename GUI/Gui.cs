using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EntityFramework.entityframework;
using static ErrorHandler.ErrorHandler;
using static Controller.ControllerUtil;
using static Controller.ControllerCustomer;
using static Controller.ControllerCourse;
using static Controller.ControllerAttending;
using static Controller.ControllerAttended;
using static Controller.ControllerPrerequisiteCourse;

namespace GUI
{
    public partial class Gui : Form
    {

        private Customer lastCust = new Customer("new", "new", "new", "new", "new");
        private Course lastCour = new Course("new", "new", "new", 0);
        private PrerequisiteCourse lastPre = new PrerequisiteCourse(0, 0);
        int CourseIndex = 0;

        public Gui()
        {
            InitializeComponent();
            UpdateCourList();
            UpdateCourTable();
            UpdateCustTable();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            UpdateBoxSuggestions();
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            ClearAllMessages();
            try
            {
                string[] stringarr = new string[] { txtCustSearch.Text };
                List<Customer> custlist = FindAnything(stringarr, FindCustomerByPnrCommand, FindCustomer);
                if (custlist.Count != 0)
                {
                    EnterCust(custlist);
                    UpdateCustTable();
                    UpdateBoxSuggestions();
                }
                else
                {
                    txtMessage.Text = "This SSN does not exist.";
                    ClearCustFields();
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
            txtCustSearch.Text = "";
        }

        private void btnCustCreate_Click(object sender, EventArgs e)
        {
            ClearAllMessages();
            try
            {
                string[] stringarr = new string[] { txtCustPnr.Text };

                if (CheckAllCustFields())
                {
                    Customer c2 = new Customer(txtCustPnr.Text, txtCustName.Text, txtCustAddress.Text, txtCustMail.Text, txtCustPhone.Text);
                    int i = CreateUpdateDeleteAnything(c2, CreateCustomer);
                    ClearCustFields();
                    txtCustSearch.Text = c2.pnr;
                    btnCustSearch.PerformClick();
                    txtMessage.Text = "Customer created successfully.";
                }

            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }

        }

        private void btnCustUpdate_Click(object sender, EventArgs e)
        {
            ClearAllMessages();
            try
            {
                if (CheckAllCustFields())
                {
                    Customer c2 = new Customer(lastCust.pnr, txtCustName.Text, txtCustAddress.Text, txtCustMail.Text, txtCustPhone.Text);
                    int i = CreateUpdateDeleteAnything(c2, UpdateCustomer);
                    ClearCustFields();
                    txtCustSearch.Text = c2.pnr;
                    btnCustSearch.PerformClick();
                    txtMessage.Text = "Customer updated successfully.";
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        private void cbCourSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastPre = new PrerequisiteCourse(0, 0);
            try
            {
                List<Course> prereqlist = null;
                if (cbCourSearch.SelectedIndex != -1)
                {
                    ClearAllMessages();
                    string code = cbCourSearch.SelectedItem.ToString().Split(' ')[0];
                    string[] stringarr = new string[] { code };
                    List<Course> courlist = FindAnything(stringarr, FindCourseByCodeCommand, FindCourse);

                    if (courlist.Count != 0)
                    {
                        string[] stringarrpre = new string[] { courlist.First().coId.ToString() };
                        List<PrerequisiteCourse> prelist = FindAnything(stringarrpre, FindPrerequisiteCourseCommand, FindPrerequisiteCourse);
                        if (prelist.Count > 0) { 
                            lastPre = prelist.First();                        
                            string[] stringarrc = new string[] { lastPre.prereqCoId.ToString() };
                            prereqlist = FindAnything(stringarrc, FindCourseByCoIdCommand, FindCourse);                           
                        }
                        EnterCour(courlist);
                        UpdateCourTable();
                        UpdateCourList(code);
                        if (lastPre.coId != 0)
                            cbCourPreReq.SelectedItem = prereqlist.First().code + " - " + prereqlist.First().name;                       
                        else
                            cbCourPreReq.SelectedItem = "Ingen";
                    }
                    cbCourSearch.SelectedIndex = -1;

                    //UpdateCourList(code);

                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        private void btnCourCreate_Click(object sender, EventArgs e)
        {
            ClearAllMessages();
            try
            {
                if (CheckAllCourseFields())
                {
                    string activity = "";
                    if (rbCourActive.Checked == true)
                        activity = "active";
                    else if (rbCourInactive.Checked == true)
                        activity = "inactive";

                    int price = Int32.Parse(txtCourPrice.Text);
                    Course c2 = new Course(txtCourCode.Text, txtCourName.Text, activity, price);
                    int i = CreateUpdateDeleteAnything(c2, CreateCourse);

                    if (cbCourPreReq.SelectedItem != null)
                    {
                        PrerequisiteCourse pc = new PrerequisiteCourse();
                        string prereq = cbCourPreReq.SelectedItem.ToString().Split(' ')[0];

                        string[] stringarr1 = new string[] { c2.code };
                        string[] stringarr2 = new string[] { prereq };

                        List<Course> courselist1 = FindAnything(stringarr1, FindCourseByCodeCommand, FindCourse);
                        List<Course> courselist2 = FindAnything(stringarr2, FindCourseByCodeCommand, FindCourse);
                        pc.coId = courselist1.First().coId;
                        pc.prereqCoId = courselist2.First().coId;
                        CreateUpdateDeleteAnything(pc, CreatePrerequisiteCourse);
                    }


                    ClearCourFields();
                    txtMessage.Text = "Course created successfully.";
                    UpdateCourList();
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }


        private void btnCourUpdate_Click(object sender, EventArgs e)
        {
            ClearAllMessages(); ;
            try
            {
                string[] stringarr = new string[] { txtCourCode.Text };
                List<Course> courselist = FindAnything(stringarr, FindCourseByCodeCommand, FindCourse);
                if (CheckAllCourseFields())
                {
                    string activity = "";
                    if (rbCourActive.Checked == true)
                        activity = "active";
                    else if (rbCourInactive.Checked == true)
                        activity = "inactive";
                    int price = 0;
                    price = Int32.Parse(txtCourPrice.Text);
                    Course c2 = new Course(txtCourCode.Text, txtCourName.Text, activity, price);
                    int i = CreateUpdateDeleteAnything(c2, UpdateCourse);

                    if (cbCourPreReq.SelectedItem.ToString() != "Ingen")
                    {
                        PrerequisiteCourse pc = new PrerequisiteCourse();
                        string prereq = cbCourPreReq.SelectedItem.ToString().Split(' ')[0];

                        string[] stringarr1 = new string[] { c2.code };
                        string[] stringarr2 = new string[] { prereq };

                        List<Course> courselist1 = FindAnything(stringarr1, FindCourseByCodeCommand, FindCourse);
                        List<Course> courselist2 = FindAnything(stringarr2, FindCourseByCodeCommand, FindCourse);
                        pc.coId = courselist1.First().coId;
                        pc.prereqCoId = courselist2.First().coId;

                        CreateUpdateDeleteAnything(lastPre, DeletePrerequisiteCourse);
                        CreateUpdateDeleteAnything(pc, CreatePrerequisiteCourse);
                        lastPre = pc;
                    }
                    else
                    {
                        CreateUpdateDeleteAnything(lastPre, DeletePrerequisiteCourse);
                        lastPre = new PrerequisiteCourse(0, 0);
                    }

                    ClearCourFields();
                    UpdateCourList();
                    cbCourSearch.SelectedIndex = CourseIndex;
                    txtMessage.Text = "Course updated successfullt.";
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        private void btnAgCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAgCour.SelectedIndex != -1)
                {
                    ClearAllMessages();
                    string code = cbAgCour.SelectedItem.ToString().Split(' ')[0];
                    string[] stringarr = new string[] { code };
                    List<Course> courlist = FindAnything(stringarr, FindCourseByCodeCommand, FindCourse);
                    decimal coID = courlist.First().coId;
                    Attending a = new Attending(lastCust.cuId, coID, "");
                    CreateUpdateDeleteAnything(a, CreateAttending);
                    UpdateCustTable();
                    UpdateCourTable();
                    cbAgCour.SelectedIndex = -1;
                    txtMessage.Text = "Customer is now attending that course.";
                }
                else
                {
                    txtMessage.Text = "No Course is selected.";
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        private void btnAgDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomerAg.SelectedCells.Count > 0)
                {
                    ClearAllMessages();
                    int selectedrowindex = dgvCustomerAg.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvCustomerAg.Rows[selectedrowindex];
                    string cCode = Convert.ToString(row.Cells["Course code"].Value);
                    string[] stringarr = new string[] { lastCust.pnr, cCode };
                    Attending a = FindAnything(stringarr, FindAttendingByBothCommand, FindAttending).First();
                    CreateUpdateDeleteAnything(a, DeleteAttending);
                    UpdateCustTable();
                    UpdateCourTable();
                    txtMessage.Text = "Customer has now been removed from that course.";
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        private void btnAgUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomerAg.SelectedCells.Count > 0)
                {
                    ClearAllMessages();
                    int selectedrowindex = dgvCustomerAg.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvCustomerAg.Rows[selectedrowindex];
                    string cCode = Convert.ToString(row.Cells["Course code"].Value);
                    string[] stringarr = new string[] { lastCust.pnr, cCode };
                    Attending a = FindAnything(stringarr, FindAttendingByBothCommand, FindAttending).First();
                    a.paid = calender.SelectionStart.ToShortDateString();
                    CreateUpdateDeleteAnything(a, UpdateAttending);
                    row.Cells["Pay date"].Value = a.paid;
                    txtMessage.Text = "Paydate has been updated.";
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }


        private void btnAdCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAdGrade.SelectedIndex != -1 && dgvCourseAg.SelectedCells.Count > 0)
                {
                    ClearAllMessages();
                    int selectedrowindex = dgvCourseAg.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvCourseAg.Rows[selectedrowindex];
                    string cPnr = Convert.ToString(row.Cells["SSN"].Value);
                    //ta bort Attending
                    string[] stringarr = new string[] { cPnr, lastCour.code };
                    Attending ag = FindAnything(stringarr, FindAttendingByBothCommand, FindAttending).First();
                    decimal cuId = ag.customer_cuId;
                    CreateUpdateDeleteAnything(ag, DeleteAttending);

                    //lägg till attended
                    string[] stringarr2 = new string[] { cPnr, lastCour.code };
                    List<Attended> listAd = FindAnything(stringarr2, FindAttendedByBothCommand, FindAttended);

                    if (listAd.Count == 0)
                    {
                        Attended ad = new Attended();
                        ad.grade = cbAdGrade.SelectedItem.ToString();
                        ad.course_coId = lastCour.coId;
                        ad.customer_cuId = cuId;
                        CreateUpdateDeleteAnything(ad, CreateAttended);
                        UpdateCourTable();
                        UpdateCustTable();
                        txtMessage.Text = "Customer has been graded.";
                    }
                    else
                    {
                        Attended ad = new Attended();
                        ad.grade = cbAdGrade.SelectedItem.ToString();
                        ad.course_coId = lastCour.coId;
                        ad.customer_cuId = cuId;
                        CreateUpdateDeleteAnything(ad, UpdateAttended);
                        UpdateCourTable();
                        UpdateCustTable();
                        txtMessage.Text = "Customer has gotten a new grade.";
                    }
                    cbAdGrade.SelectedIndex = -1;
                }

                else
                    txtMessage.Text = "Choose a course from the table and choose a grade.";
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }

        }

        private void btnCustClear_Click(object sender, EventArgs e)
        {
            ClearCustFields();
            txtCustSearch.Text = "";
        }

        private void btnCourseClear_Click(object sender, EventArgs e)
        {
            ClearCourFields();
            cbCourSearch.SelectedIndex = -1;
            cbCourPreReq.Items.Clear();
        }

        // Allt under här är bara funktioner vi använder 

        public void EnterCust(List<Customer> custlist)
        {
            try
            {
                lastCust = custlist.First();
                txtCustMail.Text = lastCust.mail;
                txtCustPhone.Text = lastCust.phonenr;
                txtCustAddress.Text = lastCust.address;
                txtCustName.Text = lastCust.name;
                txtCustPnr.Text = lastCust.pnr;


                btnCustUpdate.Enabled = true;
                btnCustCreate.Enabled = false;
                btnAgCreate.Enabled = true;
                txtCustPnr.ReadOnly = true;
                btnAgUpdate.Enabled = true;
                btnAgDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        public void EnterCour(List<Course> courlist)
        {
            try
            {
                CourseIndex = cbCourSearch.SelectedIndex;
                lastCour = courlist.First();
                txtCourCode.Text = lastCour.code;
                txtCourName.Text = lastCour.name;
                txtCourPrice.Text = lastCour.price.ToString();
                if (lastCour.inactive == "active")
                    rbCourActive.Select();
                else
                    rbCourInactive.Select();
                btnCourUpdate.Enabled = true;
                btnCourCreate.Enabled = false;
                txtCourCode.ReadOnly = true;
                btnAdCreate.Enabled = true;
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        public void UpdateCourList()
        {
            try
            {
                cbCourSearch.Items.Clear();
                cbAgCour.Items.Clear();
                cbCourPreReq.Items.Clear();
                List<Course> courlist = FindAnything(new string[] { }, FindCourseCommand, FindCourse);
                cbCourPreReq.Items.Add("Ingen");
                cbCourPreReq.SelectedItem = "Ingen";
                foreach (Course c in courlist)
                {
                    cbCourSearch.Items.Add(c.code + " - " + c.name);
                    cbAgCour.Items.Add(c.code + " - " + c.name);
                    cbCourPreReq.Items.Add(c.code + " - " + c.name);
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        public void UpdateCourList(string samecourse)
        {
            try
            {
                cbCourSearch.Items.Clear();
                cbAgCour.Items.Clear();
                cbCourPreReq.Items.Clear();
                List<Course> courlist = FindAnything(new string[] { }, FindCourseCommand, FindCourse);
                cbCourPreReq.Items.Add("Ingen");
                cbCourPreReq.SelectedItem = "Ingen";
                foreach (Course c in courlist)
                {
                    cbCourSearch.Items.Add(c.code + " - " + c.name);
                    cbAgCour.Items.Add(c.code + " - " + c.name);
                    if (c.code != samecourse)
                        cbCourPreReq.Items.Add(c.code + " - " + c.name);
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        public void UpdateCustTable()
        {
            try
            {
                List<Attending> agList = null;
                if (lastCust.pnr != "new")
                {
                    string[] stringarr = { lastCust.cuId.ToString() };
                    agList = FindAnything(stringarr, FindAttendingByCustCommand, FindAttending);
                }
                else
                {
                    string[] stringarr = { 0.ToString() };
                    agList = FindAnything(stringarr, FindAttendingByCustCommand, FindAttending);

                }
                dgvCustomerAg.DataSource = ListToTable(agList, TableCustAg);

                AutoSizeColumn(dgvCustomerAg);

                List<Attended> adList = null;
                if (lastCust.pnr != "new")
                {
                    string[] stringarr = { lastCust.cuId.ToString() };
                    adList = FindAnything(stringarr, FindAttendedByCustCommand, FindAttended);
                }
                else
                {
                    string[] stringarr = { 0.ToString() };
                    adList = FindAnything(stringarr, FindAttendedByCustCommand, FindAttended);
                }
                dgvCustomerAd.DataSource = ListToTable(adList, TableCustAd);
                AutoSizeColumn(dgvCustomerAd);
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        public void UpdateCourTable()
        {
            try
            {
                List<Attending> agList = null;
                if (lastCour.code != "new")
                {
                    string[] stringarr = { lastCour.coId.ToString() };
                    agList = FindAnything(stringarr, FindAttendingByCourCommand, FindAttending);
                }
                else
                {
                    string[] stringarr = { lastCour.coId.ToString() };
                    agList = FindAnything(stringarr, FindAttendingByCourCommand, FindAttending);
                }
                dgvCourseAg.DataSource = ListToTable(agList, TableCourAg);

                AutoSizeColumn(dgvCourseAg);
                List<Attended> adList = null;
                if (lastCour.code != "new")
                {
                    string[] stringarr = { lastCour.coId.ToString() };
                    adList = FindAnything(stringarr, FindAttendedByCourCommand, FindAttended);
                }
                else
                {
                    string[] stringarr = { 0.ToString() };
                    adList = FindAnything(stringarr, FindAttendedByCourCommand, FindAttended);
                }
                dgvCourseAd.DataSource = ListToTable(adList, TableCourAd);
                AutoSizeColumn(dgvCourseAd);
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        public void UpdateBoxSuggestions()
        {
            try
            {
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                List<string> custlist = new List<string>();
                List<Customer> searchlist = FindAnything(new string[] { }, FindCustomerCommand, FindCustomer);
                foreach (Customer c in searchlist)
                    custlist.Add(c.pnr);
                source.AddRange(custlist.ToArray());
                txtCustSearch.AutoCompleteCustomSource = source;
                txtCustSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCustSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }
        public void ClearAllMessages()
        {
            txtMessage.Text = "";
        }

        public void ClearCustFields()
        {
            lastCust = new Customer("new", "new", "new", "new", "new");
            btnAgCreate.Enabled = false;
            btnCustUpdate.Enabled = false;
            txtCustPnr.ReadOnly = false;
            btnCustCreate.Enabled = true;
            btnAgUpdate.Enabled = false;
            btnAgDelete.Enabled = false;
            UpdateCustTable();
            clear(txtCustMail, txtCustPhone, txtCustAddress, txtCustName, txtCustPnr);
        }

        public void ClearCourFields()
        {
            lastCour = new Course("new", "new", "new", 0);
            btnCourUpdate.Enabled = false;
            btnCourCreate.Enabled = true;
            txtCourCode.ReadOnly = false;
            btnAdCreate.Enabled = false;
            UpdateCourTable();
            clear(txtCourCode, txtCourName, txtCourPrice);
        }

        public void clear(params TextBox[] boxes)
        {
            foreach (TextBox box in boxes)
            {
                box.Text = "";
            }
        }

        public bool CheckAllCustFields()
        {
            if (txtCustPnr.Text == "" || txtCustName.Text == "" || txtCustAddress.Text == "" || txtCustMail.Text == "" || txtCustPhone.Text == "")
            {
                txtMessage.Text = "Fill in all the fields before creating.";
                return false;
            }
            else if (txtCustPnr.Text != "" || txtCustName.Text != "" || txtCustAddress.Text != "" || txtCustMail.Text != "" || txtCustPhone.Text != "")
                return true;
            else
                return false;
        }
        public bool CheckAllCourseFields()
        {
            if (txtCourCode.Text == "" || txtCourName.Text == "" || txtCourPrice.Text == "" || !rbCourActive.Checked && !rbCourInactive.Checked)
            {
                txtMessage.Text = "Fill in all of the fields.";
                return false;
            }
            else if (txtCourCode.Text != "" || txtCourName.Text != "" || txtCourPrice.Text != "" || !rbCourActive.Checked || rbCourInactive.Checked || rbCourActive.Checked || !rbCourInactive.Checked)
                return true;
            else
                return false;
        }

        public void AutoSizeColumn(DataGridView dgv)
        {
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        //
        //STATISTICS
        //

        private void btnStatRevenuePerCourse_Click(object sender, EventArgs e)
        {
            ClearAllMessages(); ;
            try
            {
                datastatisticchart.DataSource = StatisticExecuter("usp_StatRevenuePerCourse");
                datastatisticchart.Series["Series1"].XValueMember = "name";
                datastatisticchart.Series["Series1"].YValueMembers = "Revenue";
                datastatisticchart.DataBind();
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        private void btnStatThroughPut_Click(object sender, EventArgs e)
        {
            ClearAllMessages(); ;
            try
            {
                datastatisticchart.DataSource = StatisticExecuter("usp_StatCourseThroughPut");
                datastatisticchart.Series["Series1"].XValueMember = "name";
                datastatisticchart.Series["Series1"].YValueMembers = "Percent";
                datastatisticchart.DataBind();
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        private void btnStatHighPass_Click(object sender, EventArgs e)
        {
            ClearAllMessages(); ;
            try
            {
                datastatisticchart.DataSource = StatisticExecuter("usp_StatHighPass");
                datastatisticchart.Series["Series1"].XValueMember = "name";
                datastatisticchart.Series["Series1"].YValueMembers = "Percent";
                datastatisticchart.DataBind();
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }

        private void btmStatCourseFail_Click(object sender, EventArgs e)
        {
            ClearAllMessages(); ;
            try
            {
                datastatisticchart.DataSource = StatisticExecuter("usp_StatCourseFail");
                datastatisticchart.Series["Series1"].XValueMember = "name";
                datastatisticchart.Series["Series1"].YValueMembers = "Percent";
                datastatisticchart.DataBind();
            }
            catch (Exception ex)
            {
                txtMessage.Text = HandleExceptions(ex);
            }
        }
        private void btnStatGradeDate_Click(object sender, EventArgs e)
        {
            dgvStats.DataSource = StatisticExecuter("usp_FindFinishedStudents");
        }
    }
}

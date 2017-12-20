using MyFirstWebApp.EmployeesWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace MyFirstWebApp
{
    public partial class _Default : Page
    {
        private EmployeesWCF.Service1Client em;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.MultiView1.SetActiveView(ViewGridPerson);
                BindGridPersons();
            }
        }

        private void BindGridPersons()
        {
            if (em == null)
            {
                //Accesss a new instance of the WCF Web Service
                em = new Service1Client();
            }
            List<Person> empPers = new List<Person>();
            //Get all Persons from the web service
            empPers = em.GetAllPersons().ToList();
            //Bind the data to the GridView control
            this.GridPerson.DataSource = empPers;
            this.GridPerson.DataBind();
        }
        private void BindGridEmployees()
        {
            if (em == null)
            {
                //Accesss a new instance of the WCF Web Service
                em = new Service1Client();
            }
            List<Employee> empPersons = em.GetEmployeesPerPerson(int.Parse(Session["PersonId"].ToString())).ToList();
            if (empPersons.Count > 0)
            {
                this.btnEditEmp.Visible = true;
            }
            else
            {
                this.btnEditEmp.Visible = false;
            }

            this.GridEmployee.Visible = true;
            this.GridEmployee.DataSource = empPersons;
            this.GridEmployee.DataBind();
        }

        protected void GridPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblError.Visible = false;
            int id = int.Parse(this.GridPerson.SelectedValue.ToString());
            Session["PersonId"] = id.ToString();
            if (Session["PersonId"] != null)
            {
                BindGridEmployees();
            }
            else
            {
                this.lblError.Visible = true;
                this.lblError.Text = "Please select a row.";
            }
        }
        protected void btnSubmitPerson_Click(object sender, EventArgs e)
        {
            em = new Service1Client();

            if (Session["SubmitAction"].ToString() == "Edit")
            {
                Person person = em.GetPersonById(int.Parse(Session["PersonId"].ToString()));
                person.BirthDate = new DateTime(this.calDOB.SelectedDate.Year, this.calDOB.SelectedDate.Month, this.calDOB.SelectedDate.Day);
                person.FirstName = this.txtFirstName.Text;
                person.LastName = this.txtLastName.Text;
                person.PersonId = int.Parse(Session["PersonId"].ToString());
                em.SavePerson(person);
            }
            else if (Session["SubmitAction"].ToString() == "Add")
            {
                Person pers = new Person();
                DateTime DOB = new DateTime(calDOB.SelectedDate.Year, calDOB.SelectedDate.Month, calDOB.SelectedDate.Day);
                pers.BirthDate = DOB;
                pers.FirstName = this.txtFirstName.Text;
                pers.LastName = this.txtLastName.Text;
                em = new Service1Client();
                em.AddPerson(pers);
            }

            BindGridPersons();
            this.MultiView1.SetActiveView(ViewGridPerson);
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            this.GridEmployee.Visible = false;
            this.btnEditEmp.Visible = false;
            Session["SubmitAction"] = "Edit";
            this.lblError.Visible = false;
            if (Session["PersonId"] != null)
            {
                em = new Service1Client();
                this.MultiView1.SetActiveView(ViewSavePerson);
                int id = int.Parse(Session["PersonId"].ToString());
                Person pers = em.GetPersonById(id);
                DateTime DOB = new DateTime(pers.BirthDate.Year, pers.BirthDate.Month, pers.BirthDate.Day);
                this.calDOB.SelectedDate = DOB;
                this.calDOB.VisibleDate = DOB;
                this.txtFirstName.Text = pers.FirstName.ToString();
                this.txtLastName.Text = pers.LastName.ToString();
            }
            else
            {
                this.lblError.Visible = true;
                this.lblError.Text = "Please select a row.";
            }
        }
        protected void calDOB_SelectionChanged(object sender, EventArgs e)
        {
            Session["CalClicked"] = "true";
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            this.GridEmployee.Visible = false;
            this.btnEditEmp.Visible = false;
            Session["SubmitAction"] = "Add";
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.MultiView1.SetActiveView(ViewSavePerson);
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            this.lblError.Visible = false;
            if (Session["PersonId"] != null)
            {
                em = new Service1Client();
                int id = int.Parse(Session["PersonId"].ToString());
                Person pers = em.GetPersonById(id);
                //Delete action
                em.DeletePerson(pers);
                BindGridPersons();
            }
            else
            {
                this.lblError.Visible = true;
                this.lblError.Text = "Please select a row.";
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            this.MultiView1.SetActiveView(ViewGridPerson);
        }
        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Session["SubmitActionEmp"] = "Add";
            this.txtEmployeeNumber.Text = "";
            this.GridEmployee.Visible = false;
            this.btnEditEmp.Visible = false;
            this.MultiView1.SetActiveView(ViewSaveEmployee);
        }
        protected void btnBackEmployee_Click(object sender, EventArgs e)
        {
            this.GridEmployee.Visible = true;
            this.btnEditEmp.Visible = true;
            this.MultiView1.SetActiveView(ViewGridPerson);
        }
        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            em = new Service1Client();

            if (Session["SubmitActionEmp"].ToString() == "Edit")
            {
                Employee employee = em.GetEmployeeById(int.Parse(Session["EmployeeId"].ToString()));
                employee.EmployedDate = new DateTime(this.calEmpDate.SelectedDate.Year, this.calEmpDate.SelectedDate.Month, this.calEmpDate.SelectedDate.Day);
                if (this.calTermDate.SelectedDate != null)
                {
                    employee.TerminatedDate = new DateTime(this.calTermDate.SelectedDate.Year, this.calTermDate.SelectedDate.Month, this.calTermDate.SelectedDate.Day);
                }
                employee.EmployeeNumber = this.txtEmployeeNumber.Text;
                employee.EmployeeId = int.Parse(Session["EmployeeId"].ToString());
                employee.PersonId = int.Parse(Session["PersonId"].ToString());
                em.SaveEmployee(employee);
            }
            else if (Session["SubmitActionEmp"].ToString() == "Add")
            {
                Employee emp = new Employee();
                DateTime empDate = new DateTime(calEmpDate.SelectedDate.Year, calEmpDate.SelectedDate.Month, calEmpDate.SelectedDate.Day);
                emp.EmployedDate = empDate;
                if (this.calTermDate.SelectedDate != null)
                {
                    DateTime termDate = new DateTime(calTermDate.SelectedDate.Year, calTermDate.SelectedDate.Month, calTermDate.SelectedDate.Day);
                    emp.TerminatedDate = termDate;
                }
                emp.PersonId = int.Parse(Session["PersonId"].ToString());
                emp.EmployeeNumber = this.txtEmployeeNumber.Text;
                em = new Service1Client();
                em.AddEmployee(emp);
            }
            BindGridEmployees();
            BindGridPersons();

            this.GridEmployee.Visible = true; ;
            this.btnEditEmp.Visible = true;
            this.MultiView1.SetActiveView(ViewGridPerson);
        }
        protected void btnEditEmp_Click(object sender, EventArgs e)
        {
            this.GridEmployee.Visible = false;
            this.btnEditEmp.Visible = false;

            Session["SubmitActionEmp"] = "Edit";
            this.lblErrorEmp.Visible = false;
            if (Session["EmployeeId"] != null)
            {
                em = new Service1Client();
                this.MultiView1.SetActiveView(ViewSaveEmployee);
                int id = int.Parse(Session["EmployeeId"].ToString());
                Employee emp = em.GetEmployeeById(id);
                DateTime EmpDate = new DateTime(emp.EmployedDate.Year, emp.EmployedDate.Month, emp.EmployedDate.Day);
                this.calEmpDate.SelectedDate = EmpDate;
                this.calEmpDate.VisibleDate = EmpDate;
                DateTime TermDate = new DateTime();
                if (emp.TerminatedDate != null)
                {
                    TermDate = new DateTime(emp.TerminatedDate.Value.Year, emp.TerminatedDate.Value.Month, emp.TerminatedDate.Value.Day);
                    this.calTermDate.SelectedDate = TermDate;
                }
                this.calTermDate.VisibleDate = TermDate;
                this.txtEmployeeNumber.Text = emp.EmployeeNumber.ToString();
            }
            else
            {
                this.lblErrorEmp.Visible = true;
                this.lblErrorEmp.Text = "Please select a row.";
            }
        }

        protected void GridEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.GridEmployee.SelectedValue.ToString());
            Session["EmployeeId"] = id.ToString();
        }
    }
}
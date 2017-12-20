using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService1.Repository
{
    public class EmployeeRepository
    {
        /// <summary>
        /// Data Context.
        /// </summary>
        private EmployeesEntities db = new EmployeesEntities();

        /// <summary>
        /// Get all Employees.
        /// </summary>
        /// <returns></returns>
        public IQueryable<tblEmployee> FindAllEmployees()
        {
            return db.tblEmployees;
        }

        /// <summary>
        /// Returns an Employee by it's ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tblEmployee GetEmployeeById(int id)
        {
            return db.tblEmployees.SingleOrDefault(e => e.EmployeeId == id);
        }

        /// <summary>
        /// Returns an employee by Employee Number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public tblEmployee GetEmployerByNumber(string num)
        {
            return db.tblEmployees.SingleOrDefault(e => e.EmployeeNumber == num);
        }

        /// <summary>
        /// Add a new employee to the database.
        /// </summary>
        /// <param name="employee"></param>
        public void Add(tblEmployee employee)
        {
            db.tblEmployees.Add(employee);
            db.SaveChanges();
        }

        /// <summary>
        /// Deletes an Employee.
        /// </summary>
        /// <param name="employee"></param>
        public void Delete(tblEmployee employee)
        {

            db.tblEmployees.Remove(employee);

            db.SaveChanges();
        }

        /// <summary>
        /// Persist changes to Employee to the database.
        /// </summary>
        /// <param name="employee"></param>
        public void Save(Employee employee)
        {
            //    public int EmployeeId { get; set; }
            //public int PersonId { get; set; }
            //public string EmployeeNumber { get; set; }
            //public System.DateTime EmployedDate { get; set; }

            //public Nullable<System.DateTime> TerminatedDate { get; set; }
            tblEmployee objPersonData = new tblEmployee
            {
                EmployeeId = employee.EmployeeId,
                PersonId = employee.PersonId,
                EmployeeNumber = employee.EmployeeNumber,
                EmployedDate = new DateTime(employee.EmployedDate.Year, employee.EmployedDate.Month, employee.EmployedDate.Day)
            };

            // Since EF doesn't know about this product (it was instantiated by
            // the ModelBinder and not EF itself, we need to tell EF that the
            // object exists and that it is a modified copy of an existing row
            db.Entry(objPersonData).State = EntityState.Modified;

            db.SaveChanges();
        }
    }
}
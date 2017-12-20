using System;
using System.Linq;
using System.Data.Entity;

namespace WcfService2.Repository
{
    public class PersonRepository
    {
        /// <summary>
        /// DataContext
        /// </summary>
        private EmployeesEntities db = new EmployeesEntities();
        
        /// <summary>
        /// Get all Persons.
        /// </summary>
        /// <returns></returns>
        public IQueryable<tblPerson> FindAllPersons()
        {
            return db.tblPersons;
        }

        /// <summary>
        /// Get a Person by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tblPerson GetPersonById(int id)
        {
            return db.tblPersons.SingleOrDefault(p => p.PersonId == id);
        }

        /// <summary>
        /// Add a new Person.
        /// </summary>
        /// <param name="person"></param>
        public void Add(tblPerson person)
        {
            db.tblPersons.Add(person);
            db.SaveChanges();
        }

        /// <summary>
        /// Deletes a Person.
        /// </summary>
        /// <param name="person"></param>
        public void Delete(tblPerson person)
        {
            //query to find person to delete
            //var person_to_delete =
            //from p in db.tblPersons
            //where p.PersonId == person.PersonId
            //select p;
            //tblPerson P = var;
            db.Entry(person).State = EntityState.Deleted;
            //db.tblPersons.Remove(person);

            //Persist to database.
            db.SaveChanges();
        }

        /// <summary>
        /// Get all Employees linked to a Person.
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public IQueryable<tblEmployee> GetEmployeesPerPerson(int personId)
        {
            return from employee in db.tblEmployees
                   where employee.PersonId == personId
                   orderby employee.EmployeeId
                   select employee;
        }

        /// <summary>
        /// Persist the Person changes to the database.
        /// </summary>
        /// <param name="person"></param>
        public void Save(Person person)
        {
            tblPerson objPersonData = new tblPerson
            {
                PersonId = person.PersonId,
                LastName = person.LastName,
                FirstName = person.FirstName,
                BirthDate = new DateTime(person.BirthDate.Year, person.BirthDate.Month, person.BirthDate.Day)
            };
           
                // Since EF doesn't know about this product (it was instantiated by
                // the ModelBinder and not EF itself, we need to tell EF that the
                // object exists and that it is a modified copy of an existing row
                db.Entry(objPersonData).State = EntityState.Modified;
           
            db.SaveChanges();
        }
    }
}
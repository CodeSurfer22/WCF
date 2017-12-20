using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService2.Repository;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            //Access the employee repository
            EmployeeRepository empRepo = new EmployeeRepository();
            IQueryable<tblEmployee> empEnt = empRepo.FindAllEmployees();
            foreach (tblEmployee emp in empEnt)
            {
                //translates the return data of type EmployeeEntity to
                //type Employee.
                employees.Add(TranslateEmployeeEntityToEmployee(emp));
            }
            return employees;
        }

        public List<Employee> GetEmployeesPerPerson(int lineManagerId)
        {
            List<Employee> employees = new List<Employee>();
            PersonRepository persRepo = new PersonRepository();
            IQueryable<tblEmployee> empList = persRepo.GetEmployeesPerPerson(lineManagerId);
            foreach (tblEmployee emp in empList)
            {
                //translates the return data of type EmployeeEntity to
                //type Employee.
                employees.Add(TranslateEmployeeEntityToEmployee(emp));
            }
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            //translates the Employee type into EmployeeEntity for persistence
            //to the data source.
            tblEmployee empEnt = TranslateEmployeeToEmployeeEntity(employee);
            empRepo.Add(empEnt);
        }


        public List<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();
            //Access the Person Repository
            PersonRepository persRepo = new PersonRepository();
            IQueryable<tblPerson> persEnt = persRepo.FindAllPersons();
            foreach (tblPerson pers in persEnt)
            {
                //Translates the returned PersonEntity type into
                //type Person.
                persons.Add(TranslatePersonEntityToPerson(pers));
            }
            return persons;
        }

        private Person TranslateLineManagerEntityToPerson(tblPerson pers)
        {
            throw new NotImplementedException();
        }


        private Person TranslatePersonEntityToPerson(tblPerson personEntity)
        {
            Person person = new Person();
            person.PersonId = personEntity.PersonId;
            person.BirthDate = personEntity.BirthDate;
            person.FirstName = personEntity.FirstName;
            person.LastName = personEntity.LastName;
            return person;
        }

        private Employee TranslateEmployeeEntityToEmployee(tblEmployee employeeEntity)
        {
            Employee employee = new Employee();
            employee.PersonId = employeeEntity.PersonId;
            employee.EmployedDate = employeeEntity.EmployedDate;
            employee.EmployeeNumber = employeeEntity.EmployeeNumber;
            employee.EmployeeId = employeeEntity.EmployeeId;
            employee.TerminatedDate = employeeEntity.TerminatedDate;
            return employee;
        }

        private tblPerson TranslatePersonToPersonEntity(Person person)
        {
            tblPerson personEntity = new tblPerson();
            personEntity.PersonId = person.PersonId;
            personEntity.BirthDate = person.BirthDate;
            personEntity.FirstName = person.FirstName;
            personEntity.LastName = person.LastName;
            return personEntity;
        }

        private tblEmployee TranslateEmployeeToEmployeeEntity(Employee employee)
        {
            tblEmployee employeeEntity = new tblEmployee();
            employeeEntity.EmployedDate = employee.EmployedDate;
            employeeEntity.EmployeeId = employee.EmployeeId;
            employeeEntity.EmployeeNumber = employee.EmployeeNumber;
            employeeEntity.PersonId = employee.PersonId;
            employeeEntity.TerminatedDate = employee.TerminatedDate;
            return employeeEntity;
        }

        public Person GetPersonById(int id)
        {
            PersonRepository persRepo = new PersonRepository();
            tblPerson persEnt = persRepo.GetPersonById(id);
            return TranslatePersonEntityToPerson(persEnt);
        }

        public Employee GetEmployeeById(int id)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            tblEmployee empEnt = empRepo.GetEmployeeById(id);
            return TranslateEmployeeEntityToEmployee(empEnt);
        }

        public void SavePerson(Person person)
        {
            PersonRepository persRepo = new PersonRepository();
            persRepo.Save(person);
        }

        public void AddPerson(Person person)
        {
            PersonRepository persRepo = new PersonRepository();
            tblPerson persEnt = TranslatePersonToPersonEntity(person);
            persRepo.Add(persEnt);
        }

        public void DeletePerson(Person person)
        {
            PersonRepository persRepo = new PersonRepository();
            tblPerson persEnt = TranslatePersonToPersonEntity(person);
            persRepo.Delete(persEnt);
        }

        public void SaveEmployee(Employee employee)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            empRepo.Save(employee);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// Returna all Employee information from the data source.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Employee> GetAllEmployees();

        /// <summary>
        /// Returns all Persons from the data source.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Person> GetAllPersons();

        /// <summary>
        /// Get a specific person by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        Person GetPersonById(int id);

        /// <summary>
        /// Get employee information by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        Employee GetEmployeeById(int id);

        /// <summary>
        /// Adds a new Person to the database.
        /// </summary>
        /// <param name="person"></param>
        [OperationContract]
        void AddPerson(Person person);

        /// <summary>
        /// Deletes a Person from the database.
        /// </summary>
        /// <param name="person"></param>
        [OperationContract]
        void DeletePerson(Person person);

        /// <summary>
        /// Returns Employee information for a Person based on PersonId.
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        [OperationContract]
        List<Employee> GetEmployeesPerPerson(int managerId);

        /// <summary>
        /// Adds new employe record to database.
        /// </summary>
        /// <param name="employee"></param>
        [OperationContract]
        void AddEmployee(Employee employee);

        /// <summary>
        /// Persists Person data to the database.
        /// </summary>
        /// <param name="person"></param>
        [OperationContract]
        void SavePerson(Person person);

        /// <summary>
        /// Persists Employee data to the database.
        /// </summary>
        /// <param name="employee"></param>
        [OperationContract]
        void SaveEmployee(Employee employee);
    }

    //Data Models/Entities
    [DataContract]
    public class Person
    {
        [DataMember]
        public int PersonId { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
    }

    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public int PersonId { get; set; }
        [DataMember]
        public string EmployeeNumber { get; set; }
        [DataMember]
        public DateTime EmployedDate { get; set; }
        [DataMember]
        public DateTime? TerminatedDate { get; set; }
    }
}

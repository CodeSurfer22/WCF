﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstWebApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/WcfService2")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EmployedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> TerminatedDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EmployedDate {
            get {
                return this.EmployedDateField;
            }
            set {
                if ((this.EmployedDateField.Equals(value) != true)) {
                    this.EmployedDateField = value;
                    this.RaisePropertyChanged("EmployedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeNumber {
            get {
                return this.EmployeeNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNumberField, value) != true)) {
                    this.EmployeeNumberField = value;
                    this.RaisePropertyChanged("EmployeeNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonId {
            get {
                return this.PersonIdField;
            }
            set {
                if ((this.PersonIdField.Equals(value) != true)) {
                    this.PersonIdField = value;
                    this.RaisePropertyChanged("PersonId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> TerminatedDate {
            get {
                return this.TerminatedDateField;
            }
            set {
                if ((this.TerminatedDateField.Equals(value) != true)) {
                    this.TerminatedDateField = value;
                    this.RaisePropertyChanged("TerminatedDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfService2")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonId {
            get {
                return this.PersonIdField;
            }
            set {
                if ((this.PersonIdField.Equals(value) != true)) {
                    this.PersonIdField = value;
                    this.RaisePropertyChanged("PersonId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployees", ReplyAction="http://tempuri.org/IService1/GetAllEmployeesResponse")]
        MyFirstWebApp.ServiceReference1.Employee[] GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployees", ReplyAction="http://tempuri.org/IService1/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Employee[]> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPersons", ReplyAction="http://tempuri.org/IService1/GetAllPersonsResponse")]
        MyFirstWebApp.ServiceReference1.Person[] GetAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPersons", ReplyAction="http://tempuri.org/IService1/GetAllPersonsResponse")]
        System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Person[]> GetAllPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonById", ReplyAction="http://tempuri.org/IService1/GetPersonByIdResponse")]
        MyFirstWebApp.ServiceReference1.Person GetPersonById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonById", ReplyAction="http://tempuri.org/IService1/GetPersonByIdResponse")]
        System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Person> GetPersonByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeById", ReplyAction="http://tempuri.org/IService1/GetEmployeeByIdResponse")]
        MyFirstWebApp.ServiceReference1.Employee GetEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeById", ReplyAction="http://tempuri.org/IService1/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Employee> GetEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPerson", ReplyAction="http://tempuri.org/IService1/AddPersonResponse")]
        void AddPerson(MyFirstWebApp.ServiceReference1.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPerson", ReplyAction="http://tempuri.org/IService1/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(MyFirstWebApp.ServiceReference1.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        void DeletePerson(MyFirstWebApp.ServiceReference1.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(MyFirstWebApp.ServiceReference1.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeesPerPerson", ReplyAction="http://tempuri.org/IService1/GetEmployeesPerPersonResponse")]
        MyFirstWebApp.ServiceReference1.Employee[] GetEmployeesPerPerson(int managerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeesPerPerson", ReplyAction="http://tempuri.org/IService1/GetEmployeesPerPersonResponse")]
        System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Employee[]> GetEmployeesPerPersonAsync(int managerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployee", ReplyAction="http://tempuri.org/IService1/AddEmployeeResponse")]
        void AddEmployee(MyFirstWebApp.ServiceReference1.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployee", ReplyAction="http://tempuri.org/IService1/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(MyFirstWebApp.ServiceReference1.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SavePerson", ReplyAction="http://tempuri.org/IService1/SavePersonResponse")]
        void SavePerson(MyFirstWebApp.ServiceReference1.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SavePerson", ReplyAction="http://tempuri.org/IService1/SavePersonResponse")]
        System.Threading.Tasks.Task SavePersonAsync(MyFirstWebApp.ServiceReference1.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveEmployee", ReplyAction="http://tempuri.org/IService1/SaveEmployeeResponse")]
        void SaveEmployee(MyFirstWebApp.ServiceReference1.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveEmployee", ReplyAction="http://tempuri.org/IService1/SaveEmployeeResponse")]
        System.Threading.Tasks.Task SaveEmployeeAsync(MyFirstWebApp.ServiceReference1.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MyFirstWebApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MyFirstWebApp.ServiceReference1.IService1>, MyFirstWebApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MyFirstWebApp.ServiceReference1.Employee[] GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Employee[]> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public MyFirstWebApp.ServiceReference1.Person[] GetAllPersons() {
            return base.Channel.GetAllPersons();
        }
        
        public System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Person[]> GetAllPersonsAsync() {
            return base.Channel.GetAllPersonsAsync();
        }
        
        public MyFirstWebApp.ServiceReference1.Person GetPersonById(int id) {
            return base.Channel.GetPersonById(id);
        }
        
        public System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Person> GetPersonByIdAsync(int id) {
            return base.Channel.GetPersonByIdAsync(id);
        }
        
        public MyFirstWebApp.ServiceReference1.Employee GetEmployeeById(int id) {
            return base.Channel.GetEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Employee> GetEmployeeByIdAsync(int id) {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public void AddPerson(MyFirstWebApp.ServiceReference1.Person person) {
            base.Channel.AddPerson(person);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(MyFirstWebApp.ServiceReference1.Person person) {
            return base.Channel.AddPersonAsync(person);
        }
        
        public void DeletePerson(MyFirstWebApp.ServiceReference1.Person person) {
            base.Channel.DeletePerson(person);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(MyFirstWebApp.ServiceReference1.Person person) {
            return base.Channel.DeletePersonAsync(person);
        }
        
        public MyFirstWebApp.ServiceReference1.Employee[] GetEmployeesPerPerson(int managerId) {
            return base.Channel.GetEmployeesPerPerson(managerId);
        }
        
        public System.Threading.Tasks.Task<MyFirstWebApp.ServiceReference1.Employee[]> GetEmployeesPerPersonAsync(int managerId) {
            return base.Channel.GetEmployeesPerPersonAsync(managerId);
        }
        
        public void AddEmployee(MyFirstWebApp.ServiceReference1.Employee employee) {
            base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(MyFirstWebApp.ServiceReference1.Employee employee) {
            return base.Channel.AddEmployeeAsync(employee);
        }
        
        public void SavePerson(MyFirstWebApp.ServiceReference1.Person person) {
            base.Channel.SavePerson(person);
        }
        
        public System.Threading.Tasks.Task SavePersonAsync(MyFirstWebApp.ServiceReference1.Person person) {
            return base.Channel.SavePersonAsync(person);
        }
        
        public void SaveEmployee(MyFirstWebApp.ServiceReference1.Employee employee) {
            base.Channel.SaveEmployee(employee);
        }
        
        public System.Threading.Tasks.Task SaveEmployeeAsync(MyFirstWebApp.ServiceReference1.Employee employee) {
            return base.Channel.SaveEmployeeAsync(employee);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAppCool.EmployeeMaintenenaceClient {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeMaintenenaceClient.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployees", ReplyAction="http://tempuri.org/IService1/GetAllEmployeesResponse")]
        MVCAppCool.EmployeeMaintenenaceClient.Employee[] GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployees", ReplyAction="http://tempuri.org/IService1/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Employee[]> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPersons", ReplyAction="http://tempuri.org/IService1/GetAllPersonsResponse")]
        MVCAppCool.EmployeeMaintenenaceClient.Person[] GetAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPersons", ReplyAction="http://tempuri.org/IService1/GetAllPersonsResponse")]
        System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Person[]> GetAllPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonById", ReplyAction="http://tempuri.org/IService1/GetPersonByIdResponse")]
        MVCAppCool.EmployeeMaintenenaceClient.Person GetPersonById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonById", ReplyAction="http://tempuri.org/IService1/GetPersonByIdResponse")]
        System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Person> GetPersonByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeById", ReplyAction="http://tempuri.org/IService1/GetEmployeeByIdResponse")]
        MVCAppCool.EmployeeMaintenenaceClient.Employee GetEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeById", ReplyAction="http://tempuri.org/IService1/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Employee> GetEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPerson", ReplyAction="http://tempuri.org/IService1/AddPersonResponse")]
        void AddPerson(MVCAppCool.EmployeeMaintenenaceClient.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPerson", ReplyAction="http://tempuri.org/IService1/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(MVCAppCool.EmployeeMaintenenaceClient.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        void DeletePerson(MVCAppCool.EmployeeMaintenenaceClient.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(MVCAppCool.EmployeeMaintenenaceClient.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeesPerPerson", ReplyAction="http://tempuri.org/IService1/GetEmployeesPerPersonResponse")]
        MVCAppCool.EmployeeMaintenenaceClient.Employee[] GetEmployeesPerPerson(int managerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeesPerPerson", ReplyAction="http://tempuri.org/IService1/GetEmployeesPerPersonResponse")]
        System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Employee[]> GetEmployeesPerPersonAsync(int managerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployee", ReplyAction="http://tempuri.org/IService1/AddEmployeeResponse")]
        void AddEmployee(MVCAppCool.EmployeeMaintenenaceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployee", ReplyAction="http://tempuri.org/IService1/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(MVCAppCool.EmployeeMaintenenaceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SavePerson", ReplyAction="http://tempuri.org/IService1/SavePersonResponse")]
        void SavePerson(MVCAppCool.EmployeeMaintenenaceClient.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SavePerson", ReplyAction="http://tempuri.org/IService1/SavePersonResponse")]
        System.Threading.Tasks.Task SavePersonAsync(MVCAppCool.EmployeeMaintenenaceClient.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveEmployee", ReplyAction="http://tempuri.org/IService1/SaveEmployeeResponse")]
        void SaveEmployee(MVCAppCool.EmployeeMaintenenaceClient.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveEmployee", ReplyAction="http://tempuri.org/IService1/SaveEmployeeResponse")]
        System.Threading.Tasks.Task SaveEmployeeAsync(MVCAppCool.EmployeeMaintenenaceClient.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVCAppCool.EmployeeMaintenenaceClient.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVCAppCool.EmployeeMaintenenaceClient.IService1>, MVCAppCool.EmployeeMaintenenaceClient.IService1 {
        
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
        
        public MVCAppCool.EmployeeMaintenenaceClient.Employee[] GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Employee[]> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public MVCAppCool.EmployeeMaintenenaceClient.Person[] GetAllPersons() {
            return base.Channel.GetAllPersons();
        }
        
        public System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Person[]> GetAllPersonsAsync() {
            return base.Channel.GetAllPersonsAsync();
        }
        
        public MVCAppCool.EmployeeMaintenenaceClient.Person GetPersonById(int id) {
            return base.Channel.GetPersonById(id);
        }
        
        public System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Person> GetPersonByIdAsync(int id) {
            return base.Channel.GetPersonByIdAsync(id);
        }
        
        public MVCAppCool.EmployeeMaintenenaceClient.Employee GetEmployeeById(int id) {
            return base.Channel.GetEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Employee> GetEmployeeByIdAsync(int id) {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public void AddPerson(MVCAppCool.EmployeeMaintenenaceClient.Person person) {
            base.Channel.AddPerson(person);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(MVCAppCool.EmployeeMaintenenaceClient.Person person) {
            return base.Channel.AddPersonAsync(person);
        }
        
        public void DeletePerson(MVCAppCool.EmployeeMaintenenaceClient.Person person) {
            base.Channel.DeletePerson(person);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(MVCAppCool.EmployeeMaintenenaceClient.Person person) {
            return base.Channel.DeletePersonAsync(person);
        }
        
        public MVCAppCool.EmployeeMaintenenaceClient.Employee[] GetEmployeesPerPerson(int managerId) {
            return base.Channel.GetEmployeesPerPerson(managerId);
        }
        
        public System.Threading.Tasks.Task<MVCAppCool.EmployeeMaintenenaceClient.Employee[]> GetEmployeesPerPersonAsync(int managerId) {
            return base.Channel.GetEmployeesPerPersonAsync(managerId);
        }
        
        public void AddEmployee(MVCAppCool.EmployeeMaintenenaceClient.Employee employee) {
            base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(MVCAppCool.EmployeeMaintenenaceClient.Employee employee) {
            return base.Channel.AddEmployeeAsync(employee);
        }
        
        public void SavePerson(MVCAppCool.EmployeeMaintenenaceClient.Person person) {
            base.Channel.SavePerson(person);
        }
        
        public System.Threading.Tasks.Task SavePersonAsync(MVCAppCool.EmployeeMaintenenaceClient.Person person) {
            return base.Channel.SavePersonAsync(person);
        }
        
        public void SaveEmployee(MVCAppCool.EmployeeMaintenenaceClient.Employee employee) {
            base.Channel.SaveEmployee(employee);
        }
        
        public System.Threading.Tasks.Task SaveEmployeeAsync(MVCAppCool.EmployeeMaintenenaceClient.Employee employee) {
            return base.Channel.SaveEmployeeAsync(employee);
        }
    }
}

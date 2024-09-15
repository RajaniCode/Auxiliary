﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("SFTPHModel", "FK_Employee_Employee", "ReportsTo", global::System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(NorthWind.Business.EF.SelfReferencing.Employee), "Employees", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(NorthWind.Business.EF.SelfReferencing.Employee))]

// Original file name:
// Generation date: 11/5/2008 7:43:44 PM
namespace NorthWind.Business.EF.SelfReferencing
{
    
    /// <summary>
    /// There are no comments for SFTPHEntities in the schema.
    /// </summary>
    public partial class SFTPHEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new SFTPHEntities object using the connection string found in the 'SFTPHEntities' section of the application configuration file.
        /// </summary>
        public SFTPHEntities() : 
                base("name=SFTPHEntities", "SFTPHEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new SFTPHEntities object.
        /// </summary>
        public SFTPHEntities(string connectionString) : 
                base(connectionString, "SFTPHEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new SFTPHEntities object.
        /// </summary>
        public SFTPHEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "SFTPHEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Employee> Employees
        {
            get
            {
                if ((this._Employees == null))
                {
                    this._Employees = base.CreateQuery<Employee>("[Employees]");
                }
                return this._Employees;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Employee> _Employees;
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
        /// <summary>
        /// There are no comments for SFTPHModel.GetSubEmployees in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectResult<Manager> GetSubEmployees(global::System.Nullable<int> employeeId)
        {
            global::System.Data.Objects.ObjectParameter employeeIdParameter;
            if (employeeId.HasValue)
            {
                employeeIdParameter = new global::System.Data.Objects.ObjectParameter("EmployeeId", employeeId);
            }
            else
            {
                employeeIdParameter = new global::System.Data.Objects.ObjectParameter("EmployeeId", typeof(int));
            }
            return base.ExecuteFunction<Manager>("GetSubEmployees", employeeIdParameter);
        }
    }
    /// <summary>
    /// There are no comments for SFTPHModel.Employee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EmployeeID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SFTPHModel", Name="Employee")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    [global::System.Runtime.Serialization.KnownTypeAttribute(typeof(global::NorthWind.Business.EF.SelfReferencing.SalariedEmployee))]
    [global::System.Runtime.Serialization.KnownTypeAttribute(typeof(global::NorthWind.Business.EF.SelfReferencing.SalesAgent))]
    public abstract partial class Employee : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// There are no comments for Property EmployeeID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
            set
            {
                this.OnEmployeeIDChanging(value);
                this.ReportPropertyChanging("EmployeeID");
                this._EmployeeID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("EmployeeID");
                this.OnEmployeeIDChanged();
            }
        }
        private int _EmployeeID;
        partial void OnEmployeeIDChanging(int value);
        partial void OnEmployeeIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property HireDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> HireDate
        {
            get
            {
                return this._HireDate;
            }
            set
            {
                this.OnHireDateChanging(value);
                this.ReportPropertyChanging("HireDate");
                this._HireDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("HireDate");
                this.OnHireDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _HireDate;
        partial void OnHireDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnHireDateChanged();
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SFTPHModel", "FK_Employee_Employee", "Employees")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<Employee> Employees
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Employee>("SFTPHModel.FK_Employee_Employee", "Employees");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Employee>("SFTPHModel.FK_Employee_Employee", "Employees", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for ReportsTo in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SFTPHModel", "FK_Employee_Employee", "ReportsTo")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Employee ReportsTo
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Employee>("SFTPHModel.FK_Employee_Employee", "ReportsTo").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Employee>("SFTPHModel.FK_Employee_Employee", "ReportsTo").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for ReportsTo in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Employee> ReportsToReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Employee>("SFTPHModel.FK_Employee_Employee", "ReportsTo");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Employee>("SFTPHModel.FK_Employee_Employee", "ReportsTo", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for SFTPHModel.SalesAgent in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EmployeeID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SFTPHModel", Name="SalesAgent")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class SalesAgent : Employee
    {
        /// <summary>
        /// Create a new SalesAgent object.
        /// </summary>
        /// <param name="employeeID">Initial value of EmployeeID.</param>
        /// <param name="name">Initial value of Name.</param>
        public static SalesAgent CreateSalesAgent(int employeeID, string name)
        {
            SalesAgent salesAgent = new SalesAgent();
            salesAgent.EmployeeID = employeeID;
            salesAgent.Name = name;
            return salesAgent;
        }
        /// <summary>
        /// There are no comments for Property Commission in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> Commission
        {
            get
            {
                return this._Commission;
            }
            set
            {
                this.OnCommissionChanging(value);
                this.ReportPropertyChanging("Commission");
                this._Commission = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Commission");
                this.OnCommissionChanged();
            }
        }
        private global::System.Nullable<int> _Commission;
        partial void OnCommissionChanging(global::System.Nullable<int> value);
        partial void OnCommissionChanged();
    }
    /// <summary>
    /// There are no comments for SFTPHModel.SalariedEmployee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EmployeeID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SFTPHModel", Name="SalariedEmployee")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    [global::System.Runtime.Serialization.KnownTypeAttribute(typeof(global::NorthWind.Business.EF.SelfReferencing.Manager))]
    [global::System.Runtime.Serialization.KnownTypeAttribute(typeof(global::NorthWind.Business.EF.SelfReferencing.President))]
    [global::System.Runtime.Serialization.KnownTypeAttribute(typeof(global::NorthWind.Business.EF.SelfReferencing.Supervisor))]
    public abstract partial class SalariedEmployee : Employee
    {
        /// <summary>
        /// There are no comments for Property Salary in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> Salary
        {
            get
            {
                return this._Salary;
            }
            set
            {
                this.OnSalaryChanging(value);
                this.ReportPropertyChanging("Salary");
                this._Salary = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Salary");
                this.OnSalaryChanged();
            }
        }
        private global::System.Nullable<int> _Salary;
        partial void OnSalaryChanging(global::System.Nullable<int> value);
        partial void OnSalaryChanged();
    }
    /// <summary>
    /// There are no comments for SFTPHModel.Manager in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EmployeeID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SFTPHModel", Name="Manager")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Manager : SalariedEmployee
    {
        /// <summary>
        /// Create a new Manager object.
        /// </summary>
        /// <param name="employeeID">Initial value of EmployeeID.</param>
        /// <param name="name">Initial value of Name.</param>
        public static Manager CreateManager(int employeeID, string name)
        {
            Manager manager = new Manager();
            manager.EmployeeID = employeeID;
            manager.Name = name;
            return manager;
        }
    }
    /// <summary>
    /// There are no comments for SFTPHModel.President in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EmployeeID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SFTPHModel", Name="President")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class President : SalariedEmployee
    {
        /// <summary>
        /// Create a new President object.
        /// </summary>
        /// <param name="employeeID">Initial value of EmployeeID.</param>
        /// <param name="name">Initial value of Name.</param>
        public static President CreatePresident(int employeeID, string name)
        {
            President president = new President();
            president.EmployeeID = employeeID;
            president.Name = name;
            return president;
        }
    }
    /// <summary>
    /// There are no comments for SFTPHModel.Supervisor in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EmployeeID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SFTPHModel", Name="Supervisor")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Supervisor : SalariedEmployee
    {
        /// <summary>
        /// Create a new Supervisor object.
        /// </summary>
        /// <param name="employeeID">Initial value of EmployeeID.</param>
        /// <param name="name">Initial value of Name.</param>
        public static Supervisor CreateSupervisor(int employeeID, string name)
        {
            Supervisor supervisor = new Supervisor();
            supervisor.EmployeeID = employeeID;
            supervisor.Name = name;
            return supervisor;
        }
    }
}

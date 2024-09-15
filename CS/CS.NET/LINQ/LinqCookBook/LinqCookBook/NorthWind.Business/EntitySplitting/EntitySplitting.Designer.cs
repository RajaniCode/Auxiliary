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

// Original file name:
// Generation date: 10/28/2008 5:50:39 PM
namespace NorthWind.Business.EF.EntitySplitting
{
    
    /// <summary>
    /// There are no comments for ESEntities in the schema.
    /// </summary>
    public partial class ESEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new ESEntities object using the connection string found in the 'ESEntities' section of the application configuration file.
        /// </summary>
        public ESEntities() : 
                base("name=ESEntities", "ESEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new ESEntities object.
        /// </summary>
        public ESEntities(string connectionString) : 
                base(connectionString, "ESEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new ESEntities object.
        /// </summary>
        public ESEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "ESEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Customer> Customers
        {
            get
            {
                if ((this._Customers == null))
                {
                    this._Customers = base.CreateQuery<Customer>("[Customers]");
                }
                return this._Customers;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Customer> _Customers;
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
    }
    /// <summary>
    /// There are no comments for ESModel.Customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CustomerId
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="ESModel", Name="Customer")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Customer : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerId">Initial value of CustomerId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="accountNo">Initial value of AccountNo.</param>
        /// <param name="accountBalance">Initial value of AccountBalance.</param>
        /// <param name="clubName">Initial value of ClubName.</param>
        /// <param name="dues">Initial value of Dues.</param>
        public static Customer CreateCustomer(int customerId, string name, string accountNo, int accountBalance, string clubName, int dues)
        {
            Customer customer = new Customer();
            customer.CustomerId = customerId;
            customer.Name = name;
            customer.AccountNo = accountNo;
            customer.AccountBalance = accountBalance;
            customer.ClubName = clubName;
            customer.Dues = dues;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property CustomerId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId
        {
            get
            {
                return this._CustomerId;
            }
            set
            {
                this.OnCustomerIdChanging(value);
                this.ReportPropertyChanging("CustomerId");
                this._CustomerId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("CustomerId");
                this.OnCustomerIdChanged();
            }
        }
        private int _CustomerId;
        partial void OnCustomerIdChanging(int value);
        partial void OnCustomerIdChanged();
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
        /// There are no comments for Property AccountNo in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountNo
        {
            get
            {
                return this._AccountNo;
            }
            set
            {
                this.OnAccountNoChanging(value);
                this.ReportPropertyChanging("AccountNo");
                this._AccountNo = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("AccountNo");
                this.OnAccountNoChanged();
            }
        }
        private string _AccountNo;
        partial void OnAccountNoChanging(string value);
        partial void OnAccountNoChanged();
        /// <summary>
        /// There are no comments for Property AccountBalance in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int AccountBalance
        {
            get
            {
                return this._AccountBalance;
            }
            set
            {
                this.OnAccountBalanceChanging(value);
                this.ReportPropertyChanging("AccountBalance");
                this._AccountBalance = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AccountBalance");
                this.OnAccountBalanceChanged();
            }
        }
        private int _AccountBalance;
        partial void OnAccountBalanceChanging(int value);
        partial void OnAccountBalanceChanged();
        /// <summary>
        /// There are no comments for Property ClubName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ClubName
        {
            get
            {
                return this._ClubName;
            }
            set
            {
                this.OnClubNameChanging(value);
                this.ReportPropertyChanging("ClubName");
                this._ClubName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("ClubName");
                this.OnClubNameChanged();
            }
        }
        private string _ClubName;
        partial void OnClubNameChanging(string value);
        partial void OnClubNameChanged();
        /// <summary>
        /// There are no comments for Property Dues in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Dues
        {
            get
            {
                return this._Dues;
            }
            set
            {
                this.OnDuesChanging(value);
                this.ReportPropertyChanging("Dues");
                this._Dues = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Dues");
                this.OnDuesChanged();
            }
        }
        private int _Dues;
        partial void OnDuesChanging(int value);
        partial void OnDuesChanged();
    }
}

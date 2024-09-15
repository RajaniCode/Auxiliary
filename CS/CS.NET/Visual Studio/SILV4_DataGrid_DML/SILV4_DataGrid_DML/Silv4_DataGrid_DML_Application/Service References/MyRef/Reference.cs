//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 10-09-2010 15:58:16
namespace Silv4_DataGrid_DML_Application.MyRef
{
    
    /// <summary>
    /// There are no comments for CompanyEntities in the schema.
    /// </summary>
    public partial class CompanyEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new CompanyEntities object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public CompanyEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("CompanyModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Silv4_DataGrid_DML_Application.MyRef", typeName.Substring(12)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Silv4_DataGrid_DML_Application.MyRef", global::System.StringComparison.Ordinal))
            {
                return string.Concat("CompanyModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Customer> Customer
        {
            get
            {
                if ((this._Customer == null))
                {
                    this._Customer = base.CreateQuery<Customer>("Customer");
                }
                return this._Customer;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Customer> _Customer;
        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCustomer(Customer customer)
        {
            base.AddObject("Customer", customer);
        }
    }
    /// <summary>
    /// There are no comments for CompanyModel.Customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CustomerID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("CustomerID")]
    public partial class Customer
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerID">Initial value of CustomerID.</param>
        /// <param name="customerName">Initial value of CustomerName.</param>
        /// <param name="address">Initial value of Address.</param>
        /// <param name="city">Initial value of City.</param>
        /// <param name="state">Initial value of State.</param>
        /// <param name="age">Initial value of Age.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Customer CreateCustomer(int customerID, string customerName, string address, string city, string state, int age)
        {
            Customer customer = new Customer();
            customer.CustomerID = customerID;
            customer.CustomerName = customerName;
            customer.Address = address;
            customer.City = city;
            customer.State = state;
            customer.Age = age;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property CustomerID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this.OnCustomerIDChanging(value);
                this._CustomerID = value;
                this.OnCustomerIDChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _CustomerID;
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
        /// <summary>
        /// There are no comments for Property CustomerName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CustomerName
        {
            get
            {
                return this._CustomerName;
            }
            set
            {
                this.OnCustomerNameChanging(value);
                this._CustomerName = value;
                this.OnCustomerNameChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CustomerName;
        partial void OnCustomerNameChanging(string value);
        partial void OnCustomerNameChanged();
        /// <summary>
        /// There are no comments for Property Address in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this.OnAddressChanging(value);
                this._Address = value;
                this.OnAddressChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Address;
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
        /// <summary>
        /// There are no comments for Property City in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _City;
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property Age in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Age
        {
            get
            {
                return this._Age;
            }
            set
            {
                this.OnAgeChanging(value);
                this._Age = value;
                this.OnAgeChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Age;
        partial void OnAgeChanging(int value);
        partial void OnAgeChanged();
    }
}

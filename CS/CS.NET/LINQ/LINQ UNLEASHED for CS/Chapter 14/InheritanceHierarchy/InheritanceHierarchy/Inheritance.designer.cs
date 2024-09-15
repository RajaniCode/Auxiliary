﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inheritance
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="Inheritance")]
	public partial class InheritanceDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPerson(Person instance);
    partial void UpdatePerson(Person instance);
    partial void DeletePerson(Person instance);
    #endregion
		
		public InheritanceDataContext() : 
				base(global::InheritanceHierarchy.Properties.Settings.Default.InheritanceConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public InheritanceDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InheritanceDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InheritanceDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InheritanceDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Person> Persons
		{
			get
			{
				return this.GetTable<Person>();
			}
		}
	}
	
	[Table(Name="dbo.Person")]
	[InheritanceMapping(Code="P", Type=typeof(Person), IsDefault=true)]
	[InheritanceMapping(Code="A", Type=typeof(Patient))]
	[InheritanceMapping(Code="V", Type=typeof(VendorContact))]
	public partial class Person : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PersonID;
		
		private char _KindKey;
		
		private string _FirstName;
		
		private string _LastName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonIDChanging(int value);
    partial void OnPersonIDChanged();
    partial void OnKindKeyChanging(char value);
    partial void OnKindKeyChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    #endregion
		
		public Person()
		{
			OnCreated();
		}
		
		[Column(Storage="_PersonID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PersonID
		{
			get
			{
				return this._PersonID;
			}
			set
			{
				if ((this._PersonID != value))
				{
					this.OnPersonIDChanging(value);
					this.SendPropertyChanging();
					this._PersonID = value;
					this.SendPropertyChanged("PersonID");
					this.OnPersonIDChanged();
				}
			}
		}
		
		[Column(Storage="_KindKey", DbType="Char(1) NOT NULL", IsDiscriminator=true)]
		public char KindKey
		{
			get
			{
				return this._KindKey;
			}
			set
			{
				if ((this._KindKey != value))
				{
					this.OnKindKeyChanging(value);
					this.SendPropertyChanging();
					this._KindKey = value;
					this.SendPropertyChanged("KindKey");
					this.OnKindKeyChanged();
				}
			}
		}
		
		[Column(Storage="_FirstName", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_LastName", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class Patient : Person
	{
		
		private System.Nullable<char> _Gender;
		
		private System.Nullable<int> _Age;
		
		private System.Nullable<System.DateTime> _DateOfLastVisit;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGenderChanging(System.Nullable<char> value);
    partial void OnGenderChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnDateOfLastVisitChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfLastVisitChanged();
    #endregion
		
		public Patient()
		{
			OnCreated();
		}
		
		[Column(Storage="_Gender", DbType="NChar(1)")]
		public System.Nullable<char> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[Column(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[Column(Storage="_DateOfLastVisit", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateOfLastVisit
		{
			get
			{
				return this._DateOfLastVisit;
			}
			set
			{
				if ((this._DateOfLastVisit != value))
				{
					this.OnDateOfLastVisitChanging(value);
					this.SendPropertyChanging();
					this._DateOfLastVisit = value;
					this.SendPropertyChanged("DateOfLastVisit");
					this.OnDateOfLastVisitChanged();
				}
			}
		}
	}
	
	public partial class VendorContact : Person
	{
		
		private string _Title;
		
		private System.Nullable<int> _CompanyID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnCompanyIDChanging(System.Nullable<int> value);
    partial void OnCompanyIDChanged();
    #endregion
		
		public VendorContact()
		{
			OnCreated();
		}
		
		[Column(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_CompanyID", DbType="Int")]
		public System.Nullable<int> CompanyID
		{
			get
			{
				return this._CompanyID;
			}
			set
			{
				if ((this._CompanyID != value))
				{
					this.OnCompanyIDChanging(value);
					this.SendPropertyChanging();
					this._CompanyID = value;
					this.SendPropertyChanged("CompanyID");
					this.OnCompanyIDChanged();
				}
			}
		}
	}
}
#pragma warning restore 1591

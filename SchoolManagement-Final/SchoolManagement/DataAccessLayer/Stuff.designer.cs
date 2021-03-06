﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SchoolDataBase")]
	public partial class StuffDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStuffTable(StuffTable instance);
    partial void UpdateStuffTable(StuffTable instance);
    partial void DeleteStuffTable(StuffTable instance);
    #endregion
		
		public StuffDataContext() : 
				base(global::DataAccessLayer.Properties.Settings.Default.SchoolDataBaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StuffDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StuffDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StuffDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StuffDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<StuffTable> StuffTables
		{
			get
			{
				return this.GetTable<StuffTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StuffTable")]
	public partial class StuffTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _firstname;
		
		private string _lastname;
		
		private System.DateTime _dob;
		
		private string _currentadd;
		
		private string _permanentadd;
		
		private string _nationality;
		
		private string _marital;
		
		private string _religion;
		
		private string _catagory;
		
		private int _salary;
		
		private string _email;
		
		private string _mobile;
		
		private double _ssc;
		
		private double _hsc;
		
		private double _undergraduate;
		
		private double _graduate;
		
		private string _stid;
		
		private System.Data.Linq.Binary _image;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnfirstnameChanging(string value);
    partial void OnfirstnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OndobChanging(System.DateTime value);
    partial void OndobChanged();
    partial void OncurrentaddChanging(string value);
    partial void OncurrentaddChanged();
    partial void OnpermanentaddChanging(string value);
    partial void OnpermanentaddChanged();
    partial void OnnationalityChanging(string value);
    partial void OnnationalityChanged();
    partial void OnmaritalChanging(string value);
    partial void OnmaritalChanged();
    partial void OnreligionChanging(string value);
    partial void OnreligionChanged();
    partial void OncatagoryChanging(string value);
    partial void OncatagoryChanged();
    partial void OnsalaryChanging(int value);
    partial void OnsalaryChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnmobileChanging(string value);
    partial void OnmobileChanged();
    partial void OnsscChanging(double value);
    partial void OnsscChanged();
    partial void OnhscChanging(double value);
    partial void OnhscChanged();
    partial void OnundergraduateChanging(double value);
    partial void OnundergraduateChanged();
    partial void OngraduateChanging(double value);
    partial void OngraduateChanged();
    partial void OnstidChanging(string value);
    partial void OnstidChanged();
    partial void OnimageChanging(System.Data.Linq.Binary value);
    partial void OnimageChanged();
    #endregion
		
		public StuffTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string firstname
		{
			get
			{
				return this._firstname;
			}
			set
			{
				if ((this._firstname != value))
				{
					this.OnfirstnameChanging(value);
					this.SendPropertyChanging();
					this._firstname = value;
					this.SendPropertyChanged("firstname");
					this.OnfirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="Date NOT NULL")]
		public System.DateTime dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this.OndobChanging(value);
					this.SendPropertyChanging();
					this._dob = value;
					this.SendPropertyChanged("dob");
					this.OndobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currentadd", DbType="VarChar(50)")]
		public string currentadd
		{
			get
			{
				return this._currentadd;
			}
			set
			{
				if ((this._currentadd != value))
				{
					this.OncurrentaddChanging(value);
					this.SendPropertyChanging();
					this._currentadd = value;
					this.SendPropertyChanged("currentadd");
					this.OncurrentaddChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_permanentadd", DbType="VarChar(50)")]
		public string permanentadd
		{
			get
			{
				return this._permanentadd;
			}
			set
			{
				if ((this._permanentadd != value))
				{
					this.OnpermanentaddChanging(value);
					this.SendPropertyChanging();
					this._permanentadd = value;
					this.SendPropertyChanged("permanentadd");
					this.OnpermanentaddChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nationality", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nationality
		{
			get
			{
				return this._nationality;
			}
			set
			{
				if ((this._nationality != value))
				{
					this.OnnationalityChanging(value);
					this.SendPropertyChanging();
					this._nationality = value;
					this.SendPropertyChanged("nationality");
					this.OnnationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marital", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string marital
		{
			get
			{
				return this._marital;
			}
			set
			{
				if ((this._marital != value))
				{
					this.OnmaritalChanging(value);
					this.SendPropertyChanging();
					this._marital = value;
					this.SendPropertyChanged("marital");
					this.OnmaritalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_religion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string religion
		{
			get
			{
				return this._religion;
			}
			set
			{
				if ((this._religion != value))
				{
					this.OnreligionChanging(value);
					this.SendPropertyChanging();
					this._religion = value;
					this.SendPropertyChanged("religion");
					this.OnreligionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catagory", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string catagory
		{
			get
			{
				return this._catagory;
			}
			set
			{
				if ((this._catagory != value))
				{
					this.OncatagoryChanging(value);
					this.SendPropertyChanging();
					this._catagory = value;
					this.SendPropertyChanged("catagory");
					this.OncatagoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Int NOT NULL")]
		public int salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string mobile
		{
			get
			{
				return this._mobile;
			}
			set
			{
				if ((this._mobile != value))
				{
					this.OnmobileChanging(value);
					this.SendPropertyChanging();
					this._mobile = value;
					this.SendPropertyChanged("mobile");
					this.OnmobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ssc", DbType="Float NOT NULL")]
		public double ssc
		{
			get
			{
				return this._ssc;
			}
			set
			{
				if ((this._ssc != value))
				{
					this.OnsscChanging(value);
					this.SendPropertyChanging();
					this._ssc = value;
					this.SendPropertyChanged("ssc");
					this.OnsscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hsc", DbType="Float NOT NULL")]
		public double hsc
		{
			get
			{
				return this._hsc;
			}
			set
			{
				if ((this._hsc != value))
				{
					this.OnhscChanging(value);
					this.SendPropertyChanging();
					this._hsc = value;
					this.SendPropertyChanged("hsc");
					this.OnhscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_undergraduate", DbType="Float NOT NULL")]
		public double undergraduate
		{
			get
			{
				return this._undergraduate;
			}
			set
			{
				if ((this._undergraduate != value))
				{
					this.OnundergraduateChanging(value);
					this.SendPropertyChanging();
					this._undergraduate = value;
					this.SendPropertyChanged("undergraduate");
					this.OnundergraduateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_graduate", DbType="Float NOT NULL")]
		public double graduate
		{
			get
			{
				return this._graduate;
			}
			set
			{
				if ((this._graduate != value))
				{
					this.OngraduateChanging(value);
					this.SendPropertyChanging();
					this._graduate = value;
					this.SendPropertyChanged("graduate");
					this.OngraduateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stid", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string stid
		{
			get
			{
				return this._stid;
			}
			set
			{
				if ((this._stid != value))
				{
					this.OnstidChanging(value);
					this.SendPropertyChanging();
					this._stid = value;
					this.SendPropertyChanged("stid");
					this.OnstidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="Image", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this.OnimageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("image");
					this.OnimageChanged();
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
}
#pragma warning restore 1591

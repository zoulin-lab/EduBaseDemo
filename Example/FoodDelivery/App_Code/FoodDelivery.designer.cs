﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FoodDelivery")]
public partial class FoodDeliveryDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  #endregion
	
	public FoodDeliveryDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FoodDeliveryConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public FoodDeliveryDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FoodDeliveryDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FoodDeliveryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FoodDeliveryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<User> User
	{
		get
		{
			return this.GetTable<User>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _UserNo;
	
	private string _Password;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNoChanging(string value);
    partial void OnUserNoChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
	
	public User()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNo", DbType="VarChar(11) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string UserNo
	{
		get
		{
			return this._UserNo;
		}
		set
		{
			if ((this._UserNo != value))
			{
				this.OnUserNoChanging(value);
				this.SendPropertyChanging();
				this._UserNo = value;
				this.SendPropertyChanged("UserNo");
				this.OnUserNoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
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
#pragma warning restore 1591

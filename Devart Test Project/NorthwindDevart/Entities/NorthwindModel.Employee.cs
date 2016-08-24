﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 09.09.2014 11:43:17
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace NorthwindDevart
{

    /// <summary>
    /// There are no comments for NorthwindDevart.Employee, NorthwindDevart in the schema.
    /// </summary>
    public partial class Employee {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for Employee constructor in the schema.
        /// </summary>
        public Employee()
        {
            this.Employees_ReportsTo = new HashSet<Employee>();
            this.EmployeeTerritories = new HashSet<EmployeeTerritory>();
            this.Orders = new HashSet<Order>();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for EmployeeID in the schema.
        /// </summary>
        public virtual int EmployeeID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for LastName in the schema.
        /// </summary>
        public virtual string LastName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for FirstName in the schema.
        /// </summary>
        public virtual string FirstName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Title in the schema.
        /// </summary>
        public virtual string Title
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for TitleOfCourtesy in the schema.
        /// </summary>
        public virtual string TitleOfCourtesy
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for BirthDate in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> BirthDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for HireDate in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> HireDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Address in the schema.
        /// </summary>
        public virtual string Address
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for City in the schema.
        /// </summary>
        public virtual string City
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Region in the schema.
        /// </summary>
        public virtual string Region
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for PostalCode in the schema.
        /// </summary>
        public virtual string PostalCode
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Country in the schema.
        /// </summary>
        public virtual string Country
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for HomePhone in the schema.
        /// </summary>
        public virtual string HomePhone
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Extension in the schema.
        /// </summary>
        public virtual string Extension
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Photo in the schema.
        /// </summary>
        public virtual byte[] Photo
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        public virtual string Notes
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for PhotoPath in the schema.
        /// </summary>
        public virtual string PhotoPath
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Employees_ReportsTo in the schema.
        /// </summary>
        public virtual ISet<Employee> Employees_ReportsTo
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Employee_ReportsTo in the schema.
        /// </summary>
        public virtual Employee Employee_ReportsTo
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for EmployeeTerritories in the schema.
        /// </summary>
        public virtual ISet<EmployeeTerritory> EmployeeTerritories
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        public virtual ISet<Order> Orders
        {
            get;
            set;
        }
    }

}

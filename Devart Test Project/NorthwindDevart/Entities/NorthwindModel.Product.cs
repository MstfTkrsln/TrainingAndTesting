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
    /// There are no comments for NorthwindDevart.Product, NorthwindDevart in the schema.
    /// </summary>
    public partial class Product {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for Product constructor in the schema.
        /// </summary>
        public Product()
        {
            this.UnitPrice = 0m;
            this.UnitsInStock = 0;
            this.UnitsOnOrder = 0;
            this.ReorderLevel = 0;
            this.Discontinued = false;
            this.OrderDetails = new HashSet<OrderDetail>();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for ProductID in the schema.
        /// </summary>
        public virtual int ProductID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for ProductName in the schema.
        /// </summary>
        public virtual string ProductName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SupplierID in the schema.
        /// </summary>
        public virtual System.Nullable<int> SupplierID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for QuantityPerUnit in the schema.
        /// </summary>
        public virtual string QuantityPerUnit
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for UnitPrice in the schema.
        /// </summary>
        public virtual System.Nullable<decimal> UnitPrice
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for UnitsInStock in the schema.
        /// </summary>
        public virtual System.Nullable<short> UnitsInStock
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for UnitsOnOrder in the schema.
        /// </summary>
        public virtual System.Nullable<short> UnitsOnOrder
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for ReorderLevel in the schema.
        /// </summary>
        public virtual System.Nullable<short> ReorderLevel
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Discontinued in the schema.
        /// </summary>
        public virtual bool Discontinued
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        public virtual Category Category
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for OrderDetails in the schema.
        /// </summary>
        public virtual ISet<OrderDetail> OrderDetails
        {
            get;
            set;
        }
    }

}

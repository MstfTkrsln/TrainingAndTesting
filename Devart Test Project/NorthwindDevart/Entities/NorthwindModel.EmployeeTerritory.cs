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
    /// There are no comments for NorthwindDevart.EmployeeTerritory, NorthwindDevart in the schema.
    /// </summary>
    public partial class EmployeeTerritory {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          EmployeeTerritory toCompare = obj as EmployeeTerritory;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.EmployeeID, toCompare.EmployeeID))
            return false;
          if (!Object.Equals(this.TerritoryID, toCompare.TerritoryID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + EmployeeID.GetHashCode();
          hashCode = (hashCode * 7) + TerritoryID.GetHashCode();
          return hashCode;
        }
        
        #endregion
        /// <summary>
        /// There are no comments for EmployeeTerritory constructor in the schema.
        /// </summary>
        public EmployeeTerritory()
        {
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
        /// There are no comments for TerritoryID in the schema.
        /// </summary>
        public virtual string TerritoryID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Employee in the schema.
        /// </summary>
        public virtual Employee Employee
        {
            get;
            set;
        }
    }

}

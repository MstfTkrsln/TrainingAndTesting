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
    /// There are no comments for NorthwindDevart.Region, NorthwindDevart in the schema.
    /// </summary>
    public partial class Region {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for Region constructor in the schema.
        /// </summary>
        public Region()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for RegionID in the schema.
        /// </summary>
        public virtual int RegionID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for RegionDescription in the schema.
        /// </summary>
        public virtual string RegionDescription
        {
            get;
            set;
        }
    }

}
﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated from the Dalyan T4 template.
// Do not change
//
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dalyan.Entities.Models
{

    using System;
    using System.Collections.Generic;

    public partial class LogLogin
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public string LoginLogType { get; set; }
        public string ExceptionString { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

        public virtual User User { get; set; }
    }
}

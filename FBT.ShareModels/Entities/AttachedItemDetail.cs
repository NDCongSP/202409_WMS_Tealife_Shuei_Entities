﻿using FBT.ShareModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBT.ShareModels.Entities
{
    public class AttachedItemDetail : AuditEntityBase, IDataKeyFilter
    {
        public int Id { get; set; }
        public int AttachedItemId { get; set; } 
        public string ProductCode { get; set; }
        public string DataKey { get; set; }
        public int CompanyId { get; set; }
        // Navigation property to access the parent AttachedItem
        public virtual AttachedItem AttachedItem { get; set; }
    }
}

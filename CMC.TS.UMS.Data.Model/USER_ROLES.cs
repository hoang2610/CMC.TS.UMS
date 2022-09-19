using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMC.TS.UMS.Data.Model
{
    public class USER_ROLES
    {
        public uint ID { get; set; }
        public uint USER_ID { get; set; }
        public uint ROLE_ID { get; set; }
        public uint DEPARTMENT_ID { get; set; }
        public int IS_DEFAULT { get; set; }
        public int SEQ_NO { get; set; }
        public int IS_ACTIVE { get; set; }
        [StringLength(100)]
        public string ORG_CODE { get; set; }
        [StringLength(100)]
        public string ORG_PATH { get; set; }
        public DateTime CREATED { get; set; }
        [StringLength(100)]
        public string CREATED_BY { get; set; }
        [StringLength(100)]
        public string CREATED_BY_NAME { get; set; }
        public DateTime MODIFIED { get; set; }
        [StringLength(100)]
        public string MODIFIED_BY { get; set; }
        [StringLength(100)]
        public string MODIFIED_BY_NAME { get; set; }
        public virtual ROLES ROLEs { get; set; }
        public virtual USERS USERs { get; set; }
        public virtual ORGANIZATIONS ORGANIZATIONs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMC.TS.UMS.Data.Model
{
    public class ROLES
    {
        public ROLES()
        {
            USER_ROLEs = new HashSet<USER_ROLES>();
        }
        public uint ID { get; set; }
        [StringLength(100)]
        public string CREATE_BY { get; set; }
        [StringLength(100)]
        public string CREATE_BY_NAME { get; set; }
        public DateTime CREATED { get; set; }
        [StringLength(100)]
        public string MODIFIED_BY { get; set; }
        [StringLength(100)]
        public string MODIFIED_BY_NAME { get; set; }
        public DateTime MODIFIED { get; set; }
        [StringLength(100)]
        public string CODE { get; set; }
        [StringLength(100)]
        public string NAME { get; set; }
        [StringLength(500)]
        public string DESCRIPTION { get; set; }
        public int STATUS { get; set; }
        public int SEQ_NO { get; set; }
        public int IS_SYSTEM { get; set; }
        [StringLength(100)]
        public string SIGN_METHODS { get; set; }
        [StringLength(100)]
        public string ORG_CODE { get; set; }
        [StringLength(100)]
        public string ORG_PATH { get; set; }
        [StringLength(100)]
        public string TYPE { get; set; }
        public string ROLE_TYPE_ID { get; set; }
        public virtual ICollection<USER_ROLES> USER_ROLEs { get; set; }
    }
}

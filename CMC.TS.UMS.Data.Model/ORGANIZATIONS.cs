using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMC.TS.UMS.Data.Model
{
    public class ORGANIZATIONS
    {
        public ORGANIZATIONS()
        {
            USER_ROLEs = new HashSet<USER_ROLES>();
        }
        public uint ID { get; set; }
        public int TYPE { get; set; }
        public int PARENT_ID { get; set; }
        [StringLength(100)]
        public string PATH { get; set; }
        [StringLength(100)]
        public string CODE { get; set; }
        [StringLength(100)]
        public string E_CODE { get; set; }
        [StringLength(100)]
        public string NAME { get; set; }
        [StringLength(100)]
        public string INTERNATIONAL_NAME { get; set; }
        [StringLength(200)]
        public string DESCRIPTION { get; set; }
        public int EDOC { get; set; }
        [StringLength(100)]
        public string AREA_CODE { get; set; }
        [StringLength(100)]
        public string TAX_CODE { get; set; }
        public int STATUS { get; set; }
        [StringLength(200)]
        public string ADDRESS { get; set; }
        [StringLength(20)]
        public string PHONE { get; set; }
        [StringLength(50)]
        public string EMAIL { get; set; }
        [StringLength(100)]
        public string FAX { get; set; }
        [StringLength(100)]
        public string WEBSITE { get; set; }
        public byte STAMP { get; set; }
        public byte LOGO { get; set; }
        public int SEQ_NO { get; set; }
        public int ADMINISTRATOR { get; set; }
        public int MEMBERS { get; set; }
        public int MANAGERS { get; set; }
        public int ASSISTANCE { get; set; }
        [StringLength(100)]
        public string INPUT_CODE { get; set; }
        [StringLength(100)]
        public string ORG_CODE { get; set; }
        [StringLength(100)]
        public string ORG_PATH { get; set; }
        public int IS_LEGAL { get; set; }
        public int PRIVATE_REGISTER { get; set; }
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
        public DateTime END_DATE { get; set; }
        public DateTime START_DATE { get; set; }
        public int STAMP_HEIGHT { get; set; }
        public int STAMP_WIDTH { get; set; }
        [StringLength(100)]
        public string BIZ_CODE { get; set; }
        public ICollection<USER_ROLES> USER_ROLEs { get; set; }
    }
}

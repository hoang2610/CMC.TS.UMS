using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CMC.TS.UMS.Biz.Model.User
{
    public class Edit
    {
        public uint ID { get; set; }
        [StringLength(50)]
        public string LOGIN_NAME { get; set; }
        public string PASSWORD { get; set; }
        [StringLength(200)]
        public string FULL_NAME { get; set; }
        public DateTime BIRTH_OF_DATE { get; set; }
        public byte AVATAR { get; set; }
        public int STATUS { get; set; }
        [StringLength(200)]
        public string EMAIL { get; set; }
        [StringLength(13)]
        public string PHONE { get; set; }
        public int SEQ_NO { get; set; }
        public int MANAGER { get; set; }
        public int IS_ADMIN { get; set; }
        public int IS_SYSTEM { get; set; }
        public int IS_LOCKED { get; set; }
        public int IS_MOBILE { get; set; }
        public DateTime OFF_DATE { get; set; }
        public int PROVIDER_TYPE { get; set; }
        [StringLength(200)]
        public string PROVIDER_CODE { get; set; }
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
        [StringLength(50)]
        public string MODIFIED_BY { get; set; }
        [StringLength(100)]
        public string MODIFIED_BY_NAME { get; set; }
        [StringLength(100)]
        public string JOB_TITLE { get; set; }
        public int FAILED_LOGIN_COUNT { get; set; }
        public DateTime LAST_FAILED_LOGIN { get; set; }
        [StringLength(100)]
        public string LAST_FAILED_LOGIN_MSG { get; set; }
        public DateTime LAST_PWD_CHANGED { get; set; }
        public int IS_NOTI { get; set; }

    }
}

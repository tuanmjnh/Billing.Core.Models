namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("NET")]
    public partial class NET {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }

        [StringLength(256)]
        public string CALLING { get; set; }

        [StringLength(512)]
        public string TBTEN { get; set; }

        [StringLength(1024)]
        public string DIACHI { get; set; }

        [StringLength(128)]
        public string TEL { get; set; }

        [StringLength(128)]
        public string CITY { get; set; }

        [StringLength(256)]
        public string TOC_DO { get; set; }

        [StringLength(128)]
        public string TBTHG { get; set; }

        [StringLength(128)]
        public string MKH { get; set; }

        [StringLength(128)]
        public string CODE { get; set; }

        [StringLength(128)]
        public string TD_CHUAN { get; set; }

        [StringLength(128)]
        public string TBLOAI { get; set; }
        public bool TB_KHOAN { get; set; }
        public bool TB_NGAY { get; set; }
        public int DURATION { get; set; }
        public int CUOC_TB { get; set; }
        public int CUOC_SD { get; set; }
        public int CUOC_SDKH { get; set; }
        public int CUOC_KH { get; set; }
        public int CUOC_IP { get; set; }
        public int CUOC_EMAIL { get; set; }

        [StringLength(256)]
        public string BYTE_IN { get; set; }

        [StringLength(256)]
        public string BYTE_OUT { get; set; }
        public int TRUY_THU { get; set; }
        public int GIAM_TRU { get; set; }
        public int LUU_LUONG { get; set; }
        public int TIEN { get; set; }
        public int VAT { get; set; }
        public int TIEN_GT { get; set; }
        public int TYLE_GT { get; set; }
        public int GIAM_CUOC { get; set; }
        public int SO_IP { get; set; }
        public int DIEU_CHINH { get; set; }
        public int CUOCKM { get; set; }
        public int TG_GT { get; set; }
        public int CUOC_TBGOC { get; set; }
        public int CUOC_MBGOC { get; set; }
        public int CUOC_TGGOC { get; set; }
        public int CUOC_KHGOC { get; set; }
        public int MIEN_IP { get; set; }
        public int SL_EMAIL { get; set; }
        public int DG_EMAIL { get; set; }
        public int TG_GTEMAIL { get; set; }
        public int TG_GTIP { get; set; }
        public int PLAN { get; set; }
        public int MBMPHI { get; set; }
        public int CUOCMPHI { get; set; }
        public int TIENGIAM { get; set; }
        public int TL_GTEMAIL { get; set; }
        public DateTime? NG_GTEMAIL { get; set; }
        public int TL_GTIP { get; set; }
        public DateTime? NG_GTIP { get; set; }
        public DateTime? NGAY_KT { get; set; }

        [StringLength(128)]
        public string GIO_KT { get; set; }
        public DateTime? NGAY_SD { get; set; }

        [StringLength(128)]
        public string GIO_SD { get; set; }
        public DateTime? NGAY_MO { get; set; }

        [StringLength(128)]
        public string GIO_MO { get; set; }
        public DateTime? NGAY_KHOA { get; set; }

        [StringLength(128)]
        public string GIO_KHOA { get; set; }
        public DateTime? NGAY_TBL { get; set; }
        public DateTime? NGAY_GT { get; set; }
    }
}
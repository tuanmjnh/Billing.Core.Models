namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("MEGA")]
    public partial class MEGA {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }

        [StringLength(256)]
        public string CALLING { get; set; }

        [StringLength(512)]
        public string TOC_DO { get; set; }

        [StringLength(256)]
        public string TBLOAI { get; set; }
        public int DURATION { get; set; }
        public int CUOC_TB { get; set; }
        public int CUOC_SD { get; set; }
        public int CUOC_SDKH { get; set; }
        public int CUOC_BD { get; set; }
        public int CUOC_KHOAN { get; set; }
        public int CUOC_IP { get; set; }

        [StringLength(512)]
        public string BYTE_IN { get; set; }

        [StringLength(512)]
        public string BYTE_OUT { get; set; }
        public int TRUY_THU { get; set; }
        public int GIAM_TRU { get; set; }

        [StringLength(128)]
        public string TBTHG { get; set; }

        [StringLength(256)]
        public string LUU_LUONG { get; set; }
        public decimal TIEN { get; set; }
        public decimal VAT { get; set; }
        public DateTime? NGAY_KT { get; set; }

        [StringLength(128)]
        public string GIO_KT { get; set; }
        public DateTime? NGAY_SD { get; set; }

        [StringLength(128)]
        public string GIO_SD { get; set; }
        public bool DAI_DIEN { get; set; }
        public DateTime? NGAY_MO { get; set; }

        [StringLength(128)]
        public string GIO_MO { get; set; }
        public DateTime? NGAY_KHOA { get; set; }

        [StringLength(128)]
        public string GIO_KHOA { get; set; }
        public decimal GIAM_CUOC { get; set; }
        public bool TB_KHOAN { get; set; }
        public bool TB_NGAY { get; set; }
        public int SO_IP { get; set; }
        public int CUS_TYPE { get; set; }
        public bool PUB { get; set; }
        public bool DL_BD { get; set; }
        public bool KCX { get; set; }
        public bool LSQ { get; set; }
        public int DIEU_CHINH { get; set; }

        [StringLength(128)]
        public string MKH { get; set; }
        public decimal ACCT_ID { get; set; }

        [StringLength(128)]
        public string CODE { get; set; }
        public decimal CUOCKM { get; set; }
        public DateTime? NGAY_TBL { get; set; }
        public int TYLEGIAM { get; set; }
        public int TIEN_GT { get; set; }
        public int PLAN { get; set; }
        public DateTime? NGAY_PLAN { get; set; }

        [StringLength(256)]
        public string KHONG_THUE { get; set; }

        [StringLength(256)]
        public string CITY { get; set; }
        public decimal CUOCTBVS { get; set; }
        public decimal CUOCKHVS { get; set; }
        public decimal CUOCTGVS { get; set; }
        public decimal TYLEGTVS { get; set; }
        public DateTime? NGAYGTVS { get; set; }
        public decimal TGGTVS { get; set; }
        public decimal MIENIPVS { get; set; }
        public decimal SLEMAILVS { get; set; }
        public decimal DGEMAILVS { get; set; }
        public decimal TLGTEMVS { get; set; }
        public DateTime? NGGTEMVS { get; set; }
        public decimal TGGTEMVS { get; set; }
        public decimal TLGTIPVS { get; set; }
        public DateTime? NGGTIPVS { get; set; }
        public decimal TGGTIPVS { get; set; }
        public decimal CUOCMBVS { get; set; }
        public decimal MBMPHIVS { get; set; }
        public decimal CUOCMPHIVS { get; set; }
        public decimal TIENGIAMVS { get; set; }
    }
}
namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("HD_TSL")]
    public partial class HD_TSL {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public Guid DBKH_ID { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }
        public int MAPHO_ID { get; set; }
        public int THANHTOAN_ID { get; set; }
        public int THUEBAO_ID { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }

        [StringLength(256)]
        public string MA_TB { get; set; }
        public int DOITUONG_ID { get; set; }

        [StringLength(512)]
        public string TOC_DO { get; set; }

        [StringLength(1024)]
        public string GHICHU { get; set; }
        public int TT_THANG { get; set; }
        public int NGAY_TB { get; set; }
        public int LOAIHINHTB_ID { get; set; }

        [StringLength(256)]
        public string MA_LHTB { get; set; }
        public int? TRANGTHAITB_ID { get; set; }
        public int? TTHD_ID { get; set; }
        public int? TBDAYCHUNG_ID { get; set; }
        public int? GOICUOCID { get; set; }
        public int? ISDATMOI { get; set; }
        public int? ISHUY { get; set; }
        public int? ISTTT { get; set; }
        public int? ISDATCOC { get; set; }
        public decimal GIAM_TRU { get; set; }
        public decimal CUOC_DATA { get; set; }
        public decimal CUOC_SD { get; set; }
        public decimal CUOC_TB { get; set; }
        public decimal TONG_TTT { get; set; }
        public decimal TONG_DC { get; set; }
        public decimal TONG_IN { get; set; }
        public decimal TONG { get; set; }
        public decimal VAT { get; set; }
        public decimal TONGCONG { get; set; }
        public DateTime? NGAY_TTTB { get; set; }
        public DateTime? NGAY_SD { get; set; }
        public DateTime? NGAY_CN { get; set; }
        public DateTime? NGAY_HT { get; set; }
        public DateTime? NGAY_CAT { get; set; }
    }
    public partial class DANH_BA_TSL : HD_TSL {
        public int KHACHHANG_ID { get; set; }

        [StringLength(256)]
        public string MA_KH { get; set; }

        [StringLength(256)]
        public string MA_TT_HNI { get; set; }

        [StringLength(512)]
        public string TEN_TT { get; set; }

        [StringLength(1024)]
        public string DIACHI_TT { get; set; }

        [StringLength(256)]
        public string DIENTHOAI { get; set; }

        [StringLength(256)]
        public string MS_THUE { get; set; }

        [StringLength(256)]
        public string BANKNUMBER { get; set; }
        public int DONVIQL_ID { get; set; }

        [StringLength(128)]
        public string MA_DVI { get; set; }

        [StringLength(128)]
        public string MA_CBT { get; set; }

        [StringLength(128)]
        public string MA_TUYEN { get; set; }

        [StringLength(512)]
        public string CUSTCATE { get; set; }

        [StringLength(256)]
        public string STK { get; set; }
        public int MA_DT { get; set; }
        public int? KHLON_ID { get; set; }
        public int? LOAIKH_ID { get; set; }
        public int TH_SD { get; set; }
        public int ISNULL { get; set; }
        public int ISNULLMT { get; set; }
        public int FIX { get; set; }
        public int FLAG { get; set; }
    }
    public partial class TTHD_TSL : HD_TSL {
        public int TTHD_ID { get; set; }
    }
}
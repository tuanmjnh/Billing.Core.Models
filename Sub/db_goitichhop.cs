namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("db_goitichhop")]
    public partial class db_goitichhop {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int id_goitichhop { get; set; }

        [StringLength(512)]
        public string tengoi { get; set; }
        public decimal tongtien { get; set; }

        public DateTime ngay_bd { get; set; }
        public DateTime ngay_kt { get; set; }

        [StringLength(256)]
        public string created_by { get; set; }
        public DateTime created_at { get; set; }

        [StringLength(256)]
        public string updated_by { get; set; }
        public DateTime updated_at { get; set; }

        [StringLength(256)]
        public string deleted_by { get; set; }
        public DateTime deleted_at { get; set; }
        public int flag { get; set; }
    }
}
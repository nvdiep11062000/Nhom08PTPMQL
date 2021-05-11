using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nhom08PTPMQL.Models
{
    [Table("DonDatHangs")]
    public class DonDatHang
    {
        [Key]
        public string TenDDH { get; set; }
        public string GiaTriDDH { get; set; }
        public string TinhTrang { get; set; }
    }
}
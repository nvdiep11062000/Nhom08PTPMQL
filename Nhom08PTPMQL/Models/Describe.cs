using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nhom08PTPMQL.Models
{
    [Table("Describes")]
    public class Describe
    {
        [Key]
        public string NameDescribe { get; set; }
        [AllowHtml]
        public string ContentDescribe { get; set; }
    }
}
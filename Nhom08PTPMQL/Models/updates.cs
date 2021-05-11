using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nhom08PTPMQL.Models
{
    [Table("updatess")]
    public class updates
    {
        [Key]
        public string MyProperty { get; set; }
    }
}
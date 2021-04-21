using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nhom08PTPMQL.Models
{
    [Table("Humans")]
    public class Human
    {
        [Key]
        public string NameHuman { get; set; }
        public string PositionHuman { get; set; }
        public int IDhuman { get; set; }
        public int PhoneNumber { get; set; }
    }
}
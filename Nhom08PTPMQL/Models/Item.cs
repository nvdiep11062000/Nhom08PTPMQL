using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nhom08PTPMQL.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public string NameItem { get; set; }
        public string IDIteam { get; set; }
        public int PriceItem { get; set; }
        public int AmountItem { get; set; }
    }
}
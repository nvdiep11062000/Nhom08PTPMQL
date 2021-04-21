using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Nhom08PTPMQL.Models
{
    [Table("Accounts")]
    public class Account
    {
    [Key]
        [Required(ErrorMessage = "Username không được để trống.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password không được để trống.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
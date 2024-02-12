using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRoles.Data.Tables
{
    [Table("users")]
    public class users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Unique]
        [Required]
        public string login { get; set; }
        [Unique]
        public string password { get; set; }
        public string email { get; set; }
        [Unique]
        public string fname { get; set; }
        public string lname { get; set; }
        [ForeignKey("roles")]
        public int? role_id { get; set; }
        public role roles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_JOIN.Models
{
    [Table("Account")]
    public partial class Account
    {
        public Account()
        {
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        
        public virtual Role Role { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan_C.Data.EF
{
    public class StaffsDao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("S_Id")]
        public int Id { get; set; }

        [Column("STR_Id")]
        public int StoreId { get; set; }

        [Column("S_Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("S_Phone")]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Column("S_Email")]
        [EmailAddress]
        [MaxLength(100)]
        public string EMAIL { get; set; }

        [Column("S_Active")]
        public string IsActive { get; set; }

    
    }
}

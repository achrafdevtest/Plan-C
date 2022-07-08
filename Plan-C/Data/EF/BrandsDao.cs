using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan_C.Data.EF
{
    public class BrandsDao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("B_Id")]
        public int Id { get; set; }

        [Required]
        [Column("B_Name")]
        public string Name { get; set; }

        [Column("B_Description")]
        public string Description { get; set; }
    }
}

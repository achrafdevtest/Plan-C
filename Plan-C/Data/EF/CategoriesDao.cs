using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan_C.Data.EF
{
    public class CategoriesDao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("C_Id")]
        public int Id { get; set; }

        [Required]
        [Column("C_Name")]
        public string Name { get; set; }

        [Column("C_Description")]
        public string Description { get; set; }

    }
}

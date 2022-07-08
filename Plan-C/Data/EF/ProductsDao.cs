using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan_C.Data.EF
{
    [Table("PRODUCTS")]
    public class ProductsDao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("P_Id")]
        public int Id { get; set; }

        [Required]
        [Column("B_Brand_Id")]
        public int BrandId { get; set; }

        [Required]
        [Column("C_Category_Id")]
        public int CategoryId { get; set; }
     
        [Column("P_Name")]
        public string Name { get; set; }

        [Column("P_Description")]
        public string Description { get; set; }

        [Column("P_Model_Years")]
        [MaxLength(4)]
        public int ModelYears { get; set; }

        [Column("P_PU")]
        [Required]
        public decimal PU { get; set; }

        [Column("P_Unite")]
        public string Unite { get; set; }

        [Column("P_Status")]
        public string IsActive { get; set; }
    }
} 

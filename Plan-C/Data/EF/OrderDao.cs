using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan_C.Data.EF
{
    [Table("ORDERS")]
    public class OrderDao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("O_Id")]
        public int Id { get; set; }

        [Required]
        [Column("C_Id")]
        public int CustomerId { get; set; }

        [Required]
        [Column("STR_Id")]
        public int StoreId { get; set; }

        [Required]
        [Column("S_Id")]
        public int StaffId { get; set; }

        [Column("O_Status")]
        public bool Status { get; set; }

        [Column("O_Date")]
        public DateTime Date { get; set; }


    }
}

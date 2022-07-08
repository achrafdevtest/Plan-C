using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan_C.Data.EF
{
    public class StocksDao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("STK_Id")]
        public int Id { get; set; }

        [Required]
        [Column("STR_Id")]
        public int StoreId { get; set; }

        [Required]
        [Column("P_Id")]
        public int ProductId { get; set; }


        [Column("STK_Quantity")]
        [MaxLength(50)]
        public Decimal Quantity { get; set; }

        [Column("STK_Disponibility")]
        public bool Disponibility { get; set; }
    }
}

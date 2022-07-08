using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan_C.Data.EF
{
    [Table("CUSTOMERS")]
    public class CustomersDao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("C_ID")]
        public int Id { get; set; }

        [Column("C_FIRST_NAME")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Column("C_LAST_NAME")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Column("C_PHONE")]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Column("C_EMAIL")]
        [EmailAddress]
        [MaxLength(100)]
        public string EMAIL { get; set; }

        [Column("C_STREET")]
        public string Street { get; set; }

        [Column("C_CITY")]
        [MaxLength(30)]
        public string City { get; set; }

        [Column("C_STATE")]
        [MaxLength(30)]
        public string State { get; set; }

        [MaxLength(10)]
        [Column("C_ZIP_CODE")]
        public string ZipCode { get; set; }



    }
}

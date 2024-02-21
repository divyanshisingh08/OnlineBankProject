using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineBankDB.Models
{
    public class ChequeBookStatus
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChqId { get; set; }

        [DisplayName("ChequeBook Status")]
        [Required(ErrorMessage = "ChequeBook Status  should not be blank")]

        public string ChequeBookAlloted { get; set; }

        public virtual ICollection<Customer> Customers{ get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineBankDB.Models
{
    public class AccountType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccTypeId { get; set; }

        [DisplayName("Account Type")]
        [Required(ErrorMessage = "Category Name should not be blank")]
       
        public string AccountTypeName { get; set; }

        public virtual ICollection<Account> Account{ get; set; }

    }
}

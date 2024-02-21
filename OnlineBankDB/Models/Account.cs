using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace OnlineBankDB.Models
{
  

    
    public class Account
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Account Number")]
        public int AccountId{ get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }



        [Required]
        [Display(Name = "Type")]
        public char AccountType { get; set; }


        [Required]
        [Display(Name = "Current Balance")]
        public decimal Balance { get; set; }

        [Required]
        [Display(Name = "Date of Opening")]
        public DateTime DateOfOpening { get; set; }


        [Required]
        [Display(Name ="Cheque Book Status")]  
        public ChequeBookStatus ChequeBookAlloted { get; set; }


        
        public virtual Customer Customer { get; set; }






        public virtual ICollection<Transaction> Transactions { get; set; }


    }
}

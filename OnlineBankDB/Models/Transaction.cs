using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBankDB.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionID { get; set; }


        
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
       
        [ForeignKey("AccountId")]
        public int AccountId { get; set; }

        [ForeignKey("BeneficiaryId")]
        public int BeneficiaryId { get; set; }

        [Display(Name = "Opening Balance")]
        public decimal OpeningBalance{ get; set; }
       
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be non-negative")]
        public decimal Amount { get; set; }

        [Display(Name = "Closing Balance")]
        public decimal ClosingBalance { get; set; }

        [Required]
        [Display(Name = "Transaction Type")]
        public TransactionType Type { get; set; }

        [MaxLength(255)]

        [Display(Name = "Description")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name = "Status")]
        public string Status { get ; set; }

        
        public virtual Beneficiary Beneficiary{ get; set; }
       
        public virtual Account Accounts { get; set; }
 
        public virtual Customer Customers{ get; set; }
    }

}

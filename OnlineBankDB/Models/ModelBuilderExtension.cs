
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace OnlineBankDB.Models
{
    public static class ModelBuilderExtensions

    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleType>().HasData(
            new RoleType() { RoleTypeId = 1, RoleTypeName = "Manager" },
            new RoleType() { RoleTypeId = 2, RoleTypeName = "Customer" }
           
            );
            modelBuilder.Entity<SecurityQuestion>().HasData(
            new SecurityQuestion() { SqId = 1, Question = "What is your mother's maiden name?" },
            new SecurityQuestion() { SqId = 2, Question = "What is the name of your first pet?" },
            new SecurityQuestion() { SqId = 3, Question = "What is your nick name?" },
            new SecurityQuestion() { SqId = 4, Question = "What elementary school did you attend?" },
            new SecurityQuestion() { SqId = 5, Question = "What is the name of the town where you were born?" }
           
            );
            modelBuilder.Entity<TransactionType>().HasData(
            new TransactionType() { TraId = 1, TransactionName = "Debit" },
            new TransactionType() { TraId = 2, TransactionName = "Credit" }
           
            

             );
            modelBuilder.Entity<Status>().HasData(
            new Status() { StatusID = 1, StatusType = "Pending" },
            new Status() { StatusID = 2, StatusType = "Approved" },
            new Status() { StatusID = 3, StatusType = "Rejected" }
            );
            modelBuilder.Entity<AccountType>().HasData(
            new AccountType() { AccTypeId = 1, AccountTypeName = "Current" },
            new AccountType() { AccTypeId = 2, AccountTypeName = "Savings" }
           
           

               );
            modelBuilder.Entity<ChequeBookStatus>().HasData(
            new ChequeBookStatus() { ChqId = 1, ChequeBookAlloted = "Requested" },
            new ChequeBookStatus() { ChqId = 2, ChequeBookAlloted = "Alloted" },
            new ChequeBookStatus() { ChqId = 3, ChequeBookAlloted = "Pending" },
            new ChequeBookStatus() { ChqId = 4, ChequeBookAlloted = "Rejected" },
            new ChequeBookStatus() { ChqId = 5, ChequeBookAlloted = "Not Requested" }
            );





        }
    }
}

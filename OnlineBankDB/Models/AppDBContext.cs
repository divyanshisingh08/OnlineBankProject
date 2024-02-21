﻿using Microsoft.EntityFrameworkCore;
using System.Data;
using System;

namespace OnlineBankDB.Models
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions options) : base(options)
        {

        }

        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions{ get; set; }
        public DbSet<ChequeBookStatus> ChequeboookStatuss{ get; set; }
        
        public DbSet<RoleType> RoleTypes{ get; set; }

        public DbSet<Status> Statuss { get; set; }
        

        


    }
}

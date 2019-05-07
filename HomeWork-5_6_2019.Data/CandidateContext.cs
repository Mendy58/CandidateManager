using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_5_6_2019.Data
{
    public class CandidateContext: DbContext
    {
        private string _connectionString;

        public CandidateContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DbSet<Candidate> Candidates { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}

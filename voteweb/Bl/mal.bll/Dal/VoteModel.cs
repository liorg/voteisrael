namespace Mal.Dal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Mal.DataModel;

    public partial class VoteModel : DbContext
    {
        public VoteModel()
            : base("name=VoteModel")
        {
        }

        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<SurveyCompany> SurveyCompany { get; set; }
        public virtual DbSet<SurveyRemark> SurveyRemark { get; set; }
        public virtual DbSet<Vote> Vote { get; set; }
        public virtual DbSet<VoteRemark> VoteRemark { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Survey>()
                .HasMany(e => e.SurveyRemark)
                .WithRequired(e => e.Survey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Survey>()
                .HasMany(e => e.Vote)
                .WithRequired(e => e.Survey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SurveyCompany>()
                .HasMany(e => e.Vote)
                .WithRequired(e => e.SurveyCompany)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vote>()
                .HasMany(e => e.VoteRemark)
                .WithRequired(e => e.Vote)
                .WillCascadeOnDelete(false);
        }
    }
}

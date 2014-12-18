namespace voteweb.Dal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VoteModel : DbContext
    {
        public VoteModel()
            : base("name=VoteModel")
        {
        }

        public virtual DbSet<PoliticalParty> PoliticalParty { get; set; }
        public virtual DbSet<SurveyCompany> SurveyCompany { get; set; }
        public virtual DbSet<Vote> Vote { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoliticalParty>()
                .HasMany(e => e.Vote)
                .WithRequired(e => e.PoliticalParty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SurveyCompany>()
                .HasMany(e => e.Vote)
                .WithRequired(e => e.SurveyCompany)
                .WillCascadeOnDelete(false);
        }
    }
}

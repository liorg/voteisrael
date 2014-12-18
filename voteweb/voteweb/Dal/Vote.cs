namespace voteweb.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kipodeal_admin.Vote")]
    public partial class Vote
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int SurveyCompanyId { get; set; }

        public int PoliticalPartyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int votes { get; set; }

        public virtual PoliticalParty PoliticalParty { get; set; }

        public virtual SurveyCompany SurveyCompany { get; set; }
    }
}

namespace Mal.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kipodeal_admin.Vote")]
    public partial class Vote
    {
        public Vote()
        {
            VoteRemark = new HashSet<VoteRemark>();
        }

        public int SurveyCompanyId { get; set; }

        public int PoliticalPartyId { get; set; }

        public int votes { get; set; }

        public Guid id { get; set; }

        public Guid SurveyId { get; set; }

        public virtual Survey Survey { get; set; }

        public virtual SurveyCompany SurveyCompany { get; set; }

        public virtual ICollection<VoteRemark> VoteRemark { get; set; }
    }
}

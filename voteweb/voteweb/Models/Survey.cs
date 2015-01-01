namespace voteweb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kipodeal_admin.Survey")]
    public partial class Survey
    {
        public Survey()
        {
            SurveyRemark = new HashSet<SurveyRemark>();
            Vote = new HashSet<Vote>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string surveyname { get; set; }

        public DateTime createdon { get; set; }

        public DateTime surveydate { get; set; }

        public virtual ICollection<SurveyRemark> SurveyRemark { get; set; }

        public virtual ICollection<Vote> Vote { get; set; }
    }
}

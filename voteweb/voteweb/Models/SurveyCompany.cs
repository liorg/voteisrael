namespace voteweb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kipodeal_admin.SurveyCompany")]
    public partial class SurveyCompany
    {
        public SurveyCompany()
        {
            Vote = new HashSet<Vote>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Vote> Vote { get; set; }
    }
}

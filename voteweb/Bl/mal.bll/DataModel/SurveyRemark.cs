namespace Mal.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kipodeal_admin.SurveyRemark")]
    public partial class SurveyRemark
    {
        public Guid id { get; set; }

        [Required]
        public string desc { get; set; }

        public Guid surveyid { get; set; }

        public virtual Survey Survey { get; set; }
    }
}

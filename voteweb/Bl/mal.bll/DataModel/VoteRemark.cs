namespace Mal.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbo.VoteRemark")]
    public partial class VoteRemark
    {
        public Guid voteremarkid { get; set; }

        [Required]
        public string desc { get; set; }

        public Guid voteid { get; set; }

        public virtual Vote Vote { get; set; }
    }
}

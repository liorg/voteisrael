namespace voteweb.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("kipodeal_admin.VoteRemark")]
    public class VoteRemark
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid voteremarkid { get; set; }

        public string desc { get; set; }


    }
}
namespace OnlineEduDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int CategoryID { get; set; }

        [StringLength(255)]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(255)]
        public string Course_ID { get; set; }

        public virtual Course Course { get; set; }
    }
}

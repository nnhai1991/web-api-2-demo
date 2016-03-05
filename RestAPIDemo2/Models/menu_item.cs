namespace RestAPIDemo2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class menu_item
    {
        [Key]
        public int menu_item_id { get; set; }

        public int menu_category_id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string url { get; set; }

        [Required]
        public string component { get; set; }

        public virtual menu_category menu_category { get; set; }
    }
}

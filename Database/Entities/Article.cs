using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table("Article")]
    public class Article : _BaseEntity
    {
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [Required]
        public string ImagePath { get; set; }

        public int OrderPriority { get; set; }

        [ForeignKey("Category_Id")]
        public virtual Category Category { get; set; }

        public virtual ICollection<ArticleAmount> Amounts { get; set; }
    }
}

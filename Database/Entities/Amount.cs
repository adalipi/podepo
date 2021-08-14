using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table("Amount")]
    public class Amount : _BaseEntity
    {

        [Required]
        public string DisplayName { get; set; }
        
        [Required]
        public int OrderValue { get; set; }

        public virtual ICollection<ArticleAmount> Articles { get; set; }

    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table("ArticleAmount")]
    public class ArticleAmount
    {
        [Required]
        public int Article_Id { get; set; }
        
        [Required]
        public int Amount_Id { get; set; }

        public virtual Article Article { get; set; }

        public virtual Amount Amount { get; set; }

    }
}

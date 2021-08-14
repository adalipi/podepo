using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.Entities
{
    [Table("Table")]
    public class Table : _BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

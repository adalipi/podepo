using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Database.Entities
{
    [Table("Order")]
    public class Order : _BaseEntity
    {
        [Required]
        public DateTime DateTime { get; set; }
        public bool Payment { get; set; }
        public bool Served { get; set; }

        [Required]
        [ForeignKey("Table_Id")]
        public virtual Table Table { get; set; }

        [Required]
        public string User_Id { get; set; }
    }
}

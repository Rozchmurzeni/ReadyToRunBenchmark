using System;
using System.ComponentModel.DataAnnotations;

namespace Dependencies.Database.Entities
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string Text { get; set; }
    }
}

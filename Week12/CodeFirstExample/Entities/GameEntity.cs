using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstExample.Entities
{
    [Table("Games")]
    public class GameEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }

        [Column("Rating", TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }
    }
}

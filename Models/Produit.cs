using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projet.Models
{
    [Table("produit")]
    public class Produit

    {
        [Key]
        [Column("id_prod")]
        public int Id { get; set; }

        public string nom_produit { get; set; }
        public string description { get; set; }
        public decimal prix { get; set; }
        public int stock { get; set; }
        public int id_cat { get; set; }
        public string photo { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;

[Table("ReceitaIngrediente")]
    public class ReceitaIngrediente
    {
        [Key, Column(Order = 1)]
        public int ReceitaId { get; set; }

        [Key, Column(Order = 2)]

        public int IngredienteId { get; set; }
        [ForeignKey("IngredienteId")]
        public Ingrediente Ingrediente { get; set; }

        [Required]
        [StringLength(30)]
        public string Quantidade { get; set; }
    }

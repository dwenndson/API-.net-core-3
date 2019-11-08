using System.ComponentModel.DataAnnotations;

namespace Onyst.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage="Necessário telefone valido com DDD")]
        [StringLength(11,MinimumLength= 11)]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?[\s9]?\d{4}-?\d{4}$")]
        public int Telefone { get; set; }
        [RegularExpression(@"^(RUA|Rua|R.|AVENIDA|Avenida|AV.|TRAVESSA|Travessa|TRAV.|Trav.) ([a-zA-Z_\s]+)[, ]+(\d+)\s?([-/\da-zDA-Z\\ ]+)?$")]
        public string Longadura { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace CatalogoLivros.Models{

    public class Livro
    {
        [Key]
        public int  Id { get; set; }

        [Required]
        public string Título { get; set; }

        [Required]
        public string Autor { get; set; }

        public string Categoria { get; set; }
        
        public string ISBN { get; set; }

        public int AnoPublicacao { get; set; }


    }
}
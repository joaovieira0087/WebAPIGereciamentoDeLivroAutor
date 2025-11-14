using System.Text.Json.Serialization;

namespace WebAPIGereciamentoDeLivroAutor.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore]
        public ICollection<LivroModel> Livros { get; set; }
    }
}
//UM LIVRO PODE TER APENAS UM AUTOR, MAS UM AUTOR PODE TER VÁRIOS LIVROS.
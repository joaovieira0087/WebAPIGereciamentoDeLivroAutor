using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.services.Livro
{
    public interface ILivroService
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();

    }
}

using WebAPIGereciamentoDeLivroAutor.Dto.Autor;
using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.services.Autor
{
    public interface IAutorInterface // define os contratos que o serviço de Autor deve implementar
    {
        // Task é usado para operações assíncronas, ResponseModel encapsula a resposta com dados, mensagem e status
        Task<ResponseModel<List<AutorModel>>> ListarAutorores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idlivro);
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<List<AutorModel>>> AdicionarAutor(AutorCriacaoDto autorCriacaoDto);


        Task<ResponseModel<List<AutorModel>>> EditarAutor(AutorEdicaoDto autorEdicaoDto);
        Task<ResponseModel<List<AutorModel>>> ExcluirAutor(int idAutor);
    }
}

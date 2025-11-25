using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.services.Autor
{
    public interface IAutorInterface // define os contratos que o serviço de Autor deve implementar
    {
        // Task é usado para operações assíncronas, ResponseModel encapsula a resposta com dados, mensagem e status
        Task<ResponseModel<List<AutorModel>>> ListarAutorores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int id);
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idlivro);
    }
}

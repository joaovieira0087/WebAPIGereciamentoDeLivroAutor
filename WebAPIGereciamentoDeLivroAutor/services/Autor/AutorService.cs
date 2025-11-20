using Microsoft.EntityFrameworkCore;
using System.Resources;
using WebAPIGereciamentoDeLivroAutor.Data;
using WebAPIGereciamentoDeLivroAutor.Models;

namespace WebAPIGereciamentoDeLivroAutor.services.Autor
{
    public class AutorService : IAutorInterface // respeita a IAutorInterface, todas as regras definidas nela devem ser implementadas aqui
    {
        private readonly AppDbContext _context; // campo privado somente leitura para o contexto do banco de dados 
                                                // usado para interagir com o banco de dados                                    
                                                // AppDbContext é a classe que gerencia a conexão com o banco de dados e as operações CRUD
        public AutorService(AppDbContext context) // injeção de dependência do contexto do banco de dados 
                                                // padrão para serviços no ASP.NET Core 
                                                // permite o acesso ao banco de dados 
                                                // AppDbContext é a classe que gerencia a conexão com o banco de dados e as operações CRUD 
                                                // context é a instância do contexto injetada pelo framework 
                                                // usada para interagir com o banco de dados 
                                                // permite realizar operações como consultas e atualizações
        {
           _context = context;
        }


        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idlivro)
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            return null;
        }

        public async Task<ResponseModel<List<AutorModel>>> ListarAutorores()
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>(); // cria uma nova instância de ResponseModel para encapsular a resposta
            try // bloco try-catch para tratamento de exceções
            {
                var autores = await _context.Autores.ToListAsync(); // obtém a lista de autores do banco de dados usando o contexto
                resposta.Dados = autores; // atribui a lista de autores aos dados da resposta

                resposta.Mensagem = "Autores listados com sucesso."; // define a mensagem de sucesso na resposta
                return resposta; // retorna a resposta com os dados
            }
            catch (Exception ex) // captura qualquer exceção que ocorra no bloco try // ex é a variável que contém a exceção capturada
            {
                resposta.Mensagem = $"Erro ao listar autores: {ex.Message}"; // define a mensagem de erro na resposta
                resposta.Status = false; // define o status como falso indicando falha
                return resposta; // retorna a resposta com o erro
            }
        }

        public Task<ResponseModel<AutorModel>> ObterAutorPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

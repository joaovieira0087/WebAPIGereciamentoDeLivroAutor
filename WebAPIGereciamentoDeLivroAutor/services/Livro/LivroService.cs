using Microsoft.EntityFrameworkCore;
using System.Resources;
using WebAPIGereciamentoDeLivroAutor.Data;
using WebAPIGereciamentoDeLivroAutor.Dto.Autor;
using WebAPIGereciamentoDeLivroAutor.Dto.Livro;
using WebAPIGereciamentoDeLivroAutor.Models;


namespace WebAPIGereciamentoDeLivroAutor.services.Livro
{
    public class LivroService : ILivroService
    {
        private readonly AppDbContext _context;

        public LivroService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<LivroModel>>> AdiconarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            ResponseModel<List<LivroModel>> resposta = new ResponseModel<List<LivroModel>>();

            try
            {
                var livro = new LivroModel()
                {
                    Titulo = livroCriacaoDto.Titulo,
                    Id = livroCriacaoDto.Id
                };

                _context.Add(livro);
                await _context.SaveChangesAsync();

                resposta.Dados = await _context.Livros.ToListAsync();
                resposta.Mensagem = "Livro adicionado com sucesso";

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Mensagem = "erro ao listar livros";
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idlivro)
        {
            ResponseModel<List<LivroModel>> resposta = new ResponseModel<List<LivroModel>>();

            try
            {
                var livro = _context.Livros.FirstOrDefault(x => x.Id == idlivro);

                if (livro == null)
                {
                    resposta.Mensagem = "Livro não encontrado";
                    resposta.Status = false;
                    return resposta;
                }

                _context.RemoveRange(livro);
                await _context.SaveChangesAsync();

                resposta.Dados = await _context.Livros.ToListAsync();
                resposta.Mensagem = "Autor excluído com sucesso.";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Mensagem = "erro ao listar livros";
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<List<LivroModel>>> ListarLivros()
        {
            ResponseModel<List<LivroModel>> resposta = new ResponseModel<List<LivroModel>>();

            try
            {
                var livro = await _context.Livros.ToListAsync();
                resposta.Dados = livro;

                if (livro == null || livro.Count == 0)
                {
                    resposta.Mensagem = "Nenhum livro encontrado";
                    resposta.Status = false;
                    return resposta;
                }

                resposta.Mensagem = "Livros listados com sucesso";
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Mensagem = "erro ao listar livros";
                resposta.Status = false;
                return resposta;
            }
        }

        
    }
}

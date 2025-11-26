using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIGereciamentoDeLivroAutor.Dto.Livro;
using WebAPIGereciamentoDeLivroAutor.Models;
using WebAPIGereciamentoDeLivroAutor.services.Autor;
using WebAPIGereciamentoDeLivroAutor.services.Livro;

namespace WebAPIGereciamentoDeLivroAutor.Controllerss
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _LivroInterface;

        public LivroController(ILivroService livroInterface)
        {
            _LivroInterface = livroInterface;
        }


        [HttpGet("ListaLivros")]

        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarLivros()
        {
            var livros = await _LivroInterface.ListarLivros();
            return Ok(livros);
        }

        [HttpGet("BuscarLivroPorId")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarLivroPorId(int livroId)
        {
            var BuscarLivroPorId = await _LivroInterface.BuscarLivroPorId(livroId);
            return Ok(BuscarLivroPorId);
        }

        [HttpGet("BuscarLivroPorIdAutor")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarLivroPorIdAutor(int livroId)
        {
            var BuscarLivroPorIdAutor = await _LivroInterface.BuscarLivroPorIdAutor(livroId);
            return Ok(BuscarLivroPorIdAutor);
        }

        [HttpPost("AdicionarLivro")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> AdiconarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livroCriar = await _LivroInterface.AdiconarLivro(livroCriacaoDto);
            return Ok(livroCriar);
        }

        [HttpPut("EditarLivro")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> EditarLivro(LivroEdicaoDto livroEdicaoDto)
        {
            var EditarLivro = await _LivroInterface.EditarLivro(livroEdicaoDto);
            return Ok(EditarLivro);
        }

        [HttpDelete("ExcluirLivro")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ExcluirLivro(int idlivro)
        {
            var ExcluirLivro = await _LivroInterface.ExcluirLivro(idlivro);
            return Ok(ExcluirLivro);
        }
    }
}
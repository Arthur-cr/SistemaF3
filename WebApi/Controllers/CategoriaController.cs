using Domain.Interfaces.ICategoria;
using Domain.Interfaces.InterfaceServicos;
using Entities.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly InterfaceCategoria _InterfaceCategoria;
        private readonly ICategoriaServico _ICategoriaServico;

        public CategoriaController(InterfaceCategoria InterfaceCategoria,
            ICategoriaServico ICategoriaServico)
        {
            _InterfaceCategoria = InterfaceCategoria;
            _ICategoriaServico = ICategoriaServico;
        }


        [HttpGet("/api/ListarCategoriasUsuario")]
        [Produces("application/json")]
        public async Task<object> ListarCategoriasUsuario(string emailUsuario)
        {
            return _InterfaceCategoria.ListarCategoriasUsuario(emailUsuario);
        }


        [HttpPost("/api/AdicionarCategoria")]
        [Produces("application/json")]
        public async Task<object> AdicionarCategoria(Categoria catagoria)
        {
            await _ICategoriaServico.AdicionarCategoria(catagoria);

            return catagoria;
        }


        [HttpPut("/api/AtualizarCategoria")]
        [Produces("application/json")]
        public async Task<object> AtualizarCategoria(Categoria catagoria)
        {
            await _ICategoriaServico.AtualizarCategoria(catagoria);

            return catagoria;
        }


        [HttpGet("/api/ObterCategoria")]
        [Produces("application/json")]
        public async Task<object> ObterCategoria(int id)
        {
            return await _InterfaceCategoria.GetEntityById(id);
        }


        [HttpDelete("/api/DeleteCategoria")]
        [Produces("application/json")]
        public async Task<object> DeleteCategoria(int id)
        {
            try
            {
                var categoria = await _InterfaceCategoria.GetEntityById(id);
                await _InterfaceCategoria.Delete(categoria);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}

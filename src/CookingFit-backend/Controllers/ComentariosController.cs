using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookingFit_backend.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly AppDbContext _context;

        public ComentariosController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Comentarios
        [HttpPost]
        public async Task<IActionResult> PostComentario(PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Criar um novo objeto de Comentario com os dados do PostModel
                    var comentario = new Comentario
                    {
                        Nota = postModel.nota,
                        IdReceita = postModel.IdReceita,
                        Texto = postModel.comentario
                    };

                    // Adicionar o comentário ao contexto e salvar as mudanças no banco de dados
                    _context.Comentarios.Add(comentario);
                    await _context.SaveChangesAsync();

                    // Retornar sucesso
                    return Ok(comentario);
                }
                catch (Exception ex)
                {
                    // Lidar com erros, se necessário
                    return BadRequest("Ocorreu um erro ao adicionar o comentário: " + ex.Message);
                }
            }

            // Se o modelo não for válido, retornar erro de modelo inválido
            return BadRequest(ModelState);
        }
    }
}

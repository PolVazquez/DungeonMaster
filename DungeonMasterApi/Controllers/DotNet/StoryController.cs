using Microsoft.AspNetCore.Mvc;

namespace DungeonMasterApi.Controllers.DotNet
{
    [ApiController] // Asegúrate de que el controlador sea reconocido como una API
    [Route("api/[controller]")] // Ruta base para este controlador
    public class StoryController : ControllerBase
    {
        // Endpoint para generar historia
        [HttpGet("generate")]
        public async Task<IActionResult> GenerateHistory()
        {
            // Lógica para generar la historia usando la IA
            return Ok("Historia generada");  // Retorna el texto generado
        }
    }
}
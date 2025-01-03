using Microsoft.AspNetCore.Mvc;

namespace DungeonMasterApi.Controllers.DotNet
{
    [ApiController] // Asegúrate de que el controlador sea reconocido como una API
    [Route("api/[controller]")] // Ruta base para este controlador
    public class StoryController : ControllerBase
    {
        // Endpoint para generar historia
        [HttpGet("generate")]
        public async Task<string> GenerateHistory()
        {
            // Lógica de generación de historia (esto puede ser más complejo en tu caso)
            return "Historia generada correctamente";
        }
    }
}

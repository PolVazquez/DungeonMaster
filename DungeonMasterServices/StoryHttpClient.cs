using System.Net.Http;
using System.Net.Http.Json;

namespace DungeonMasterServices
{
    public interface IStoryService
    {
        Task<string> GetStory();
    }

    public sealed class StoryHttpClient(HttpClient http) : IStoryService
    {
        private readonly HttpClient _http = http ?? throw new ArgumentNullException(nameof(http));

        // Método que hace una solicitud GET a la API para obtener la historia
        public async Task<string> GetStory()
        {
            try
            {
                var response = await _http.GetAsync("api/Story/generate");

                if (response.IsSuccessStatusCode)
                {
                    // Lee el contenido de la respuesta como string
                    return await response.Content.ReadAsStringAsync();
                }

                // Manejo de códigos de error HTTP
                return $"Error: Código de estado {response.StatusCode}";
            }
            catch (HttpRequestException ex)
            {
                // Manejo de errores de red
                return $"Error de red: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Manejo de cualquier otro error
                return $"Error inesperado: {ex.Message}";
            }
        }
    }
}

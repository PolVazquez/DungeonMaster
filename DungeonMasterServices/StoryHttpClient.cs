namespace DungeonMasterServices
{
    public interface IStoryService
    {
        Task<string> GetStory();
    }

    public sealed class StoryHttpClient(HttpClient http) : IStoryService
    {
        private readonly HttpClient _http = http;

        // Método que hace una solicitud GET a la API para obtener la historia
        public async Task<string> GetStory() =>
            await _http.GetStringAsync($"{_http.BaseAddress}/story/generate");
    }
}
using DungeonMasterApp;
using DungeonMasterServices; // Importa el espacio de nombres de servicios
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// A�adir componentes ra�z
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurar HttpClient para que use la direcci�n base
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5257/api") // La direcci�n base de la API
});

// Registrar el servicio StoryHttpClient
builder.Services.AddScoped<IStoryService, StoryHttpClient>();

// Registra BlazorBootstrap (si lo necesitas)
builder.Services.AddBlazorBootstrap();

// Construye y ejecuta la aplicaci�n
await builder.Build().RunAsync();

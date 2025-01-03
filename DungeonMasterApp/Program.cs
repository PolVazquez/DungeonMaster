using DungeonMasterApp;
using DungeonMasterServices; // Importa el espacio de nombres de servicios
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Añadir componentes raíz
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurar HttpClient para que use la dirección base
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5257/api") // La dirección base de la API
});

// Registrar el servicio StoryHttpClient
builder.Services.AddScoped<IStoryService, StoryHttpClient>();

// Registra BlazorBootstrap (si lo necesitas)
builder.Services.AddBlazorBootstrap();

// Construye y ejecuta la aplicación
await builder.Build().RunAsync();

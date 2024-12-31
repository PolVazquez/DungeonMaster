using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DungeonMasterApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Registrar los componentes principales
builder.RootComponents.Add<App>("#app");  // Componente principal de la app
builder.RootComponents.Add<HeadOutlet>("head::after");  // Permite la inyección de contenido en el head del HTML

// Configuración de HttpClient para consumir APIs
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7109") });


// Crear y ejecutar la aplicación Blazor
await builder.Build().RunAsync();

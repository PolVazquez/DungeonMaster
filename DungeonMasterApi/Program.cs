var builder = WebApplication.CreateBuilder(args);

// Lee la URL de la aplicación Blazor desde la configuración
var allowedOrigin = builder.Configuration["CorsSettings:AllowBlazorApp"];

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp",
        policy =>
        {
            policy.WithOrigins(allowedOrigin ?? throw new InvalidOperationException("La configuración de CORS para AllowBlazorApp no está presente o es inválida.")) // Usa la URL que leíste desde el archivo appsettings.json
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

builder.Services.AddControllers();

// Servicio IA
//builder.Services.AddHttpClient<IStoryService, StoryHttpClient>(client =>
//{
//    client.BaseAddress = new Uri("https://tu-backend-de-ia.com/");
//});

var app = builder.Build();

// Usa la política de CORS en la aplicación
app.UseCors("AllowBlazorApp");

app.MapControllers();

app.Run();

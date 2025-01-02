var builder = WebApplication.CreateBuilder(args);

// Lee la URL de la aplicaci�n Blazor desde la configuraci�n
var allowedOrigin = builder.Configuration["CorsSettings:AllowBlazorApp"];

// Configuraci�n de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp",
        policy =>
        {
            policy.WithOrigins(allowedOrigin ?? throw new InvalidOperationException("La configuraci�n de CORS para AllowBlazorApp no est� presente o es inv�lida.")) // Usa la URL que le�ste desde el archivo appsettings.json
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

builder.Services.AddControllers();

// Otros servicios...

var app = builder.Build();

// Usa la pol�tica de CORS en la aplicaci�n
app.UseCors("AllowBlazorApp");

app.MapControllers();

app.Run();

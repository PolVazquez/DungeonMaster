# Dungeon Master AI 🧙‍♂️🎲

Dungeon Master AI es un proyecto innovador que combina 🤖 inteligencia artificial y tecnología 🌐 moderna para crear un director de juego automatizado para partidas de rol, especialmente diseñado para **Pathfinder**. Este proyecto incluye una aplicación frontend en Blazor WebAssembly 🖥️ y un backend API para manejar la lógica del juego.

---

## Características principales ✨

### Aplicación WebAssembly 🕹️

- Construida con **Blazor WebAssembly**.
- Interfaz interactiva para los jugadores 🧑‍🤝‍🧑.
- Comunicación con el backend API para manejar la lógica del juego 🔗.

### API Backend ⚙️

- Construida con **ASP.NET Core**.
- Gestión de combate ⚔️, exploración 🌍 e interacción con NPCs 🤝.
- Implementación de políticas CORS para interactuar con el frontend 🔐.
- Endpoint para probar la conectividad: `/weatherforecast` 🌤️.

### IA Autonómica 🧠

- **Dungeon Master Virtual**: Toma decisiones autónomas como un director de juego humano 🧙‍♀️.
- **Soporte de Texto y Voz** 🎙️💬: Interacción fluida con los jugadores.
- Mapeo dinámico de mapas 🗺️ y gestión de eventos de rol.

---

## Requisitos previos 📋

### Software necesario 🖥️

- **Visual Studio 2022** o superior (Enterprise recomendado).
- **.NET SDK 8.0** o superior.
- Navegador moderno (Microsoft Edge, Google Chrome, etc.) 🌐.

### Librerías y herramientas adicionales 🛠️

- Blazor WebAssembly.
- ASP.NET Core.

---

## Instrucciones de configuración ⚙️

### Paso 1: Clonar el repositorio 🌀

```bash
git clone <URL_DEL_REPOSITORIO>
cd DungeonMasterAI
```

### Paso 2: Configurar la API 🛠️

1. Navega al proyecto de la API (`DungeonMasterApi`).
2. Configura las políticas de CORS en `Program.cs` para permitir solicitudes desde el frontend:
   ```csharp
   builder.Services.AddCors(options =>
   {
       options.AddPolicy("AllowBlazorApp", policy =>
       {
           policy.WithOrigins("https://localhost:7289", "http://localhost:5131")
                 .AllowAnyMethod()
                 .AllowAnyHeader();
       });
   });
   app.UseCors("AllowBlazorApp");
   ```
3. Asegúrate de que el archivo `launchSettings.json` esté configurado correctamente para evitar conflictos de puertos 🚪.

### Paso 3: Configurar el frontend 💻

1. Navega al proyecto WebAssembly (`DungeonMasterApp`).
2. Configura el cliente HTTP en `Program.cs` para apuntar al backend API:
   ```csharp
   builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7109") });
   ```

### Paso 4: Ejecutar ambos proyectos ▶️

1. Configura Visual Studio para ejecutar ambos proyectos simultáneamente:
   - Ve a las **Propiedades de la solución** ⚙️.
   - Selecciona **Inicio de varios proyectos** y habilita ambos proyectos.
2. Ejecuta la solución presionando **F5** ⏯️.

---

## Estructura del proyecto 🗂️

```
DungeonMasterAI/
├── DungeonMasterApp/      # Proyecto Blazor WebAssembly (Frontend)
├── DungeonMasterApi/      # Proyecto ASP.NET Core API (Backend)
└── README.md             # Documentación del proyecto
```

---

## Pruebas iniciales ✅

1. Accede a la aplicación WebAssembly en tu navegador 🕸️:

   - URL: `https://localhost:7289`.

2. Prueba la conectividad con la API 🔄:

   - En el frontend, realiza una llamada al endpoint `/weatherforecast` 🌦️.

3. Verifica el correcto funcionamiento del backend accediendo a Swagger 📜:

   - URL: `https://localhost:7109/swagger`.

---

## Próximos pasos 🚀

1. Implementar funcionalidades avanzadas para la IA 🧩 (gestión autónoma de combates ⚔️, creación de NPCs dinámicos 🧑‍🎨).
2. Agregar soporte de voz usando bibliotecas de conversión texto a voz (TTS) 🗣️.
3. Integrar un sistema de mapeo dinámico para escenarios de rol 🗺️.

---

## Contribuciones 🤝

Las contribuciones son bienvenidas 🙌. Si deseas colaborar, por favor abre un **issue** o envía un **pull request** ✉️.

---

## Licencia 📜

Este proyecto está bajo la [Licencia MIT](LICENSE).


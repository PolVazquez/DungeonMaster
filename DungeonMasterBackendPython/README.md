# DungeonMasterBackendPython ![Python](https://img.shields.io/badge/Python-3.x-blue?logo=python)

Este proyecto es el backend de un sistema de Dungeon Master para un juego de rol basado en IA. Utiliza **Flask** como framework web y está diseñado para generar historias interactivas para un juego de rol de fantasía.

## Estructura del Proyecto 📁
```
DungeonMasterBackendPython/ 
│ 
├── app.py # Archivo principal para iniciar la aplicación 
├── controllers/ # Carpeta con los controladores 
│ 
├── init.py # Hace que 'controllers' sea un paquete 
│ ├── story_controller.py # Controlador de la historia 
│ └── ai_controller.py # Controlador para la interacción con IA
├── requirements.txt # Archivo con las dependencias del proyecto 
└── config.py # Archivo de configuración
```

## Requisitos ⚙️

Antes de ejecutar la aplicación, asegúrate de tener instaladas las siguientes herramientas:

- **Python 3.x**
- **pip**

## Instalación 🛠️

1. Clona este repositorio a tu máquina local:

    ```bash
    git clone https://github.com/tu_usuario/DungeonMasterBackendPython.git
    cd DungeonMasterBackendPython
    ```

2. Crea un entorno virtual para aislar las dependencias (opcional pero recomendado):

    En **Windows**:
    ```
    python -m venv venv
    .\venv\Scripts\activate
    ```

    En **macOS/Linux**:
    ```
    python3 -m venv venv
    source venv/bin/activate
    ```

3. Instala las dependencias necesarias:

    ```
    
    pip install -r requirements.txt
    
    ```

## Configuración ⚡

Si necesitas usar claves de API u otras configuraciones, puedes definirlas en el archivo **`config.py`**. Asegúrate de tener una clave válida de OpenAI si planeas usar la API de OpenAI.

### Ejemplo de configuración en `config.py`:

```
import os

class Config:
    OPENAI_API_KEY = os.getenv("OPENAI_API_KEY", "tu-clave-api-aqui")
    DEBUG = True  # Establece a False para producción

```
## Ejecución 🚀
Para ejecutar la aplicación, usa el siguiente comando:

```

python app.py

```
La aplicación se ejecutará en http://127.0.0.1:5000/. 

## Endpoints 🌐
GET /get-text
Genera un texto de ejemplo como respuesta.


``
json
{
  "message": "Este es el texto que devuelvo como respuesta."
}
``

## Contribuir 🤝
Haz un fork del repositorio.
Crea una rama para tu nueva funcionalidad o corrección de errores (git checkout -b feature/nueva-funcionalidad).
Realiza tus cambios y haz commit de ellos (git commit -am 'Agregada nueva funcionalidad').
Envía un pull request.
Licencia 📜
Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.

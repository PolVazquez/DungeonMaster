import os

class Config:
    OPENAI_API_KEY = os.getenv("OPENAI_API_KEY", "tu-clave-api-aqui")
    DEBUG = True  # Puedes configurar el modo debug o producción
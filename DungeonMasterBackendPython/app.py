from flask import Flask
from controllers.story_controller import story_blueprint  # Importar el blueprint del controlador
from config import Config

app = Flask(__name__)
app.config.from_object(Config)


# Registra los controladores (blueprints)
app.register_blueprint(story_blueprint)

if __name__ == '__main__':
    app.run(debug=True)
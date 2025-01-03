from flask import Blueprint, jsonify

# Crear un blueprint para las rutas relacionadas con las historias
story_blueprint = Blueprint('story', __name__)

@story_blueprint.route('/get-text', methods=['GET'])
def get_text():
    return jsonify({"message": "Este es el texto que devuelvo como respuesta."})

# Puedes agregar más rutas aquí si es necesario
from fastapi import FastAPI
from pydantic import BaseModel

from fastapi.middleware.cors import CORSMiddleware
app = FastAPI()

app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],  # O especifica tus orígenes
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)

class Story(BaseModel):
    title: str
    content: str

@app.get("/generateStory", response_model=Story)
async def generate_story():
    title = "A Brave Adventure"
    content = "You venture into the forest and encounter a mighty dragon!"
    return Story(title=title, content=content)

if __name__ == "__main__":
    import uvicorn
    uvicorn.run(app, host="0.0.0.0", port=8000)

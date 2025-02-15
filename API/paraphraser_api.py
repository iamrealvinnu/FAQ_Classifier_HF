import pandas as pd
from flask import Flask, request, jsonify

app = Flask(__name__)

# Load FAQ dataset from CSV
try:
    df = pd.read_csv("../Data/faq_dataset.csv")
    df.columns = ['Question', 'Answer']
except FileNotFoundError:
    raise FileNotFoundError("Ensure the correct path to 'faq_dataset.csv' is provided.")

@app.route('/paraphrase', methods=['POST'])
def paraphrase():
    data = request.json
    text = data.get("text", "")
    
    if not text:
        return jsonify({"error": "Text input is required"}), 400
    
    # Select random variations from the dataset
    if len(df) < 2:
        return jsonify({"error": "Not enough data in the dataset"}), 500
    
    variations = df['Question'].sample(2).tolist()
    
    return jsonify({"paraphrases": variations})

@app.route('/')
def home():
    return "Welcome to the Paraphraser API! Post requests to /paraphrase."

if __name__ == '__main__':
    app.run(port=5000)

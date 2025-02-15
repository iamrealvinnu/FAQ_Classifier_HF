FAQ Classifier HF
This repository contains a machine learning project for classifying frequently asked questions (FAQs) and a paraphraser API to generate variations of questions.

Project Structure
API/paraphraser_api.py: A Flask API that provides paraphrasing functionality for given text inputs using a dataset of FAQs.
Client/client_request.js: A sample client script using Axios to make requests to the paraphraser API.
Data/faq_dataset.csv: The dataset containing FAQ questions and answers.
MLModel/FAQ_Classifier_HF.sln: Visual Studio solution file for the FAQ classifier model.
MLModel/Program.cs: The C# program for training the FAQ classifier model using ML.NET.
Getting Started
Prerequisites
Python 3.x
Flask
Pandas
Node.js
Axios
.NET SDK
Installation
Clone the repository:

sh
git clone https://github.com/iamrealvinnu/FAQ_Classifier_HF.git
cd FAQ_Classifier_HF
Set up the Python environment and install dependencies:

sh
cd API
pip install flask pandas
Install Node.js dependencies:

sh
cd Client
npm install axios
Set up the .NET environment and build the ML model:

sh
cd MLModel
dotnet build
Usage
Start the Flask API server:

sh
cd API
python paraphraser_api.py
Run the client script to test the paraphraser API:

sh
cd Client
node client_request.js
Train the FAQ classifier model:

sh
cd MLModel
dotnet run
Example
To get paraphrased variations of a question:

Make a POST request to http://127.0.0.1:5000/paraphrase with a JSON body:
JSON
{
  "text": "How do I track my order?"
}
Response:
JSON
{
  "paraphrases": [
    "How do I track my order?",
    "Can you tell me how to track my order?"
  ]
}
Contributing
Contributions are welcome. Please submit a pull request or open an issue to discuss any changes.

License
This project is licensed under the MIT License.

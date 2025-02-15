# FAQ Classifier HF

This repository contains a machine learning project for classifying frequently asked questions (FAQs) and a paraphraser API to generate variations of questions.

## Table of Contents
- [Project Overview](#project-overview)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
  - [Starting the Flask API](#starting-the-flask-api)
  - [Running the Client Script](#running-the-client-script)
  - [Training the FAQ Classifier Model](#training-the-faq-classifier-model)
- [Example](#example)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Project Overview
The **FAQ Classifier HF** is designed to classify frequently asked questions using machine learning. Additionally, it includes a **paraphraser API** that generates alternative question formulations to improve user interaction.

## Project Structure
```
FAQ_Classifier_HF/
│── API/
│   ├── paraphraser_api.py    # Flask API for paraphrasing questions
│   ├── requirements.txt      # Dependencies for the API
│── Client/
│   ├── client_request.js     # Client script using Axios
│── Data/
│   ├── faq_data.tsv          # FAQ data in TSV format
│   ├── faq_dataset.csv       # Dataset containing FAQ questions and answers
│── MLModel/
│   ├── FAQ_Classifier_HF.sln # Visual Studio solution file
│   ├── FAQ_Classifier_HF.csproj # .NET project file
│   ├── MLModel.csproj        # Additional .NET project file
│   ├── Program.cs            # C# program using ML.NET
│── .gitattributes            # Git attributes configuration
│── .gitignore                # Git ignore file
│── README.md                 # Documentation
```

## Getting Started
### Prerequisites
Ensure you have the following installed:
- Python 3.x
- Flask
- Pandas
- Node.js
- Axios
- .NET SDK

### Installation
Clone the repository:
```sh
git clone https://github.com/iamrealvinnu/FAQ_Classifier_HF.git
cd FAQ_Classifier_HF
```

Set up the Python environment and install dependencies:
```sh
cd API
pip install -r requirements.txt
```

Install Node.js dependencies:
```sh
cd Client
npm install axios
```

Set up the .NET environment and build the ML model:
```sh
cd MLModel
dotnet build
```

## Usage
### Starting the Flask API
```sh
cd API
python paraphraser_api.py
```

### Running the Client Script
```sh
cd Client
node client_request.js
```

### Training the FAQ Classifier Model
```sh
cd MLModel
dotnet run
```

## Example
To get paraphrased variations of a question, make a POST request to `http://127.0.0.1:5000/paraphrase` with the following JSON body:
```json
{
  "text": "How do I track my order?"
}
```

Response:
```json
{
  "paraphrases": [
    "How do I track my order?",
    "Can you tell me how to track my order?"
  ]
}
```

## Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -m "Add new feature"`).
4. Push to the branch (`git push origin feature-branch`).
5. Open a pull request.

## License
This project is licensed under the MIT License.

## Contact
For any inquiries or support, feel free to reach out:
- **Author**: [Vinay](https://github.com/iamrealvinnu)
- **Email**: [your-email@example.com](mailto:gupta.vinayC@gmail.com)

Enjoy building with **FAQ Classifier HF**! 🚀


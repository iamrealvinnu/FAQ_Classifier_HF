const axios = require('axios');

const question = { text: "How do I track my order?" };

axios.post('http://127.0.0.1:5000/paraphrase', question)
    .then(response => {
        console.log("Generated Variations:", response.data);
    })
    .catch(error => {
        console.error("Error:", error.message);
    });

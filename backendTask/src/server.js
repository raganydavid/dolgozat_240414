const express = require('express');
const app = express();
const PORT = process.env.PORT || 3000;


app.get('/api/users', (req, res) => {
    
    res.json({ message: 'Get all users' });
});

app.post('/api/users', (req, res) => {
    
    res.json({ message: 'Create a new user' });
});


app.use((req, res) => {
    res.status(404).json({ error: 'Route not found' });
});


app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});
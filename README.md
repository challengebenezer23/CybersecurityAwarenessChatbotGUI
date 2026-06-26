# 🛡️ Cybersecurity Awareness Chatbot System (Windows Forms)

##Overview

The Cybersecurity Awareness Chatbot System is a C# Windows Forms desktop application designed to educate users about cybersecurity while demonstrating core software engineering principles.

It combines a chatbot interface, task management system, quiz game, and activity logging into one integrated application.

The system simulates Natural Language Processing (NLP) using keyword detection and string matching to interpret user input and route it to the correct feature.

---

##Key Features

###Chatbot (NLP Simulation)
- Interacts with the user through a chat interface
- Uses keyword detection (`Contains()`) to simulate NLP
- Recognises intents such as:
  - Add task
  - Start quiz
  - Show activity log
  - Cybersecurity topic queries
- Provides educational responses on:
  - Password safety
  - Phishing attacks
  - Online privacy
  - Scam awareness

---

###Task Management System
- Add cybersecurity-related tasks
- Mark tasks as complete
- Delete tasks
- Stores all data in a local JSON file (`tasks.json`)
- Supports full CRUD operations:
  - Create
  - Read
  - Update
  - Delete

---

###Cybersecurity Quiz System
- Interactive quiz with 10+ cybersecurity questions
- Displays one question at a time
- Immediate feedback after each answer
- Final score calculation
- Covers topics such as:
  - Phishing
  - Password security
  - Malware
  - Social engineering
  - Two-factor authentication
  - Safe browsing

---

###Activity Log System
- Records all important system actions
- Each entry includes a timestamp
- Tracks:
  - Task creation
  - Task completion
  - Quiz start and completion
  - NLP intent detection
  - Chatbot interactions
- Displays the most recent 10 actions
- Option to view full history

---

##Project Architecture

The application follows a modular architecture with separation of concerns:
CybersecurityAwarenessChatbotGUI
│
├── MainForm.cs # Main UI controller (Windows Forms)
├── ChatbotEngine.cs # Chatbot logic and NLP simulation
├── TaskManager.cs # Task operations (business logic)
├── TaskStorageHelper.cs # JSON file handling
├── QuizManager.cs # Quiz logic and scoring system
├── ActivityLogger.cs # System activity tracking
├── SentimentAnalyzer.cs # User sentiment detection
├── User.cs # User data model
└── Program.cs # Application entry point

---

##Technologies Used

- C# (.NET Windows Forms)
- Object-Oriented Programming (OOP)
- Event-driven programming
- JSON file storage (Newtonsoft.Json)
- Keyword-based NLP simulation

---

##How It Works

1. The application starts and the chatbot greets the user
2. The user enters their name and interacts with the chatbot
3. Input is processed using keyword-based NLP simulation
4. The system routes requests to:
   - Task Manager (for tasks)
   - Quiz Manager (for quiz gameplay)
   - Activity Logger (for tracking actions)
5. All updates are reflected in the UI in real time

---

##Key Software Engineering Concepts

- Separation of concerns (UI, logic, storage)
- Modular architecture
- Persistent data storage using JSON
- Event-driven UI design
- Simulated Natural Language Processing
- Interactive educational system design

---

##Example Interaction

**User:**
Add a task to enable two-factor authentication

**Bot:**
Task added successfully. Would you like to set a reminder?

---

## Future Improvements

- Integration with a real database (SQL Server or SQLite)
- AI-powered NLP instead of keyword detection
- User authentication system
- Cloud-based task synchronization
- Mobile version of the application

---

##Author

Developed as part of a cybersecurity awareness and software development learning project using C# Windows Forms.

---

## License

This project is intended for educational purposes only.

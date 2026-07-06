# Quiz_test

A Windows Forms trivia quiz application built in C#. Each session pulls 4 random questions from a pool of general knowledge topics (movies, books, music, sports, and more), shuffles the answer options, and tracks the player's score across attempts.

## Features

- Randomly selects and shuffles questions from a larger question pool each session
- Displays each question with a typewriter-style animation (implemented with async tasks and cross-thread UI updates)
- Tracks correct/incorrect answers and adjusts a running score
- Shows an explanation after each answer
- Displays a final results screen with total score and attempts

## Tech Stack

- **Language:** C#
- **UI:** Windows Forms (WinForms), built with swappable UserControls for each screen (menu, questions, results)
- **Concurrency:** Task-based async operations for non-blocking UI updates

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/AmIprogramme/Quiz_test.git
   ```
2. Open the solution file (`.sln`) in Visual Studio.
3. Build and run the project (`F5`).
4. Use the on-screen buttons to answer each question.

## Status

This is a learning project developed to practice object-oriented design, UI state management, and asynchronous programming in C#.

## Author

**Andrés Quesada Rodríguez**
[LinkedIn](https://www.linkedin.com/in/andres-quesada-rodr%C3%ADguez-894213243) · andresquesada7501@gmail.com

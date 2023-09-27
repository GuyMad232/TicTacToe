# TicTacToe Game (Reversed Version) 🎮

## 📝 Description
This project is a reversed rendition of the classic TicTacToe game, conceptualized as an academic project for an Object-Oriented Programming (OOP) course. The game, implemented in C#, leverages Visual Studio Forms for graphical visualization, offering users an interactive and intuitive gameplay experience. The game offers adaptive gameplay with dynamic game validation, ensuring a responsive and engaging environment.

## 🌐 Table of Contents
1. [Features](#-features)
2. [Installation](#-installation)
3. [Usage](#-usage)
4. [Technologies Used](#-technologies-used)


## 🚀 Features
- **Adaptive Gameplay**: Adjusts gameplay based on user preferences, offering customized board sizes and opponent types.
- **Responsive Interaction Handling**: Provides smooth interaction handling with real-time feedback on user actions.
- **Dynamic Game Validation**: Determines game status in real-time, checking for winning conditions or a draw efficiently.
- **Intuitive User Interface**: Features user-friendly gameplay through Visual Studio Forms.

## 🖥️ Visualization Layer
- **FormGameSettings**: Manages initial settings, such as board size and player names.
- **FormGame**: Represents the main game window, initializing and updating the game board and settings.
- **Messages**: Manages the display of in-game messages and player decisions on game continuation.
- **CellButton**: Acts as an interactive cell on the game board, reflecting its current state.

## ⚙️ Game Logic Layer
- **Board**: Represents the game board logically, tracks available cells, and manages board initialization.
- **Cell**: Denotes an individual cell on the board, holding its state and managing state transitions.
- **Player**: Represents an individual player, managing the player’s symbol, type, and score.
- **GameValidation**: Validates the game status dynamically, ensuring accurate game state representation.
- 
## 🕹️ Controller Layer
- **GameControls**: Controls the game flow, managing player interactions and the transition between game states.

## 💻 Installation
1. Clone this repository.
2. Open the project in Visual Studio.
3. Build and run the project.

## 🎮 Usage
1. Execute the program to start the game.
2. Choose preferred settings and begin an interactive game session.
3. Play and experience real-time updates and smooth gameplay.

## 🛠️ Technologies Used
- **C#: Implements strong typing and object-oriented principles.
- **Visual Studio Forms: Enables graphical user interface for intuitive user interaction.
- **LINQ: Employed for efficient data querying and manipulation in game status verification.
- **.NET Technologies: Provide a versatile development and execution environment.

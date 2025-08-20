# Coding Challenge README

This repository contains a solution for the Trail Coding Challenge, a coding exercise inspired by the game Yahtzee. The challenge requires calculating the maximum score for 1000 rounds of a dice-rolling game with customizable numbers of dice (`I`) and sides (`J`), displaying the score for each round, and measuring the total execution time.

## Prerequisites

To build and run this project, you need the following:

- **Operating System**: Windows (as per the provided document focus).
- **.NET 9 SDK**: The recommended version for this project, offering Standard Term Support and new features like AI integration and performance boosts.

## Installation

### Step 1: Install .NET 9 SDK
Visit the official .NET download page: [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download).
### Step 2: Install Visual Studio Code
Download Visual Studio Code from: [https://code.visualstudio.com/](https://code.visualstudio.com/).

## Project Setup

1. **Clone the Repository**:
   Clone this repository to your local machine using:
   ```bash
   git clone <repository-url>
   cd coding_challenge
   ```

2. **Restore Dependencies**:
   Open the project folder in VS Code. The C# Dev Kit will automatically restore the .NET dependencies. Alternatively, run:
   ```bash
   dotnet restore
   ```

## Running the Application

1. **Build the Project**:
   Build the solution to ensure there are no compilation errors:
   ```bash
   dotnet build
   ```

2. **Run the Application**:
   Execute the program from the terminal:
   ```bash
   dotnet run
   ```
   - The program will prompt you to enter the number of dice (`I`) and the number of sides per die (`J`).
   - Example input: `I = 5`, `J = 6` (mimicking a standard Yahtzee game).
   - It will then simulate 1000 rounds, displaying the roll and score for each round, followed by the total execution time.

## Example Output
```
Enter the number of dice (I): 5
Enter the number of sides per die (J): 6
Round 1: [2, 3, 5, 5, 6] => Score = 10
Round 2: [1, 1, 1, 1, 3] => Score = 4
...
Round 1000: [6, 6, 6, 6, 5] => Score = 24
Total time: 0.1234 seconds
```


# Play Card and Deck Example in C#

## Introduction

This project demonstrates how to create a **play card** and a **deck** in C#. It serves as the foundation for building any card-based games. You can freely copy, modify, and develop it to create your own card games.

### Concepts Covered:

- **Arrays**, **Lists**, and **Dictionaries**
- **Object-Oriented Programming (OOP)** concepts such as **classes**, **properties**, and **methods**
- ASCII art for cards, showing different styles of representation
- Managing collections with methods like `RemoveAt` and implementing custom logic (e.g., `Pop` for drawing cards)

Additionally, this example includes a **class inside a class**, which was part of our lesson to better organize and structure code.

---

## Features

- A fully functional **deck** of cards with `Color`, `Value`, `Suit`, and `Symbol`.
- A **dictionary** is used to map suits to their respective symbols (`♥`, `♦`, `♣`, `♠`).
- Two different types of **ASCII art cards** to visually represent the cards.
- Methods to:
  - Shuffle the deck
  - Draw a card (`Pop`)
  - Display the entire deck

---

## Prerequisites

- Install [.NET SDK](https://dotnet.microsoft.com/download) on your system.

### Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/card-game-csharp.git
   cd card-game-csharp
   ```
2. Restore dependencies (if any):
   ```bash
   dotnet restore
   ```
3. Build and run the program:
   ```bash
   dotnet build
   dotnet run
   ```

---

## Key Concepts Explained

### 1. **Dictionary for Symbols**

We used a dictionary to map card suits (`Hearts`, `Spades`, etc.) to their respective symbols (`♥`, `♠`, etc.). This helps in easily managing and accessing symbols for each suit:

```csharp
Dictionary<string, char> cardWithSymbol = new Dictionary<string, char>();
for (int i = 0; i < suits.Length; i++)
{
    cardWithSymbol[suits[i]] = symbols[i];
}
```

This is a flexible and scalable way to link related data.

---

### 2. **RemoveAt Method**

The `RemoveAt` method is used in our custom `Pop` implementation to remove the last card from the deck:

```csharp
Card card = deck[deck.Count - 1];
deck.RemoveAt(deck.Count - 1);
```

- `RemoveAt(index)` removes an item from the specified index of the list.
- In our example, removing the last card ensures the deck size decreases as cards are drawn.

---

## How It Works

1. The **deck** is created using the `CreateDeck` method.
2. Cards are **shuffled** using a custom shuffle method that swaps cards randomly.
3. Cards can be **drawn** (using `Pop`) or displayed graphically (using `DrawDeck` and `DrawCard`).

---

## ASCII Art Cards

The project includes two ASCII art card designs for better visualization:

- Compact cards for smaller screens
- Larger, more detailed cards with centered symbols and values

Example:

```
    ╔════════════╗
    ║ A          ║
    ║            ║
    ║      ♥     ║
    ║            ║
    ║          A ║
    ╚════════════╝
```

---

## Future Improvements

Feel free to enhance this project by:

- Adding card dealing and game logic.
- Creating player classes and game rounds.
- Implementing more advanced deck shuffling techniques.

---

## Conclusion

This project covers the core properties of OOP and is an excellent example of how to design reusable components for games. It integrates lessons on **classes**, **collections**, and ASCII art while showcasing how to apply C# features in a practical way.

Happy coding and game building! 🎮

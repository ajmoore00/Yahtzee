# Yahtzee

## Overview

Windows Forms Yahtzee game for C# Programming final project. 
The first version will be user vs computer (1v1). 
Planning to add the ability for more Com players later. 
Focusing on correct scoring, simple UI, dice hold/roll, and a basic Computer logic for now.

I wasn't able to get around to making the save/load actually work,
or making the computer actually smart,
or making the settings actually do anything.

## Game Rules

- 5 six-sided dice. Up to 3 rolls per turn. User can hold any dice between rolls.
- 13 categories:
  - Ones, Twos, Threes, Fours, Fives, Sixes
  - Three of a Kind (3K)
  - Four of a Kind (4K)
  - Full House (3 of one number + 2 of another, 25 points)
  - Small Straight (sequence of 4, 30 points)
  - Large Straight (sequence of 5, 40 points)
  - Yahtzee (five of a kind, 50 points)
  - Chance (sum of all dice)
- Upper section bonus: If Ones–Sixes total 63 or more, add 35 points.
- Game ends when all categories are filled. Highest total wins.
- No Joker rules or extra Yahtzee bonuses for now (can add later).

## Files

- Form1.cs
- SettingsForm.cs
- DiceSet.cs
- Player.cs
- ScoreCard.cs
- ScoreCategory.cs
- GameState.cs
- GameManager.cs
- ScoreCalculator.cs
- ComEngine.cs
- SaveLoadService.cs
- ScoreCalculatorTests.cs
- Program.cs
- Any image or sound files for dice, stored in an Assets folder

## Classes

- GameManager: Handles game state, starting new games, rolling dice, toggling holds, scoring, switching turns, 
	and (optionally) saving/loading.
- DiceSet: Stores dice values and held status, rolls dice, resets holds, gets counts, sums dice.
- Player: Name, IsAI, ScoreCard, computes total score.
- ScoreCard: Stores scores for each category, assigns scores, gets upper section sum, gets total.
- ScoreCalculator: Pure functions to calculate scores for each category from dice.
- AIEngine: Decides which dice to hold and which category to score. Start with simple logic.

## UI

- Form1:
  - Menu: New, Save, Load, Settings
  - Dice area: 5 PictureBoxes (click to hold/unhold)
  - Buttons: Roll, End Turn
  - Scorecard: DataGridView or list; click category to assign score
  - Status bar: roll count, current player, tips
- Show preview score when hovering over a category.
- Disable roll after 3 rolls.

## Scoring Helpers

- GetCounts(dice): returns counts of each face (1–6)
- IsNOfAKind(counts, n)
- IsFullHouse(counts)
- IsSmallStraight(counts)
- IsLargeStraight(counts)
- IsYahtzee(counts)
- Sum(dice)

## AI

- Easy: random holds or hold matching dice.
- Normal: greedy—hold largest matching face, hold runs for straights, pick best immediate score.
- Hard: simulate expected value (only if time allows).

## Save/Load

- Save game state (players, scorecards, dice, turn, roll count) to JSON. Optional.

## Plan

1. Create WinForms project and MainForm.
2. Implement DiceSet and GameManager.RollDice, show dice in UI.
3. Implement ScoreCalculator and unit tests for scoring.
4. Add scorecard UI and scoring assignment.
5. Add simple Computer logic and turn switching.
6. (Optional) Add save/load, settings, and polish.

## Potential Methods

- `GameManager.StartNewGame()`
- `GameManager.RollDice()`
- `GameManager.ToggleHold(int dieIndex)`
- `GameManager.ScoreCategory(Player p, ScoreCategory c)`
- `GameManager.NextTurn()`
- `DiceSet.Roll(Random rng)`
- `ScoreCalculator.ScoreForCategory(ScoreCategory c, int[] dice)`
- `ComEngine.DecideHolds(int[] dice, int roll, ScoreCard sc)`
- `SaveLoadService.Save(GameState s, string path)` / `Load(...)`

## First Steps

- [ ] Create WinForms project and MainForm.
- [ ] Add 5 PictureBoxes and Roll button.
- [ ] Implement DiceSet and GameManager.RollDice().
- [ ] Implement ScoreCalculator and unit tests for core categories.
- [ ] Set up basic scorecard UI and simple Com logic.

## Notes

- Start without Joker rules and advanced Yahtzee bonuses. Add a settings toggle for classic rules later if needed.
- Allow forced zero in any category if necessary. Tie = draw (optionally break ties by number of Yahtzees).
- Keep scoring logic pure, UI should only show state from GameManager.
- Start minimal, then add rules, AI improvements, and polish after basic logic works.

---

# Pseudocode

## 1. Create the Windows Forms App
- Make a new Windows Forms App called "Yahtzee".
- The main form will be Form1.

## 2. Design the Main Game UI (Form1)
- Add menu options: New Game, Save, Load, Settings.
- Add 5 PictureBoxes for dice.
    - Clicking a PictureBox toggles hold/unhold for that die.
- Add Roll button.
- Add End Turn button.
- Add DataGridView or ListView for scorecard.
    - Clicking a category assigns score for that turn.
    - Hovering a category shows preview score.
- Add status bar for roll count, current player, and tips.
- Disable Roll button after 3 rolls.

## 3. Data Classes
- DiceSet
    - Properties: `int[] values` (5), `bool[] held` (5)
    - Methods: `Roll(Random rng)`, `ResetHolds()`, `GetCounts()`, `Sum()`
- Player
    - Properties: `string Name`, `bool IsCom`, `ScoreCard scoreCard`
    - Methods: `ComputeTotal()`
- ScoreCard
    - Properties: `Dictionary<ScoreCategory, int?> scores`
    - Methods: `AssignScore()`, `GetUpperSum()`, `GetTotal()`
- ScoreCategory (enum)
    - Values: Ones, Twos, Threes, Fours, Fives, Sixes, ThreeOfAKind, FourOfAKind, FullHouse, SmallStraight, LargeStraight, Yahtzee, Chance
- GameState
    - Properties: `List<Player> players`, `int currentPlayerIndex`, `int rollCount`, `DiceSet diceSet`

## 4. Game Logic Classes
- GameManager
    - Properties: `GameState state`
    - Methods:
        - `StartNewGame()`
        - `RollDice()`
        - `ToggleHold(int dieIndex)`
        - `ScoreCategory(Player p, ScoreCategory c)`
        - `NextTurn()`
        - `Save(string path)`
        - `Load(string path)`
- ScoreCalculator
    - Methods:
        - `ScoreForCategory(ScoreCategory c, int[] dice)`
        - `GetCounts(int[] dice)`
        - `IsNOfAKind(int[] counts, int n)`
        - `IsFullHouse(int[] counts)`
        - `IsSmallStraight(int[] counts)`
        - `IsLargeStraight(int[] counts)`
        - `IsYahtzee(int[] counts)`
        - `Sum(int[] dice)`
- ComEngine
    - Methods:
        - `DecideHolds(int[] dice, int roll, ScoreCard sc)`
        - `ChooseCategory(int[] dice, ScoreCard sc)`

## 5. Settings Form (`SettingsForm.cs`)
- Add controls for toggling advanced rules (Ones are wild, extra Yahtzee bonuses).
- Optionally allow changing player names or Com difficulty.

## 6. Save/Load Service
- SaveLoadService
    - Methods:
        - `Save(GameState s, string path)` – serialize to JSON
        - `Load(string path)` – deserialize from JSON

## 7. Unit Tests
- ScoreCalculatorTests
    - Test all scoring methods for each category.
    - Use sample dice arrays to verify correct scores.

## 8. Form1_Load
- On form load, initialize GameManager and UI controls.
- Load assets (dice images, sounds) if available.

## 9. Game Flow
- On "New Game":
    - Call `GameManager.StartNewGame()`
    - Reset UI and state.
- On "Roll":
    - Call `GameManager.RollDice()`
    - Update dice images and roll count.
    - Disable Roll button after 3 rolls.
- On dice PictureBox click:
    - Call `GameManager.ToggleHold(dieIndex)`
    - Update held status visually.
- On scorecard category click:
    - Call `GameManager.ScoreCategory(currentPlayer, selectedCategory)`
    - Update scorecard UI.
    - Call `GameManager.NextTurn()`
    - Reset roll count and held dice.
- On "End Turn":
    - If score assigned, call `GameManager.NextTurn()`
    - Update UI for next player.
- On "Save"/"Load":
    - Use `SaveLoadService` to save/load game state.

## 10. Com Turn Logic
- If current player is AI:
    - Use `ComEngine.DecideHolds()` to select dice to hold.
    - Roll up to 3 times.
    - Use `ComEngine.ChooseCategory()` to pick best category.
    - Assign score and end turn.
    
    - Added a timer delay and status updates.

## 11. Scoring Logic
- Use `ScoreCalculator` to compute possible scores for each category.
- Show preview score when hovering over a category.
- Assign score only if category is not already filled.

## 12. End of Game
- When all categories are filled for all players:
    - Compute total scores.
    - Show winner (highest score).
    - Handle ties (optionally by number of Yahtzees).

## 13. Error Handling & Validation
- Use try/catch for file I/O (save/load).
- Validate user input (e.g., category selection, dice holds).
- Show error messages for invalid actions.

## 14. Assets
- Store dice images and sound effects in an "Assets" folder.
- Load images for dice faces in PictureBoxes.

---

# AI Assistance
- Copilot wrote most of the comments, but only after everything was done.
- I had it explain the rules as well, since I never played Yahtzee.
- It also helped with some debugging of logic errors with the computer player.
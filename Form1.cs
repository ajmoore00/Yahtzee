using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        // Stores the current game manager
        private GameManager GameManager;

        // Dice images (assumes Dice1.png ... Dice6.png in Assets)
        private Image[] DiceImages;

        // Timer for computer turn
        private System.Windows.Forms.Timer ComputerTurnTimer = new System.Windows.Forms.Timer();

        // Step counter for computer turn
        private int ComputerRollStep = 0;

        // Chosen category for computer scoring
        private ScoreCategory ComputerChosenCategory;

        // Tracks if the user has scored this turn
        private bool HasScoredThisTurn = false;

        // Tracks if game over message has been shown
        private bool GameOverMessageShown = false;

        public Form1()
        {
            InitializeComponent();
            LoadDiceImages();

            // Wire up events for dice PictureBoxes
            Die1PictureBox.Click += (s, e) => ToggleDie(0);
            Die2PictureBox.Click += (s, e) => ToggleDie(1);
            Die3PictureBox.Click += (s, e) => ToggleDie(2);
            Die4PictureBox.Click += (s, e) => ToggleDie(3);
            Die5PictureBox.Click += (s, e) => ToggleDie(4);

            // Wire up button events
            RollDiceButton.Click += RollDiceButton_Click;
            EndTurnButton.Click += EndTurnButton_Click;
            NewGameButton.Click += NewGameButton_Click;
            SaveGameButton.Click += SaveGameButton_Click;
            LoadGameButton.Click += LoadGameButton_Click;
            SettingsButton.Click += SettingsButton_Click;
            RulesButton.Click += RulesButton_Click;

            // Wire up scorecard click
            ScorecardGridView.CellClick += ScorecardGridView_CellClick;

            // Form load event
            this.Load += Form1_Load;

            // Setup computer turn timer
            ComputerTurnTimer.Interval = 1500; // 1.5 seconds per step
            ComputerTurnTimer.Tick += ComputerTurnTimer_Tick;
        }

        // Handles form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            GameManager = new GameManager();
            InstructionsLabel.Text = "Welcome to Yahtzee! Roll the dice and click a category to score.";
            StartNewGame();
        }

        // Loads dice images from Assets folder
        private void LoadDiceImages()
        {
            DiceImages = new Image[6];
            for (int i = 0; i < 6; i++)
            {
                DiceImages[i] = Image.FromFile($"Assets/Dice{i + 1}.png");
            }
        }

        // Starts a new game
        private void StartNewGame()
        {
            GameManager.StartNewGame();
            HasScoredThisTurn = false;
            UpdateUI();
            StatusLabel.Text = "New game started. Good luck!";
        }

        // Handles the Roll Dice button click
        private void RollDiceButton_Click(object sender, EventArgs e)
        {
            if (GameManager.CanRoll)
            {
                GameManager.RollDice();
                UpdateUI();
                StatusLabel.Text = "Rolled the dice.";
            }
            else
            {
                StatusLabel.Text = "No rolls left. Please score or end turn.";
            }
        }

        // Handles the End Turn button click
        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            if (GameManager.CanEndTurn)
            {
                GameManager.NextTurn();
                HasScoredThisTurn = false; // Reset for new turn
                UpdateUI();

                if (GameManager.CurrentPlayer.IsCom)
                {
                    StatusLabel.Text = "Computer's turn...";
                    ComputerRollStep = 1;
                    ComputerTurnTimer.Enabled = true;
                }
                else
                {
                    StatusLabel.Text = $"Turn ended. Now it's {GameManager.CurrentPlayer.Name}'s turn.";
                }
            }
            else
            {
                StatusLabel.Text = "You must score before ending your turn.";
            }
        }

        // Handles the New Game button click
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        // Handles the Save button click
        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog { Filter = "Yahtzee Save|*.json" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SaveLoadService.Save(GameManager.State, dlg.FileName);
                StatusLabel.Text = "Game saved.";
            }
        }

        // Handles the Load button click
        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Filter = "Yahtzee Save|*.json" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GameManager.State = SaveLoadService.Load(dlg.FileName);
                UpdateUI();
                StatusLabel.Text = "Game loaded.";
            }
        }

        // Handles the Settings button click
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                settingsForm.ShowDialog();
                // Apply settings if needed
            }
        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
            using (var rulesForm = new RulesForm())
            {
                rulesForm.ShowDialog();
            }
        }

        // Handles dice PictureBox click to toggle hold
        private void ToggleDie(int dieIndex)
        {
            GameManager.ToggleHold(dieIndex);
            UpdateUI();
        }

        // Handles scorecard cell click to assign score
        private void ScorecardGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                if (HasScoredThisTurn)
                {
                    StatusLabel.Text = "You've already scored this turn. Click 'End Turn' to continue.";
                    return;
                }

                var selectedCategory = (ScoreCategory)e.RowIndex;
                if (GameManager.CanScore(selectedCategory))
                {
                    GameManager.ScoreCategory(GameManager.CurrentPlayer, selectedCategory);

                    // Ensure EndTurnButton is enabled after scoring
                    GameManager.State.RollCount = 1; // Allow ending turn after scoring
                    HasScoredThisTurn = true; // Prevent further scoring this turn
                    UpdateUI();

                    StatusLabel.Text = $"Scored {selectedCategory} for {GameManager.CurrentPlayer.Name}. Click 'End Turn' to continue.";
                }
                else
                {
                    StatusLabel.Text = "Category already scored or not allowed.";
                }
            }
        }

        // Updates all UI elements based on game state
        private void UpdateUI()
        {
            // Update dice images and held status
            var dice = GameManager.State.DiceSet.Values;
            var held = GameManager.State.DiceSet.Held;
            PictureBox[] diceBoxes = { Die1PictureBox, Die2PictureBox, Die3PictureBox, Die4PictureBox, Die5PictureBox };
            for (int i = 0; i < 5; i++)
            {
                diceBoxes[i].Image = DiceImages[dice[i] - 1];
                diceBoxes[i].BorderStyle = held[i] ? BorderStyle.Fixed3D : BorderStyle.None;
            }

            // Update roll count and player info
            RollCountLabel.Text = $"Roll: {GameManager.State.RollCount}/3";
            CurrentPlayerLabel.Text = $"Player: {GameManager.CurrentPlayer.Name}";

            // Update scorecard
            UpdateScorecardGrid();

            // Enable/disable buttons
            RollDiceButton.Enabled = GameManager.CanRoll && !GameManager.CurrentPlayer.IsCom;
            EndTurnButton.Enabled = GameManager.CanEndTurn && !GameManager.CurrentPlayer.IsCom;

            // Check for game end
            bool userDone = GameManager.State.Players[0].ScoreCard.Scores.Values.All(s => s.HasValue);
            bool comDone = GameManager.State.Players[1].ScoreCard.Scores.Values.All(s => s.HasValue);

            // Show game over message if needed
            if (userDone && comDone && !GameOverMessageShown)
            {
                GameOverMessageShown = true;
                int userScore = GameManager.State.Players[0].ComputeTotal();
                int comScore = GameManager.State.Players[1].ComputeTotal();
                string winner = userScore > comScore ? "You win!" : userScore < comScore ? "Computer wins!" : "It's a tie!";
                MessageBox.Show($"Game Over!\nYour score: {userScore}\nComputer score: {comScore}\n{winner}", "Game Over");
                StatusLabel.Text = "Game over. " + winner;
                RollDiceButton.Enabled = false;
                EndTurnButton.Enabled = false;
            }
        }

        // Updates the scorecard DataGridView
        private void UpdateScorecardGrid()
        {
            ScorecardGridView.Rows.Clear();
            foreach (ScoreCategory cat in Enum.GetValues(typeof(ScoreCategory)))
            {
                int? userScore = GameManager.State.Players[0].ScoreCard.GetScore(cat);
                int? comScore = GameManager.State.Players[1].ScoreCard.GetScore(cat);
                ScorecardGridView.Rows.Add(cat.ToString(), userScore?.ToString() ?? "", comScore?.ToString() ?? "");
            }

            // Add a blank row for spacing (optional)
            ScorecardGridView.Rows.Add("", "", "");

            // Add total scores row
            int userTotal = GameManager.State.Players[0].ComputeTotal();
            int comTotal = GameManager.State.Players[1].ComputeTotal();
            ScorecardGridView.Rows.Add("Total", userTotal.ToString(), comTotal.ToString());

            // Add winner row if game is over
            bool userDone = GameManager.State.Players[0].ScoreCard.Scores.Values.All(s => s.HasValue);
            bool comDone = GameManager.State.Players[1].ScoreCard.Scores.Values.All(s => s.HasValue);
            if (userDone && comDone)
            {
                string winner;
                if (userTotal > comTotal)
                    winner = "You win!";
                else if (userTotal < comTotal)
                    winner = "Computer wins!";
                else
                    winner = "It's a tie!";
                ScorecardGridView.Rows.Add("Winner", winner, "");
            }
        }

        // Handles the computer's turn step-by-step
        private void ComputerTurnTimer_Tick(object sender, EventArgs e)
        {
            var com = GameManager.CurrentPlayer;
            var diceSet = GameManager.State.DiceSet;

            if (ComputerRollStep <= 3)
            {
                // Decide holds and roll
                var holds = ComEngine.DecideHolds(diceSet.Values, ComputerRollStep, com.ScoreCard);
                for (int i = 0; i < holds.Length; i++)
                    diceSet.Held[i] = holds[i];

                GameManager.RollDice();
                UpdateUI();

                StatusLabel.Text = ComputerRollStep == 1
                    ? "Computer rolled the dice."
                    : $"Computer kept some dice and rolled again ({ComputerRollStep}/3).";

                ComputerRollStep++;
            }
            else
            {
                // Choose category and score
                ComputerChosenCategory = ComEngine.ChooseCategory(diceSet.Values, com.ScoreCard);
                GameManager.ScoreCategory(com, ComputerChosenCategory);
                UpdateUI();
                StatusLabel.Text = $"Computer scored {ComputerChosenCategory}.";

                ComputerTurnTimer.Enabled = false;

                // Switch back to user
                GameManager.NextTurn();
                UpdateUI();
                StatusLabel.Text = "Your turn!";
            }
        }

        // Close dat shi
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

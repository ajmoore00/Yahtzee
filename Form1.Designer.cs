namespace Yahtzee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InstructionsLabel = new Label();
            RollCountLabel = new Label();
            CurrentPlayerLabel = new Label();
            StatusLabel = new Label();
            Die1PictureBox = new PictureBox();
            Die2PictureBox = new PictureBox();
            Die3PictureBox = new PictureBox();
            Die4PictureBox = new PictureBox();
            Die5PictureBox = new PictureBox();
            RollDiceButton = new Button();
            EndTurnButton = new Button();
            NewGameButton = new Button();
            SaveGameButton = new Button();
            LoadGameButton = new Button();
            SettingsButton = new Button();
            ScorecardGridView = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Computer = new DataGridViewTextBoxColumn();
            MainStatusStrip = new StatusStrip();
            MainStatusLabel = new ToolStripStatusLabel();
            RulesButton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Die1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Die2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Die3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Die4PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Die5PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScorecardGridView).BeginInit();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // InstructionsLabel
            // 
            InstructionsLabel.AutoSize = true;
            InstructionsLabel.Location = new Point(14, 17);
            InstructionsLabel.Margin = new Padding(4, 0, 4, 0);
            InstructionsLabel.Name = "InstructionsLabel";
            InstructionsLabel.Size = new Size(76, 25);
            InstructionsLabel.TabIndex = 0;
            InstructionsLabel.Text = "Yahtzee!";
            // 
            // RollCountLabel
            // 
            RollCountLabel.AutoSize = true;
            RollCountLabel.Location = new Point(14, 83);
            RollCountLabel.Margin = new Padding(4, 0, 4, 0);
            RollCountLabel.Name = "RollCountLabel";
            RollCountLabel.Size = new Size(77, 25);
            RollCountLabel.TabIndex = 1;
            RollCountLabel.Text = "Roll: 0/3";
            // 
            // CurrentPlayerLabel
            // 
            CurrentPlayerLabel.AutoSize = true;
            CurrentPlayerLabel.Location = new Point(171, 83);
            CurrentPlayerLabel.Margin = new Padding(4, 0, 4, 0);
            CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            CurrentPlayerLabel.Size = new Size(103, 25);
            CurrentPlayerLabel.TabIndex = 2;
            CurrentPlayerLabel.Text = "Player: User";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(13, 338);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(60, 25);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status";
            // 
            // Die1PictureBox
            // 
            Die1PictureBox.Image = Properties.Resources.dice1;
            Die1PictureBox.Location = new Point(14, 150);
            Die1PictureBox.Margin = new Padding(4, 5, 4, 5);
            Die1PictureBox.Name = "Die1PictureBox";
            Die1PictureBox.Size = new Size(71, 83);
            Die1PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die1PictureBox.TabIndex = 4;
            Die1PictureBox.TabStop = false;
            // 
            // Die2PictureBox
            // 
            Die2PictureBox.Image = Properties.Resources.dice1;
            Die2PictureBox.Location = new Point(100, 150);
            Die2PictureBox.Margin = new Padding(4, 5, 4, 5);
            Die2PictureBox.Name = "Die2PictureBox";
            Die2PictureBox.Size = new Size(71, 83);
            Die2PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die2PictureBox.TabIndex = 5;
            Die2PictureBox.TabStop = false;
            // 
            // Die3PictureBox
            // 
            Die3PictureBox.Image = Properties.Resources.dice1;
            Die3PictureBox.Location = new Point(186, 150);
            Die3PictureBox.Margin = new Padding(4, 5, 4, 5);
            Die3PictureBox.Name = "Die3PictureBox";
            Die3PictureBox.Size = new Size(71, 83);
            Die3PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die3PictureBox.TabIndex = 6;
            Die3PictureBox.TabStop = false;
            // 
            // Die4PictureBox
            // 
            Die4PictureBox.Image = Properties.Resources.dice1;
            Die4PictureBox.Location = new Point(271, 150);
            Die4PictureBox.Margin = new Padding(4, 5, 4, 5);
            Die4PictureBox.Name = "Die4PictureBox";
            Die4PictureBox.Size = new Size(71, 83);
            Die4PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die4PictureBox.TabIndex = 7;
            Die4PictureBox.TabStop = false;
            // 
            // Die5PictureBox
            // 
            Die5PictureBox.Image = Properties.Resources.dice1;
            Die5PictureBox.Location = new Point(357, 150);
            Die5PictureBox.Margin = new Padding(4, 5, 4, 5);
            Die5PictureBox.Name = "Die5PictureBox";
            Die5PictureBox.Size = new Size(71, 83);
            Die5PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die5PictureBox.TabIndex = 8;
            Die5PictureBox.TabStop = false;
            // 
            // RollDiceButton
            // 
            RollDiceButton.Location = new Point(14, 267);
            RollDiceButton.Margin = new Padding(4, 5, 4, 5);
            RollDiceButton.Name = "RollDiceButton";
            RollDiceButton.Size = new Size(107, 38);
            RollDiceButton.TabIndex = 9;
            RollDiceButton.Text = "Roll Dice";
            RollDiceButton.UseVisualStyleBackColor = true;
            // 
            // EndTurnButton
            // 
            EndTurnButton.Location = new Point(171, 267);
            EndTurnButton.Margin = new Padding(4, 5, 4, 5);
            EndTurnButton.Name = "EndTurnButton";
            EndTurnButton.Size = new Size(107, 38);
            EndTurnButton.TabIndex = 10;
            EndTurnButton.Text = "End Turn";
            EndTurnButton.UseVisualStyleBackColor = true;
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(329, 267);
            NewGameButton.Margin = new Padding(4, 5, 4, 5);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(107, 38);
            NewGameButton.TabIndex = 11;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            // 
            // SaveGameButton
            // 
            SaveGameButton.Location = new Point(484, 483);
            SaveGameButton.Margin = new Padding(4, 5, 4, 5);
            SaveGameButton.Name = "SaveGameButton";
            SaveGameButton.Size = new Size(107, 38);
            SaveGameButton.TabIndex = 12;
            SaveGameButton.Text = "Save";
            SaveGameButton.UseVisualStyleBackColor = true;
            // 
            // LoadGameButton
            // 
            LoadGameButton.Location = new Point(484, 594);
            LoadGameButton.Margin = new Padding(4, 5, 4, 5);
            LoadGameButton.Name = "LoadGameButton";
            LoadGameButton.Size = new Size(107, 38);
            LoadGameButton.TabIndex = 13;
            LoadGameButton.Text = "Load";
            LoadGameButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            SettingsButton.Location = new Point(484, 703);
            SettingsButton.Margin = new Padding(4, 5, 4, 5);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(107, 38);
            SettingsButton.TabIndex = 14;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            // 
            // ScorecardGridView
            // 
            ScorecardGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScorecardGridView.Columns.AddRange(new DataGridViewColumn[] { Category, User, Computer });
            ScorecardGridView.Location = new Point(13, 368);
            ScorecardGridView.Margin = new Padding(4, 5, 4, 5);
            ScorecardGridView.Name = "ScorecardGridView";
            ScorecardGridView.RowHeadersVisible = false;
            ScorecardGridView.RowHeadersWidth = 62;
            ScorecardGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ScorecardGridView.Size = new Size(462, 604);
            ScorecardGridView.TabIndex = 15;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.Width = 150;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 150;
            // 
            // Computer
            // 
            Computer.HeaderText = "Computer";
            Computer.MinimumWidth = 8;
            Computer.Name = "Computer";
            Computer.ReadOnly = true;
            Computer.Width = 150;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(24, 24);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { MainStatusLabel });
            MainStatusStrip.Location = new Point(0, 977);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Padding = new Padding(1, 0, 20, 0);
            MainStatusStrip.Size = new Size(617, 32);
            MainStatusStrip.TabIndex = 16;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // MainStatusLabel
            // 
            MainStatusLabel.Name = "MainStatusLabel";
            MainStatusLabel.Size = new Size(140, 25);
            MainStatusLabel.Text = "MainStatusLabel";
            // 
            // RulesButton
            // 
            RulesButton.Location = new Point(484, 368);
            RulesButton.Margin = new Padding(4, 5, 4, 5);
            RulesButton.Name = "RulesButton";
            RulesButton.Size = new Size(107, 38);
            RulesButton.TabIndex = 17;
            RulesButton.Text = "Rules";
            RulesButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(482, 808);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 1009);
            Controls.Add(ExitButton);
            Controls.Add(RulesButton);
            Controls.Add(MainStatusStrip);
            Controls.Add(ScorecardGridView);
            Controls.Add(SettingsButton);
            Controls.Add(LoadGameButton);
            Controls.Add(SaveGameButton);
            Controls.Add(NewGameButton);
            Controls.Add(EndTurnButton);
            Controls.Add(RollDiceButton);
            Controls.Add(Die5PictureBox);
            Controls.Add(Die4PictureBox);
            Controls.Add(Die3PictureBox);
            Controls.Add(Die2PictureBox);
            Controls.Add(Die1PictureBox);
            Controls.Add(StatusLabel);
            Controls.Add(CurrentPlayerLabel);
            Controls.Add(RollCountLabel);
            Controls.Add(InstructionsLabel);
            Name = "Form1";
            Text = "Yahtzee";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Die1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Die2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Die3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Die4PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Die5PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScorecardGridView).EndInit();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InstructionsLabel;
        private Label RollCountLabel;
        private Label CurrentPlayerLabel;
        private Label StatusLabel;
        private PictureBox Die1PictureBox;
        private PictureBox Die2PictureBox;
        private PictureBox Die3PictureBox;
        private PictureBox Die4PictureBox;
        private PictureBox Die5PictureBox;
        private Button RollDiceButton;
        private Button EndTurnButton;
        private Button NewGameButton;
        private Button SaveGameButton;
        private Button LoadGameButton;
        private Button SettingsButton;
        private DataGridView ScorecardGridView;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Computer;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel MainStatusLabel;
        private Button RulesButton;
        private Button ExitButton;
    }
}

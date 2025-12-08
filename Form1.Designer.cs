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
            InstructionsLabel.Location = new Point(10, 10);
            InstructionsLabel.Name = "InstructionsLabel";
            InstructionsLabel.Size = new Size(50, 15);
            InstructionsLabel.TabIndex = 0;
            InstructionsLabel.Text = "Yahtzee!";
            // 
            // RollCountLabel
            // 
            RollCountLabel.AutoSize = true;
            RollCountLabel.Location = new Point(10, 50);
            RollCountLabel.Name = "RollCountLabel";
            RollCountLabel.Size = new Size(50, 15);
            RollCountLabel.TabIndex = 1;
            RollCountLabel.Text = "Roll: 0/3";
            // 
            // CurrentPlayerLabel
            // 
            CurrentPlayerLabel.AutoSize = true;
            CurrentPlayerLabel.Location = new Point(120, 50);
            CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            CurrentPlayerLabel.Size = new Size(68, 15);
            CurrentPlayerLabel.TabIndex = 2;
            CurrentPlayerLabel.Text = "Player: User";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(10, 443);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status";
            // 
            // Die1PictureBox
            // 
            Die1PictureBox.Image = Properties.Resources.dice1;
            Die1PictureBox.Location = new Point(10, 90);
            Die1PictureBox.Name = "Die1PictureBox";
            Die1PictureBox.Size = new Size(50, 50);
            Die1PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die1PictureBox.TabIndex = 4;
            Die1PictureBox.TabStop = false;
            // 
            // Die2PictureBox
            // 
            Die2PictureBox.Image = Properties.Resources.dice1;
            Die2PictureBox.Location = new Point(70, 90);
            Die2PictureBox.Name = "Die2PictureBox";
            Die2PictureBox.Size = new Size(50, 50);
            Die2PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die2PictureBox.TabIndex = 5;
            Die2PictureBox.TabStop = false;
            // 
            // Die3PictureBox
            // 
            Die3PictureBox.Image = Properties.Resources.dice1;
            Die3PictureBox.Location = new Point(130, 90);
            Die3PictureBox.Name = "Die3PictureBox";
            Die3PictureBox.Size = new Size(50, 50);
            Die3PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die3PictureBox.TabIndex = 6;
            Die3PictureBox.TabStop = false;
            // 
            // Die4PictureBox
            // 
            Die4PictureBox.Image = Properties.Resources.dice1;
            Die4PictureBox.Location = new Point(190, 90);
            Die4PictureBox.Name = "Die4PictureBox";
            Die4PictureBox.Size = new Size(50, 50);
            Die4PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die4PictureBox.TabIndex = 7;
            Die4PictureBox.TabStop = false;
            // 
            // Die5PictureBox
            // 
            Die5PictureBox.Image = Properties.Resources.dice1;
            Die5PictureBox.Location = new Point(250, 90);
            Die5PictureBox.Name = "Die5PictureBox";
            Die5PictureBox.Size = new Size(50, 50);
            Die5PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Die5PictureBox.TabIndex = 8;
            Die5PictureBox.TabStop = false;
            // 
            // RollDiceButton
            // 
            RollDiceButton.Location = new Point(10, 160);
            RollDiceButton.Name = "RollDiceButton";
            RollDiceButton.Size = new Size(75, 23);
            RollDiceButton.TabIndex = 9;
            RollDiceButton.Text = "Roll Dice";
            RollDiceButton.UseVisualStyleBackColor = true;
            // 
            // EndTurnButton
            // 
            EndTurnButton.Location = new Point(120, 160);
            EndTurnButton.Name = "EndTurnButton";
            EndTurnButton.Size = new Size(75, 23);
            EndTurnButton.TabIndex = 10;
            EndTurnButton.Text = "End Turn";
            EndTurnButton.UseVisualStyleBackColor = true;
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(230, 160);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(75, 23);
            NewGameButton.TabIndex = 11;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            // 
            // SaveGameButton
            // 
            SaveGameButton.Location = new Point(339, 278);
            SaveGameButton.Name = "SaveGameButton";
            SaveGameButton.Size = new Size(75, 23);
            SaveGameButton.TabIndex = 12;
            SaveGameButton.Text = "Save";
            SaveGameButton.UseVisualStyleBackColor = true;
            // 
            // LoadGameButton
            // 
            LoadGameButton.Location = new Point(339, 351);
            LoadGameButton.Name = "LoadGameButton";
            LoadGameButton.Size = new Size(75, 23);
            LoadGameButton.TabIndex = 13;
            LoadGameButton.Text = "Load";
            LoadGameButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            SettingsButton.Location = new Point(339, 417);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(75, 23);
            SettingsButton.TabIndex = 14;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            // 
            // ScorecardGridView
            // 
            ScorecardGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScorecardGridView.Columns.AddRange(new DataGridViewColumn[] { Category, User, Computer });
            ScorecardGridView.Location = new Point(10, 210);
            ScorecardGridView.Name = "ScorecardGridView";
            ScorecardGridView.RowHeadersVisible = false;
            ScorecardGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ScorecardGridView.Size = new Size(303, 230);
            ScorecardGridView.TabIndex = 15;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            // 
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            // 
            // Computer
            // 
            Computer.HeaderText = "Computer";
            Computer.Name = "Computer";
            Computer.ReadOnly = true;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { MainStatusLabel });
            MainStatusStrip.Location = new Point(0, 467);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(422, 22);
            MainStatusStrip.TabIndex = 16;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // MainStatusLabel
            // 
            MainStatusLabel.Name = "MainStatusLabel";
            MainStatusLabel.Size = new Size(94, 17);
            MainStatusLabel.Text = "MainStatusLabel";
            // 
            // RulesButton
            // 
            RulesButton.Location = new Point(339, 210);
            RulesButton.Name = "RulesButton";
            RulesButton.Size = new Size(75, 23);
            RulesButton.TabIndex = 17;
            RulesButton.Text = "Rules";
            RulesButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 489);
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
            Margin = new Padding(2);
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
    }
}

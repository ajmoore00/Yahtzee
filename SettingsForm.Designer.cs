namespace Yahtzee
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            JokerRulesCheckBox = new CheckBox();
            BonusYahtzeeCheckBox = new CheckBox();
            PlayerNameLabel = new Label();
            PlayerNameTextBox = new TextBox();
            ComDifficultyLabel = new Label();
            ComDifficultyComboBox = new ComboBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // JokerRulesCheckBox
            // 
            JokerRulesCheckBox.AutoSize = true;
            JokerRulesCheckBox.Location = new Point(20, 20);
            JokerRulesCheckBox.Name = "JokerRulesCheckBox";
            JokerRulesCheckBox.Size = new Size(101, 19);
            JokerRulesCheckBox.TabIndex = 0;
            JokerRulesCheckBox.Text = "Ones Are Wild";
            JokerRulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // BonusYahtzeeCheckBox
            // 
            BonusYahtzeeCheckBox.AutoSize = true;
            BonusYahtzeeCheckBox.Location = new Point(20, 55);
            BonusYahtzeeCheckBox.Name = "BonusYahtzeeCheckBox";
            BonusYahtzeeCheckBox.Size = new Size(140, 19);
            BonusYahtzeeCheckBox.TabIndex = 1;
            BonusYahtzeeCheckBox.Text = "Enable Bonus Yahtzee";
            BonusYahtzeeCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Location = new Point(20, 100);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(77, 15);
            PlayerNameLabel.TabIndex = 2;
            PlayerNameLabel.Text = "Player Name:";
            // 
            // PlayerNameTextBox
            // 
            PlayerNameTextBox.Location = new Point(103, 97);
            PlayerNameTextBox.Name = "PlayerNameTextBox";
            PlayerNameTextBox.Size = new Size(150, 23);
            PlayerNameTextBox.TabIndex = 3;
            // 
            // ComDifficultyLabel
            // 
            ComDifficultyLabel.AutoSize = true;
            ComDifficultyLabel.Location = new Point(20, 140);
            ComDifficultyLabel.Name = "ComDifficultyLabel";
            ComDifficultyLabel.Size = new Size(115, 15);
            ComDifficultyLabel.TabIndex = 4;
            ComDifficultyLabel.Text = "Computer Difficulty:";
            // 
            // ComDifficultyComboBox
            // 
            ComDifficultyComboBox.FormattingEnabled = true;
            ComDifficultyComboBox.Items.AddRange(new object[] { "Easy", "Normal", "Hard" });
            ComDifficultyComboBox.Location = new Point(141, 137);
            ComDifficultyComboBox.Name = "ComDifficultyComboBox";
            ComDifficultyComboBox.Size = new Size(121, 23);
            ComDifficultyComboBox.TabIndex = 5;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(40, 190);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(140, 190);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 258);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(ComDifficultyComboBox);
            Controls.Add(ComDifficultyLabel);
            Controls.Add(PlayerNameTextBox);
            Controls.Add(PlayerNameLabel);
            Controls.Add(BonusYahtzeeCheckBox);
            Controls.Add(JokerRulesCheckBox);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox JokerRulesCheckBox;
        private CheckBox BonusYahtzeeCheckBox;
        private Label PlayerNameLabel;
        private TextBox PlayerNameTextBox;
        private Label ComDifficultyLabel;
        private ComboBox ComDifficultyComboBox;
        private Button SaveButton;
        private Button CancelButton;
    }
}
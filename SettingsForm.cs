using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class SettingsForm : Form
    {
        // Properties to expose settings to main form
        public bool JokerRulesEnabled => JokerRulesCheckBox.Checked;
        public bool BonusYahtzeeEnabled => BonusYahtzeeCheckBox.Checked;
        public string PlayerName => PlayerNameTextBox.Text.Trim();
        public string ComDifficulty => ComDifficultyComboBox.SelectedItem?.ToString() ?? "Normal";

        public SettingsForm()
        {
            InitializeComponent();

            // Set default values
            JokerRulesCheckBox.Checked = false;
            BonusYahtzeeCheckBox.Checked = false;
            ComDifficultyComboBox.Items.AddRange(new[] { "Easy", "Normal", "Hard" });
            ComDifficultyComboBox.SelectedIndex = 1; // Default to Normal

            // Save and Cancel button events
            SaveButton.Click += SaveButton_Click;
            CancelButton.Click += (s, e) => this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // You can add validation here if needed
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

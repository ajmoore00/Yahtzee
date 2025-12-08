namespace Yahtzee
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            RulesTextBox = new TextBox();
            SuspendLayout();
            // 
            // RulesTextBox
            // 
            RulesTextBox.Dock = DockStyle.Fill;
            RulesTextBox.Location = new Point(0, 0);
            RulesTextBox.Multiline = true;
            RulesTextBox.Name = "RulesTextBox";
            RulesTextBox.ReadOnly = true;
            RulesTextBox.ScrollBars = ScrollBars.Vertical;
            RulesTextBox.Size = new Size(399, 401);
            RulesTextBox.TabIndex = 0;
            RulesTextBox.Text = resources.GetString("RulesTextBox.Text");
            // 
            // RulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 401);
            Controls.Add(RulesTextBox);
            Name = "RulesForm";
            Text = "RulesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RulesTextBox;
    }
}
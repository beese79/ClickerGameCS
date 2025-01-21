using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        private bool buttonLocked = false; // Flag to prevent rapid clicks
        private readonly int lockDuration = 112; // Milliseconds to lock button after click

        public Form1()
        {
            InitializeComponent();
            StartAutoUpdateLoop();
            this.AcceptButton = null; // Disable Enter key triggering the ButtonMain
            UpdateMultiplierCostLabel(); // Initialize multiplier cost label when form loads
        }

        // Declared starting variables for score, autoclickers, multiplier, and cost of multiplier
        public int Score = 0;
        public bool HasAuto = false;
        public bool HasAuto2 = false;
        public bool DebugMode = false;
        public int Multiplier = 1; // Starting multiplier
        public int MultiplierCost = 50; // Initial cost for the multiplier

        private async void ButtonMain_Click(object sender, EventArgs e)
        {
            if (buttonLocked) return; // Ignore the click if button is locked

            buttonLocked = true; // Lock the button to prevent rapid clicking

            // Apply the multiplier to the score
            Score += Multiplier;
            UpdateScoreLabel();

            await Task.Delay(lockDuration); // Wait before allowing the next click
            buttonLocked = false; // Unlock the button
        }

        private void ButtonAutoBuy_Click(object sender, EventArgs e)
        {
            if (HasAuto || HasAuto2)
            {
                LabelAutoInfo.Text = "already purchased";
                MessageBox.Show("You have already purchased the autoclicker.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Score >= 150)
            {
                MessageBox.Show("Autoclicker purchased!", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HasAuto = true;
                Score -= 150;
                UpdateScoreLabel();
            }
            else
            {
                MessageBox.Show("Your funds are insufficient. You have not been charged.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMultBuy_Click(object sender, EventArgs e)
        {
            // Check if player has enough score to buy the multiplier
            if (Score >= MultiplierCost)
            {
                Multiplier += 1; // Increase the multiplier
                Score -= MultiplierCost; // Deduct the cost from the score

                // Increase the multiplier cost for the next purchase (e.g., double the cost each time)
                MultiplierCost *= 2;

                MessageBox.Show($"Multiplier increased! New multiplier: x{Multiplier}", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateScoreLabel();
                UpdateMultiplierCostLabel(); // Update the multiplier cost label after purchase
            }
            else
            {
                MessageBox.Show("Your funds are insufficient. You have not been charged.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDebugScore_Click(object sender, EventArgs e)
        {
            Score += 1000;
            UpdateScoreLabel();
        }

        // Updates the score label to reflect the current score
        private void UpdateScoreLabel()
        {
            LabelScoreNum.Text = $"{Score}";
            LabelMultNum.Text = $"{Multiplier}";
        }

        // Updates the multiplier cost label to reflect the current multiplier cost
        private void UpdateMultiplierCostLabel()
        {
            LabelMultInfo.Text = $"{MultiplierCost} score required";
        }

        private async void StartAutoUpdateLoop()
        {
            while (true)
            {
                if (HasAuto)
                {
                    LabelAuto2.Show();
                    LabelAutoInfo2.Show();
                    ButtonAuto2Buy.Show();
                    await Task.Delay(1000);
                    Score += 1 * Multiplier; // Apply the multiplier to autoclicker gains
                    UpdateScoreLabel();
                }
                else if (HasAuto2)
                {
                    await Task.Delay(300);
                    Score += 1 * Multiplier; // Apply the multiplier to autoclicker gains
                    UpdateScoreLabel();
                }
                else
                {
                    await Task.Delay(100);
                }

                
            }

        }
        /* GPT messed up my code, DO NOT TOUCH ANYTHING PAST THIS LINE (unless I do something with it, which I probably won't)
        * (this causes the debug menu to not function, I'll do something about that)
        */

        private void ButtonAuto2Buy_Click(object sender, EventArgs e)
        {
            if (HasAuto2)
            {
                MessageBox.Show("You have already purchased the autoclicker.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Score >= 350)
            {
                MessageBox.Show("Autoclicker purchased!", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HasAuto = false;
                HasAuto2 = true;
                LabelAutoInfo2.Text = "already purchased";
                Score -= 350;
                UpdateScoreLabel();
            }
            else
            {
                MessageBox.Show("Your funds are insufficient. You have not been charged.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDebugAuto2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autoclicker purchased!", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HasAuto = false;
            HasAuto2 = true;
        }

        private void ButtonDebugAuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autoclicker purchased!", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HasAuto = true;
        }

        private void LabelAuto2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

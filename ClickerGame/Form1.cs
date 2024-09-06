using System;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
I'm working on some comments throughout the code, just give me some time or ask me about certain stuff if you need to know what something does =D

Feel free to also add any comments, issues, suggestions, etc down here as well, or state so on the GitHub repository

New contributors, PLEASE create your own branch when making commits for the first time, so if anything goes wrong, we can revert back to main
Just common sense ;)
*/

/*

Put general ideas under this line
********************************************************************
e.g. Scrap GUI debug menu and add debug options into output console?
/this is a real idea btw/
********************************************************************

*/
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
            this.AcceptButton = null; // Disable Enter key triggering the ButtonMain; players can't spam button
        }

        // Declared starting variables for score, autoclickers 1 and 2, and more to come
        public int Score = 0;
        public bool HasAuto = false;
        public bool HasAuto2 = false;

        private async void ButtonMain_Click(object sender, EventArgs e) // Code for main button
        {
            if (buttonLocked) return; // Ignore the click if button is locked

            buttonLocked = true; // Lock the button to prevent rapid clicking
            Score += 1;
            UpdateScoreLabel();

            await Task.Delay(lockDuration); // Wait before allowing the next click
            buttonLocked = false; // Unlock the button
        }

        private void ButtonAutoBuy_Click(object sender, EventArgs e) // Purchase button for lvl 1 autoclicker
        {
            if (HasAuto || HasAuto2)
            {
                MessageBox.Show("You have already purchased the autoclicker.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Score >= 150)
            {
                MessageBox.Show("Autoclicker purchased!", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HasAuto = true;
                LabelAutoInfo.Text = "already purchased";
                Score -= 150;
                UpdateScoreLabel();
            }
            else
            {
                MessageBox.Show("Your funds are insufficient. You have not been charged.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDebugAuto_Click(object sender, EventArgs e) // Button for autoclicker in debug menu
        {
            DialogResult DebugOptLvl1 = MessageBox.Show("Proceeding will not allow you to revert back to autoclicker 2, are you sure? (This is subject to change)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (DebugOptLvl1 == DialogResult.Yes && HasAuto2)
            {
                MessageBox.Show("You have been given autoclicker.", "Confirmation");
                HasAuto = true;
            }
            else
            {
                MessageBox.Show("Cancelled. You have not been given autoclicker.", "Confirmation");
            }
        }

        private void ButtonDebugScore_Click(object sender, EventArgs e) // Button for score giver in debug menu
        {
            Score += 1000;
            UpdateScoreLabel();
        }

        private void UpdateScoreLabel() // Process to update score label
        {
            LabelScoreNum.Text = Score.ToString();
        }

        private async void StartAutoUpdateLoop() // Updates process
        {
            while (true)
            {
                if (HasAuto) // Process for autoclicker 1
                {
                    await Task.Delay(1000);
                    Score += 1;
                    UpdateScoreLabel();
                    LabelAuto2.Show();
                    LabelAutoInfo2.Show();
                    ButtonAuto2Buy.Show();
                }
                else if (HasAuto2) // Process for autoclicker 2
                { 
                    await Task.Delay(500);
                    Score += 1;
                    UpdateScoreLabel();

                }
                else
                {
                    await Task.Delay(100);
                }
            }
        }

        private void LabelAuto2_Click(object sender, EventArgs e)
        {
            // DO NOT TOUCH, for some reason, code won't run without this
        }

        private void ButtonAuto2Buy_Click(object sender, EventArgs e) // Purchase button for lvl 2 autoclicker
        {
            if (HasAuto2)
            {
                MessageBox.Show("You have already purchased the autoclicker.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (HasAuto && Score > 349)
            {
                MessageBox.Show("Autoclicker level 2 purchased!", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HasAuto2 = true;
                HasAuto = false;
                LabelAutoInfo2.Text = "already purchased";
                Score -= 350;
            }
            else
            {
                MessageBox.Show("Your funds are insufficient. You have not been charged.", "Purchase Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDebugAuto2_Click(object sender, EventArgs e) // Button for autoclicker 2 in debug menu
        {
            DialogResult DebugOptLvl2 = MessageBox.Show("Proceeding will not allow you to purchase level 2 in the shop if hidden. Are you sure? (This does not apply if you already have autoclicker 2)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (DebugOptLvl2 == DialogResult.Yes)
            {
                MessageBox.Show("You have been given autoclicker 2.", "Confirmation");
                HasAuto2 = true;
            }
            else
            {
                MessageBox.Show("Cancelled. You have not been given autoclicker 2.", "Confirmation");
            }
        }
    }
}

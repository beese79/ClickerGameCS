namespace ClickerGame
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonMain = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonAuto2Buy = new System.Windows.Forms.Button();
            this.LabelAutoInfo2 = new System.Windows.Forms.Label();
            this.LabelAuto2 = new System.Windows.Forms.Label();
            this.ButtonAutoBuy = new System.Windows.Forms.Button();
            this.LabelAutoInfo = new System.Windows.Forms.Label();
            this.LabelAuto = new System.Windows.Forms.Label();
            this.LabelShopTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonDebugScore = new System.Windows.Forms.Button();
            this.ButtonDebugAuto = new System.Windows.Forms.Button();
            this.LabelDebugTitle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LabelBlueTitle = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelScoreNum = new System.Windows.Forms.Label();
            this.ButtonDebugAuto2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitle.Location = new System.Drawing.Point(201, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(281, 37);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "clicker game";
            // 
            // ButtonMain
            // 
            this.ButtonMain.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMain.Location = new System.Drawing.Point(263, 325);
            this.ButtonMain.Name = "ButtonMain";
            this.ButtonMain.Size = new System.Drawing.Size(157, 40);
            this.ButtonMain.TabIndex = 1;
            this.ButtonMain.Text = "click me";
            this.ButtonMain.UseVisualStyleBackColor = true;
            this.ButtonMain.Click += new System.EventHandler(this.ButtonMain_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 270);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGreen;
            this.tabPage1.Controls.Add(this.ButtonAuto2Buy);
            this.tabPage1.Controls.Add(this.LabelAutoInfo2);
            this.tabPage1.Controls.Add(this.LabelAuto2);
            this.tabPage1.Controls.Add(this.ButtonAutoBuy);
            this.tabPage1.Controls.Add(this.LabelAutoInfo);
            this.tabPage1.Controls.Add(this.LabelAuto);
            this.tabPage1.Controls.Add(this.LabelShopTitle);
            this.tabPage1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "shop";
            // 
            // ButtonAuto2Buy
            // 
            this.ButtonAuto2Buy.Location = new System.Drawing.Point(30, 163);
            this.ButtonAuto2Buy.Name = "ButtonAuto2Buy";
            this.ButtonAuto2Buy.Size = new System.Drawing.Size(75, 23);
            this.ButtonAuto2Buy.TabIndex = 6;
            this.ButtonAuto2Buy.Text = "purchase";
            this.ButtonAuto2Buy.UseVisualStyleBackColor = true;
            this.ButtonAuto2Buy.Visible = false;
            this.ButtonAuto2Buy.Click += new System.EventHandler(this.ButtonAuto2Buy_Click);
            // 
            // LabelAutoInfo2
            // 
            this.LabelAutoInfo2.AutoSize = true;
            this.LabelAutoInfo2.Location = new System.Drawing.Point(6, 147);
            this.LabelAutoInfo2.Name = "LabelAutoInfo2";
            this.LabelAutoInfo2.Size = new System.Drawing.Size(133, 13);
            this.LabelAutoInfo2.TabIndex = 5;
            this.LabelAutoInfo2.Text = "350 score required";
            this.LabelAutoInfo2.Visible = false;
            // 
            // LabelAuto2
            // 
            this.LabelAuto2.AutoSize = true;
            this.LabelAuto2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAuto2.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAuto2.Location = new System.Drawing.Point(12, 130);
            this.LabelAuto2.Name = "LabelAuto2";
            this.LabelAuto2.Size = new System.Drawing.Size(108, 17);
            this.LabelAuto2.TabIndex = 4;
            this.LabelAuto2.Text = "auto lvl 2";
            this.LabelAuto2.Visible = false;
            this.LabelAuto2.Click += new System.EventHandler(this.LabelAuto2_Click);
            // 
            // ButtonAutoBuy
            // 
            this.ButtonAutoBuy.Location = new System.Drawing.Point(30, 85);
            this.ButtonAutoBuy.Name = "ButtonAutoBuy";
            this.ButtonAutoBuy.Size = new System.Drawing.Size(75, 23);
            this.ButtonAutoBuy.TabIndex = 3;
            this.ButtonAutoBuy.Text = "purchase";
            this.ButtonAutoBuy.UseVisualStyleBackColor = true;
            this.ButtonAutoBuy.Click += new System.EventHandler(this.ButtonAutoBuy_Click);
            // 
            // LabelAutoInfo
            // 
            this.LabelAutoInfo.AutoSize = true;
            this.LabelAutoInfo.Location = new System.Drawing.Point(6, 69);
            this.LabelAutoInfo.Name = "LabelAutoInfo";
            this.LabelAutoInfo.Size = new System.Drawing.Size(133, 13);
            this.LabelAutoInfo.TabIndex = 2;
            this.LabelAutoInfo.Text = "150 score required";
            // 
            // LabelAuto
            // 
            this.LabelAuto.AutoSize = true;
            this.LabelAuto.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAuto.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelAuto.Location = new System.Drawing.Point(12, 52);
            this.LabelAuto.Name = "LabelAuto";
            this.LabelAuto.Size = new System.Drawing.Size(118, 17);
            this.LabelAuto.TabIndex = 1;
            this.LabelAuto.Text = "autoclicker";
            // 
            // LabelShopTitle
            // 
            this.LabelShopTitle.AutoSize = true;
            this.LabelShopTitle.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelShopTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelShopTitle.Location = new System.Drawing.Point(188, 0);
            this.LabelShopTitle.Name = "LabelShopTitle";
            this.LabelShopTitle.Size = new System.Drawing.Size(278, 25);
            this.LabelShopTitle.TabIndex = 0;
            this.LabelShopTitle.Text = "welcome to the shop";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Indigo;
            this.tabPage2.Controls.Add(this.ButtonDebugAuto2);
            this.tabPage2.Controls.Add(this.ButtonDebugScore);
            this.tabPage2.Controls.Add(this.ButtonDebugAuto);
            this.tabPage2.Controls.Add(this.LabelDebugTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "debug";
            // 
            // ButtonDebugScore
            // 
            this.ButtonDebugScore.Location = new System.Drawing.Point(6, 108);
            this.ButtonDebugScore.Name = "ButtonDebugScore";
            this.ButtonDebugScore.Size = new System.Drawing.Size(113, 23);
            this.ButtonDebugScore.TabIndex = 2;
            this.ButtonDebugScore.Text = "add score";
            this.ButtonDebugScore.UseVisualStyleBackColor = true;
            this.ButtonDebugScore.Click += new System.EventHandler(this.ButtonDebugScore_Click);
            // 
            // ButtonDebugAuto
            // 
            this.ButtonDebugAuto.Location = new System.Drawing.Point(6, 50);
            this.ButtonDebugAuto.Name = "ButtonDebugAuto";
            this.ButtonDebugAuto.Size = new System.Drawing.Size(113, 23);
            this.ButtonDebugAuto.TabIndex = 1;
            this.ButtonDebugAuto.Text = "give autoclicker";
            this.ButtonDebugAuto.UseVisualStyleBackColor = true;
            this.ButtonDebugAuto.Click += new System.EventHandler(this.ButtonDebugAuto_Click);
            // 
            // LabelDebugTitle
            // 
            this.LabelDebugTitle.AutoSize = true;
            this.LabelDebugTitle.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDebugTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelDebugTitle.Location = new System.Drawing.Point(112, 0);
            this.LabelDebugTitle.Name = "LabelDebugTitle";
            this.LabelDebugTitle.Size = new System.Drawing.Size(404, 25);
            this.LabelDebugTitle.TabIndex = 0;
            this.LabelDebugTitle.Text = "debug options for developers";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabPage3.Controls.Add(this.LabelBlueTitle);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(628, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // LabelBlueTitle
            // 
            this.LabelBlueTitle.AutoSize = true;
            this.LabelBlueTitle.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelBlueTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelBlueTitle.Location = new System.Drawing.Point(197, 0);
            this.LabelBlueTitle.Name = "LabelBlueTitle";
            this.LabelBlueTitle.Size = new System.Drawing.Size(250, 25);
            this.LabelBlueTitle.TabIndex = 0;
            this.LabelBlueTitle.Text = "placeholder label";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelScore.Location = new System.Drawing.Point(476, 342);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(38, 15);
            this.LabelScore.TabIndex = 3;
            this.LabelScore.Text = "score:";
            // 
            // LabelScoreNum
            // 
            this.LabelScoreNum.AutoSize = true;
            this.LabelScoreNum.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelScoreNum.Location = new System.Drawing.Point(520, 342);
            this.LabelScoreNum.Name = "LabelScoreNum";
            this.LabelScoreNum.Size = new System.Drawing.Size(13, 15);
            this.LabelScoreNum.TabIndex = 4;
            this.LabelScoreNum.Text = "0";
            // 
            // ButtonDebugAuto2
            // 
            this.ButtonDebugAuto2.Location = new System.Drawing.Point(6, 79);
            this.ButtonDebugAuto2.Name = "ButtonDebugAuto2";
            this.ButtonDebugAuto2.Size = new System.Drawing.Size(113, 23);
            this.ButtonDebugAuto2.TabIndex = 3;
            this.ButtonDebugAuto2.Text = "give autoclicker 2";
            this.ButtonDebugAuto2.UseVisualStyleBackColor = true;
            this.ButtonDebugAuto2.Click += new System.EventHandler(this.ButtonDebugAuto2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(683, 383);
            this.Controls.Add(this.LabelScoreNum);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ButtonMain);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Clicker Game";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelTitle;
        private Button ButtonMain;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label LabelShopTitle;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label LabelScore;
        private Label LabelScoreNum;
        private Button ButtonAutoBuy;
        private Label LabelAutoInfo;
        private Label LabelAuto;
        private Button ButtonDebugScore;
        private Button ButtonDebugAuto;
        private Label LabelDebugTitle;
        private Label LabelBlueTitle;
        private Button ButtonAuto2Buy;
        private Label LabelAutoInfo2;
        private Label LabelAuto2;
        private Button ButtonDebugAuto2;
    }
}
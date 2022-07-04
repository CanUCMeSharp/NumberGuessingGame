namespace NumberGuessingGame
{
    partial class MainWindow
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
            this.UOText = new System.Windows.Forms.Label();
            this.UILeadNav = new System.Windows.Forms.Button();
            this.UISetNav = new System.Windows.Forms.Button();
            this.UIStartBut = new System.Windows.Forms.Button();
            this.UIGuessBox = new System.Windows.Forms.TextBox();
            this.UIGuessBut = new System.Windows.Forms.Button();
            this.UOHighLowInidicator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UOText
            // 
            this.UOText.AutoSize = true;
            this.UOText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UOText.Location = new System.Drawing.Point(102, 51);
            this.UOText.Name = "UOText";
            this.UOText.Size = new System.Drawing.Size(564, 67);
            this.UOText.TabIndex = 0;
            this.UOText.Text = "Number Guessing Game";
            // 
            // UILeadNav
            // 
            this.UILeadNav.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UILeadNav.Location = new System.Drawing.Point(659, 160);
            this.UILeadNav.Name = "UILeadNav";
            this.UILeadNav.Size = new System.Drawing.Size(122, 42);
            this.UILeadNav.TabIndex = 3;
            this.UILeadNav.Text = "Leaderboard";
            this.UILeadNav.UseVisualStyleBackColor = false;
            // 
            // UISetNav
            // 
            this.UISetNav.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UISetNav.Location = new System.Drawing.Point(659, 112);
            this.UISetNav.Name = "UISetNav";
            this.UISetNav.Size = new System.Drawing.Size(122, 42);
            this.UISetNav.TabIndex = 4;
            this.UISetNav.Text = "Settings";
            this.UISetNav.UseVisualStyleBackColor = false;
            // 
            // UIStartBut
            // 
            this.UIStartBut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UIStartBut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UIStartBut.Location = new System.Drawing.Point(301, 388);
            this.UIStartBut.Name = "UIStartBut";
            this.UIStartBut.Size = new System.Drawing.Size(174, 50);
            this.UIStartBut.TabIndex = 5;
            this.UIStartBut.Text = "Start!";
            this.UIStartBut.UseVisualStyleBackColor = false;
            this.UIStartBut.Click += new System.EventHandler(this.UIStartBut_Click);
            // 
            // UIGuessBox
            // 
            this.UIGuessBox.Location = new System.Drawing.Point(307, 271);
            this.UIGuessBox.Name = "UIGuessBox";
            this.UIGuessBox.PlaceholderText = "Guess!";
            this.UIGuessBox.Size = new System.Drawing.Size(168, 27);
            this.UIGuessBox.TabIndex = 6;
            this.UIGuessBox.UseSystemPasswordChar = true;
            this.UIGuessBox.Visible = false;
            // 
            // UIGuessBut
            // 
            this.UIGuessBut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UIGuessBut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UIGuessBut.Location = new System.Drawing.Point(301, 321);
            this.UIGuessBut.Name = "UIGuessBut";
            this.UIGuessBut.Size = new System.Drawing.Size(174, 50);
            this.UIGuessBut.TabIndex = 7;
            this.UIGuessBut.Text = "Guess!";
            this.UIGuessBut.UseVisualStyleBackColor = false;
            this.UIGuessBut.Visible = false;
            this.UIGuessBut.Click += new System.EventHandler(this.UIGuessBut_Click);
            // 
            // UOHighLowInidicator
            // 
            this.UOHighLowInidicator.AutoSize = true;
            this.UOHighLowInidicator.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UOHighLowInidicator.Location = new System.Drawing.Point(102, 263);
            this.UOHighLowInidicator.Name = "UOHighLowInidicator";
            this.UOHighLowInidicator.Size = new System.Drawing.Size(0, 35);
            this.UOHighLowInidicator.TabIndex = 8;
            this.UOHighLowInidicator.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UOHighLowInidicator);
            this.Controls.Add(this.UIGuessBut);
            this.Controls.Add(this.UIGuessBox);
            this.Controls.Add(this.UIStartBut);
            this.Controls.Add(this.UISetNav);
            this.Controls.Add(this.UILeadNav);
            this.Controls.Add(this.UOText);
            this.Name = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UOText;
        private Button UILeadNav;
        private Button UISetNav;
        private Button UIStartBut;
        private TextBox UIGuessBox;
        private Button UIGuessBut;
        private Label UOHighLowInidicator;
    }
}
namespace NumberGuessingGame
{
    partial class Settings
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
            this.UIMinimum = new System.Windows.Forms.NumericUpDown();
            this.UIMaximum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UOPlayersTreeView = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UIPlayerName = new System.Windows.Forms.TextBox();
            this.UIAddBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UOAddPlayerErrorLabel = new System.Windows.Forms.Label();
            this.UIRemovePlayerBox = new System.Windows.Forms.ComboBox();
            this.UIRemoveBut = new System.Windows.Forms.Button();
            this.UISaveBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UIMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIMaximum)).BeginInit();
            this.SuspendLayout();
            // 
            // UIMinimum
            // 
            this.UIMinimum.Location = new System.Drawing.Point(180, 34);
            this.UIMinimum.Name = "UIMinimum";
            this.UIMinimum.Size = new System.Drawing.Size(50, 27);
            this.UIMinimum.TabIndex = 0;
            // 
            // UIMaximum
            // 
            this.UIMaximum.Location = new System.Drawing.Point(180, 65);
            this.UIMaximum.Name = "UIMaximum";
            this.UIMaximum.Size = new System.Drawing.Size(50, 27);
            this.UIMaximum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maximum Value";
            // 
            // UOPlayersTreeView
            // 
            this.UOPlayersTreeView.Location = new System.Drawing.Point(420, 65);
            this.UOPlayersTreeView.Name = "UOPlayersTreeView";
            this.UOPlayersTreeView.Size = new System.Drawing.Size(361, 241);
            this.UOPlayersTreeView.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(541, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Players";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add Player";
            // 
            // UIPlayerName
            // 
            this.UIPlayerName.Location = new System.Drawing.Point(180, 114);
            this.UIPlayerName.Name = "UIPlayerName";
            this.UIPlayerName.PlaceholderText = "Add Player";
            this.UIPlayerName.Size = new System.Drawing.Size(123, 27);
            this.UIPlayerName.TabIndex = 7;
            // 
            // UIAddBut
            // 
            this.UIAddBut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UIAddBut.Location = new System.Drawing.Point(327, 110);
            this.UIAddBut.Name = "UIAddBut";
            this.UIAddBut.Size = new System.Drawing.Size(87, 35);
            this.UIAddBut.TabIndex = 8;
            this.UIAddBut.Text = "Add";
            this.UIAddBut.UseVisualStyleBackColor = false;
            this.UIAddBut.Click += new System.EventHandler(this.UIAddBut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remove Player";
            // 
            // UOAddPlayerErrorLabel
            // 
            this.UOAddPlayerErrorLabel.AutoSize = true;
            this.UOAddPlayerErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UOAddPlayerErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.UOAddPlayerErrorLabel.Location = new System.Drawing.Point(180, 144);
            this.UOAddPlayerErrorLabel.Name = "UOAddPlayerErrorLabel";
            this.UOAddPlayerErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.UOAddPlayerErrorLabel.TabIndex = 10;
            // 
            // UIRemovePlayerBox
            // 
            this.UIRemovePlayerBox.FormattingEnabled = true;
            this.UIRemovePlayerBox.Location = new System.Drawing.Point(180, 193);
            this.UIRemovePlayerBox.Name = "UIRemovePlayerBox";
            this.UIRemovePlayerBox.Size = new System.Drawing.Size(123, 28);
            this.UIRemovePlayerBox.TabIndex = 11;
            // 
            // UIRemoveBut
            // 
            this.UIRemoveBut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UIRemoveBut.Location = new System.Drawing.Point(327, 193);
            this.UIRemoveBut.Name = "UIRemoveBut";
            this.UIRemoveBut.Size = new System.Drawing.Size(87, 35);
            this.UIRemoveBut.TabIndex = 12;
            this.UIRemoveBut.Text = "Remove";
            this.UIRemoveBut.UseVisualStyleBackColor = false;
            this.UIRemoveBut.Click += new System.EventHandler(this.UIRemoveBut_Click);
            // 
            // UISaveBut
            // 
            this.UISaveBut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UISaveBut.Location = new System.Drawing.Point(26, 262);
            this.UISaveBut.Name = "UISaveBut";
            this.UISaveBut.Size = new System.Drawing.Size(103, 44);
            this.UISaveBut.TabIndex = 13;
            this.UISaveBut.Text = "Save";
            this.UISaveBut.UseVisualStyleBackColor = false;
            this.UISaveBut.Click += new System.EventHandler(this.UISaveBut_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.UISaveBut);
            this.Controls.Add(this.UIRemoveBut);
            this.Controls.Add(this.UIRemovePlayerBox);
            this.Controls.Add(this.UOAddPlayerErrorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UIAddBut);
            this.Controls.Add(this.UIPlayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UOPlayersTreeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UIMaximum);
            this.Controls.Add(this.UIMinimum);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.UIMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIMaximum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown UIMinimum;
        private NumericUpDown UIMaximum;
        private Label label1;
        private Label label2;
        private TreeView UOPlayersTreeView;
        private Label label3;
        private Label label4;
        private TextBox UIPlayerName;
        private Button UIAddBut;
        private Label label5;
        private Label UOAddPlayerErrorLabel;
        private ComboBox UIRemovePlayerBox;
        private Button UIRemoveBut;
        private Button UISaveBut;
    }
}
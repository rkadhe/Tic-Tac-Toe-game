namespace Tic_Tac_Toe
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B1 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.X_Score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.O_Score = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetScoreToolStripMenuItem,
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(706, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(144, 36);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetScoreToolStripMenuItem
            // 
            this.resetScoreToolStripMenuItem.Name = "resetScoreToolStripMenuItem";
            this.resetScoreToolStripMenuItem.Size = new System.Drawing.Size(150, 36);
            this.resetScoreToolStripMenuItem.Text = "Reset Score";
            this.resetScoreToolStripMenuItem.Click += new System.EventHandler(this.resetScoreToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(26, 158);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(207, 155);
            this.B1.TabIndex = 1;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.clickbutton);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B4.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(26, 319);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(207, 155);
            this.B4.TabIndex = 2;
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.clickbutton);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B7.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.Location = new System.Drawing.Point(26, 480);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(207, 155);
            this.B7.TabIndex = 3;
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Click += new System.EventHandler(this.clickbutton);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(239, 158);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(207, 155);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.clickbutton);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B5.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.Location = new System.Drawing.Point(239, 319);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(207, 155);
            this.B5.TabIndex = 5;
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.clickbutton);
            // 
            // B8
            // 
            this.B8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B8.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.Location = new System.Drawing.Point(239, 480);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(207, 155);
            this.B8.TabIndex = 6;
            this.B8.UseVisualStyleBackColor = false;
            this.B8.Click += new System.EventHandler(this.clickbutton);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(452, 158);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(207, 155);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.clickbutton);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B6.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.Location = new System.Drawing.Point(452, 319);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(207, 155);
            this.B6.TabIndex = 8;
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.clickbutton);
            // 
            // B9
            // 
            this.B9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.B9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B9.Font = new System.Drawing.Font("Goudy Old Style", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.Location = new System.Drawing.Point(452, 480);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(207, 155);
            this.B9.TabIndex = 9;
            this.B9.UseVisualStyleBackColor = false;
            this.B9.Click += new System.EventHandler(this.clickbutton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 76);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score X";
            // 
            // X_Score
            // 
            this.X_Score.AutoSize = true;
            this.X_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_Score.Location = new System.Drawing.Point(112, 104);
            this.X_Score.Name = "X_Score";
            this.X_Score.Size = new System.Drawing.Size(39, 42);
            this.X_Score.TabIndex = 11;
            this.X_Score.Text = "0";
            this.X_Score.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 76);
            this.label3.TabIndex = 12;
            this.label3.Text = "Score O";
            // 
            // O_Score
            // 
            this.O_Score.AutoSize = true;
            this.O_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_Score.Location = new System.Drawing.Point(531, 104);
            this.O_Score.Name = "O_Score";
            this.O_Score.Size = new System.Drawing.Size(39, 42);
            this.O_Score.TabIndex = 13;
            this.O_Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 655);
            this.Controls.Add(this.O_Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.X_Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label X_Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label O_Score;
    }
}


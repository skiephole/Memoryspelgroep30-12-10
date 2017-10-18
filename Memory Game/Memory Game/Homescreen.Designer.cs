namespace Memory_Game
{
    partial class Homescreen
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
            this.Start = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.HighScores = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Themes = new System.Windows.Forms.Button();
            this.titel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.PaleGreen;
            this.Start.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(267, 99);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(267, 53);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.IndianRed;
            this.Quit.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(608, 375);
            this.Quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(133, 45);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // HighScores
            // 
            this.HighScores.BackColor = System.Drawing.Color.PaleGreen;
            this.HighScores.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScores.Location = new System.Drawing.Point(267, 275);
            this.HighScores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HighScores.Name = "HighScores";
            this.HighScores.Size = new System.Drawing.Size(267, 53);
            this.HighScores.TabIndex = 2;
            this.HighScores.Text = "HighScores";
            this.HighScores.UseVisualStyleBackColor = false;
            this.HighScores.Click += new System.EventHandler(this.HighScores_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.PaleGreen;
            this.Continue.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(267, 183);
            this.Continue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(267, 53);
            this.Continue.TabIndex = 3;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            // 
            // Themes
            // 
            this.Themes.BackColor = System.Drawing.Color.PaleGreen;
            this.Themes.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Themes.Location = new System.Drawing.Point(267, 367);
            this.Themes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Themes.Name = "Themes";
            this.Themes.Size = new System.Drawing.Size(267, 53);
            this.Themes.TabIndex = 4;
            this.Themes.Text = "Themes";
            this.Themes.UseVisualStyleBackColor = false;
            this.Themes.Click += new System.EventHandler(this.Themes_Click);
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Corbel", 42F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(252, 9);
            this.titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(282, 86);
            this.titel.TabIndex = 5;
            this.titel.Text = "Memory";
            // 
            // Homescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.Themes);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.HighScores);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Start);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Homescreen";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button HighScores;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Themes;
        private System.Windows.Forms.Label titel;
    }
}


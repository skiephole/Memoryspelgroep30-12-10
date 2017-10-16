namespace Memory_Game
{
    partial class HomescreenThemes
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
            this.Theme1 = new System.Windows.Forms.Label();
            this.Theme2 = new System.Windows.Forms.Label();
            this.Theme3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Titel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Theme1
            // 
            this.Theme1.AutoSize = true;
            this.Theme1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.Theme1.Location = new System.Drawing.Point(167, 111);
            this.Theme1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Theme1.Name = "Theme1";
            this.Theme1.Size = new System.Drawing.Size(119, 35);
            this.Theme1.TabIndex = 0;
            this.Theme1.Text = "Theme 1";
            // 
            // Theme2
            // 
            this.Theme2.AutoSize = true;
            this.Theme2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.Theme2.Location = new System.Drawing.Point(167, 203);
            this.Theme2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Theme2.Name = "Theme2";
            this.Theme2.Size = new System.Drawing.Size(122, 35);
            this.Theme2.TabIndex = 1;
            this.Theme2.Text = "Theme 2";
            // 
            // Theme3
            // 
            this.Theme3.AutoSize = true;
            this.Theme3.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.Theme3.Location = new System.Drawing.Point(167, 295);
            this.Theme3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Theme3.Name = "Theme3";
            this.Theme3.Size = new System.Drawing.Size(122, 35);
            this.Theme3.TabIndex = 2;
            this.Theme3.Text = "Theme 3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(385, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 203);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Meme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 295);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pokemon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Monotype Corsiva", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Titel.Location = new System.Drawing.Point(267, 18);
            this.Titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(220, 84);
            this.Titel.TabIndex = 6;
            this.Titel.Text = "Themes";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PaleGreen;
            this.Back.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(267, 369);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(267, 49);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // HomescreenThemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Theme3);
            this.Controls.Add(this.Theme2);
            this.Controls.Add(this.Theme1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomescreenThemes";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Theme1;
        private System.Windows.Forms.Label Theme2;
        private System.Windows.Forms.Label Theme3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Button Back;
    }
}
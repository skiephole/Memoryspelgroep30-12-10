namespace Memory_Game
{
    partial class HomescreenHighscores
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
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PaleGreen;
            this.Back.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(200, 300);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(200, 40);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // HomescreenHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Back);
            this.Name = "HomescreenHighscores";
            this.Text = "Memory Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
    }
}
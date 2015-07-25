namespace ProgrammingChallenge
{
    partial class PlayLevel
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
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEasy
            // 
            this.buttonEasy.Location = new System.Drawing.Point(72, 57);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(138, 32);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.Location = new System.Drawing.Point(72, 132);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(138, 30);
            this.buttonHard.TabIndex = 2;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(25, 217);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PlayLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgrammingChallenge.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonEasy);
            this.MaximizeBox = false;
            this.Name = "PlayLevel";
            this.Text = "Level";
            this.Load += new System.EventHandler(this.PlayLevel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonMenu;
    }
}
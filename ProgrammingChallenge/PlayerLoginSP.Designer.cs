namespace ProgrammingChallenge
{
    partial class PlayerLoginSP
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Player Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(197, 163);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(22, 163);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Menu";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PlayerLoginSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.Name = "PlayerLoginSP";
            this.Text = "Player Login";
            this.Load += new System.EventHandler(this.PlayerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonBack;
    }
}
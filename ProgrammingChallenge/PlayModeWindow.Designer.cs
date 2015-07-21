namespace ProgrammingChallenge
{
    partial class PlayModeWindow
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
            this.buttonSinglePlayer = new System.Windows.Forms.Button();
            this.buttonTwoPlayer = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSinglePlayer
            // 
            this.buttonSinglePlayer.Location = new System.Drawing.Point(61, 49);
            this.buttonSinglePlayer.Name = "buttonSinglePlayer";
            this.buttonSinglePlayer.Size = new System.Drawing.Size(153, 31);
            this.buttonSinglePlayer.TabIndex = 0;
            this.buttonSinglePlayer.Text = "Single Player";
            this.buttonSinglePlayer.UseVisualStyleBackColor = true;
            this.buttonSinglePlayer.Click += new System.EventHandler(this.buttonSinglePlayer_Click);
            // 
            // buttonTwoPlayer
            // 
            this.buttonTwoPlayer.Location = new System.Drawing.Point(61, 111);
            this.buttonTwoPlayer.Name = "buttonTwoPlayer";
            this.buttonTwoPlayer.Size = new System.Drawing.Size(153, 33);
            this.buttonTwoPlayer.TabIndex = 1;
            this.buttonTwoPlayer.Text = "Two Player";
            this.buttonTwoPlayer.UseVisualStyleBackColor = true;
            this.buttonTwoPlayer.Click += new System.EventHandler(this.buttonTwoPlayer_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(61, 170);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(153, 33);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // PlayModeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonTwoPlayer);
            this.Controls.Add(this.buttonSinglePlayer);
            this.MaximizeBox = false;
            this.Name = "PlayModeWindow";
            this.Text = "Play Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSinglePlayer;
        private System.Windows.Forms.Button buttonTwoPlayer;
        private System.Windows.Forms.Button buttonExit;
    }
}
namespace ProgrammingChallenge
{
    partial class PlayerLoginTP
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
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.labelPlayFirst = new System.Windows.Forms.Label();
            this.radioButtonP1 = new System.Windows.Forms.RadioButton();
            this.radioButtonP2 = new System.Windows.Forms.RadioButton();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(25, 48);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(82, 13);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player Name 1 :";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(25, 104);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(82, 13);
            this.labelPlayer2.TabIndex = 1;
            this.labelPlayer2.Text = "Player Name 2 :";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(113, 45);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(137, 20);
            this.textBoxPlayer1.TabIndex = 2;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Location = new System.Drawing.Point(113, 101);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(137, 20);
            this.textBoxPlayer2.TabIndex = 3;
            // 
            // labelPlayFirst
            // 
            this.labelPlayFirst.AutoSize = true;
            this.labelPlayFirst.Location = new System.Drawing.Point(25, 167);
            this.labelPlayFirst.Name = "labelPlayFirst";
            this.labelPlayFirst.Size = new System.Drawing.Size(79, 13);
            this.labelPlayFirst.TabIndex = 4;
            this.labelPlayFirst.Text = "Play First         :";
            // 
            // radioButtonP1
            // 
            this.radioButtonP1.AutoSize = true;
            this.radioButtonP1.Location = new System.Drawing.Point(113, 163);
            this.radioButtonP1.Name = "radioButtonP1";
            this.radioButtonP1.Size = new System.Drawing.Size(63, 17);
            this.radioButtonP1.TabIndex = 5;
            this.radioButtonP1.TabStop = true;
            this.radioButtonP1.Text = "Player 1";
            this.radioButtonP1.UseVisualStyleBackColor = true;
            // 
            // radioButtonP2
            // 
            this.radioButtonP2.AutoSize = true;
            this.radioButtonP2.Location = new System.Drawing.Point(187, 163);
            this.radioButtonP2.Name = "radioButtonP2";
            this.radioButtonP2.Size = new System.Drawing.Size(63, 17);
            this.radioButtonP2.TabIndex = 6;
            this.radioButtonP2.TabStop = true;
            this.radioButtonP2.Text = "Player 2";
            this.radioButtonP2.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(175, 211);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 7;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(28, 211);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PlayerLoginTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgrammingChallenge.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.radioButtonP2);
            this.Controls.Add(this.radioButtonP1);
            this.Controls.Add(this.labelPlayFirst);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.MaximizeBox = false;
            this.Name = "PlayerLoginTP";
            this.Text = "Player Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Label labelPlayFirst;
        private System.Windows.Forms.RadioButton radioButtonP1;
        private System.Windows.Forms.RadioButton radioButtonP2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonMenu;
    }
}
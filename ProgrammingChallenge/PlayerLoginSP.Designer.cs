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
            this.labelPlayFirst = new System.Windows.Forms.Label();
            this.radioButtonComputer = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayer = new System.Windows.Forms.RadioButton();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Player Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(121, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelPlayFirst
            // 
            this.labelPlayFirst.AutoSize = true;
            this.labelPlayFirst.Location = new System.Drawing.Point(19, 104);
            this.labelPlayFirst.Name = "labelPlayFirst";
            this.labelPlayFirst.Size = new System.Drawing.Size(73, 13);
            this.labelPlayFirst.TabIndex = 2;
            this.labelPlayFirst.Text = "Play First       :";
            // 
            // radioButtonComputer
            // 
            this.radioButtonComputer.AutoSize = true;
            this.radioButtonComputer.Location = new System.Drawing.Point(121, 104);
            this.radioButtonComputer.Name = "radioButtonComputer";
            this.radioButtonComputer.Size = new System.Drawing.Size(70, 17);
            this.radioButtonComputer.TabIndex = 3;
            this.radioButtonComputer.TabStop = true;
            this.radioButtonComputer.Text = "Computer";
            this.radioButtonComputer.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlayer
            // 
            this.radioButtonPlayer.AutoSize = true;
            this.radioButtonPlayer.Location = new System.Drawing.Point(211, 104);
            this.radioButtonPlayer.Name = "radioButtonPlayer";
            this.radioButtonPlayer.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPlayer.TabIndex = 4;
            this.radioButtonPlayer.TabStop = true;
            this.radioButtonPlayer.Text = "Player";
            this.radioButtonPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(190, 203);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(22, 203);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // PlayerLoginSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgrammingChallenge.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.radioButtonPlayer);
            this.Controls.Add(this.radioButtonComputer);
            this.Controls.Add(this.labelPlayFirst);
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
        private System.Windows.Forms.Label labelPlayFirst;
        private System.Windows.Forms.RadioButton radioButtonComputer;
        private System.Windows.Forms.RadioButton radioButtonPlayer;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonBack;
    }
}
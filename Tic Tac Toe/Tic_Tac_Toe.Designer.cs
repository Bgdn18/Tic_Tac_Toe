namespace Tic_Tac_Toe
{
    partial class Tic_Tac_Toe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tic_Tac_Toe));
            btnRestart = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            lblCurrentPlayer = new Label();
            SuspendLayout();
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(630, 60);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(190, 115);
            btnRestart.TabIndex = 0;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(200, 200);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button2.Location = new Point(218, 12);
            button2.Name = "button2";
            button2.Size = new Size(200, 200);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button3.Location = new Point(424, 12);
            button3.Name = "button3";
            button3.Size = new Size(200, 200);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button4.Location = new Point(12, 218);
            button4.Name = "button4";
            button4.Size = new Size(200, 200);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button5.Location = new Point(218, 218);
            button5.Name = "button5";
            button5.Size = new Size(200, 200);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button6.Location = new Point(424, 218);
            button6.Name = "button6";
            button6.Size = new Size(200, 200);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button7.Location = new Point(12, 424);
            button7.Name = "button7";
            button7.Size = new Size(200, 200);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button8.Location = new Point(218, 424);
            button8.Name = "button8";
            button8.Size = new Size(200, 200);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold);
            button9.Location = new Point(424, 424);
            button9.Name = "button9";
            button9.Size = new Size(200, 200);
            button9.TabIndex = 7;
            button9.UseVisualStyleBackColor = true;
            // 
            // lblCurrentPlayer
            // 
            lblCurrentPlayer.AutoSize = true;
            lblCurrentPlayer.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPlayer.Location = new Point(630, 12);
            lblCurrentPlayer.Name = "lblCurrentPlayer";
            lblCurrentPlayer.Size = new Size(191, 27);
            lblCurrentPlayer.TabIndex = 10;
            lblCurrentPlayer.Text = "Player's Turn: O/X";
            // 
            // Tic_Tac_Toe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 636);
            Controls.Add(lblCurrentPlayer);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRestart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tic_Tac_Toe";
            Text = "Tic Tac Toe!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRestart;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label lblCurrentPlayer;
    }
}

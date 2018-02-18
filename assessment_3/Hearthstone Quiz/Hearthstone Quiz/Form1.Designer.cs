namespace Hearthstone_Quiz
{
    partial class Index
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
			this.label1 = new System.Windows.Forms.Label();
			this.questionField = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkAnswer = new System.Windows.Forms.Button();
			this.nextQuestion = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.scoreField = new System.Windows.Forms.TextBox();
			this.responseField = new System.Windows.Forms.TextBox();
			this.resetGame = new System.Windows.Forms.Button();
			this.answerOne = new System.Windows.Forms.RadioButton();
			this.answerTwo = new System.Windows.Forms.RadioButton();
			this.answerThree = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label1.Location = new System.Drawing.Point(15, 115);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label1.Size = new System.Drawing.Size(500, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Guess the name of each Hearthstone card described below by it\'s flavour text. Goo" +
    "d luck!";
			// 
			// questionField
			// 
			this.questionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.questionField.Location = new System.Drawing.Point(15, 187);
			this.questionField.Multiline = true;
			this.questionField.Name = "questionField";
			this.questionField.ReadOnly = true;
			this.questionField.ShortcutsEnabled = false;
			this.questionField.Size = new System.Drawing.Size(500, 75);
			this.questionField.TabIndex = 2;
			this.questionField.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(500, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// checkAnswer
			// 
			this.checkAnswer.Location = new System.Drawing.Point(9, 362);
			this.checkAnswer.Name = "checkAnswer";
			this.checkAnswer.Size = new System.Drawing.Size(250, 25);
			this.checkAnswer.TabIndex = 4;
			this.checkAnswer.Text = "Check Answer";
			this.checkAnswer.UseVisualStyleBackColor = true;
			this.checkAnswer.Click += new System.EventHandler(this.checkAnswer_Click);
			// 
			// nextQuestion
			// 
			this.nextQuestion.Location = new System.Drawing.Point(265, 362);
			this.nextQuestion.Name = "nextQuestion";
			this.nextQuestion.Size = new System.Drawing.Size(250, 25);
			this.nextQuestion.TabIndex = 5;
			this.nextQuestion.Text = "Next Question";
			this.nextQuestion.UseVisualStyleBackColor = true;
			this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label2.Location = new System.Drawing.Point(15, 447);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Your score is:";
			// 
			// scoreField
			// 
			this.scoreField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.scoreField.Location = new System.Drawing.Point(133, 447);
			this.scoreField.Multiline = true;
			this.scoreField.Name = "scoreField";
			this.scoreField.ReadOnly = true;
			this.scoreField.ShortcutsEnabled = false;
			this.scoreField.Size = new System.Drawing.Size(100, 25);
			this.scoreField.TabIndex = 7;
			this.scoreField.Text = "1 / 1";
			// 
			// responseField
			// 
			this.responseField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.responseField.Location = new System.Drawing.Point(15, 404);
			this.responseField.Multiline = true;
			this.responseField.Name = "responseField";
			this.responseField.ReadOnly = true;
			this.responseField.ShortcutsEnabled = false;
			this.responseField.Size = new System.Drawing.Size(494, 25);
			this.responseField.TabIndex = 8;
			// 
			// resetGame
			// 
			this.resetGame.Location = new System.Drawing.Point(15, 493);
			this.resetGame.Name = "resetGame";
			this.resetGame.Size = new System.Drawing.Size(500, 25);
			this.resetGame.TabIndex = 9;
			this.resetGame.Text = "Reset Game";
			this.resetGame.UseVisualStyleBackColor = true;
			this.resetGame.Click += new System.EventHandler(this.resetGame_Click);
			// 
			// answerOne
			// 
			this.answerOne.AutoSize = true;
			this.answerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.answerOne.Location = new System.Drawing.Point(15, 268);
			this.answerOne.Name = "answerOne";
			this.answerOne.Size = new System.Drawing.Size(14, 13);
			this.answerOne.TabIndex = 10;
			this.answerOne.TabStop = true;
			this.answerOne.UseVisualStyleBackColor = true;
			this.answerOne.CheckedChanged += new System.EventHandler(this.answerOne_CheckedChanged);
			// 
			// answerTwo
			// 
			this.answerTwo.AutoSize = true;
			this.answerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.answerTwo.Location = new System.Drawing.Point(15, 291);
			this.answerTwo.Name = "answerTwo";
			this.answerTwo.Size = new System.Drawing.Size(14, 13);
			this.answerTwo.TabIndex = 11;
			this.answerTwo.TabStop = true;
			this.answerTwo.UseVisualStyleBackColor = true;
			this.answerTwo.CheckedChanged += new System.EventHandler(this.answerTwo_CheckedChanged);
			// 
			// answerThree
			// 
			this.answerThree.AutoSize = true;
			this.answerThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.answerThree.Location = new System.Drawing.Point(15, 314);
			this.answerThree.Name = "answerThree";
			this.answerThree.Size = new System.Drawing.Size(14, 13);
			this.answerThree.TabIndex = 12;
			this.answerThree.TabStop = true;
			this.answerThree.UseVisualStyleBackColor = true;
			this.answerThree.CheckedChanged += new System.EventHandler(this.answerThree_CheckedChanged);
			// 
			// Index
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 539);
			this.Controls.Add(this.answerThree);
			this.Controls.Add(this.answerTwo);
			this.Controls.Add(this.answerOne);
			this.Controls.Add(this.resetGame);
			this.Controls.Add(this.responseField);
			this.Controls.Add(this.scoreField);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nextQuestion);
			this.Controls.Add(this.checkAnswer);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.questionField);
			this.Controls.Add(this.label1);
			this.Name = "Index";
			this.Text = "Index";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button checkAnswer;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scoreField;
        private System.Windows.Forms.TextBox responseField;
        private System.Windows.Forms.Button resetGame;
        private System.Windows.Forms.RadioButton answerOne;
        private System.Windows.Forms.RadioButton answerTwo;
        private System.Windows.Forms.RadioButton answerThree;
    }
}


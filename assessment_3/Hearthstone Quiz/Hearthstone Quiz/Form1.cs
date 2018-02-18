using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearthstone_Quiz {

    public partial class Index : Form { //This class encapsulates everything

		//Declare and initialise variables to be used in app.
        string[,] questionsAndAnswers = new string[10, 5] { //2D Array containing the questions and answers
            { "'Hey! Ancestors!'", "Ancestor’s call", "Rhonin", "Living Roots", "Ancestor’s call"},
			{ "Sometimes the Old Gods’ corruptions gives you power untold, sometimes you get +1 Attack. We can’t all be winners in the Eldritch lottery.", "Sky Cap’n Kragg", "Twisted Worgen", "Drakonid Operative", "Twisted Worgen"},
			{ "Or if you’re too tired, you can just kind of lean against the darkness.", "Acidmaw", "Dreadscale", "Stand Against Darkness", "Stand Against Darkness"},
			{ "peerc rewop", "Big Game Hunter", "Aya Blackpaw", "Am’Gam Rager", "Am’Gam Rager"},
			{ "What happens when you try and corrupt a corrupted firelord? DOUBLE NEGATIVE, INSECT!", "Skulking Geist", "Ragnaros, Lightlord", "Lilian Voss", "Ragnaros, Lightlord"},
			{ "Clever girl!", "Mounted Raptor", "Ysera", "C'Thun", "Mounted Raptor"},
			{ "'Oh, I’m not serious about it. I only pirate on the weekends.'", "Small-Time Buccaneer", "Wrathion", "White Eyes", "Small-Time Buccaneer"},
			{ "It has double the Attack. 'Go on.' And double the Health. 'Yes??' And its trigger has twice the effect. 'WHAT???' And it costs… Five times more.", "Prince Keleseth", "Red Mana Wyrm", "The Lich King", "Red Mana Wyrm"},
			{ "Meditating under a jade blossom is said to grant you wisdom, unless you have a pollen allergy.", "Frostmourne", "Aviana", "Jade Blossom", "Jade Blossom"},
			{ "Now we know why they wear tiny watches.", "Raza the Chained", "Profesor Putricide", "Small-Time Recruits", "Small-Time Recruits"}
        };
		int questionCounter = 0;
		String givenAnswer = "";
        String trueAnswer = "Congradulations, you are correct!";                         //Text 1 for responseField
        String falseAnswer = "Commiserations, you are incorrect!";                       //Text 2 for responseField
        int correctAnswers = 0;                                                          //Number of correctly answered questions
        int answeredQuestions = 1;                                                       //Number of questions answered


        public Index() { //Runs on startup
            //Calls the method that initializes the page
            InitializeComponent();

            //Fills initial data into fields
            questionField.Text = questionsAndAnswers[questionCounter, 0];
            answerOne.Text = questionsAndAnswers[questionCounter, 1];
            answerTwo.Text = questionsAndAnswers[questionCounter, 2];
            answerThree.Text = questionsAndAnswers[questionCounter, 3];
            scoreField.Text = correctAnswers + " / " + answeredQuestions;
        }

		private void answerOne_CheckedChanged(object sender, EventArgs e) { //Sets given answer to option 1
			givenAnswer = questionsAndAnswers[questionCounter, 1];
		}

		private void answerTwo_CheckedChanged(object sender, EventArgs e) { //Sets given answer to option 2
			givenAnswer = questionsAndAnswers[questionCounter, 2];
		}

		private void answerThree_CheckedChanged(object sender, EventArgs e) { //Sets given answer to option 3
			givenAnswer = questionsAndAnswers[questionCounter, 3];
		}

		private void checkAnswer_Click(object sender, EventArgs e) { //Checks the answer
			if (givenAnswer.Equals(questionsAndAnswers[questionCounter, 4], StringComparison.Ordinal)) { //If given answer is equal to correct answer then
				//Add 1 to correct answers
				correctAnswers++; 

				//Ouput correct response
				responseField.Text = trueAnswer;

			}
			else {
				//Output false answer
				responseField.Text = falseAnswer;
			}

			//Ouput score regardless of answer
			scoreField.Text = correctAnswers + " / " + answeredQuestions;

			//Disables radio buttons and checkAnswer once the answer has been checked
			answerOne.Enabled = false;
			answerTwo.Enabled = false;
			answerThree.Enabled = false;
			checkAnswer.Enabled = false;
		}

		private void nextQuestion_Click(object sender, EventArgs e) {
			if (questionCounter != (questionsAndAnswers.GetLength(0) - 1)) {
				questionCounter++;
				answeredQuestions++;

				questionField.Text = questionsAndAnswers[questionCounter, 0];
				answerOne.Text = questionsAndAnswers[questionCounter, 1];
				answerTwo.Text = questionsAndAnswers[questionCounter, 2];
				answerThree.Text = questionsAndAnswers[questionCounter, 3];
				answerOne.Checked = false;
				answerTwo.Checked = false;
				answerThree.Checked = false;
				answerOne.Enabled = true;
				answerTwo.Enabled = true;
				answerThree.Enabled = true;
				checkAnswer.Enabled = true;
				scoreField.Text = correctAnswers + " / " + answeredQuestions;
			} else {
				questionField.Text = "You have completed the quiz.";
				answerOne.Text = "";
				answerTwo.Text = "";
				answerThree.Text = "";
				answerOne.Enabled = false;
				answerTwo.Enabled = false;
				answerThree.Enabled = false;
				checkAnswer.Enabled = false;
				nextQuestion.Enabled = false;
				responseField.Text = "To start afresh select 'Reset Game'";
			}

		}

		private void resetGame_Click(object sender, EventArgs e) { //Reset everything!
			questionCounter = 0;
			givenAnswer = "";
			correctAnswers = 0;
			answeredQuestions = 0;

			questionField.Text = questionsAndAnswers[questionCounter, 0];
			answerOne.Text = questionsAndAnswers[questionCounter, 1];
			answerTwo.Text = questionsAndAnswers[questionCounter, 2];
			answerThree.Text = questionsAndAnswers[questionCounter, 3];
			answerOne.Checked = false;
			answerTwo.Checked = false;
			answerThree.Checked = false;
			answerOne.Enabled = true;
			answerTwo.Enabled = true;
			answerThree.Enabled = true;
			checkAnswer.Enabled = true;
			nextQuestion.Enabled = true;
			responseField.Text = "";
			scoreField.Text = correctAnswers + " / " + answeredQuestions;
		}
	}
}

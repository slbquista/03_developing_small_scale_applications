using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradeSummary
{

    //Written by:               Ed Lynch
    //                          Dundee and Angus College
    //                          Gardyne Rd, Dundee.
    //
    //Project Title:            GradeSummary App
    //Written on:               19/10/16
    //Requires:                 MS Visual Studio 2015
    //Version:                  1.0

    //Modified by:              Your name here


    public partial class Form1 : Form
    {
                                                                            //Declare and initialise variables to be used in app.
        int[]   markArray = new int[1000000];                               //Declare an array of integers to hold entered user values
        int     arrayPointer;                                               //Declare array pointer
        double  totalMarks = 0.0;                                           //Declare total marks
        int     numberOfMarksEntered= 0;                                    //Declare number of marks entered
        double  averageMark = 0.0;                                          //Declare average mark
        double  lowestMark = 0.0;
        double  highestMark = 0.0;



        public Form1()
        {
            InitializeComponent();                                                //Call method
            textEntry.Focus();                                                    //Set cursor position in text box
        }

        private void buttonMainPage_Click(object sender, EventArgs e)
        {
           tabControlMainPage.SelectedIndex = 0;                                  //Select tab form 0
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();                                                         //Quit the app
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            tabControlMainPage.SelectedIndex = 1;                                 //Select tab form 1

            textBoxNumberOfMarks.Text = Convert.ToString(numberOfMarksEntered);   //Convert and display value in text box
            textBoxTotalMarks.Text = Convert.ToString(totalMarks);                //Convert and display value in text box

            textBoxAverageMark.Text = Convert.ToString(averageMark);              //Convert and display value in text box

            textBoxLowestMark.Text = Convert.ToString(lowestMark);
            textBoxHighestMark.Text = Convert.ToString(highestMark);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try                                                                                                                                         //Test value enter is number
            {
                markArray[arrayPointer] = Convert.ToInt32(textEntry.Text);        //Take value from text box and place in array cell if it is a int
            }
            catch                                                                                                                                    //Catch non ints
            {
                MessageBox.Show("You must enter a number ");                      //if not int display error messsage  
            }
            totalMarks = totalMarks + markArray[arrayPointer];                    //Add mark entered to running total
            
            numberOfMarksEntered++;                                               //Increment counter                                              //Increment number of marks entered counter
            averageMark = totalMarks / numberOfMarksEntered;                      //Calculate average mark

            textEntry.Text = "";                                                  //Initilaise entry                                                           //Blank named text box
            textEntry.Focus();                                                    //Move I bar to text box                                                          //Set cursor position in text box
            arrayPointer++;                                                       //Increment array pointer                                                          //Increment array pointer
            lowestMark = calcLowest();
            highestMark = calcHighest();
        }

        private void buttonClear_Click(object sender, EventArgs e)                //Method clears form
        {
            arrayPointer = 0;                                                                                                              //Initialise array pointer
            totalMarks = 0;                                                                                                                //Initialise total marks
            numberOfMarksEntered = 0;                                                                                         //Initialise number of marks entered
            averageMark = 0;                                                                                                             //Initialise average marks
            lowestMark = 0;
            highestMark = 0;

            textEntry.Text = "";                                                                                                            //Initialise text box contents
            textBoxAverageMark.Text = "";                                                                                       //Initialise text box contents
            textBoxTotalMarks.Text = "";                                                                                          //Initialise text box contents
            textBoxNumberOfMarks.Text = "";                                                                                 //Initialise text box contents      
            textBoxLowestMark.Text = ""; 

            textEntry.Focus();                                                                                                              //Set cursor position in text box
        }

        private void Form1_Load(object sender, EventArgs e)                        //Form load event for app
        {
            textEntry.Focus();                                                                                                              //Set cursor position in text box
        }

        private double calcLowest()                                                 //Method to calculate the lowest mark
        {
            int lowestMark = markArray[0];

            for (int i = 1; i < numberOfMarksEntered; i++)
            {
                if (markArray[i] < lowestMark)
                {
                    lowestMark = markArray[i];
                }
            }

            return lowestMark;
        }


        private double calcHighest()                                                //Method to calculate the highest mark
        {
            int highestMark = markArray[0];

            for (int i = 1; i < numberOfMarksEntered; i++)
            {
                if (markArray[i] > highestMark)
                {
                    highestMark = markArray[i];
                }
            }

            return highestMark;
        }
    }
}

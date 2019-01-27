using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeRemaining = timeRemaining - 1;
                timeLabel.Text = timeRemaining + " Seconds";

            }
            else
            {

                timer1.Stop();
                startButton.Enabled = true;
                timeLabel.Text = "Time's up!";
                CheckSubAnswer();
                CheckDivisionAnswer();
                CheckAddAnswer();
                if (CheckMultAnswer() && CheckSubAnswer() && CheckDivisionAnswer() && CheckAddAnswer())
                {
                    MessageBox.Show("You answered all 4 questions correctly!");

                }

                else {
                    MessageBox.Show("Sorry, you only answered " +numCorrect + " questions correctly!");
                }
            }


        }
        

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        } 

        private void sum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            giveFeedback();
            if (CheckAddAnswer() && CheckMultAnswer() && CheckSubAnswer() && CheckDivisionAnswer())
            {
                timer1.Stop();
                startButton.Enabled = true;
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You answered all 4 questions correctly!");

            }

            else
            {
                timeRemaining--;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
            sum.Value = 0;
            difference.Value = 0;
            divisionAnswerBox.Value = 0;
            multAnswerBox.Value = 0;
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }
    }
    }


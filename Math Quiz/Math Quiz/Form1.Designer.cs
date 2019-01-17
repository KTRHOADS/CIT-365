using System.Drawing;

namespace Math_Quiz
{
    partial class Form1
    {
        //Random Number Generator
        System.Random random = new System.Random();

        //Addition Numbers
        int addend1;
        int addend2;

        //Subtraction
        int sub1;
        int sub2;

        //Multiplication
        int firstMultiplier;
        int secondMultiplier;

        //Division
        int divisor;
        int tempAnswer;

        //Time Remaining
        int maxTime = 30;
        int timeRemaining;

        //Number Correct
        int numCorrect;

        //Feedback Images
        Image correct = Image.FromFile("images/correct.png");
        Image wrong = Image.FromFile("images/wrong.png");



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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusSign = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusEquals = new System.Windows.Forms.Label();
            this.plusLabel1 = new System.Windows.Forms.Label();
            this.plusLabel2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.multAnswerBox = new System.Windows.Forms.NumericUpDown();
            this.divisionAnswerBox = new System.Windows.Forms.NumericUpDown();
            this.minus2 = new System.Windows.Forms.Label();
            this.minus1 = new System.Windows.Forms.Label();
            this.mult1 = new System.Windows.Forms.Label();
            this.dividend1 = new System.Windows.Forms.Label();
            this.dividend2 = new System.Windows.Forms.Label();
            this.mult2 = new System.Windows.Forms.Label();
            this.addFeedback = new System.Windows.Forms.Label();
            this.subFeedback = new System.Windows.Forms.Label();
            this.multFeedback = new System.Windows.Forms.Label();
            this.divisionFeedback = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multAnswerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionAnswerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(388, 11);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(234, 36);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            this.plusSign.Image = ((System.Drawing.Image)(resources.GetObject("plusSign.Image")));
            this.plusSign.Location = new System.Drawing.Point(177, 81);
            this.plusSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(105, 52);
            this.plusSign.TabIndex = 2;
            this.plusSign.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.plusSign.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // plusEquals
            // 
            this.plusEquals.Image = ((System.Drawing.Image)(resources.GetObject("plusEquals.Image")));
            this.plusEquals.Location = new System.Drawing.Point(413, 81);
            this.plusEquals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plusEquals.Name = "plusEquals";
            this.plusEquals.Size = new System.Drawing.Size(105, 52);
            this.plusEquals.TabIndex = 4;
            // 
            // plusLabel1
            // 
            this.plusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.plusLabel1.Location = new System.Drawing.Point(39, 98);
            this.plusLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plusLabel1.Name = "plusLabel1";
            this.plusLabel1.Size = new System.Drawing.Size(153, 18);
            this.plusLabel1.TabIndex = 5;
            this.plusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLabel2
            // 
            this.plusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.plusLabel2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.plusLabel2.Location = new System.Drawing.Point(271, 96);
            this.plusLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plusLabel2.Name = "plusLabel2";
            this.plusLabel2.Size = new System.Drawing.Size(153, 18);
            this.plusLabel2.TabIndex = 6;
            this.plusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(543, 96);
            this.sum.Margin = new System.Windows.Forms.Padding(4);
            this.sum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(180, 23);
            this.sum.TabIndex = 9;
            this.sum.ValueChanged += new System.EventHandler(this.sum_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 10;
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(543, 162);
            this.difference.Margin = new System.Windows.Forms.Padding(4);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(180, 23);
            this.difference.TabIndex = 11;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(413, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 52);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(177, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 52);
            this.label5.TabIndex = 13;
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(413, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 52);
            this.label6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(413, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 52);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(177, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 52);
            this.label8.TabIndex = 16;
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(177, 263);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 52);
            this.label9.TabIndex = 17;
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // multAnswerBox
            // 
            this.multAnswerBox.Location = new System.Drawing.Point(543, 222);
            this.multAnswerBox.Margin = new System.Windows.Forms.Padding(4);
            this.multAnswerBox.Name = "multAnswerBox";
            this.multAnswerBox.Size = new System.Drawing.Size(180, 23);
            this.multAnswerBox.TabIndex = 18;
            this.multAnswerBox.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // divisionAnswerBox
            // 
            this.divisionAnswerBox.Location = new System.Drawing.Point(543, 279);
            this.divisionAnswerBox.Margin = new System.Windows.Forms.Padding(4);
            this.divisionAnswerBox.Name = "divisionAnswerBox";
            this.divisionAnswerBox.Size = new System.Drawing.Size(180, 23);
            this.divisionAnswerBox.TabIndex = 19;
            this.divisionAnswerBox.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minus2
            // 
            this.minus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.minus2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.minus2.Location = new System.Drawing.Point(271, 149);
            this.minus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minus2.Name = "minus2";
            this.minus2.Size = new System.Drawing.Size(153, 18);
            this.minus2.TabIndex = 20;
            this.minus2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus1
            // 
            this.minus1.BackColor = System.Drawing.SystemColors.Control;
            this.minus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.minus1.Location = new System.Drawing.Point(39, 149);
            this.minus1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minus1.Name = "minus1";
            this.minus1.Size = new System.Drawing.Size(153, 18);
            this.minus1.TabIndex = 21;
            this.minus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mult1
            // 
            this.mult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.mult1.Location = new System.Drawing.Point(39, 222);
            this.mult1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mult1.Name = "mult1";
            this.mult1.Size = new System.Drawing.Size(153, 18);
            this.mult1.TabIndex = 22;
            this.mult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividend1
            // 
            this.dividend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividend1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.dividend1.Location = new System.Drawing.Point(39, 281);
            this.dividend1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dividend1.Name = "dividend1";
            this.dividend1.Size = new System.Drawing.Size(153, 18);
            this.dividend1.TabIndex = 23;
            this.dividend1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividend2
            // 
            this.dividend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dividend2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.dividend2.Location = new System.Drawing.Point(271, 286);
            this.dividend2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dividend2.Name = "dividend2";
            this.dividend2.Size = new System.Drawing.Size(153, 18);
            this.dividend2.TabIndex = 24;
            this.dividend2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mult2
            // 
            this.mult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mult2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.mult2.Location = new System.Drawing.Point(271, 222);
            this.mult2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mult2.Name = "mult2";
            this.mult2.Size = new System.Drawing.Size(153, 18);
            this.mult2.TabIndex = 25;
            this.mult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addFeedback
            // 
            this.addFeedback.Location = new System.Drawing.Point(18, 81);
            this.addFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addFeedback.Name = "addFeedback";
            this.addFeedback.Size = new System.Drawing.Size(60, 49);
            this.addFeedback.TabIndex = 27;
            // 
            // subFeedback
            // 
            this.subFeedback.CausesValidation = false;
            this.subFeedback.Location = new System.Drawing.Point(18, 138);
            this.subFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subFeedback.Name = "subFeedback";
            this.subFeedback.Size = new System.Drawing.Size(60, 49);
            this.subFeedback.TabIndex = 28;
            // 
            // multFeedback
            // 
            this.multFeedback.Location = new System.Drawing.Point(18, 206);
            this.multFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.multFeedback.Name = "multFeedback";
            this.multFeedback.Size = new System.Drawing.Size(60, 49);
            this.multFeedback.TabIndex = 29;
            // 
            // divisionFeedback
            // 
            this.divisionFeedback.Location = new System.Drawing.Point(18, 263);
            this.divisionFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.divisionFeedback.Name = "divisionFeedback";
            this.divisionFeedback.Size = new System.Drawing.Size(60, 49);
            this.divisionFeedback.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.Image = global::Math_Quiz.Properties.Resources.Button_check;
            this.label10.Location = new System.Drawing.Point(427, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 63);
            this.label10.TabIndex = 31;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.Image = global::Math_Quiz.Properties.Resources.Start_button;
            this.label11.Location = new System.Drawing.Point(188, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 63);
            this.label11.TabIndex = 32;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(726, 429);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.divisionFeedback);
            this.Controls.Add(this.multFeedback);
            this.Controls.Add(this.subFeedback);
            this.Controls.Add(this.addFeedback);
            this.Controls.Add(this.mult2);
            this.Controls.Add(this.dividend2);
            this.Controls.Add(this.dividend1);
            this.Controls.Add(this.mult1);
            this.Controls.Add(this.minus1);
            this.Controls.Add(this.minus2);
            this.Controls.Add(this.divisionAnswerBox);
            this.Controls.Add(this.multAnswerBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusLabel2);
            this.Controls.Add(this.plusLabel1);
            this.Controls.Add(this.plusEquals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multAnswerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionAnswerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusSign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusEquals;
        private System.Windows.Forms.Label plusLabel1;
        private System.Windows.Forms.Label plusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown sum;

        public void StartQuiz() {
            
            //Restart Timer
            timeRemaining = maxTime;
            timer1.Enabled = true;
            
            //Reset Everything
            multFeedback.Image = null;
            divisionFeedback.Image = null;
            subFeedback.Image = null;
            addFeedback.Image = null;
            sum.Value = 0;
            difference.Value = 0;
            multAnswerBox.Value = 0;
            divisionAnswerBox.Value = 0;
            numCorrect = 0;
            

            //Start Addition Problem
            addend1 = random.Next(51);
            addend2 = random.Next(51);
            plusLabel1.Text = addend1.ToString();
            plusLabel2.Text = addend2.ToString();

            //Start Subtraction Problem
            sub1 = random.Next(1, 101);
            sub2 = random.Next(1, sub1);
            minus1.Text = sub1.ToString();
            minus2.Text = sub2.ToString();

            //Start Multiplication Problem
            firstMultiplier = random.Next (2, 11);
            secondMultiplier = random.Next(2, 11);
            mult1.Text = firstMultiplier.ToString();
            mult2.Text = secondMultiplier.ToString();

            //Start Division Problem
            divisor = random.Next(2, 11);
            int randomNumber = random.Next(2, 11);
            tempAnswer = divisor * randomNumber;
            dividend2.Text = divisor.ToString();
            dividend1.Text = tempAnswer.ToString();


        }

        private bool CheckAddAnswer()
        {
            numCorrect = 0;
            if (addend1 + addend2 == sum.Value)
            {
                
                numCorrect++;
                return true;
            }
            else
            {

                
                return false;
            }
        }


        private bool CheckSubAnswer()
        {
            if (sub1 - sub2 == difference.Value)
            {
                
                numCorrect++;
                return true;
            }
            else
            {

                //subFeedback.Image = wrong;
                return false;
            }


        }

        private bool CheckMultAnswer()
        {
            
            if (firstMultiplier * secondMultiplier == multAnswerBox.Value)
            {
               
                numCorrect++;
                return true;
            }
            else
            {

               
                return false;
            }
        }

        private bool CheckDivisionAnswer()
        {
            if ( tempAnswer/divisor  == divisionAnswerBox.Value)
            {
                
                numCorrect++;
                return true;
            }
            else
            {

                
                return false;
            }
        }

        private void giveFeedback() {
            numCorrect = 0;

            if (CheckAddAnswer())
            {
                addFeedback.Image = correct;
                numCorrect++;
            }

            else {
                addFeedback.Image = wrong;
            }

            if (CheckDivisionAnswer())
            {
                divisionFeedback.Image = correct;
                numCorrect++;
            }

            else {
                divisionFeedback.Image = wrong;
            }

            if (CheckMultAnswer())
            {
                multFeedback.Image = correct;
                numCorrect++;
            }

            else {
                multFeedback.Image = wrong;
            }

            if (CheckSubAnswer())
            {
                subFeedback.Image = correct;
                numCorrect++;
            }

            else {
                subFeedback.Image = wrong;
            }
        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown multAnswerBox;
        private System.Windows.Forms.NumericUpDown divisionAnswerBox;
        private System.Windows.Forms.Label minus2;
        private System.Windows.Forms.Label minus1;
        private System.Windows.Forms.Label mult1;
        private System.Windows.Forms.Label dividend1;
        private System.Windows.Forms.Label dividend2;
        private System.Windows.Forms.Label mult2;
        private System.Windows.Forms.Label addFeedback;
        private System.Windows.Forms.Label subFeedback;
        private System.Windows.Forms.Label multFeedback;
        private System.Windows.Forms.Label divisionFeedback;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }

        }
      
   


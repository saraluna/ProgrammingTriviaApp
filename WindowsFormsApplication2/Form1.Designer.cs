namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnIncorrect = new System.Windows.Forms.Button();
            this.cbxSubjects = new System.Windows.Forms.CheckedListBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblTotalAsked = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.MaskedTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.questions = new System.Windows.Forms.Label();
            this.btnAddToInvestigate = new System.Windows.Forms.Button();
            this.pnlQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(348, 330);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(101, 23);
            this.btnNextQuestion.TabIndex = 0;
            this.btnNextQuestion.Text = "Next Question >>";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Visible = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Location = new System.Drawing.Point(181, 130);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(101, 23);
            this.btnShowAnswer.TabIndex = 1;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(0, 0);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(449, 124);
            this.txtQuestion.TabIndex = 2;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(3, 159);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer.Size = new System.Drawing.Size(446, 167);
            this.txtAnswer.TabIndex = 3;
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.Controls.Add(this.lblSubject);
            this.pnlQuestions.Controls.Add(this.txtAnswer);
            this.pnlQuestions.Controls.Add(this.txtQuestion);
            this.pnlQuestions.Controls.Add(this.btnShowAnswer);
            this.pnlQuestions.Controls.Add(this.btnNextQuestion);
            this.pnlQuestions.Controls.Add(this.btnCorrect);
            this.pnlQuestions.Controls.Add(this.btnIncorrect);
            this.pnlQuestions.Enabled = false;
            this.pnlQuestions.Location = new System.Drawing.Point(138, 2);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(452, 359);
            this.pnlQuestions.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(23, 135);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(0, 13);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Visible = false;
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(171, 330);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(75, 23);
            this.btnCorrect.TabIndex = 4;
            this.btnCorrect.Text = "Correct";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnIncorrect
            // 
            this.btnIncorrect.Location = new System.Drawing.Point(252, 330);
            this.btnIncorrect.Name = "btnIncorrect";
            this.btnIncorrect.Size = new System.Drawing.Size(75, 23);
            this.btnIncorrect.TabIndex = 5;
            this.btnIncorrect.Text = "Incorrect";
            this.btnIncorrect.UseVisualStyleBackColor = true;
            this.btnIncorrect.Click += new System.EventHandler(this.btnIncorrect_Click);
            // 
            // cbxSubjects
            // 
            this.cbxSubjects.FormattingEnabled = true;
            this.cbxSubjects.Items.AddRange(new object[] {
            "csharp",
            "javascript",
            "sql",
            "jQuery"});
            this.cbxSubjects.Location = new System.Drawing.Point(12, 2);
            this.cbxSubjects.Name = "cbxSubjects";
            this.cbxSubjects.Size = new System.Drawing.Size(120, 64);
            this.cbxSubjects.TabIndex = 3;
            this.cbxSubjects.Click += new System.EventHandler(this.cbxSubjects_Click);
            this.cbxSubjects.SelectedIndexChanged += new System.EventHandler(this.cbxSubjects_Click);
            this.cbxSubjects.SelectedValueChanged += new System.EventHandler(this.cbxSubjects_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(13, 181);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(13, 13);
            this.lblCorrect.TabIndex = 6;
            this.lblCorrect.Text = "0";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(13, 201);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(13, 13);
            this.lblIncorrect.TabIndex = 7;
            this.lblIncorrect.Text = "0";
            // 
            // lblTotalAsked
            // 
            this.lblTotalAsked.AutoSize = true;
            this.lblTotalAsked.Location = new System.Drawing.Point(13, 223);
            this.lblTotalAsked.Name = "lblTotalAsked";
            this.lblTotalAsked.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAsked.TabIndex = 8;
            this.lblTotalAsked.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Correct";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Incorrect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Asked";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(16, 73);
            this.tbTotal.Mask = "999";
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(44, 20);
            this.tbTotal.TabIndex = 12;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start >>";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // questions
            // 
            this.questions.AutoSize = true;
            this.questions.Location = new System.Drawing.Point(66, 76);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(52, 13);
            this.questions.TabIndex = 14;
            this.questions.Text = "questions";
            // 
            // btnAddToInvestigate
            // 
            this.btnAddToInvestigate.Location = new System.Drawing.Point(3, 279);
            this.btnAddToInvestigate.Name = "btnAddToInvestigate";
            this.btnAddToInvestigate.Size = new System.Drawing.Size(129, 23);
            this.btnAddToInvestigate.TabIndex = 15;
            this.btnAddToInvestigate.Text = "Add to Investigate List";
            this.btnAddToInvestigate.UseVisualStyleBackColor = true;
            this.btnAddToInvestigate.Click += new System.EventHandler(this.btnAddToInvestigate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(603, 362);
            this.Controls.Add(this.btnAddToInvestigate);
            this.Controls.Add(this.questions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalAsked);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.cbxSubjects);
            this.Controls.Add(this.pnlQuestions);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sara\'s Trivia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlQuestions.ResumeLayout(false);
            this.pnlQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Panel pnlQuestions;
        private System.Windows.Forms.CheckedListBox cbxSubjects;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnIncorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblTotalAsked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbTotal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label questions;
        private System.Windows.Forms.Button btnAddToInvestigate;
        private System.Windows.Forms.Label lblSubject;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        private int myVariable;

        public int MyVariable
        {
            get { return myVariable; }
            set { myVariable = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxSubjects.SetItemChecked(0, true);
            cbxSubjects.SetItemChecked(1, true);
            cbxSubjects.SetItemChecked(2, true);
            cbxSubjects.SetItemChecked(3, true);
            int total = GetTotalQuestions();
            int digits = tbTotal.Text.Length;
            tbTotal.Text = total.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetQuestion();
        }

        private void GetQuestion()
        {
            if (int.Parse(lblTotalAsked.Text) < int.Parse(tbTotal.Text))
            {
                TriviaQuestion tq = GetTriviaQuestion();
                txtQuestion.Text = tq.Subject.Replace("csharp","C#") +": "+ tq.Question;
                txtAnswer.Visible = false;
                txtAnswer.Text = tq.Answer;
                lblSubject.Text = tq.Subject;
                btnCorrect.Enabled = false;
                btnIncorrect.Enabled = false;
                btnShowAnswer.Enabled = true;
            }
            else
            {
                GetScore();
            }
        }

        private void GetScore()
        {
            decimal score = (decimal.Parse(lblCorrect.Text) / decimal.Parse(lblTotalAsked.Text)) * 100;
            MessageBox.Show("Correct:   " + lblCorrect.Text + Environment.NewLine
                + "Incorrect:    " + lblIncorrect.Text + Environment.NewLine
                + "Total:   " + lblTotalAsked.Text + Environment.NewLine
                + "Score:    " + (Math.Round(score, 2)).ToString() + "%"
                ,
                "Congrats");
            pnlQuestions.Enabled = false;
            txtQuestion.Text = string.Empty;
            txtAnswer.Text = string.Empty;
            tbTotal.Text = GetTotalQuestions().ToString();
            lblCorrect.Text = 0.ToString();
            lblIncorrect.Text = 0.ToString();
            lblTotalAsked.Text = 0.ToString();
            btnStart.Enabled = true;
            tbTotal.Enabled = true;
        }
        public int GetTotalQuestions()
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string spath = directory + "\\triviaXML.xml";
            XDocument questions = XDocument.Load(spath); 
            List<string> x = new List<string>();
            for (int i = 0; i < cbxSubjects.Items.Count; i++)
            {
                if (!cbxSubjects.GetItemChecked(i))
                    x.Add(cbxSubjects.Items[i].ToString());
                else
                    x.Add("");
            }
            var qas = questions.Descendants("triviaquestion")
                       .Where(xml => xml.Attribute("subject").Value != x[0])
                       .Where(xml => xml.Attribute("subject").Value != x[1])
                       .Where(xml => xml.Attribute("subject").Value != x[2])
                       .Where(xml => xml.Attribute("subject").Value != x[3]);
            int qaCount = qas.Count();
            return qaCount;
        }
        public TriviaQuestion GetTriviaQuestion()
        {
            try
            {
                string h = string.Empty;
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                string spath = directory + "\\triviaXML.xml";
                XDocument questions = XDocument.Load(spath);
                
                List<string> selectedSubjects = new List<string>();
                for (int i = 0; i < cbxSubjects.Items.Count; i++){
                    if(!cbxSubjects.GetItemChecked(i))
                        selectedSubjects.Add(cbxSubjects.Items[i].ToString());
                    else
                        selectedSubjects.Add("");
                }
                var qas = questions.Descendants("triviaquestion")
                           .Where(xml => xml.Attribute("subject").Value != selectedSubjects[0])
                           .Where(xml => xml.Attribute("subject").Value != selectedSubjects[1])
                           .Where(xml => xml.Attribute("subject").Value != selectedSubjects[2])
                           .Where(xml => xml.Attribute("subject").Value != selectedSubjects[3]);
                
                int qaCount = qas.Count();
                int index = rnd.Next(0, qaCount - 1);
                h = qas.ElementAt(index).Element("question").Value;
                TriviaQuestion ret= new TriviaQuestion();
                ret.Question = h;
                 h = qas.ElementAt(index).Element("answer").Value;
                 ret.Answer = h;
                 h = qas.ElementAt(index).Attribute("subject").Value;
                 ret.Subject = h;
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAnswer.Visible = true;
            btnCorrect.Enabled = true;
            btnIncorrect.Enabled = true;
            btnShowAnswer.Enabled = false;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            lblCorrect.Text = (int.Parse(lblCorrect.Text) + 1).ToString();
            lblTotalAsked.Text = (int.Parse(lblTotalAsked.Text) + 1).ToString();
            GetQuestion();
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            lblIncorrect.Text = (int.Parse(lblIncorrect.Text) + 1).ToString();
            lblTotalAsked.Text = (int.Parse(lblTotalAsked.Text) + 1).ToString();
            GetQuestion();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlQuestions.Enabled = true;
            btnStart.Enabled = false;
            tbTotal.Enabled = false;
            GetQuestion();
        }

        private void cbxSubjects_Click(object sender, EventArgs e)
        {
            tbTotal.Text = GetTotalQuestions().ToString();
        }

        private void btnAddToInvestigate_Click(object sender, EventArgs e)
        {
            AddToInvestigate x= new AddToInvestigate(txtQuestion.Text,lblSubject.Text);
            x.Show();
        }

    }
    public class TriviaQuestion
    {
        private string question;

        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        private string answer;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}

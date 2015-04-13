using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication2
{
    public partial class AddToInvestigate : Form
    {
        public AddToInvestigate()
        {
            InitializeComponent();
        }
        public AddToInvestigate(string question,string subject)
        {
            InitializeComponent();
            tbOriginal.Text = question;
            lblSubject.Text = subject;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveQuestionToInvestigate();
        }

        private void SaveQuestionToInvestigate()
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string spath = directory + "\\investigateListXML.xml";
            XDocument doc = XDocument.Load(spath);
            XElement root = new XElement("question");
            root.Add(new XAttribute("subject", lblSubject.Text));
            root.Add(new XElement("original", tbOriginal.Text));
            root.Add(new XElement("toInvestigate", txtQuestion.Text));
            doc.Element("questions").Add(root);
            doc.Save(spath);
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EditorDisciples
{
    public partial class Form1 : Form
    {
        public string Diff = "Easy";
        public int WidthOfMap = 8;
        public int HeightOfMap = 8;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveData()
        {
            XmlDocument document = new XmlDocument();
            document.Load("D:/Disciples/Disciples/bin/Debug/Data.xml");
            XmlElement element = document.DocumentElement;
            foreach(XmlNode node in element)
            {
                WriteData(node);
            }
            document.Save("D:/Disciples/Disciples/bin/Debug/Data.xml");
        }

        private void WriteData(XmlNode node)
        {
            foreach(XmlNode lox in node.ChildNodes)
            {
                switch (lox.Name)
                {
                    case "Width":
                        lox.InnerText = WidthOfMap.ToString();
                        break;
                    case "Height":
                        lox.InnerText = HeightOfMap.ToString();
                        break;
                    case "Difficulty":
                        lox.InnerText = Diff;
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = WidthBar.Value.ToString();
            label4.Text = HeightBar.Value.ToString();
        }

        private void WidthBar_Scroll(object sender, EventArgs e)
        {
            label3.Text = WidthBar.Value.ToString();
        }

        private void HeightBar_Scroll(object sender, EventArgs e)
        {
            label4.Text = HeightBar.Value.ToString();
        }

        private void ApplyWidth_Click(object sender, EventArgs e)
        {
            WidthOfMap = WidthBar.Value;
        }

        private void ApplyHeight_Click(object sender, EventArgs e)
        {
            HeightOfMap = HeightBar.Value;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void ApplyDif_Click(object sender, EventArgs e)
        {
            /*foreach(string item in Difficulty.Items)
            {
                Diff = item;
            }*/
            Diff = Difficulty.Text;
        }
    }
}

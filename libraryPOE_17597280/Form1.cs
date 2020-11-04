using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryPOE_17597280
{
    public partial class Form1 : Form
    {
        List<string> n = new List<string>();
        int Score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadTreeViewFromFile("tv.txt", treeView1);
           LoadTreeViewFromFile("tv.txt", treeView1);


        }
        int XpNumLvl01 = 100, XpNumLvl02 = 500, XpNumLvl03 = 1000, XpNumLvl04 = 1500,
           XpNumLvl05 = 2000, XpNumLvl06 = 2500, XpNumLvl07 = 3000,
           XpNumLvl08 = 3500, XpNumLvl09 = 4000, XpNumLvl10 = 4500;
        private void SetXpForPlayer(int Score, int NewScore)
        {

            Score = Score + NewScore;//adding up score for user

            if (Score > 0 && Score <= XpNumLvl01)
            {

                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, 0, XpNumLvl01, 1);
            }
            else if (Score > XpNumLvl01 && Score <= XpNumLvl02)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl01, XpNumLvl02, 2);
            }
            else if (Score > XpNumLvl02 && Score <= XpNumLvl03)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl02, XpNumLvl03, 3);
            }
            else if (Score > XpNumLvl03 && Score <= XpNumLvl04)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl03, XpNumLvl04, 4);
            }
            else if (Score > XpNumLvl04 && Score <= XpNumLvl05)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl04, XpNumLvl05, 5);
            }
            else if (Score > XpNumLvl05 && Score <= XpNumLvl06)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl05, XpNumLvl06, 6);
            }
            else if (Score > XpNumLvl06 && Score <= XpNumLvl07)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl06, XpNumLvl07, 7);
            }
            else if (Score > XpNumLvl07 && Score <= XpNumLvl08)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl07, XpNumLvl08, 8);
            }
            else if (Score > XpNumLvl08 && Score <= XpNumLvl09)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl08, XpNumLvl09, 9);
            }
            else if (Score > XpNumLvl09 && Score <= XpNumLvl10)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl09, XpNumLvl10, 10);

            }



        }
        private void SetingProgressBarANdLabel(int Score, int Min, int Max, int Level)
        {

            lblXpnum.Text = "Points: " + Score.ToString() + " of " + Max + " Level: " + Level;//setting label
            progressbarforXpTv.Maximum = Max;//setting Bar max
            progressbarforXpTv.Minimum = Min;//setting Bar Min
            progressbarforXpTv.Value = Score;//setting Bar Value

        }

        private void LoadTreeViewFromFile(string file_name, TreeView trv)
        {
            n = new List<string>();
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(file_name);
                
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                   n.Add(line);
                    //Read the next line

                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            string s = "";
            string parent = "";


            foreach (var ns in n)
            {
                char c = ns.FirstOrDefault();
                if (ns.Contains("omputer science"))
                {

                    addParrent(trv, ns);

                    parent = ns;

                    //MessageBox.Show("h");

                }
                if (ns.Contains("+0"))
                {
                    parent = ns;
                        addChild(trv, parent, ns);
                    Thread.Sleep(100);

                }
                
                if (c == '1')
                {
                    parent = ns;
                    addParrent(trv, ns);

                }
                if (ns.Contains("+1"))
                {
                    addChild(trv, parent, ns);

                }
                if (c == '2')
                {
                    parent = ns;
                    addParrent(trv, ns);
                }
                if (ns.Contains("+2"))
                {
                    
                    addChild(trv, parent, ns);
                }
                
                if (c == '3')
                {
                    parent = ns;
                    addParrent(trv, ns);
                }
                if (ns.Contains("+3"))
                {
                    parent = ns;
                    addChild(trv, parent, ns);
                }
                
                if (c == '4')
                {
                    parent = ns;
                    addParrent(trv, ns);
                }
                if (ns.Contains("+4"))
                {
                    addChild(trv, parent, ns);
                }
                if (c == '5')
                {
                    parent = ns;
                    addParrent(trv, ns);
                }
                if (ns.Contains("+5"))
                {
                    addChild(trv, parent, ns);
                }
                if (c == '6')
                {
                    parent = ns;
                    addParrent(trv, ns);
                }
                if (ns.Contains("+6"))
                {
                    addChild(trv, parent, ns);
                }
                if (c == '7')
                {
                    parent = ns;
                    addParrent(trv, ns);
                }
                if (ns.Contains("+7"))
                {
                    addChild(trv, parent, ns);
                }
                if (c == '8')
                {
                    parent = ns;
                    addParrent(trv, ns);
                }
                if (ns.Contains("+8"))
                {
                    addChild(trv, parent, ns);
                }
                if (c == '9')
                {
                    parent = ns;
                    addParrent(trv, ns);
                }
                if (ns.Contains("+9"))
                {
                    addChild(trv, parent, ns);
                }


            }
            lblQuestion.Text = randNode();



        }
        public void addParrent(TreeView tv, string parent)
        {
            string yourParentNode = "";
            if (tv.Equals(null))
            {
                tv = new TreeView();
                yourParentNode = parent.Trim();
                tv.Nodes.Add(yourParentNode);

            }
            else {
                tv.BeginUpdate();
                yourParentNode = parent.Trim();
                tv.Nodes.Add(yourParentNode);
                tv.EndUpdate();
            }
           


        }
        public void addChild(TreeView tv, string parent,string child)
        {
            var treeNode = tv.Nodes;
            foreach (TreeNode par in treeNode)
                {
                if (par.Text == parent)
                {
                    treeView1.SelectedNode = par;
                    tv.BeginUpdate();
                    StringBuilder sb = new StringBuilder(child);
                    sb.Remove(0, 1);
                    tv.SelectedNode.Nodes.Add(sb.ToString());
                    tv.ExpandAll();
                    tv.EndUpdate();
                }
            }
        }

        public void addChildChild(TreeView tv, string parent, string child)
        {
            var treeNode = tv.Nodes;
            foreach (TreeNode par in treeNode)
            {
                if (par.Text == parent)
                {
                    treeView1.SelectedNode = par;
                    tv.BeginUpdate();
                    StringBuilder sb = new StringBuilder(child);
                    sb.Remove(0, 1);
                    tv.SelectedNode.Nodes.Add(sb.ToString());
                    tv.ExpandAll();
                    tv.EndUpdate();
                }
            }
        }

        private void btnSelectArea_Click(object sender, EventArgs e)
        {
            Score =100;
            int newScore = Score;
            if (treeView1.SelectedNode.Equals(lblQuestion.Text)) {

                Score = Score + 100;
                SetXpForPlayer(Score, newScore);


            }
            else {
                Score = Score;
            }
            SetXpForPlayer(Score, newScore);
        }
        public string randNode() {
            
            Random rnd = new Random();

            int num = rnd.Next(1, n.Count);

           // MessageBox.Show("no" + n.Count);
            string Question = n[num].ToString();

            if (Question.Contains("+"))
            {

                StringBuilder sb = new StringBuilder(Question);
                sb.Remove(0, 1);
                Question = sb.ToString();

            }

            return Question;

        }


    }

}
        



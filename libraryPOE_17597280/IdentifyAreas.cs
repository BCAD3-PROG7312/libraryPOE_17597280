using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryPOE_17597280
{
    public partial class IdentifyAreas : Form
    {
        Dictionary<int, string> CallNumAreaDic = new Dictionary<int, string>();
        List<idAreas> ListofAreas = new List<idAreas>();
        //first lists

        List<int> keys = new List<int>();
        List<string> description = new List<string>();
        List<int> ANswerIdex = new List<int>();

        List<idAreas> ListofPossabileQuestions = new List<idAreas>();

        List<idAreas> ListofAnswers = new List<idAreas>();
        public static int XpNumCurrent, XpNumNew = 0;

        //for Levels
        int XpNumLvl01 = 100, XpNumLvl02 = 500, XpNumLvl03 = 1000, XpNumLvl04 = 1500,
            XpNumLvl05 = 2000, XpNumLvl06 = 2500, XpNumLvl07 = 3000,
            XpNumLvl08 = 3500, XpNumLvl09 = 4000, XpNumLvl10 = 4500;
        public IdentifyAreas()
        {
            InitializeComponent();
        }

        private void IdentifyAreas_Load(object sender, EventArgs e)
        {
            createDictionary();
            ReadScore();
            SetXpForPlayer(XpNumCurrent, XpNumNew);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            GetSelectedvaluesfromCombobox(cb1Ident, cb2Ident, cb3Ident, cb4Ident);
        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }
        public void createDictionary()
        {

            CallNumAreaDic = new Dictionary<int, string>();

            CallNumAreaDic.Add(000, "General Knowledge");
            CallNumAreaDic.Add(100, "Philosophy");
            CallNumAreaDic.Add(200, "Religion");
            CallNumAreaDic.Add(300, "Social sciences");
            CallNumAreaDic.Add(400, "Language");
            CallNumAreaDic.Add(500, "Science");
            CallNumAreaDic.Add(600, "Technology");
            CallNumAreaDic.Add(700, "Arts & recreation");
            CallNumAreaDic.Add(800, "Literature");
            CallNumAreaDic.Add(900, "History & geography");

            cb1Ident.Items.Add(1);
            cb1Ident.Items.Add(2);
            cb1Ident.Items.Add(3);
            cb1Ident.Items.Add(4);
            cb1Ident.Items.Add(5);
            cb1Ident.Items.Add(6);
            cb1Ident.Items.Add(7);


            cb2Ident.Items.Add(1);
            cb2Ident.Items.Add(2);
            cb2Ident.Items.Add(3);
            cb2Ident.Items.Add(4);
            cb2Ident.Items.Add(5);
            cb2Ident.Items.Add(6);
            cb2Ident.Items.Add(7);


            cb3Ident.Items.Add(1);
            cb3Ident.Items.Add(2);
            cb3Ident.Items.Add(3);
            cb3Ident.Items.Add(4);
            cb3Ident.Items.Add(5);
            cb3Ident.Items.Add(6);
            cb3Ident.Items.Add(7);


            cb4Ident.Items.Add(1);
            cb4Ident.Items.Add(2);
            cb4Ident.Items.Add(3);
            cb4Ident.Items.Add(4);
            cb4Ident.Items.Add(5);
            cb4Ident.Items.Add(6);
            cb4Ident.Items.Add(7);



            keys = new List<int>(CallNumAreaDic.Keys);
            description = new List<string>(CallNumAreaDic.Values);

            ListofAreas = new List<idAreas>();


            for (int i = 0; i < keys.Count; i++)
            {
                ListofAreas.Add(new idAreas(keys[i], description[i]));

            }

            getQuestions();
            getAnswers();
            decideBetweenNumOrDiscriptions();



        }

        public void getQuestions()
        {

            ListofPossabileQuestions = new List<idAreas>();
            ListofAreas.Shuffle();
            ListofPossabileQuestions = ListofAreas;
            Random rand = new Random();
            int Chose = rand.Next(0, 7);

            ListofPossabileQuestions.RemoveRange(Chose, 3);
            string g = "";
            for (int i = 0; i < ListofPossabileQuestions.Count; i++)
            {
                g = g + i + " " + ListofPossabileQuestions[i].Keys + " " + ListofPossabileQuestions[i].Desriptions1 + "\n";

            }
            MessageBox.Show("This is just to help my in testing:\n" + g);




        }

        public void getAnswers()
        {

            ListofAnswers = new List<idAreas>();

            Random r1 = new Random();
            int ind1 = r1.Next(0, 6);

            int ind2 = 10, ind3 = 10, ind4 = 10;
            while (ind2 == 10)
            {
                Random r2 = new Random();
                int temp = r2.Next(0, 6);
                if (temp != ind1)
                {
                    ind2 = temp;
                }

            }
            while (ind3 == 10)
            {
                Random r2 = new Random();
                int temp = r2.Next(0, 6);
                if (temp != ind1 && temp != ind2)
                {
                    ind3 = temp;
                }

            } while (ind4 == 10)
            {
                Random r2 = new Random();
                int temp = r2.Next(0, 6);
                if (temp != ind1 && temp != ind2 && temp != ind3)
                {
                    ind4 = temp;
                }

            }



            ListofAnswers.Add(new idAreas(ListofPossabileQuestions[ind1].Keys, ListofPossabileQuestions[ind1].Desriptions1));
            ListofAnswers.Add(new idAreas(ListofPossabileQuestions[ind2].Keys, ListofPossabileQuestions[ind2].Desriptions1));
            ListofAnswers.Add(new idAreas(ListofPossabileQuestions[ind3].Keys, ListofPossabileQuestions[ind3].Desriptions1));
            ListofAnswers.Add(new idAreas(ListofPossabileQuestions[ind4].Keys, ListofPossabileQuestions[ind4].Desriptions1));


            ANswerIdex = new List<int>();
            ANswerIdex.Add(ind1);
            ANswerIdex.Add(ind2);
            ANswerIdex.Add(ind3);
            ANswerIdex.Add(ind4);

            string g = "";
            for (int i = 0; i < ListofAnswers.Count; i++)
            {
                g = g + i + " " + ListofAnswers[i].Keys + " " + ListofAnswers[i].Desriptions1 + "\n";

            }
            MessageBox.Show("This is just to help my in testing:\n" + g);
        }
        public void setNumberAsColA()
        {
            setLabels(ListofPossabileQuestions[0].Desriptions1, ListofPossabileQuestions[1].Desriptions1, ListofPossabileQuestions[2].Desriptions1, ListofPossabileQuestions[3].Desriptions1, ListofPossabileQuestions[4].Desriptions1, ListofPossabileQuestions[5].Desriptions1, ListofPossabileQuestions[6].Desriptions1, Convert.ToString(ListofAnswers[0].Keys), Convert.ToString(ListofAnswers[1].Keys), Convert.ToString(ListofAnswers[2].Keys), Convert.ToString(ListofAnswers[3].Keys));

        }
        public void setDescriptionrAsColA()
        {

            setLabels(Convert.ToString(ListofPossabileQuestions[0].Keys), Convert.ToString(ListofPossabileQuestions[1].Keys),
                Convert.ToString(ListofPossabileQuestions[2].Keys), Convert.ToString(ListofPossabileQuestions[3].Keys), Convert.ToString(ListofPossabileQuestions[4].Keys), Convert.ToString(ListofPossabileQuestions[5].Keys), Convert.ToString(ListofPossabileQuestions[6].Keys), ListofAnswers[0].Desriptions1, ListofAnswers[1].Desriptions1, ListofAnswers[2].Desriptions1, ListofAnswers[3].Desriptions1);
        }

        public void setLabels(string answer1, string answer2, string answer3, string answer4, string answer5, string answer6, string answer7, string Question1,
            string Question2, string Question3, string Question4)
        {
            Q1.Text = Question1;
            Q2.Text = Question2;
            Q3.Text = Question3;
            Q4.Text = Question4;

            A1.Text = answer1;
            A2.Text = answer2;
            A3.Text = answer3;
            A4.Text = answer4;
            A5.Text = answer5;
            A6.Text = answer6;
            A7.Text = answer7;

        }

        public void decideBetweenNumOrDiscriptions()
        {

            Random random = new Random();
            int Chose = random.Next(0, 2);
            if (Chose == 0)
            {
                setNumberAsColA();
            }
            else
            {
                setDescriptionrAsColA();
            }


        }
        private void GetSelectedvaluesfromCombobox(ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4)
        {

            if (cb1 != null && cb2 != null
                && cb3 != null && cb4 != null
               )
            {
                // Fill the list
                List<int> selectedvalues = new List<int>(10);
                selectedvalues.Add(Convert.ToInt32(cb1.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb2.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb3.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb4.SelectedItem));


                //string p = " ";
                //foreach (int s in selectedvalues) {
                //    p += p +" "+s+" "; 
                //}
                //MessageBox.Show(p);


                if (selectedvalues.Count != selectedvalues.Distinct().Count())
                {
                    // Duplicates exist
                    MessageBox.Show("Please Make Sure You dont Select Multiple Of the Same Values in the Order call Number Collom");
                }
                else
                {

                    CheckAnswers(selectedvalues[0], selectedvalues[1], selectedvalues[2], selectedvalues[3], XpNumCurrent);

                    //for (int i = 0; i < ANswerIdex.Count; i++)
                    //{
                    //    if (ANswerIdex[i] == selectedvalues[i])
                    //    {
                    //        score = score + 100;
                    //    }

                    //}
                }


            }




        }

        private void CheckAnswers(int p1, int p2, int p3, int p4, int currentScore)
        {
            int score = currentScore;


            if (ListofAnswers[0].Keys == ListofPossabileQuestions[p1 - 1].Keys)
            {
                score = score + 25;
            }
            if (ListofAnswers[1].Keys == ListofPossabileQuestions[p2 - 1].Keys)
            {
                score = score + 25;
            }
            if (ListofAnswers[2].Keys == ListofPossabileQuestions[p3 - 1].Keys)
            {
                score = score + 25;
            }
            if (ListofAnswers[3].Keys == ListofPossabileQuestions[p4 - 1].Keys)
            {
                score = score + 25;
            }



            MessageBox.Show("Score = " + score);

            XpNumNew = score;
            SetXpForPlayer(XpNumCurrent, XpNumNew);


            IdentifyAreas ia = new IdentifyAreas();
            this.Close();
            ia.Show();






        }
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
            if (Score > 0)
            {
                // SaveScore(Score);
            }


        }
        private void SetingProgressBarANdLabel(int Score, int Min, int Max, int Level)
        {

            lblXpnum.Text = "Points: " + Score.ToString() + " of " + Max + " Level: " + Level;//setting label
            progressbarforXpIA.Maximum = Max;//setting Bar max
            progressbarforXpIA.Minimum = Min;//setting Bar Min
            progressbarforXpIA.Value = Score;//setting Bar Value

        }
        private void ReadScore()
        {

            //string text = System.IO.File.ReadAllText("/TextFileScore/Score.txt");

            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(@"Score.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    MessageBox.Show(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                XpNumCurrent = Convert.ToInt32(line);

                SetXpForPlayer(XpNumCurrent, XpNumNew);



                MessageBox.Show(XpNumCurrent.ToString());


                sr.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                MessageBox.Show("Executing finally block.");
            }

        }
        private void SaveScore(int Score)
        {

            //string text = System.IO.File.ReadAllText("/TextFileScore/Score.txt");
            DeleteFile();
            CreatetFile();


            try
            {
                //Pass the file path and file name to the StreamReader constructor
                using (StreamWriter sw = new StreamWriter(@"Score.txt"))
                {
                    sw.WriteLine(Score);
                }
                //Read the first line of text


                //close the file



            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                MessageBox.Show("Executing finally block.");
            }

        }
        public void DeleteFile()
        {
            if (File.Exists(@"Score.txt"))
            {
                File.Delete(@"Score.txt");
                MessageBox.Show("File Deleted");
            }
        }
        public void CreatetFile()
        {
            if (!File.Exists(@"Score.txt"))
            {
                File.Create(@"Score.txt");
                MessageBox.Show("File created");
            }
        }
    }
}

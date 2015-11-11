using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using own = ownlibary.Class1;
using _8Ball_Anwendung;


namespace _8Ball_Anwendung
{
    public partial class Form1 : Form
    {
        string[] Meldungen = { "Spieler 2 hat gewonnen", "Spieler 1 hat gewonnen", "Spieler 1 an der Reihe", "Spieler 2 an der Reihe", "Spieler 1 Ball in Hand", "Spieler 2 Ball in Hand" };
        WrapperForLibs mywrapper = new WrapperForLibs();
        Boolean chooselibrary = false;

        public Form1()
        {
            InitializeComponent();
            tb_Ausgabe.Clear();
            tb_Ausgabe.Text += "Neues Spiel" + Environment.NewLine;
        }

        private void hit_Click(object sender, EventArgs e)
        {


            //Inizialisierung von Variablen aus der GUI
            bool hit = true;
            int round = Int32.Parse(lb_count.Text);
            int hitBalls = Int32.Parse(touchedBalls.Text);
            string[] sinkedBallsS = elmBalls.Text.Split(',');
            int ansage = 0;
            if (cb_ansage.SelectedItem != null)
            {
                ansage = Int32.Parse(cb_ansage.SelectedItem.ToString());
            }
            int[] sinkedBalls = new int[0];

            if (sinkedBallsS[0] != "")
            {
                sinkedBalls = new int[sinkedBallsS.Length];
                for (int i = 0; i < sinkedBalls.Length; i++)
                {
                    sinkedBalls[i] = Int32.Parse(sinkedBallsS[i]);
                }
            }


            if (radioButton1.Checked == true)
            {
                chooselibrary = false;
            }
            else if(radioButton2.Checked == true)
            {
                chooselibrary = true;
            }

            //Kein Ball getroffen?
            if(hitBalls == 0 && sinkedBalls.Length == 0)
            {
                hit = false;
            }
            
            //Erster Stoss?
            if (round == 0)
            {
                int m = mywrapper.first(hitBalls, hit, sinkedBalls, chooselibrary);
                lb_count.Text = "1";
                lb_ansage.Visible = true;
                cb_ansage.Visible = true;
                if (m > 0)
                {
                    tb_Ausgabe.Text += Meldungen[m - 1] + Environment.NewLine;
                }
                else
                {
                    tb_Ausgabe.Text += "Spiel Fehler";
                }
            }
            else
            {

                //zweiter und folgende Stöße
                mywrapper.ansage(ansage, chooselibrary);
                int m = mywrapper.other(hitBalls, sinkedBalls, chooselibrary);

                lb_count.Text = round + 1 + "";
                if (m > 0)
                {
                    tb_Ausgabe.Text += Meldungen[m - 1] + Environment.NewLine;
                }
                else
                {
                    tb_Ausgabe.Text += "Spiel Fehler";
                }


            }
           
        }

    }
}

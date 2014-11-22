using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        public static double czas_pozostaly = 0;
        public static string rodzaj = "s";

        public Form1()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            InitializeComponent();
        }

        private void Godziny_CheckedChanged(object sender, EventArgs e)
        {
            if (GodzinyInput.Enabled)
                GodzinyInput.Enabled = false;
            else
                GodzinyInput.Enabled = true;
        }

        private void Minuty_CheckedChanged(object sender, EventArgs e)
        {
            if (MinutyInput.Enabled)
                MinutyInput.Enabled = false;
            else
                MinutyInput.Enabled = true;
        }

        private void Sekundy_CheckedChanged(object sender, EventArgs e)
        {
            if (SekundyInput.Enabled)
                SekundyInput.Enabled = false;
            else
                SekundyInput.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool powodzenie = true;
            if (Start.Text == "Start")
            {
                int h, m, s;
                string blad = "";
                if (!Int32.TryParse("0" + GodzinyInput.Text, out h))
                {
                    blad += "Godzina nie jest numerem.\n";
                    powodzenie = false;
                }
                if (!Int32.TryParse("0" + MinutyInput.Text, out m))
                {
                    blad += "Minuty nie są numerem.\n";
                    powodzenie = false;
                }
                if (!Int32.TryParse("0" + SekundyInput.Text, out s))
                {
                    blad += "Sekundy nie są numerem.\n";
                    powodzenie = false;
                }
                czas_pozostaly = h * 3600 + m * 60 + s; // Obliczanie czasu
                if (czas_pozostaly == 0 & powodzenie == true)
                {
                    blad += "Nie ustawiono czasu";
                    powodzenie = false;
                }
                if (powodzenie == false)
                {
                    MessageBox.Show(blad);
                }
                else
                {
                    Godziny.Enabled = false;
                    GodzinyInput.Enabled = false;
                    Minuty.Enabled = false;
                    MinutyInput.Enabled = false;
                    Sekundy.Enabled = false;
                    SekundyInput.Enabled = false;

                    aTimer.Enabled = true;
                    leftTime.Text = Convert.ToString(TimeSpan.FromSeconds(czas_pozostaly));
                    Start.Text = "Przerwij";
                }
            }
            else
            {
                Start.Text = "Start";
                aTimer.Enabled = false;

                Godziny.Enabled = true;
                GodzinyInput.Enabled = true;
                Minuty.Enabled = true;
                MinutyInput.Enabled = true;
                Sekundy.Enabled = true;
                SekundyInput.Enabled = true;
            }


        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //funkcja wywołana co 1s
            if (czas_pozostaly <= 0)
            {
                aTimer.Enabled = false;
                operacja();
                Application.Exit();
            }
            else
            {
                czas_pozostaly--;
                this.Invoke((MethodInvoker)delegate
                {
                    leftTime.Text = Convert.ToString(TimeSpan.FromSeconds(czas_pozostaly));// zmiana czasu i ustawienie go w labelu
                });
            }
        }
        
        private void Wylaczenie_Click(object sender, EventArgs e)
        {
            if (Wylaczenie.Checked == false)
            {
                Wylaczenie.Checked = true;
                Hibernacja.Checked = false;
                Restart.Checked = false;
                rodzaj = "s";
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            if (Restart.Checked == false)
            {
                Wylaczenie.Checked = false;
                Hibernacja.Checked = false;
                Restart.Checked = true;
                rodzaj = "r";
            }
        }

        private void Hibernacja_Click(object sender, EventArgs e)
        {
            if (Hibernacja.Checked == false)
            {
                Wylaczenie.Checked = false;
                Hibernacja.Checked = true;
                Restart.Checked = false;
                rodzaj = "h";
            }
        }
        public void operacja()
        {
            Process.Start("shutdown","/" + rodzaj + " /t 0");// dodać osobno XP
        }

    }
}

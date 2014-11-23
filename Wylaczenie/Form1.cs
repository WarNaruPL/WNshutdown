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
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason); // odwołanie do bibloteki aby m.in wyłączyć komputer
        Version win8version = new Version(6, 2, 9200, 0);// sprawdzanie wersji windows

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


                if (Godziny.Checked == false)
                    h = 0;
                if (Minuty.Checked == false)
                    m = 0;
                if (Sekundy.Checked == false)
                    s = 0;

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
                Godziny.Checked = true;
                GodzinyInput.Enabled = true;
                Minuty.Enabled = true;
                Minuty.Checked = true;
                MinutyInput.Enabled = true;
                Sekundy.Enabled = true;
                Sekundy.Checked = true;
                SekundyInput.Enabled = true;
            }


        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //funkcja wywołana co 1s
            if (czas_pozostaly <= 0)
            {
                aTimer.Enabled = false;
                operacja(Wyloguj.Checked, Wylaczenie.Checked, Hibernacja.Checked);
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
        public void operacja(bool wyloguj, bool wylaczenie, bool hibernacja)
        {

            if (wyloguj)
                ExitWindowsEx(0, 0x00040000); // 0 - wylogowanie uzyttkownika, wartość 0x powód - wywołane przez aplikacje
            if (wylaczenie)
                if (Environment.OSVersion.Platform == PlatformID.Win32NT &&
                    Environment.OSVersion.Version >= win8version)
                {
                    // To jest system win 8 lub nowszy i akcpetuje hybrydowe wyłączanie komputera
                    ExitWindowsEx(0x00400000, 0x00040000);
                }
                else
                    ExitWindowsEx(0x00000008, 0x00040000); // 0x - wylacznie komputera, wartość 0x powód - wywołane przez aplikacje
            if (hibernacja) ;

        }

        private void MinutyInput_Leave(object sender, EventArgs e)
        {
            if (MinutyInput.Text != "" && Int32.Parse(MinutyInput.Text) < 0)
                MinutyInput.Text = "0";
            if (MinutyInput.Text != "" && Int32.Parse(MinutyInput.Text) > 59)
                MinutyInput.Text = "59";
        }

        private void SekundyInput_Leave(object sender, EventArgs e)
        {
            if (SekundyInput.Text != "" && Int32.Parse(SekundyInput.Text) < 0)
                SekundyInput.Text = "0";
            if (SekundyInput.Text != "" && Int32.Parse(SekundyInput.Text) > 59)
                SekundyInput.Text = "59";
        }

        private void GodzinyInput_Leave(object sender, EventArgs e)
        {
            if (GodzinyInput.Text != "" && Int32.Parse(GodzinyInput.Text) < 0)
                GodzinyInput.Text = "0";
            if (GodzinyInput.Text != "" && Int32.Parse(GodzinyInput.Text) > 240)
                GodzinyInput.Text = "240";
        }

    }
}

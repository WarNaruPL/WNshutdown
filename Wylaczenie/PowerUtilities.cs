using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    class ZarzadzanieUruchomieniem
    {
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);//odwoalnie do wylogowania zewnetrznej bibloteki

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);// odwolanie do uspienia i hibernacji

        public static void Metoda(int rodzaj)
        {
            if (rodzaj ==0)
                ExitWindowsEx(0, 0); // wylogowanie
            else if (rodzaj == 1)
                Process.Start("shutdown", "/s /t 0");
            else if (rodzaj == 2)
                SetSuspendState(false, true, true);
            else if (rodzaj == 3)
                SetSuspendState(true, true, true);
        }
    }
}

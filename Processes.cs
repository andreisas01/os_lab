using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborator
{
    public partial class Processes : Form
    {
        public Processes()
        {
            InitializeComponent();
        }

        private void notepad_button_Click(object sender, EventArgs e)
        {
            WinApiClass.SECURITY_ATTRIBUTES security_attr_proc = new WinApiClass.SECURITY_ATTRIBUTES();
            WinApiClass.SECURITY_ATTRIBUTES security_attr_thread = new WinApiClass.SECURITY_ATTRIBUTES();
            WinApiClass.STARTUPINFO startup_info = new WinApiClass.STARTUPINFO();
            WinApiClass.PROCESS_INFORMATION proc_info = new WinApiClass.PROCESS_INFORMATION();

            WinApiClass.CreateProcess(
                "C:\\Windows\\System32\\notepad.exe",
                null,
                ref security_attr_proc,
                ref security_attr_thread,
                false,
                0,
                IntPtr.Zero,
                null,
                ref startup_info,
                out proc_info
            );

            display_window.Text += "Notepad process created with PID: " + proc_info.dwProcessId + '\n';

            WinApiClass.CloseHandle((uint)proc_info.hProcess);
            WinApiClass.CloseHandle((uint)proc_info.hThread);
        }

        private void paint_button_Click(object sender, EventArgs e)
        {
            WinApiClass.SECURITY_ATTRIBUTES security_attr_proc = new WinApiClass.SECURITY_ATTRIBUTES();
            WinApiClass.SECURITY_ATTRIBUTES security_attr_thread = new WinApiClass.SECURITY_ATTRIBUTES();
            WinApiClass.STARTUPINFO startup_info = new WinApiClass.STARTUPINFO();
            WinApiClass.PROCESS_INFORMATION proc_info = new WinApiClass.PROCESS_INFORMATION();

            WinApiClass.CreateProcess(
                "C:\\Program Files\\WindowsApps\\Microsoft.Paint_11.2601.401.0_x64__8wekyb3d8bbwe\\PaintApp\\mspaint.exe",
                null,
                ref security_attr_proc,
                ref security_attr_thread,
                false,
                0,
                IntPtr.Zero,
                null,
                ref startup_info,
                out proc_info
            );

            display_window.Text += "Paint process created with PID: " + proc_info.dwProcessId + '\n';

            WinApiClass.CloseHandle((uint)proc_info.hProcess);
            WinApiClass.CloseHandle((uint)proc_info.hThread);
        }

        private void txt_button_Click(object sender, EventArgs e)
        {
            WinApiClass.SECURITY_ATTRIBUTES security_attr_proc = new WinApiClass.SECURITY_ATTRIBUTES();
            WinApiClass.SECURITY_ATTRIBUTES security_attr_thread = new WinApiClass.SECURITY_ATTRIBUTES();
            WinApiClass.STARTUPINFO startup_info = new WinApiClass.STARTUPINFO();
            WinApiClass.PROCESS_INFORMATION proc_info = new WinApiClass.PROCESS_INFORMATION();

            WinApiClass.CreateProcess(
                "C:\\Windows\\System32\\notepad.exe",
                " \"D:\\ulbs computer science\\homework\\Calculatoare Numerice\\INT21H_functions.txt\"",
                ref security_attr_proc,
                ref security_attr_thread,
                false,
                0,
                IntPtr.Zero,
                null,
                ref startup_info,
                out proc_info
            );

            display_window.Text += "Notepad process (opening a file) created with PID: " + proc_info.dwProcessId + '\n';

            WinApiClass.CloseHandle((uint)proc_info.hProcess);
            WinApiClass.CloseHandle((uint)proc_info.hThread);
        }
    }
}

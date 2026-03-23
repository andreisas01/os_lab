using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static laborator.WinApiClass;

namespace laborator
{
    public partial class TaskManager : Form
    {
        const uint TH32CS_SNAPPROCESS = 0x00000002;
        const int PROCESS_TERMINATE = 0x0001;

        IntPtr hProcessSnap = IntPtr.Zero;
        WinApiClass.PROCESSENTRY32 procEntry = new WinApiClass.PROCESSENTRY32();

        public TaskManager()
        {
            InitializeComponent();
            find_processes();
        }

        private void find_processes()
        {
            hProcessSnap = WinApiClass.CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
            display_window.Items.Clear();

            procEntry.dwSize = (uint)Marshal.SizeOf(typeof(WinApiClass.PROCESSENTRY32));
            if (WinApiClass.Process32First(hProcessSnap, ref procEntry) == false)
            {
                display_window.Items.Add("No processes found.");
                return;
            }

            do
            {
                String processInfo = $"PID: {procEntry.th32ProcessID} " +
                    $"| PPID: {procEntry.th32ParentProcessID} " +
                    $"| {procEntry.szExeFile}";
                display_window.Items.Add(processInfo);

            } while (WinApiClass.Process32Next(hProcessSnap, ref procEntry) == true);
        }

        private void terminate_process_Click(object sender, EventArgs e)
        {
            if (display_window.SelectedItem == null)
            {
                MessageBox.Show("Please select a process to terminate.");
                return;
            }

            string pattern = @"\bPID:\s*(\d+)\b";
            Match match = Regex.Match(display_window.SelectedItem.ToString(), pattern);
            if (!match.Success)
            {
                MessageBox.Show("Failed to extract PID.");
                return;
            }

            int pid = int.Parse(match.Groups[1].Value);
            IntPtr hProcess = WinApiClass.OpenProcess(PROCESS_TERMINATE, false, pid);
            if(WinApiClass.TerminateProcess(hProcess, 0) == false)
                MessageBox.Show("Failed to terminate process.");
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            find_processes();
        }
    }
}

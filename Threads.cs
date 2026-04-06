using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborator
{
    public enum ThreadState
    {
        New,
        Running,
        Suspended
    }
    public partial class Threads : Form
    {
        private static ThreadState thread_1_state, thread_2_state, thread_3_state;
        private static IntPtr h_thread_1, h_thread_2, h_thread_3;
        private static uint thread_1_id, thread_2_id, thread_3_id;
        private static WinApiClass.ThreadPriority thread_1_priority, thread_2_priority, thread_3_priority;

        public Threads()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            thread_1_state = thread_2_state = thread_3_state = ThreadState.New;
            thread_1_priority = WinApiClass.ThreadPriority.THREAD_PRIORITY_ABOVE_NORMAL;
            thread_2_priority = WinApiClass.ThreadPriority.THREAD_PRIORITY_TIME_CRITICAL;
            thread_3_priority = WinApiClass.ThreadPriority.THREAD_PRIORITY_IDLE;
        }

        // -- Shared functions between all threads --
        private uint increment_progress_bar(IntPtr lpParameter)
        {
            switch (lpParameter.ToInt32())
            {
                case 1:
                    while (progress_bar_1.Value < progress_bar_1.Maximum)
                    {
                        progress_bar_1.Value += 1;
                    }
                    break;
                case 2:
                    while (progress_bar_2.Value < progress_bar_2.Maximum)
                    {
                        progress_bar_2.Value += 5;
                    }
                    break;
                case 3:
                    while (progress_bar_3.Value < progress_bar_3.Maximum)
                    {
                        progress_bar_3.Value += 10;
                    }
                    break;
            }

            return 0;
        }

        private void start_stop_thread(ref IntPtr hThread, ref ThreadState threadState,
            uint threadNumber, ref uint threadId, ref Button button)
        {
            switch (threadState)
            {
                case ThreadState.New:
                    hThread = (IntPtr)WinApiClass.CreateThread(IntPtr.Zero, 0, increment_progress_bar,
                                        new IntPtr(threadNumber), 0, out threadId);

                    threadState = ThreadState.Running;
                    button.Text = "suspend";
                    break;

                case ThreadState.Running:
                    WinApiClass.SuspendThread(hThread);

                    threadState = ThreadState.Suspended;
                    button.Text = "resume";

                    break;

                case ThreadState.Suspended:
                    WinApiClass.ResumeThread(hThread);

                    threadState = ThreadState.Running;
                    button.Text = "suspend";
                    break;
            }
        }

        private void get_thread_info(IntPtr hThread) 
        {
            WinApiClass.FILETIME creation_time, exit_time, kernel_time, user_time;
            if (!WinApiClass.GetThreadTimes(hThread,
                out creation_time, out exit_time, out kernel_time, out user_time)) return;

            WinApiClass.SYSTEMTIME creation_system_time, exit_system_time, kernel_system_time, user_system_time;
            if (!WinApiClass.FileTimeToSystemTime(ref creation_time, out creation_system_time)) return;
            if (!WinApiClass.FileTimeToSystemTime(ref exit_time, out exit_system_time)) return;
            if (!WinApiClass.FileTimeToSystemTime(ref kernel_time, out kernel_system_time)) return;
            if (!WinApiClass.FileTimeToSystemTime(ref user_time, out user_system_time)) return;

            MessageBox.Show(
                $"Creation time: {creation_system_time.Second}s {creation_system_time.Milliseconds}ms\n" +
                $"Exit time: {exit_system_time.Second}s {exit_system_time.Milliseconds}ms\n" +
                $"Kernel time: {kernel_system_time.Second}s {kernel_system_time.Milliseconds} ms\n" +
                $"User time: {user_system_time.Second}s {user_system_time.Milliseconds}ms"
            );
        }

        // -- Start/Stop buttons for each thread --
        private void control_1_button_Click(object sender, EventArgs e)
        {
            start_stop_thread(ref h_thread_1, ref thread_1_state, 1, ref thread_1_id, ref control_1_button);
        }

        private void control_2_button_Click(object sender, EventArgs e)
        {
            start_stop_thread(ref h_thread_2, ref thread_2_state, 2, ref thread_2_id, ref control_2_button);
        }

        private void control_3_button_Click(object sender, EventArgs e)
        {
            start_stop_thread(ref h_thread_3, ref thread_3_state, 3, ref thread_3_id, ref control_3_button);
        }


        // -- Info buttons for each thread --
        private void info_1_button_Click(object sender, EventArgs e)
        {
            get_thread_info(h_thread_1);
        }

        private void info_2_button_Click(object sender, EventArgs e)
        {
            get_thread_info(h_thread_2);
        }

        private void info_3_button_Click(object sender, EventArgs e)
        {
            get_thread_info(h_thread_3);
        }
    }
}

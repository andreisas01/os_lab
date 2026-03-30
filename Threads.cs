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
        public Threads()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            thread_1_state = thread_2_state = thread_3_state = ThreadState.New;
        }

        private uint increment_progress_bar_1(IntPtr lpParameter)
        {
            while (progress_bar_1.Value < progress_bar_1.Maximum)
            {
                progress_bar_1.Value += 1;
            }

            return 0;
        }
        private uint increment_progress_bar_2(IntPtr lpParameter)
        {
            while (progress_bar_2.Value < progress_bar_2.Maximum)
            {
                progress_bar_2.Value += 5;
            }

            return 0;
        }
        private uint increment_progress_bar_3(IntPtr lpParameter)
        {
            while (progress_bar_3.Value < progress_bar_3.Maximum)
            {
                progress_bar_3.Value += 10;
            }

            return 0;
        }

        private void control_1_button_Click(object sender, EventArgs e)
        {
            switch (thread_1_state)
            {
                case ThreadState.New:
                    h_thread_1 = (IntPtr)WinApiClass.CreateThread(IntPtr.Zero, 0, increment_progress_bar_1,
                                        IntPtr.Zero, 0, out thread_1_id);

                    thread_1_state = ThreadState.Running;
                    control_1_button.Text = "suspend";
                    break;

                case ThreadState.Running:
                    WinApiClass.SuspendThread(h_thread_1);

                    thread_1_state = ThreadState.Suspended;
                    control_1_button.Text = "resume";

                    break;

                case ThreadState.Suspended:
                    WinApiClass.ResumeThread(h_thread_1);

                    thread_1_state = ThreadState.Running;
                    control_1_button.Text = "suspend";
                    break;
            }
        }

        private void control_2_button_Click(object sender, EventArgs e)
        {
            switch (thread_2_state)
            {
                case ThreadState.New:
                    h_thread_2 = (IntPtr)WinApiClass.CreateThread(IntPtr.Zero, 0, increment_progress_bar_2,
                                        IntPtr.Zero, 0, out thread_2_id);

                    thread_2_state = ThreadState.Running;
                    control_2_button.Text = "suspend";
                    break;

                case ThreadState.Running:
                    WinApiClass.SuspendThread(h_thread_2);

                    thread_2_state = ThreadState.Suspended;
                    control_2_button.Text = "resume";

                    break;

                case ThreadState.Suspended:
                    WinApiClass.ResumeThread(h_thread_2);

                    thread_2_state = ThreadState.Running;
                    control_2_button.Text = "suspend";
                    break;
            }
        }

        private void control_3_button_Click(object sender, EventArgs e)
        {
            switch (thread_3_state)
            {
                case ThreadState.New:
                    h_thread_3 = (IntPtr)WinApiClass.CreateThread(IntPtr.Zero, 0, increment_progress_bar_3,
                                        IntPtr.Zero, 0, out thread_3_id);

                    thread_3_state = ThreadState.Running;
                    control_3_button.Text = "suspend";
                    break;

                case ThreadState.Running:
                    WinApiClass.SuspendThread(h_thread_3);

                    thread_3_state = ThreadState.Suspended;
                    control_3_button.Text = "resume";

                    break;

                case ThreadState.Suspended:
                    WinApiClass.ResumeThread(h_thread_3);

                    thread_3_state = ThreadState.Running;
                    control_3_button.Text = "suspend";
                    break;
            }
        }
    }
}

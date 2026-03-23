namespace laborator
{
    partial class TaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.display_window = new System.Windows.Forms.ListBox();
            this.terminate_process = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.refresh_timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // display_window
            // 
            this.display_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_window.FormattingEnabled = true;
            this.display_window.ItemHeight = 25;
            this.display_window.Location = new System.Drawing.Point(175, 35);
            this.display_window.Name = "display_window";
            this.display_window.Size = new System.Drawing.Size(690, 429);
            this.display_window.TabIndex = 2;
            // 
            // terminate_process
            // 
            this.terminate_process.Location = new System.Drawing.Point(26, 35);
            this.terminate_process.Name = "terminate_process";
            this.terminate_process.Size = new System.Drawing.Size(114, 48);
            this.terminate_process.TabIndex = 3;
            this.terminate_process.Text = "terminate";
            this.terminate_process.UseVisualStyleBackColor = true;
            this.terminate_process.Click += new System.EventHandler(this.terminate_process_Click);
            // 
            // refresh_timer
            // 
            this.refresh_timer.Enabled = true;
            this.refresh_timer.Interval = 10000;
            this.refresh_timer.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 497);
            this.Controls.Add(this.terminate_process);
            this.Controls.Add(this.display_window);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox display_window;
        private System.Windows.Forms.Button terminate_process;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer refresh_timer;
        private System.Windows.Forms.Timer timer2;
    }
}
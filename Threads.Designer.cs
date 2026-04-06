namespace laborator
{
    partial class Threads
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
            this.progress_bar_1 = new System.Windows.Forms.ProgressBar();
            this.control_1_button = new System.Windows.Forms.Button();
            this.control_2_button = new System.Windows.Forms.Button();
            this.control_3_button = new System.Windows.Forms.Button();
            this.progress_bar_2 = new System.Windows.Forms.ProgressBar();
            this.progress_bar_3 = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.info_1_button = new System.Windows.Forms.Button();
            this.info_2_button = new System.Windows.Forms.Button();
            this.info_3_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progress_bar_1
            // 
            this.progress_bar_1.Location = new System.Drawing.Point(269, 87);
            this.progress_bar_1.Maximum = 1000000;
            this.progress_bar_1.Name = "progress_bar_1";
            this.progress_bar_1.Size = new System.Drawing.Size(469, 41);
            this.progress_bar_1.Step = 1;
            this.progress_bar_1.TabIndex = 0;
            // 
            // control_1_button
            // 
            this.control_1_button.Location = new System.Drawing.Point(97, 87);
            this.control_1_button.Name = "control_1_button";
            this.control_1_button.Size = new System.Drawing.Size(112, 41);
            this.control_1_button.TabIndex = 1;
            this.control_1_button.Text = "start";
            this.control_1_button.UseVisualStyleBackColor = true;
            this.control_1_button.Click += new System.EventHandler(this.control_1_button_Click);
            // 
            // control_2_button
            // 
            this.control_2_button.Location = new System.Drawing.Point(97, 172);
            this.control_2_button.Name = "control_2_button";
            this.control_2_button.Size = new System.Drawing.Size(112, 41);
            this.control_2_button.TabIndex = 2;
            this.control_2_button.Text = "start";
            this.control_2_button.UseVisualStyleBackColor = true;
            this.control_2_button.Click += new System.EventHandler(this.control_2_button_Click);
            // 
            // control_3_button
            // 
            this.control_3_button.Location = new System.Drawing.Point(97, 261);
            this.control_3_button.Name = "control_3_button";
            this.control_3_button.Size = new System.Drawing.Size(112, 41);
            this.control_3_button.TabIndex = 3;
            this.control_3_button.Text = "start";
            this.control_3_button.UseVisualStyleBackColor = true;
            this.control_3_button.Click += new System.EventHandler(this.control_3_button_Click);
            // 
            // progress_bar_2
            // 
            this.progress_bar_2.Location = new System.Drawing.Point(269, 172);
            this.progress_bar_2.Maximum = 1000000;
            this.progress_bar_2.Name = "progress_bar_2";
            this.progress_bar_2.Size = new System.Drawing.Size(469, 41);
            this.progress_bar_2.Step = 1;
            this.progress_bar_2.TabIndex = 4;
            // 
            // progress_bar_3
            // 
            this.progress_bar_3.Location = new System.Drawing.Point(269, 261);
            this.progress_bar_3.Maximum = 1000000;
            this.progress_bar_3.Name = "progress_bar_3";
            this.progress_bar_3.Size = new System.Drawing.Size(469, 41);
            this.progress_bar_3.Step = 1;
            this.progress_bar_3.TabIndex = 5;
            // 
            // info_1_button
            // 
            this.info_1_button.Location = new System.Drawing.Point(761, 91);
            this.info_1_button.Name = "info_1_button";
            this.info_1_button.Size = new System.Drawing.Size(33, 32);
            this.info_1_button.TabIndex = 6;
            this.info_1_button.Text = "i";
            this.info_1_button.UseVisualStyleBackColor = true;
            this.info_1_button.Click += new System.EventHandler(this.info_1_button_Click);
            // 
            // info_2_button
            // 
            this.info_2_button.Location = new System.Drawing.Point(761, 176);
            this.info_2_button.Name = "info_2_button";
            this.info_2_button.Size = new System.Drawing.Size(33, 32);
            this.info_2_button.TabIndex = 7;
            this.info_2_button.Text = "i";
            this.info_2_button.UseVisualStyleBackColor = true;
            this.info_2_button.Click += new System.EventHandler(this.info_2_button_Click);
            // 
            // info_3_button
            // 
            this.info_3_button.Location = new System.Drawing.Point(761, 265);
            this.info_3_button.Name = "info_3_button";
            this.info_3_button.Size = new System.Drawing.Size(33, 32);
            this.info_3_button.TabIndex = 8;
            this.info_3_button.Text = "i";
            this.info_3_button.UseVisualStyleBackColor = true;
            this.info_3_button.Click += new System.EventHandler(this.info_3_button_Click);
            // 
            // Threads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.info_3_button);
            this.Controls.Add(this.info_2_button);
            this.Controls.Add(this.info_1_button);
            this.Controls.Add(this.progress_bar_3);
            this.Controls.Add(this.progress_bar_2);
            this.Controls.Add(this.control_3_button);
            this.Controls.Add(this.control_2_button);
            this.Controls.Add(this.control_1_button);
            this.Controls.Add(this.progress_bar_1);
            this.Name = "Threads";
            this.Text = "Threads";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress_bar_1;
        private System.Windows.Forms.Button control_1_button;
        private System.Windows.Forms.Button control_2_button;
        private System.Windows.Forms.Button control_3_button;
        private System.Windows.Forms.ProgressBar progress_bar_2;
        private System.Windows.Forms.ProgressBar progress_bar_3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button info_1_button;
        private System.Windows.Forms.Button info_2_button;
        private System.Windows.Forms.Button info_3_button;
    }
}
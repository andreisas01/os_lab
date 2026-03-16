namespace laborator
{
    partial class Processes
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
            this.notepad_button = new System.Windows.Forms.Button();
            this.paint_button = new System.Windows.Forms.Button();
            this.txt_button = new System.Windows.Forms.Button();
            this.display_window = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // notepad_button
            // 
            this.notepad_button.Location = new System.Drawing.Point(69, 89);
            this.notepad_button.Name = "notepad_button";
            this.notepad_button.Size = new System.Drawing.Size(130, 54);
            this.notepad_button.TabIndex = 0;
            this.notepad_button.Text = "notepad";
            this.notepad_button.UseVisualStyleBackColor = true;
            this.notepad_button.Click += new System.EventHandler(this.notepad_button_Click);
            // 
            // paint_button
            // 
            this.paint_button.Location = new System.Drawing.Point(69, 173);
            this.paint_button.Name = "paint_button";
            this.paint_button.Size = new System.Drawing.Size(130, 54);
            this.paint_button.TabIndex = 1;
            this.paint_button.Text = "paint";
            this.paint_button.UseVisualStyleBackColor = true;
            this.paint_button.Click += new System.EventHandler(this.paint_button_Click);
            // 
            // txt_button
            // 
            this.txt_button.Location = new System.Drawing.Point(69, 265);
            this.txt_button.Name = "txt_button";
            this.txt_button.Size = new System.Drawing.Size(130, 54);
            this.txt_button.TabIndex = 2;
            this.txt_button.Text = "open txt";
            this.txt_button.UseVisualStyleBackColor = true;
            this.txt_button.Click += new System.EventHandler(this.txt_button_Click);
            // 
            // display_window
            // 
            this.display_window.Location = new System.Drawing.Point(340, 27);
            this.display_window.Name = "display_window";
            this.display_window.Size = new System.Drawing.Size(415, 406);
            this.display_window.TabIndex = 3;
            this.display_window.Text = "";
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 501);
            this.Controls.Add(this.display_window);
            this.Controls.Add(this.txt_button);
            this.Controls.Add(this.paint_button);
            this.Controls.Add(this.notepad_button);
            this.Name = "Processes";
            this.Text = "processes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notepad_button;
        private System.Windows.Forms.Button paint_button;
        private System.Windows.Forms.Button txt_button;
        private System.Windows.Forms.RichTextBox display_window;
    }
}


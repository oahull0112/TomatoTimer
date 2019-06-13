namespace TomatoTimer
{
    partial class TomatoView
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.shortBreakButton = new System.Windows.Forms.Button();
            this.longBreakButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(16, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(233, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Log";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // shortBreakButton
            // 
            this.shortBreakButton.Location = new System.Drawing.Point(32, 190);
            this.shortBreakButton.Name = "shortBreakButton";
            this.shortBreakButton.Size = new System.Drawing.Size(110, 40);
            this.shortBreakButton.TabIndex = 6;
            this.shortBreakButton.Text = "Short Break";
            this.shortBreakButton.UseVisualStyleBackColor = true;
            this.shortBreakButton.Click += new System.EventHandler(this.shortBreakButton_Click);
            // 
            // longBreakButton
            // 
            this.longBreakButton.Location = new System.Drawing.Point(188, 190);
            this.longBreakButton.Name = "longBreakButton";
            this.longBreakButton.Size = new System.Drawing.Size(110, 40);
            this.longBreakButton.TabIndex = 7;
            this.longBreakButton.Text = "Long Break";
            this.longBreakButton.UseVisualStyleBackColor = true;
            this.longBreakButton.Click += new System.EventHandler(this.longBreakButton_Click);
            // 
            // TomatoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 332);
            this.Controls.Add(this.longBreakButton);
            this.Controls.Add(this.shortBreakButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "TomatoView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button shortBreakButton;
        private System.Windows.Forms.Button longBreakButton;
    }
}


namespace Task1
{
    partial class Task1
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
            this.lstPop = new System.Windows.Forms.ListBox();
            this.lstPush = new System.Windows.Forms.ListBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPop
            // 
            this.lstPop.FormattingEnabled = true;
            this.lstPop.Location = new System.Drawing.Point(146, 41);
            this.lstPop.Name = "lstPop";
            this.lstPop.Size = new System.Drawing.Size(120, 212);
            this.lstPop.TabIndex = 7;
            // 
            // lstPush
            // 
            this.lstPush.FormattingEnabled = true;
            this.lstPush.Location = new System.Drawing.Point(20, 41);
            this.lstPush.Name = "lstPush";
            this.lstPush.Size = new System.Drawing.Size(120, 212);
            this.lstPush.TabIndex = 6;
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(146, 10);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 5;
            this.btnPop.Text = "pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(19, 10);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 4;
            this.btnPush.Text = "push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstPop);
            this.Controls.Add(this.lstPush);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Name = "Task1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPop;
        private System.Windows.Forms.ListBox lstPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPush;
    }
}


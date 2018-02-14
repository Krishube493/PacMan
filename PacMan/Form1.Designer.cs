namespace PacMan
{
    partial class Form1
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
            this.RunB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunB
            // 
            this.RunB.BackColor = System.Drawing.Color.White;
            this.RunB.ForeColor = System.Drawing.Color.Black;
            this.RunB.Location = new System.Drawing.Point(200, 277);
            this.RunB.Name = "RunB";
            this.RunB.Size = new System.Drawing.Size(75, 25);
            this.RunB.TabIndex = 0;
            this.RunB.Text = "Run";
            this.RunB.UseVisualStyleBackColor = false;
            this.RunB.Click += new System.EventHandler(this.RunB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(504, 357);
            this.Controls.Add(this.RunB);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunB;
    }
}


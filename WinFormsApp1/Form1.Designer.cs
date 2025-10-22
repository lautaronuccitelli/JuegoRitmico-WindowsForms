
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Location = new System.Drawing.Point(543, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.Location = new System.Drawing.Point(265, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.Location = new System.Drawing.Point(265, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button8.Location = new System.Drawing.Point(517, 283);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 51);
            this.button8.TabIndex = 7;
            this.button8.Text = "1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(771, 407);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
    }
}


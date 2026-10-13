namespace AsyncAwaitDemo
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
            label1 = new Label();
            listBox1 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            Browse = new Button();
            txtFileName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 0;
            label1.Text = "File";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(103, 102);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(498, 254);
            listBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Browse
            // 
            Browse.Location = new Point(510, 28);
            Browse.Name = "Browse";
            Browse.Size = new Size(128, 47);
            Browse.TabIndex = 2;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(228, 36);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(276, 31);
            txtFileName.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(218, 375);
            button1.Name = "button1";
            button1.Size = new Size(105, 35);
            button1.TabIndex = 4;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(428, 371);
            button2.Name = "button2";
            button2.Size = new Size(115, 39);
            button2.TabIndex = 5;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 469);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtFileName);
            Controls.Add(Browse);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private OpenFileDialog openFileDialog1;
        private Button Browse;
        private TextBox txtFileName;
        private Button button1;
        private Button button2;
    }
}

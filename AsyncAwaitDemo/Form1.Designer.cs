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
            lblBook1 = new Label();
            txtBook1 = new TextBox();
            btnBrowseBook1 = new Button();
            lblBook2 = new Label();
            txtBook2 = new TextBox();
            btnBrowseBook2 = new Button();
            btnSubmit = new Button();
            btnExit = new Button();
            lstBook1 = new ListBox();
            lstBook2 = new ListBox();
            ofdBook1 = new OpenFileDialog();
            ofdBook2 = new OpenFileDialog();
            SuspendLayout();
            //
            // lblBook1
            //
            lblBook1.AutoSize = true;
            lblBook1.Location = new Point(40, 58);
            lblBook1.Name = "lblBook1";
            lblBook1.Size = new Size(64, 25);
            lblBook1.TabIndex = 0;
            lblBook1.Text = "Book 1";
            //
            // txtBook1
            //
            txtBook1.Location = new Point(110, 55);
            txtBook1.Name = "txtBook1";
            txtBook1.ReadOnly = true;
            txtBook1.Size = new Size(250, 31);
            txtBook1.TabIndex = 1;
            //
            // btnBrowseBook1
            //
            btnBrowseBook1.Location = new Point(375, 52);
            btnBrowseBook1.Name = "btnBrowseBook1";
            btnBrowseBook1.Size = new Size(110, 38);
            btnBrowseBook1.TabIndex = 2;
            btnBrowseBook1.Text = "Browse";
            btnBrowseBook1.UseVisualStyleBackColor = true;
            btnBrowseBook1.Click += btnBrowseBook1_Click;
            //
            // lblBook2
            //
            lblBook2.AutoSize = true;
            lblBook2.Location = new Point(520, 58);
            lblBook2.Name = "lblBook2";
            lblBook2.Size = new Size(64, 25);
            lblBook2.TabIndex = 3;
            lblBook2.Text = "Book 2";
            //
            // txtBook2
            //
            txtBook2.Location = new Point(590, 55);
            txtBook2.Name = "txtBook2";
            txtBook2.ReadOnly = true;
            txtBook2.Size = new Size(250, 31);
            txtBook2.TabIndex = 4;
            //
            // btnBrowseBook2
            //
            btnBrowseBook2.Location = new Point(855, 52);
            btnBrowseBook2.Name = "btnBrowseBook2";
            btnBrowseBook2.Size = new Size(110, 38);
            btnBrowseBook2.TabIndex = 5;
            btnBrowseBook2.Text = "Browse";
            btnBrowseBook2.UseVisualStyleBackColor = true;
            btnBrowseBook2.Click += btnBrowseBook2_Click;
            //
            // btnSubmit
            //
            btnSubmit.Location = new Point(370, 115);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 38);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            //
            // btnExit
            //
            btnExit.Location = new Point(520, 115);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 38);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            //
            // lstBook1
            //
            lstBook1.FormattingEnabled = true;
            lstBook1.ItemHeight = 25;
            lstBook1.Location = new Point(40, 180);
            lstBook1.Name = "lstBook1";
            lstBook1.Size = new Size(445, 329);
            lstBook1.TabIndex = 8;
            //
            // lstBook2
            //
            lstBook2.FormattingEnabled = true;
            lstBook2.ItemHeight = 25;
            lstBook2.Location = new Point(520, 180);
            lstBook2.Name = "lstBook2";
            lstBook2.Size = new Size(445, 329);
            lstBook2.TabIndex = 9;
            //
            // ofdBook1
            //
            ofdBook1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdBook1.Title = "Choose Book 1";
            //
            // ofdBook2
            //
            ofdBook2.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdBook2.Title = "Choose Book 2";
            //
            // Form1
            //
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1005, 550);
            Controls.Add(lstBook2);
            Controls.Add(lstBook1);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowseBook2);
            Controls.Add(txtBook2);
            Controls.Add(lblBook2);
            Controls.Add(btnBrowseBook1);
            Controls.Add(txtBook1);
            Controls.Add(lblBook1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBook1;
        private TextBox txtBook1;
        private Button btnBrowseBook1;
        private Label lblBook2;
        private TextBox txtBook2;
        private Button btnBrowseBook2;
        private Button btnSubmit;
        private Button btnExit;
        private ListBox lstBook1;
        private ListBox lstBook2;
        private OpenFileDialog ofdBook1;
        private OpenFileDialog ofdBook2;
    }
}

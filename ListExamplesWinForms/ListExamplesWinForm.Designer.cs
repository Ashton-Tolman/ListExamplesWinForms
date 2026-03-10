namespace ListExamplesWinForms
{
    partial class ListExamplesWinForm
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
            ExitButton = new Button();
            SubmitButton = new Button();
            ClearButton = new Button();
            InfoGroupbox = new GroupBox();
            FirstNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            CompanyLabel = new Label();
            CompanyTextBox = new TextBox();
            OutputGroupBox = new GroupBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            InfoGroupbox.SuspendLayout();
            OutputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(661, 370);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(127, 68);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(395, 370);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(127, 68);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(528, 370);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(127, 68);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // InfoGroupbox
            // 
            InfoGroupbox.Controls.Add(CompanyLabel);
            InfoGroupbox.Controls.Add(CompanyTextBox);
            InfoGroupbox.Controls.Add(LastNameLabel);
            InfoGroupbox.Controls.Add(LastNameTextBox);
            InfoGroupbox.Controls.Add(FirstNameLabel);
            InfoGroupbox.Controls.Add(FirstNameTextBox);
            InfoGroupbox.Location = new Point(12, 12);
            InfoGroupbox.Name = "InfoGroupbox";
            InfoGroupbox.Size = new Size(284, 426);
            InfoGroupbox.TabIndex = 0;
            InfoGroupbox.TabStop = false;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(120, 33);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(140, 31);
            FirstNameTextBox.TabIndex = 4;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(6, 33);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(45, 25);
            FirstNameLabel.TabIndex = 4;
            FirstNameLabel.Text = "First";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(6, 70);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(43, 25);
            LastNameLabel.TabIndex = 5;
            LastNameLabel.Text = "Last";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(120, 67);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(140, 31);
            LastNameTextBox.TabIndex = 6;
            // 
            // CompanyLabel
            // 
            CompanyLabel.AutoSize = true;
            CompanyLabel.Location = new Point(6, 107);
            CompanyLabel.Name = "CompanyLabel";
            CompanyLabel.Size = new Size(89, 25);
            CompanyLabel.TabIndex = 7;
            CompanyLabel.Text = "Company";
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(120, 101);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(140, 31);
            CompanyTextBox.TabIndex = 8;
            // 
            // OutputGroupBox
            // 
            OutputGroupBox.Controls.Add(listBox1);
            OutputGroupBox.Controls.Add(comboBox1);
            OutputGroupBox.Location = new Point(302, 12);
            OutputGroupBox.Name = "OutputGroupBox";
            OutputGroupBox.Size = new Size(486, 352);
            OutputGroupBox.TabIndex = 3;
            OutputGroupBox.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(8, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(472, 279);
            listBox1.TabIndex = 1;
            // 
            // ListExamplesWinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputGroupBox);
            Controls.Add(InfoGroupbox);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Name = "ListExamplesWinForm";
            Text = "Form1";
            InfoGroupbox.ResumeLayout(false);
            InfoGroupbox.PerformLayout();
            OutputGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Button ClearButton;
        private GroupBox InfoGroupbox;
        private Label CompanyLabel;
        private TextBox CompanyTextBox;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private GroupBox OutputGroupBox;
        private ListBox listBox1;
        private ComboBox comboBox1;
    }
}

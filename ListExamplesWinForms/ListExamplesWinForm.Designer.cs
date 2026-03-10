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
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(628, 352);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(127, 68);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(362, 352);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(127, 68);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(495, 352);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(127, 68);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ListExamplesWinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Name = "ListExamplesWinForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Button ClearButton;
    }
}

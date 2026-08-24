namespace WinFormsApp1
{
    partial class Form3
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
            cmbSubject1 = new ComboBox();
            btnSubmit = new Button();
            cmbSubject2 = new ComboBox();
            SuspendLayout();
            // 
            // cmbSubject1
            // 
            cmbSubject1.FormattingEnabled = true;
            cmbSubject1.Items.AddRange(new object[] { "Maths", "Tamil", "English", "Science " });
            cmbSubject1.Location = new Point(176, 130);
            cmbSubject1.Name = "cmbSubject1";
            cmbSubject1.Size = new Size(151, 28);
            cmbSubject1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(300, 387);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // cmbSubject2
            // 
            cmbSubject2.FormattingEnabled = true;
            cmbSubject2.Items.AddRange(new object[] { "English", "Science ", "Maths", "Tamil" });
            cmbSubject2.Location = new Point(398, 130);
            cmbSubject2.Name = "cmbSubject2";
            cmbSubject2.Size = new Size(151, 28);
            cmbSubject2.TabIndex = 2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(cmbSubject2);
            Controls.Add(btnSubmit);
            Controls.Add(cmbSubject1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSubject1;
        private Button btnSubmit;
        private ComboBox cmbSubject2;
    }
}
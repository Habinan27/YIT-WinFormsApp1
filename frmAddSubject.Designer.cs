namespace WinFormsApp1
{
    partial class frmAddSubject
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtAdmissionNo = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            label5 = new Label();
            panel1 = new Panel();
            clbSubjects = new CheckedListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 92);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 154);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Student name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 219);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Admission No";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(39, 121);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(340, 27);
            txtStudentID.TabIndex = 3;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(39, 184);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(340, 27);
            txtStudentName.TabIndex = 4;
            // 
            // txtAdmissionNo
            // 
            txtAdmissionNo.Location = new Point(39, 249);
            txtAdmissionNo.Name = "txtAdmissionNo";
            txtAdmissionNo.Size = new Size(340, 27);
            txtAdmissionNo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 285);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 7;
            label4.Text = "Add subject";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(125, 438);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 50);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Sienna;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(124, 15);
            label5.Name = "label5";
            label5.Size = new Size(171, 38);
            label5.TabIndex = 61;
            label5.Text = "Add Subject";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 71);
            panel1.TabIndex = 62;
            // 
            // clbSubjects
            // 
            clbSubjects.FormattingEnabled = true;
            clbSubjects.Items.AddRange(new object[] { "     " });
            clbSubjects.Location = new Point(39, 312);
            clbSubjects.Name = "clbSubjects";
            clbSubjects.Size = new Size(340, 114);
            clbSubjects.TabIndex = 63;
            // 
            // frmAddSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(421, 498);
            Controls.Add(clbSubjects);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(txtAdmissionNo);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmAddSubject";
            Text = "AddSubject";
            Load += frmAddSubject_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private TextBox txtAdmissionNo;
        private Label label4;
        private Button btnAdd;
        private Label label5;
        private Panel panel1;
        private CheckedListBox clbSubjects;
    }
}
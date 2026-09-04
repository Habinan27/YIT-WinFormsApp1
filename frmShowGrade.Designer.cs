namespace WinFormsApp1
{
    partial class frmShowGrade
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGradeColour = new TextBox();
            txtGradeOrder = new TextBox();
            txtGradeGroup = new TextBox();
            txtGradeName = new TextBox();
            lblGradeName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(1, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 57);
            panel1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(124, 7);
            label4.Name = "label4";
            label4.Size = new Size(171, 38);
            label4.TabIndex = 8;
            label4.Text = "Show Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 336);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 17;
            label3.Text = "Grade Colour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 253);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 16;
            label2.Text = "Grade Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 173);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 15;
            label1.Text = "Grade Group";
            // 
            // txtGradeColour
            // 
            txtGradeColour.Location = new Point(27, 375);
            txtGradeColour.Name = "txtGradeColour";
            txtGradeColour.Size = new Size(340, 27);
            txtGradeColour.TabIndex = 14;
            // 
            // txtGradeOrder
            // 
            txtGradeOrder.Location = new Point(27, 287);
            txtGradeOrder.Name = "txtGradeOrder";
            txtGradeOrder.Size = new Size(340, 27);
            txtGradeOrder.TabIndex = 13;
            // 
            // txtGradeGroup
            // 
            txtGradeGroup.Location = new Point(26, 205);
            txtGradeGroup.Name = "txtGradeGroup";
            txtGradeGroup.Size = new Size(340, 27);
            txtGradeGroup.TabIndex = 12;
            // 
            // txtGradeName
            // 
            txtGradeName.Location = new Point(26, 134);
            txtGradeName.Name = "txtGradeName";
            txtGradeName.Size = new Size(340, 27);
            txtGradeName.TabIndex = 11;
            // 
            // lblGradeName
            // 
            lblGradeName.AutoSize = true;
            lblGradeName.Location = new Point(27, 100);
            lblGradeName.Name = "lblGradeName";
            lblGradeName.Size = new Size(93, 20);
            lblGradeName.TabIndex = 10;
            lblGradeName.Text = "Grade Name";
            // 
            // frmShowGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGradeColour);
            Controls.Add(txtGradeOrder);
            Controls.Add(txtGradeGroup);
            Controls.Add(txtGradeName);
            Controls.Add(lblGradeName);
            Name = "frmShowGrade";
            Text = "Form5";
            Load += this.frmShowGrade_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGradeColour;
        private TextBox txtGradeOrder;
        private TextBox txtGradeGroup;
        private TextBox txtGradeName;
        private Label lblGradeName;
    }
}
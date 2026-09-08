namespace WinFormsApp1
{
    partial class frmEditGrade
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
            txtGradeOrder = new TextBox();
            txtGradeGroup = new TextBox();
            txtGradeName = new TextBox();
            lblGradeName = new Label();
            btnUpdate = new Button();
            btnChooseColour = new Button();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 57);
            panel1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(124, 7);
            label4.Name = "label4";
            label4.Size = new Size(151, 38);
            label4.TabIndex = 8;
            label4.Text = "Edit Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 320);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 26;
            label3.Text = "Grade Colour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 237);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 25;
            label2.Text = "Grade Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 157);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 24;
            label1.Text = "Grade Group";
            // 
            // txtGradeOrder
            // 
            txtGradeOrder.Location = new Point(26, 271);
            txtGradeOrder.Name = "txtGradeOrder";
            txtGradeOrder.Size = new Size(340, 27);
            txtGradeOrder.TabIndex = 22;
            // 
            // txtGradeGroup
            // 
            txtGradeGroup.Location = new Point(25, 189);
            txtGradeGroup.Name = "txtGradeGroup";
            txtGradeGroup.Size = new Size(340, 27);
            txtGradeGroup.TabIndex = 21;
            // 
            // txtGradeName
            // 
            txtGradeName.Location = new Point(25, 118);
            txtGradeName.Name = "txtGradeName";
            txtGradeName.Size = new Size(340, 27);
            txtGradeName.TabIndex = 20;
            // 
            // lblGradeName
            // 
            lblGradeName.AutoSize = true;
            lblGradeName.Location = new Point(26, 84);
            lblGradeName.Name = "lblGradeName";
            lblGradeName.Size = new Size(93, 20);
            lblGradeName.TabIndex = 19;
            lblGradeName.Text = "Grade Name";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(124, 408);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 51);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnChooseColour
            // 
            btnChooseColour.Location = new Point(26, 351);
            btnChooseColour.Name = "btnChooseColour";
            btnChooseColour.Size = new Size(118, 42);
            btnChooseColour.TabIndex = 39;
            btnChooseColour.UseVisualStyleBackColor = true;
            btnChooseColour.Click += btnChooseColour_Click;
            // 
            // frmEditGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 471);
            Controls.Add(btnChooseColour);
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGradeOrder);
            Controls.Add(txtGradeGroup);
            Controls.Add(txtGradeName);
            Controls.Add(lblGradeName);
            Name = "frmEditGrade";
            Text = "frmEditStudent";
            Load += frmEditGrade_Load;
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
        private TextBox txtGradeOrder;
        private TextBox txtGradeGroup;
        private TextBox txtGradeName;
        private Label lblGradeName;
        private Button btnUpdate;
        private Button btnChooseColour;
        private ColorDialog colorDialog1;
    }
}
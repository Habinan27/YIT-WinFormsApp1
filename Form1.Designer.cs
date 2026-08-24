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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtfname = new TextBox();
            txtlname = new TextBox();
            btnFillData = new Button();
            label8 = new Label();
            txtfullname = new TextBox();
            lblError01 = new Label();
            lblError02 = new Label();
            lblError03 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 74);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 125);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // txtfname
            // 
            txtfname.Location = new Point(113, 72);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(236, 27);
            txtfname.TabIndex = 0;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(112, 125);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(236, 27);
            txtlname.TabIndex = 2;
            // 
            // btnFillData
            // 
            btnFillData.Location = new Point(123, 255);
            btnFillData.Name = "btnFillData";
            btnFillData.Size = new Size(125, 40);
            btnFillData.TabIndex = 9;
            btnFillData.Text = "Fill Data";
            btnFillData.UseVisualStyleBackColor = true;
            btnFillData.Click += btnFillData_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 181);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 27;
            label8.Text = "Full Name";
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(113, 181);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(236, 27);
            txtfullname.TabIndex = 28;
            // 
            // lblError01
            // 
            lblError01.AutoSize = true;
            lblError01.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError01.ForeColor = Color.Red;
            lblError01.Location = new Point(123, 102);
            lblError01.Name = "lblError01";
            lblError01.Size = new Size(0, 17);
            lblError01.TabIndex = 29;
            // 
            // lblError02
            // 
            lblError02.AutoSize = true;
            lblError02.ForeColor = Color.Red;
            lblError02.Location = new Point(117, 152);
            lblError02.Name = "lblError02";
            lblError02.Size = new Size(0, 20);
            lblError02.TabIndex = 30;
            // 
            // lblError03
            // 
            lblError03.AutoSize = true;
            lblError03.ForeColor = SystemColors.ActiveCaption;
            lblError03.Location = new Point(102, 225);
            lblError03.Name = "lblError03";
            lblError03.Size = new Size(0, 20);
            lblError03.TabIndex = 31;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // dtdob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 320);
            Controls.Add(lblError03);
            Controls.Add(lblError02);
            Controls.Add(lblError01);
            Controls.Add(txtfullname);
            Controls.Add(label8);
            Controls.Add(btnFillData);
            Controls.Add(txtlname);
            Controls.Add(txtfname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "dtdob";
            Text = "Form1";
            Load += dtdob_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtfname;
        private TextBox txtlname;
        private Button btnFillData;
        private Label label8;
        private TextBox txtfullname;
        private Label lblError01;
        private Label lblError02;
        private Label lblError03;
        private System.Windows.Forms.Timer timer1;
    }
}

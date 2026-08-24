namespace WinFormsApp1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            txtfullname = new TextBox();
            label8 = new Label();
            dtdob2 = new DateTimePicker();
            dtdob = new DateTimePicker();
            txtnic2 = new TextBox();
            txttel2 = new TextBox();
            txtaddress2 = new TextBox();
            txtlname2 = new TextBox();
            txtfname2 = new TextBox();
            rdofemale2 = new RadioButton();
            rdomale2 = new RadioButton();
            rdofemale = new RadioButton();
            rdomale = new RadioButton();
            btnFillData = new Button();
            txtnic = new TextBox();
            txttel = new TextBox();
            txtaddress = new TextBox();
            txtlname = new TextBox();
            txtfname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            lblfname = new Label();
            lbllname = new Label();
            lbldob = new Label();
            lbladdress = new Label();
            lbltel = new Label();
            lblgender = new Label();
            lblnic = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtfullname
            // 
            txtfullname.Font = new Font("Segoe UI", 10.2F);
            txtfullname.Location = new Point(133, 187);
            txtfullname.Name = "txtfullname";
            txtfullname.ReadOnly = true;
            txtfullname.Size = new Size(525, 30);
            txtfullname.TabIndex = 56;
            txtfullname.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(9, 188);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 55;
            label8.Text = "Full Name";
            // 
            // dtdob2
            // 
            dtdob2.Enabled = false;
            dtdob2.Location = new Point(430, 247);
            dtdob2.Name = "dtdob2";
            dtdob2.Size = new Size(228, 27);
            dtdob2.TabIndex = 54;
            // 
            // dtdob
            // 
            dtdob.Location = new Point(133, 247);
            dtdob.Name = "dtdob";
            dtdob.Size = new Size(236, 27);
            dtdob.TabIndex = 9;
            dtdob.Value = new DateTime(2026, 8, 24, 11, 8, 38, 0);
            // 
            // txtnic2
            // 
            txtnic2.Enabled = false;
            txtnic2.Font = new Font("Segoe UI", 10.2F);
            txtnic2.Location = new Point(430, 468);
            txtnic2.Name = "txtnic2";
            txtnic2.Size = new Size(228, 30);
            txtnic2.TabIndex = 53;
            // 
            // txttel2
            // 
            txttel2.AcceptsReturn = true;
            txttel2.Enabled = false;
            txttel2.Font = new Font("Segoe UI", 10.2F);
            txttel2.Location = new Point(430, 360);
            txttel2.Name = "txttel2";
            txttel2.Size = new Size(228, 30);
            txttel2.TabIndex = 52;
            // 
            // txtaddress2
            // 
            txtaddress2.Enabled = false;
            txtaddress2.Font = new Font("Segoe UI", 10.2F);
            txtaddress2.Location = new Point(430, 306);
            txtaddress2.Multiline = true;
            txtaddress2.Name = "txtaddress2";
            txtaddress2.Size = new Size(228, 27);
            txtaddress2.TabIndex = 51;
            // 
            // txtlname2
            // 
            txtlname2.Enabled = false;
            txtlname2.Font = new Font("Segoe UI", 10.2F);
            txtlname2.Location = new Point(430, 133);
            txtlname2.Name = "txtlname2";
            txtlname2.Size = new Size(228, 30);
            txtlname2.TabIndex = 50;
            // 
            // txtfname2
            // 
            txtfname2.Enabled = false;
            txtfname2.Font = new Font("Segoe UI", 10.2F);
            txtfname2.Location = new Point(430, 80);
            txtfname2.Name = "txtfname2";
            txtfname2.Size = new Size(228, 30);
            txtfname2.TabIndex = 49;
            // 
            // rdofemale2
            // 
            rdofemale2.AutoCheck = false;
            rdofemale2.AutoSize = true;
            rdofemale2.Location = new Point(559, 412);
            rdofemale2.Name = "rdofemale2";
            rdofemale2.Size = new Size(78, 24);
            rdofemale2.TabIndex = 48;
            rdofemale2.TabStop = true;
            rdofemale2.Text = "Female";
            rdofemale2.UseVisualStyleBackColor = true;
            // 
            // rdomale2
            // 
            rdomale2.AutoCheck = false;
            rdomale2.AutoSize = true;
            rdomale2.Location = new Point(429, 412);
            rdomale2.Name = "rdomale2";
            rdomale2.Size = new Size(63, 24);
            rdomale2.TabIndex = 47;
            rdomale2.TabStop = true;
            rdomale2.Text = "Male";
            rdomale2.UseVisualStyleBackColor = true;
            // 
            // rdofemale
            // 
            rdofemale.AutoSize = true;
            rdofemale.Location = new Point(256, 412);
            rdofemale.Name = "rdofemale";
            rdofemale.Size = new Size(78, 24);
            rdofemale.TabIndex = 7;
            rdofemale.TabStop = true;
            rdofemale.Text = "Female";
            rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            rdomale.AutoSize = true;
            rdomale.Location = new Point(133, 412);
            rdomale.Name = "rdomale";
            rdomale.Size = new Size(63, 24);
            rdomale.TabIndex = 6;
            rdomale.TabStop = true;
            rdomale.Text = "Male";
            rdomale.UseVisualStyleBackColor = true;
            // 
            // btnFillData
            // 
            btnFillData.BackColor = Color.White;
            btnFillData.Location = new Point(274, 515);
            btnFillData.Name = "btnFillData";
            btnFillData.Size = new Size(218, 40);
            btnFillData.TabIndex = 9;
            btnFillData.Text = "Fill Data";
            btnFillData.UseVisualStyleBackColor = false;
            btnFillData.Click += btnFillData_Click;
            // 
            // txtnic
            // 
            txtnic.Font = new Font("Segoe UI", 10.2F);
            txtnic.Location = new Point(133, 468);
            txtnic.Name = "txtnic";
            txtnic.Size = new Size(236, 30);
            txtnic.TabIndex = 8;
            // 
            // txttel
            // 
            txttel.Font = new Font("Segoe UI", 10.2F);
            txttel.Location = new Point(133, 360);
            txttel.Name = "txttel";
            txttel.Size = new Size(236, 30);
            txttel.TabIndex = 5;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 10.2F);
            txtaddress.Location = new Point(133, 303);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(236, 27);
            txtaddress.TabIndex = 4;
            // 
            // txtlname
            // 
            txtlname.Font = new Font("Segoe UI", 10.2F);
            txtlname.Location = new Point(133, 133);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(236, 30);
            txtlname.TabIndex = 1;
            // 
            // txtfname
            // 
            txtfname.Font = new Font("Segoe UI", 10.2F);
            txtfname.Location = new Point(133, 80);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(236, 30);
            txtfname.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(9, 468);
            label7.Name = "label7";
            label7.Size = new Size(39, 23);
            label7.TabIndex = 42;
            label7.Text = "NIC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(8, 412);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 40;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(8, 360);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 38;
            label5.Text = "Telephone no";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(8, 306);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 36;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(8, 247);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 34;
            label3.Text = "DOB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(9, 136);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 33;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 87);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 31;
            label1.Text = "First name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(269, 5);
            label9.Name = "label9";
            label9.Size = new Size(214, 46);
            label9.TabIndex = 57;
            label9.Text = "Information";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 55);
            panel1.TabIndex = 58;
            // 
            // lblfname
            // 
            lblfname.AutoSize = true;
            lblfname.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfname.ForeColor = Color.Red;
            lblfname.Location = new Point(136, 110);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(0, 17);
            lblfname.TabIndex = 59;
            // 
            // lbllname
            // 
            lbllname.AutoSize = true;
            lbllname.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllname.ForeColor = Color.Red;
            lbllname.Location = new Point(136, 163);
            lbllname.Name = "lbllname";
            lbllname.Size = new Size(0, 17);
            lbllname.TabIndex = 60;
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.Font = new Font("Segoe UI", 7.8F);
            lbldob.ForeColor = Color.Red;
            lbldob.Location = new Point(136, 277);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(0, 17);
            lbldob.TabIndex = 61;
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Font = new Font("Segoe UI", 7.8F);
            lbladdress.ForeColor = Color.Red;
            lbladdress.Location = new Point(136, 333);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(0, 17);
            lbladdress.TabIndex = 62;
            // 
            // lbltel
            // 
            lbltel.AutoSize = true;
            lbltel.Font = new Font("Segoe UI", 7.8F);
            lbltel.ForeColor = Color.Red;
            lbltel.Location = new Point(138, 390);
            lbltel.Name = "lbltel";
            lbltel.Size = new Size(0, 17);
            lbltel.TabIndex = 63;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Segoe UI", 7.8F);
            lblgender.ForeColor = Color.Red;
            lblgender.Location = new Point(138, 439);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(0, 17);
            lblgender.TabIndex = 64;
            // 
            // lblnic
            // 
            lblnic.AutoSize = true;
            lblnic.Font = new Font("Segoe UI", 7.8F);
            lblnic.ForeColor = Color.Red;
            lblnic.Location = new Point(138, 498);
            lblnic.Name = "lblnic";
            lblnic.Size = new Size(0, 17);
            lblnic.TabIndex = 65;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(708, 567);
            Controls.Add(lblnic);
            Controls.Add(lblgender);
            Controls.Add(lbltel);
            Controls.Add(lbladdress);
            Controls.Add(lbldob);
            Controls.Add(lbllname);
            Controls.Add(lblfname);
            Controls.Add(panel1);
            Controls.Add(txtfullname);
            Controls.Add(label8);
            Controls.Add(dtdob2);
            Controls.Add(dtdob);
            Controls.Add(txtnic2);
            Controls.Add(txttel2);
            Controls.Add(txtaddress2);
            Controls.Add(txtlname2);
            Controls.Add(txtfname2);
            Controls.Add(rdofemale2);
            Controls.Add(rdomale2);
            Controls.Add(rdofemale);
            Controls.Add(rdomale);
            Controls.Add(btnFillData);
            Controls.Add(txtnic);
            Controls.Add(txttel);
            Controls.Add(txtaddress);
            Controls.Add(txtlname);
            Controls.Add(txtfname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtfullname;
        private Label label8;
        private DateTimePicker dtdob2;
        private DateTimePicker dtdob;
        private TextBox txtnic2;
        private TextBox txttel2;
        private TextBox txtaddress2;
        private TextBox txtlname2;
        private TextBox txtfname2;
        private RadioButton rdofemale2;
        private RadioButton rdomale2;
        private RadioButton rdofemale;
        private RadioButton rdomale;
        private Button btnFillData;
        private TextBox txtnic;
        private TextBox txttel;
        private TextBox txtaddress;
        private TextBox txtlname;
        private TextBox txtfname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Panel panel1;
        private Label lblfname;
        private Label lbllname;
        private Label lbldob;
        private Label lbladdress;
        private Label lbltel;
        private Label lblgender;
        private Label lblnic;
        private System.Windows.Forms.Timer timer1;
    }
}
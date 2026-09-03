namespace WinFormsApp1
{
    partial class databaseconnect
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
            btnConnect = new Button();
            btnAllStudent = new Button();
            dcvAllStudent = new DataGridView();
            btnShow = new Button();
            lblFname = new Label();
            txtFname = new TextBox();
            lblLname = new Label();
            txtLname = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            cmbGrade = new ComboBox();
            lblGrade = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            label1 = new Label();
            btnDBShow = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dcvAllStudent).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 86);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(105, 39);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnAllStudent
            // 
            btnAllStudent.Location = new Point(178, 86);
            btnAllStudent.Name = "btnAllStudent";
            btnAllStudent.Size = new Size(105, 39);
            btnAllStudent.TabIndex = 1;
            btnAllStudent.Text = "All student";
            btnAllStudent.UseVisualStyleBackColor = true;
            btnAllStudent.Click += btnAllStudent_Click;
            // 
            // dcvAllStudent
            // 
            dcvAllStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dcvAllStudent.Location = new Point(12, 152);
            dcvAllStudent.Name = "dcvAllStudent";
            dcvAllStudent.RowHeadersWidth = 51;
            dcvAllStudent.Size = new Size(776, 429);
            dcvAllStudent.TabIndex = 2;
            dcvAllStudent.CellContentClick += dcvAllStudent_CellContentClick;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(340, 86);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(105, 39);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(830, 154);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(77, 20);
            lblFname.TabIndex = 4;
            lblFname.Text = "First name";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(830, 177);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(263, 27);
            txtFname.TabIndex = 5;
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(830, 229);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(76, 20);
            lblLname.TabIndex = 6;
            lblLname.Text = "Last name";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(830, 252);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(263, 27);
            txtLname.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(830, 305);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(830, 328);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(266, 53);
            txtAddress.TabIndex = 9;
            // 
            // cmbGrade
            // 
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Location = new Point(830, 427);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(263, 28);
            cmbGrade.TabIndex = 10;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(830, 400);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(49, 20);
            lblGrade.TabIndex = 11;
            lblGrade.Text = "Grade";
            // 
            // button1
            // 
            button1.Location = new Point(507, 86);
            button1.Name = "button1";
            button1.Size = new Size(119, 39);
            button1.TabIndex = 12;
            button1.Text = "Show Grade";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(830, 480);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(999, 480);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(833, 557);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(63, 24);
            rdoMale.TabIndex = 15;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            rdoMale.CheckedChanged += rdoMale_CheckedChanged;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(999, 557);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(78, 24);
            rdoFemale.TabIndex = 16;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(833, 528);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 17;
            label1.Text = "Gender";
            // 
            // btnDBShow
            // 
            btnDBShow.Location = new Point(681, 86);
            btnDBShow.Name = "btnDBShow";
            btnDBShow.Size = new Size(107, 39);
            btnDBShow.TabIndex = 18;
            btnDBShow.Text = "DB Show";
            btnDBShow.UseVisualStyleBackColor = true;
            btnDBShow.Click += btnDBShow_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(854, 86);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 39);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(999, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // databaseconnect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1150, 609);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnDBShow);
            Controls.Add(label1);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblGrade);
            Controls.Add(cmbGrade);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtLname);
            Controls.Add(lblLname);
            Controls.Add(txtFname);
            Controls.Add(lblFname);
            Controls.Add(btnShow);
            Controls.Add(dcvAllStudent);
            Controls.Add(btnAllStudent);
            Controls.Add(btnConnect);
            Name = "databaseconnect";
            Text = "databaseconnect";
            Load += databaseconnect_Load;
            ((System.ComponentModel.ISupportInitialize)dcvAllStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Button btnAllStudent;
        private DataGridView dcvAllStudent;
        private Button btnShow;
        private Label lblFname;
        private TextBox txtFname;
        private Label lblLname;
        private TextBox txtLname;
        private Label lblAddress;
        private TextBox txtAddress;
        private ComboBox cmbGrade;
        private Label lblGrade;
        private Button button1;
        private Button button2;
        private Button button3;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Label label1;
        private Button btnDBShow;
        private Button btnEdit;
        private Button btnDelete;
    }
}
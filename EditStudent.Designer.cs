
namespace WinFormsApp1
{
    partial class EditStudent
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
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            lblBirthNO = new Label();
            txtBirthNo = new TextBox();
            txtAdmissionNo = new TextBox();
            lblAdNo = new Label();
            txtTel = new TextBox();
            txtNIC = new TextBox();
            lblTel = new Label();
            lblNIC = new Label();
            lblHouse = new Label();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            cmbGrade = new ComboBox();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblGender = new Label();
            lblGrade = new Label();
            lblAddress = new Label();
            lblLastName = new Label();
            lblFirstname = new Label();
            cmbFamily = new ComboBox();
            dtpAdmission = new DateTimePicker();
            cmbMedium = new ComboBox();
            lblAdmission = new Label();
            lblMedium = new Label();
            lblFamily = new Label();
            cmbHouse = new ComboBox();
            panel1 = new Panel();
            lable01 = new Label();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(13, 531);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(262, 27);
            dtpDOB.TabIndex = 50;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(7, 499);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(94, 20);
            lblDOB.TabIndex = 49;
            lblDOB.Text = "Date of Birth";
            // 
            // lblBirthNO
            // 
            lblBirthNO.AutoSize = true;
            lblBirthNO.Location = new Point(379, 143);
            lblBirthNO.Name = "lblBirthNO";
            lblBirthNO.Size = new Size(128, 20);
            lblBirthNO.TabIndex = 48;
            lblBirthNO.Text = "Birth Certificat No";
            // 
            // txtBirthNo
            // 
            txtBirthNo.Location = new Point(382, 167);
            txtBirthNo.Name = "txtBirthNo";
            txtBirthNo.Size = new Size(260, 27);
            txtBirthNo.TabIndex = 47;
            // 
            // txtAdmissionNo
            // 
            txtAdmissionNo.Location = new Point(13, 94);
            txtAdmissionNo.Name = "txtAdmissionNo";
            txtAdmissionNo.Size = new Size(262, 27);
            txtAdmissionNo.TabIndex = 46;
            // 
            // lblAdNo
            // 
            lblAdNo.AutoSize = true;
            lblAdNo.Location = new Point(5, 71);
            lblAdNo.Name = "lblAdNo";
            lblAdNo.Size = new Size(78, 20);
            lblAdNo.TabIndex = 45;
            lblAdNo.Text = "Admission";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(382, 240);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(260, 27);
            txtTel.TabIndex = 44;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(382, 94);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(260, 27);
            txtNIC.TabIndex = 43;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(374, 217);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(70, 20);
            lblTel.TabIndex = 42;
            lblTel.Text = "Telphone";
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Location = new Point(379, 71);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(33, 20);
            lblNIC.TabIndex = 41;
            lblNIC.Text = "NIC";
            // 
            // lblHouse
            // 
            lblHouse.AutoSize = true;
            lblHouse.Location = new Point(379, 289);
            lblHouse.Name = "lblHouse";
            lblHouse.Size = new Size(51, 20);
            lblHouse.TabIndex = 40;
            lblHouse.Text = "House";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(108, 458);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(78, 24);
            rdoFemale.TabIndex = 39;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(15, 458);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(63, 24);
            rdoMale.TabIndex = 38;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // cmbGrade
            // 
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Location = new Point(13, 381);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(262, 28);
            cmbGrade.TabIndex = 37;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(13, 312);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(262, 27);
            txtAddress.TabIndex = 36;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(13, 240);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(262, 27);
            txtLastName.TabIndex = 35;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(13, 167);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(262, 27);
            txtFirstName.TabIndex = 34;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(6, 428);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 33;
            lblGender.Text = "Gender";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(6, 358);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(49, 20);
            lblGrade.TabIndex = 32;
            lblGrade.Text = "Grade";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(3, 289);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 31;
            lblAddress.Text = "Address";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(6, 217);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 30;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(6, 144);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(80, 20);
            lblFirstname.TabIndex = 29;
            lblFirstname.Text = "First Name";
            // 
            // cmbFamily
            // 
            cmbFamily.FormattingEnabled = true;
            cmbFamily.Location = new Point(382, 533);
            cmbFamily.Name = "cmbFamily";
            cmbFamily.Size = new Size(260, 28);
            cmbFamily.TabIndex = 56;
            // 
            // dtpAdmission
            // 
            dtpAdmission.Location = new Point(382, 455);
            dtpAdmission.Name = "dtpAdmission";
            dtpAdmission.Size = new Size(260, 27);
            dtpAdmission.TabIndex = 55;
            // 
            // cmbMedium
            // 
            cmbMedium.FormattingEnabled = true;
            cmbMedium.Location = new Point(382, 381);
            cmbMedium.Name = "cmbMedium";
            cmbMedium.Size = new Size(260, 28);
            cmbMedium.TabIndex = 54;
            // 
            // lblAdmission
            // 
            lblAdmission.AutoSize = true;
            lblAdmission.Location = new Point(379, 428);
            lblAdmission.Name = "lblAdmission";
            lblAdmission.Size = new Size(114, 20);
            lblAdmission.TabIndex = 53;
            lblAdmission.Text = "Admission Date";
            // 
            // lblMedium
            // 
            lblMedium.AutoSize = true;
            lblMedium.Location = new Point(377, 358);
            lblMedium.Name = "lblMedium";
            lblMedium.Size = new Size(64, 20);
            lblMedium.TabIndex = 52;
            lblMedium.Text = "Medium";
            // 
            // lblFamily
            // 
            lblFamily.AutoSize = true;
            lblFamily.Location = new Point(378, 499);
            lblFamily.Name = "lblFamily";
            lblFamily.Size = new Size(51, 20);
            lblFamily.TabIndex = 51;
            lblFamily.Text = "Family";
            // 
            // cmbHouse
            // 
            cmbHouse.FormattingEnabled = true;
            cmbHouse.Location = new Point(382, 311);
            cmbHouse.Name = "cmbHouse";
            cmbHouse.Size = new Size(260, 28);
            cmbHouse.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lable01);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 61);
            panel1.TabIndex = 58;
            // 
            // lable01
            // 
            lable01.AutoSize = true;
            lable01.BackColor = SystemColors.MenuHighlight;
            lable01.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable01.ForeColor = SystemColors.ButtonHighlight;
            lable01.Location = new Point(162, 9);
            lable01.Name = "lable01";
            lable01.Size = new Size(338, 38);
            lable01.TabIndex = 0;
            lable01.Text = "Edit Student information ";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(245, 581);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 50);
            btnUpdate.TabIndex = 59;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(683, 638);
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            Controls.Add(txtNIC);
            Controls.Add(cmbHouse);
            Controls.Add(cmbFamily);
            Controls.Add(dtpAdmission);
            Controls.Add(cmbMedium);
            Controls.Add(lblAdmission);
            Controls.Add(lblMedium);
            Controls.Add(lblFamily);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(lblBirthNO);
            Controls.Add(txtBirthNo);
            Controls.Add(txtAdmissionNo);
            Controls.Add(lblAdNo);
            Controls.Add(txtTel);
            Controls.Add(lblTel);
            Controls.Add(lblNIC);
            Controls.Add(lblHouse);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(cmbGrade);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblGender);
            Controls.Add(lblGrade);
            Controls.Add(lblAddress);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstname);
            Name = "EditStudent";
            Text = "EditStudent";
            Load += EditStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private Label lblBirthNO;
        private TextBox txtBirthNo;
        private TextBox txtAdmissionNo;
        private Label lblAdNo;
        private TextBox txtTel;
        private TextBox txtNIC;
        private Label lblTel;
        private Label lblNIC;
        private Label lblHouse;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private ComboBox cmbGrade;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblGender;
        private Label lblGrade;
        private Label lblAddress;
        private Label lblLastName;
        private Label lblFirstname;
        private ComboBox cmbFamily;
        private DateTimePicker dtpAdmission;
        private ComboBox cmbMedium;
        private Label lblAdmission;
        private Label lblMedium;
        private Label lblFamily;
        private ComboBox cmbHouse;
        private Panel panel1;
        private Label lable01;
        private Button btnUpdate;
    }
}
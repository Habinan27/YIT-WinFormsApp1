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
            button1 = new Button();
            btnDBShow = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dcvAllStudent).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 102);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(105, 39);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnAllStudent
            // 
            btnAllStudent.Location = new Point(132, 102);
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
            dcvAllStudent.Location = new Point(12, 168);
            dcvAllStudent.Name = "dcvAllStudent";
            dcvAllStudent.RowHeadersWidth = 51;
            dcvAllStudent.Size = new Size(967, 429);
            dcvAllStudent.TabIndex = 2;
            dcvAllStudent.CellContentClick += dcvAllStudent_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            // 
            // btnDBShow
            // 
            btnDBShow.Location = new Point(259, 102);
            btnDBShow.Name = "btnDBShow";
            btnDBShow.Size = new Size(107, 39);
            btnDBShow.TabIndex = 18;
            btnDBShow.Text = "DB Show";
            btnDBShow.UseVisualStyleBackColor = true;
            btnDBShow.Click += btnDBShow_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(386, 102);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 39);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(502, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(629, 102);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 39);
            btnInsert.TabIndex = 21;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(380, 16);
            label2.Name = "label2";
            label2.Size = new Size(201, 38);
            label2.TabIndex = 22;
            label2.Text = "Students Table";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 65);
            panel1.TabIndex = 23;
            // 
            // databaseconnect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(992, 609);
            Controls.Add(panel1);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnDBShow);
            Controls.Add(button1);
            Controls.Add(dcvAllStudent);
            Controls.Add(btnAllStudent);
            Controls.Add(btnConnect);
            Name = "databaseconnect";
            Text = "databaseconnect";
            Load += databaseconnect_Load;
            ((System.ComponentModel.ISupportInitialize)dcvAllStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnect;
        private Button btnAllStudent;
        private DataGridView dcvAllStudent;
        private Button button1;
        private Button btnDBShow;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnInsert;
        private Label label2;
        private Panel panel1;
    }
}
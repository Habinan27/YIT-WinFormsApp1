namespace WinFormsApp1
{
    partial class GradeTable
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
            dgvAllGrades = new DataGridView();
            btnConnection = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnShow = new Button();
            btnAllGrades = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllGrades).BeginInit();
            SuspendLayout();
            // 
            // dgvAllGrades
            // 
            dgvAllGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllGrades.Location = new Point(24, 95);
            dgvAllGrades.Name = "dgvAllGrades";
            dgvAllGrades.RowHeadersWidth = 51;
            dgvAllGrades.Size = new Size(620, 334);
            dgvAllGrades.TabIndex = 0;
            dgvAllGrades.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnConnection
            // 
            btnConnection.Location = new Point(28, 29);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(112, 47);
            btnConnection.TabIndex = 1;
            btnConnection.Text = "Connection";
            btnConnection.UseVisualStyleBackColor = true;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(655, 34);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(111, 41);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(541, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 41);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(419, 34);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 42);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(293, 34);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(105, 42);
            btnShow.TabIndex = 8;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnAllGrades
            // 
            btnAllGrades.Location = new Point(153, 29);
            btnAllGrades.Name = "btnAllGrades";
            btnAllGrades.Size = new Size(109, 47);
            btnAllGrades.TabIndex = 7;
            btnAllGrades.Text = "All Grade";
            btnAllGrades.UseVisualStyleBackColor = true;
            btnAllGrades.Click += btnAllGrades_Click;
            // 
            // GradeTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnShow);
            Controls.Add(btnAllGrades);
            Controls.Add(btnConnection);
            Controls.Add(dgvAllGrades);
            Name = "GradeTable";
            Text = "GradeTable";
            ((System.ComponentModel.ISupportInitialize)dgvAllGrades).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvAllGrades;
        private Button btnConnection;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnShow;
        private Button btnAllGrades;
    }
}
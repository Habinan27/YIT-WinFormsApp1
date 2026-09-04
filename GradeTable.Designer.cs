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
            // GradeTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnection);
            Controls.Add(dgvAllGrades);
            Name = "GradeTable";
            Text = "GradeTable";
            ((System.ComponentModel.ISupportInitialize)dgvAllGrades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAllGrades;
        private Button btnConnection;
    }
}
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvAllGrades = new DataGridView();
            btnConnection = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnShow = new Button();
            btnAllGrades = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAllGrades).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAllGrades
            // 
            dgvAllGrades.AllowUserToAddRows = false;
            dgvAllGrades.AllowUserToDeleteRows = false;
            dgvAllGrades.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 250, 250);
            dgvAllGrades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAllGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllGrades.BackgroundColor = Color.White;
            dgvAllGrades.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAllGrades.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Teal;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAllGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAllGrades.ColumnHeadersHeight = 42;
            dgvAllGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 139, 139);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAllGrades.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAllGrades.EnableHeadersVisualStyles = false;
            dgvAllGrades.GridColor = Color.LightGray;
            dgvAllGrades.Location = new Point(24, 149);
            dgvAllGrades.MultiSelect = false;
            dgvAllGrades.Name = "dgvAllGrades";
            dgvAllGrades.ReadOnly = true;
            dgvAllGrades.RowHeadersVisible = false;
            dgvAllGrades.RowHeadersWidth = 51;
            dgvAllGrades.RowTemplate.Height = 35;
            dgvAllGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllGrades.Size = new Size(742, 334);
            dgvAllGrades.TabIndex = 0;
            dgvAllGrades.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.White;
            btnConnection.FlatAppearance.BorderColor = Color.LightGray;
            btnConnection.FlatStyle = FlatStyle.Flat;
            btnConnection.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnConnection.ForeColor = Color.FromArgb(50, 50, 50);
            btnConnection.Location = new Point(28, 88);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(112, 41);
            btnConnection.TabIndex = 1;
            btnConnection.Text = "Connection";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.White;
            btnInsert.FlatAppearance.BorderColor = Color.LightGray;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnInsert.ForeColor = Color.FromArgb(50, 50, 50);
            btnInsert.Location = new Point(673, 88);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(93, 41);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.LightGray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(50, 50, 50);
            btnDelete.Location = new Point(559, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 41);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.FlatAppearance.BorderColor = Color.LightGray;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(50, 50, 50);
            btnEdit.Location = new Point(438, 88);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 41);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.White;
            btnShow.FlatAppearance.BorderColor = Color.LightGray;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnShow.ForeColor = Color.FromArgb(50, 50, 50);
            btnShow.Location = new Point(307, 88);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(105, 41);
            btnShow.TabIndex = 8;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnAllGrades
            // 
            btnAllGrades.BackColor = Color.White;
            btnAllGrades.FlatAppearance.BorderColor = Color.LightGray;
            btnAllGrades.FlatStyle = FlatStyle.Flat;
            btnAllGrades.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAllGrades.ForeColor = Color.FromArgb(50, 50, 50);
            btnAllGrades.Location = new Point(169, 88);
            btnAllGrades.Name = "btnAllGrades";
            btnAllGrades.Size = new Size(109, 41);
            btnAllGrades.TabIndex = 7;
            btnAllGrades.Text = "All Grade";
            btnAllGrades.UseVisualStyleBackColor = false;
            btnAllGrades.Click += btnAllGrades_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 67);
            label1.TabIndex = 12;
            label1.Text = "Grade Table";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 13;
            // 
            // GradeTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 500);
            Controls.Add(btnInsert);
            Controls.Add(panel1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnShow);
            Controls.Add(btnAllGrades);
            Controls.Add(btnConnection);
            Controls.Add(dgvAllGrades);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GradeTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade Table";
            ((System.ComponentModel.ISupportInitialize)dgvAllGrades).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView dgvAllGrades;
        private Button btnConnection;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnShow;
        private Button btnAllGrades;
        private Label label1;
        private Panel panel1;
        }
    }
#endregion


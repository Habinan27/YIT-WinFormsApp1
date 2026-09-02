namespace WinFormsApp1
{
    partial class Form4
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
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            btnadd = new Button();
            btnsub = new Button();
            btnmult = new Button();
            btndiv = new Button();
            txtresult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(114, 95);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(125, 27);
            txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(114, 165);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(125, 27);
            txtnum2.TabIndex = 1;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(6, 236);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(47, 42);
            btnadd.TabIndex = 2;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnsub
            // 
            btnsub.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnsub.Location = new Point(83, 236);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(47, 42);
            btnsub.TabIndex = 3;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = true;
            btnsub.Click += btnsub_Click;
            // 
            // btnmult
            // 
            btnmult.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnmult.Location = new Point(169, 236);
            btnmult.Name = "btnmult";
            btnmult.Size = new Size(47, 42);
            btnmult.TabIndex = 4;
            btnmult.Text = "x";
            btnmult.UseVisualStyleBackColor = true;
            btnmult.Click += btnmult_Click;
            // 
            // btndiv
            // 
            btndiv.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btndiv.Location = new Point(243, 236);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(47, 42);
            btndiv.TabIndex = 5;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += btndiv_Click;
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtresult.Location = new Point(114, 322);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(125, 43);
            txtresult.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 98);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 7;
            label1.Text = "Number 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 172);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Number 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 330);
            label3.Name = "label3";
            label3.Size = new Size(87, 31);
            label3.TabIndex = 9;
            label3.Text = "Result :";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtresult);
            Controls.Add(btndiv);
            Controls.Add(btnmult);
            Controls.Add(btnsub);
            Controls.Add(btnadd);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum1;
        private TextBox txtnum2;
        private Button btnadd;
        private Button btnsub;
        private Button btnmult;
        private Button btndiv;
        private TextBox txtresult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
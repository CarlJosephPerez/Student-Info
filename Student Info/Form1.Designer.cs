namespace Student_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConTest = new Button();
            dgvStudentInfo = new DataGridView();
            btnLoadData = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxID = new TextBox();
            tbxLname = new TextBox();
            tbxFname = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            tbxCourse = new TextBox();
            label4 = new Label();
            tbxYlevel = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            SuspendLayout();
            // 
            // btnConTest
            // 
            btnConTest.Location = new Point(12, 440);
            btnConTest.Name = "btnConTest";
            btnConTest.Size = new Size(129, 23);
            btnConTest.TabIndex = 0;
            btnConTest.Text = "Connection Test";
            btnConTest.UseVisualStyleBackColor = true;
            btnConTest.Click += btnConTest_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Location = new Point(276, 12);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.ReadOnly = true;
            dgvStudentInfo.RowTemplate.Height = 25;
            dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentInfo.Size = new Size(566, 451);
            dgvStudentInfo.TabIndex = 1;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(147, 440);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(102, 23);
            btnLoadData.TabIndex = 2;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 34);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "STUDENT ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 62);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "LAST NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 91);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "FIRST NAME:";
            // 
            // tbxID
            // 
            tbxID.Location = new Point(110, 31);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(139, 23);
            tbxID.TabIndex = 6;
            // 
            // tbxLname
            // 
            tbxLname.Location = new Point(110, 59);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(139, 23);
            tbxLname.TabIndex = 7;
            // 
            // tbxFname
            // 
            tbxFname.Location = new Point(110, 88);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(139, 23);
            tbxFname.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(13, 184);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(94, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(175, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxCourse
            // 
            tbxCourse.Location = new Point(110, 117);
            tbxCourse.Name = "tbxCourse";
            tbxCourse.Size = new Size(139, 23);
            tbxCourse.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 120);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 12;
            label4.Text = "COURSE:";
            // 
            // tbxYlevel
            // 
            tbxYlevel.Location = new Point(111, 146);
            tbxYlevel.Name = "tbxYlevel";
            tbxYlevel.Size = new Size(139, 23);
            tbxYlevel.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 149);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 14;
            label5.Text = "YEAR LEVEL:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 475);
            Controls.Add(tbxYlevel);
            Controls.Add(label5);
            Controls.Add(tbxCourse);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(tbxFname);
            Controls.Add(tbxLname);
            Controls.Add(tbxID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadData);
            Controls.Add(dgvStudentInfo);
            Controls.Add(btnConTest);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Student Info";
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConTest;
        private DataGridView dgvStudentInfo;
        private Button btnLoadData;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxID;
        private TextBox tbxLname;
        private TextBox tbxFname;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox tbxCourse;
        private Label label4;
        private TextBox tbxYlevel;
        private Label label5;
    }
}
namespace Project2
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
            lbxStudentList = new ListBox();
            lblStudentList = new Label();
            lblStudentName = new Label();
            tbxStudentName = new TextBox();
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            lblCountStudent = new Label();
            SuspendLayout();
            // 
            // lbxStudentList
            // 
            lbxStudentList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbxStudentList.FormattingEnabled = true;
            lbxStudentList.ItemHeight = 21;
            lbxStudentList.Location = new Point(57, 86);
            lbxStudentList.Name = "lbxStudentList";
            lbxStudentList.Size = new Size(225, 256);
            lbxStudentList.TabIndex = 0;
            lbxStudentList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentList.Location = new Point(57, 53);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(112, 21);
            lblStudentList.TabIndex = 1;
            lblStudentList.Text = "Ogrenci Listesi";
            lblStudentList.Click += lblStudentList_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentName.Location = new Point(288, 90);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(92, 21);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Ogrenci Adi";
            // 
            // tbxStudentName
            // 
            tbxStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxStudentName.Location = new Point(386, 86);
            tbxStudentName.Name = "tbxStudentName";
            tbxStudentName.Size = new Size(291, 29);
            tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddStudent.Location = new Point(683, 86);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(80, 29);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Ekle";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveStudent.Location = new Point(57, 348);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(225, 29);
            btnRemoveStudent.TabIndex = 5;
            btnRemoveStudent.Text = "Sil";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // lblCountStudent
            // 
            lblCountStudent.AutoSize = true;
            lblCountStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountStudent.Location = new Point(254, 53);
            lblCountStudent.Name = "lblCountStudent";
            lblCountStudent.Size = new Size(28, 21);
            lblCountStudent.TabIndex = 6;
            lblCountStudent.Text = "......";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCountStudent);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(tbxStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentList);
            Controls.Add(lbxStudentList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxStudentList;
        private Label lblStudentList;
        private Label lblStudentName;
        private TextBox tbxStudentName;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private Label lblCountStudent;
    }
}
namespace Project3
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
            dgrwCustomers = new DataGridView();
            tbxId = new TextBox();
            tbxEmail = new TextBox();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxCity = new TextBox();
            lblId = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblCity = new Label();
            btnAdd = new Button();
            gbxAdd = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).BeginInit();
            gbxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dgrwCustomers
            // 
            dgrwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwCustomers.Dock = DockStyle.Top;
            dgrwCustomers.Location = new Point(0, 0);
            dgrwCustomers.Name = "dgrwCustomers";
            dgrwCustomers.RowTemplate.Height = 25;
            dgrwCustomers.Size = new Size(772, 167);
            dgrwCustomers.TabIndex = 0;
            // 
            // tbxId
            // 
            tbxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxId.Location = new Point(141, 22);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(150, 29);
            tbxId.TabIndex = 1;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.Location = new Point(141, 127);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(150, 29);
            tbxEmail.TabIndex = 2;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxFirstName.Location = new Point(141, 57);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(150, 29);
            tbxFirstName.TabIndex = 3;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxLastName.Location = new Point(141, 92);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(150, 29);
            tbxLastName.TabIndex = 4;
            // 
            // tbxCity
            // 
            tbxCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxCity.Location = new Point(141, 162);
            tbxCity.Name = "tbxCity";
            tbxCity.Size = new Size(150, 29);
            tbxCity.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(76, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 21);
            lblId.TabIndex = 6;
            lblId.Text = "Id";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(76, 65);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(29, 21);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Ad";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(76, 100);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(53, 21);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Soyad";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(76, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 21);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Mail";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.Location = new Point(76, 170);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(46, 21);
            lblCity.TabIndex = 10;
            lblCity.Text = "Sehir";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(141, 197);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 32);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(tbxFirstName);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxId);
            gbxAdd.Controls.Add(lblCity);
            gbxAdd.Controls.Add(tbxEmail);
            gbxAdd.Controls.Add(lblEmail);
            gbxAdd.Controls.Add(tbxLastName);
            gbxAdd.Controls.Add(lblLastName);
            gbxAdd.Controls.Add(tbxCity);
            gbxAdd.Controls.Add(lblFirstName);
            gbxAdd.Controls.Add(lblId);
            gbxAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbxAdd.Location = new Point(12, 173);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(353, 247);
            gbxAdd.TabIndex = 12;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Ekle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 432);
            Controls.Add(gbxAdd);
            Controls.Add(dgrwCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrwCustomers;
        private TextBox tbxId;
        private TextBox tbxEmail;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxCity;
        private Label lblId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblCity;
        private Button btnAdd;
        private GroupBox gbxAdd;
    }
}
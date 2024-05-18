namespace Classes
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
            lbxStudents = new ListBox();
            dgrwStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgrwStudents).BeginInit();
            SuspendLayout();
            // 
            // lbxStudents
            // 
            lbxStudents.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbxStudents.FormattingEnabled = true;
            lbxStudents.ItemHeight = 21;
            lbxStudents.Location = new Point(34, 32);
            lbxStudents.Name = "lbxStudents";
            lbxStudents.Size = new Size(213, 277);
            lbxStudents.TabIndex = 0;
            // 
            // dgrwStudents
            // 
            dgrwStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwStudents.Location = new Point(299, 32);
            dgrwStudents.Name = "dgrwStudents";
            dgrwStudents.RowTemplate.Height = 25;
            dgrwStudents.Size = new Size(459, 277);
            dgrwStudents.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgrwStudents);
            Controls.Add(lbxStudents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbxStudents;
        private DataGridView dgrwStudents;
    }
}
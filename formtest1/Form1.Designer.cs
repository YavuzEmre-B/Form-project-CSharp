namespace formtest1
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
            lbxProducts = new ListBox();
            lblProducts = new Label();
            btnAddToCart = new Button();
            lbxCart = new ListBox();
            lblCart = new Label();
            btnRemoveFromCart = new Button();
            btnRemoveAllInCart = new Button();
            lblBakiye = new Label();
            SuspendLayout();
            // 
            // lbxProducts
            // 
            lbxProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbxProducts.FormattingEnabled = true;
            lbxProducts.ItemHeight = 21;
            lbxProducts.Location = new Point(31, 81);
            lbxProducts.Name = "lbxProducts";
            lbxProducts.Size = new Size(123, 172);
            lbxProducts.TabIndex = 0;
            lbxProducts.SelectedIndexChanged += lbxProducts_SelectedIndexChanged;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducts.Location = new Point(31, 45);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(52, 21);
            lblProducts.TabIndex = 1;
            lblProducts.Text = "label1";
            lblProducts.Click += lblProducts_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(31, 259);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(123, 23);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "button1";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbxCart
            // 
            lbxCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbxCart.FormattingEnabled = true;
            lbxCart.ItemHeight = 21;
            lbxCart.Location = new Point(174, 81);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new Size(123, 172);
            lbxCart.TabIndex = 3;
            lbxCart.SelectedIndexChanged += lbxCart_SelectedIndexChanged;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCart.Location = new Point(174, 45);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(52, 21);
            lblCart.TabIndex = 4;
            lblCart.Text = "label1";
            lblCart.Click += lblCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(174, 259);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(123, 23);
            btnRemoveFromCart.TabIndex = 5;
            btnRemoveFromCart.Text = "button1";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnRemoveAllInCart
            // 
            btnRemoveAllInCart.Location = new Point(174, 290);
            btnRemoveAllInCart.Name = "btnRemoveAllInCart";
            btnRemoveAllInCart.Size = new Size(123, 23);
            btnRemoveAllInCart.TabIndex = 6;
            btnRemoveAllInCart.Text = "button1";
            btnRemoveAllInCart.UseVisualStyleBackColor = true;
            btnRemoveAllInCart.Click += btnRemoveAllInCart_Click;
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBakiye.Location = new Point(702, 28);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(52, 21);
            lblBakiye.TabIndex = 7;
            lblBakiye.Text = "label1";
            lblBakiye.Click += bakiye_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 448);
            Controls.Add(lblBakiye);
            Controls.Add(btnRemoveAllInCart);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(lblCart);
            Controls.Add(lbxCart);
            Controls.Add(btnAddToCart);
            Controls.Add(lblProducts);
            Controls.Add(lbxProducts);
            Name = "Form1";
            Text = "Rent a car";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxProducts;
        private Label lblProducts;
        private Button btnAddToCart;
        private ListBox lbxCart;
        private Label lblCart;
        private Button btnRemoveFromCart;
        private Button btnRemoveAllInCart;
        private Label lblBakiye;
    }
}
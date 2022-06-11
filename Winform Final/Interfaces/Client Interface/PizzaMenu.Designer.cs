namespace Winform_Final.Client_Interface
{
    partial class PizzaMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.PizzaListBtn = new System.Windows.Forms.Button();
            this.DrinkListBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.foodListPanel = new System.Windows.Forms.Panel();
            this.testBtn = new FontAwesome.Sharp.IconButton();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.cartPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.cancelBtn = new FontAwesome.Sharp.IconButton();
            this.confirmBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.foodGridView = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cart_itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_itemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_itemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPanel.SuspendLayout();
            this.foodListPanel.SuspendLayout();
            this.cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "Keep calm and order pizza.";
            // 
            // PizzaListBtn
            // 
            this.PizzaListBtn.BackColor = System.Drawing.Color.White;
            this.PizzaListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PizzaListBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaListBtn.Location = new System.Drawing.Point(12, 82);
            this.PizzaListBtn.Name = "PizzaListBtn";
            this.PizzaListBtn.Size = new System.Drawing.Size(134, 49);
            this.PizzaListBtn.TabIndex = 1;
            this.PizzaListBtn.Text = "Pizza";
            this.PizzaListBtn.UseVisualStyleBackColor = false;
            // 
            // DrinkListBtn
            // 
            this.DrinkListBtn.BackColor = System.Drawing.Color.White;
            this.DrinkListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrinkListBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkListBtn.Location = new System.Drawing.Point(152, 82);
            this.DrinkListBtn.Name = "DrinkListBtn";
            this.DrinkListBtn.Size = new System.Drawing.Size(134, 49);
            this.DrinkListBtn.TabIndex = 1;
            this.DrinkListBtn.Text = "Drinks";
            this.DrinkListBtn.UseVisualStyleBackColor = false;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(252)))), ((int)(((byte)(197)))));
            this.menuPanel.Controls.Add(this.foodListPanel);
            this.menuPanel.Controls.Add(this.cartPanel);
            this.menuPanel.Controls.Add(this.DrinkListBtn);
            this.menuPanel.Controls.Add(this.PizzaListBtn);
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.ForeColor = System.Drawing.Color.Black;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1232, 725);
            this.menuPanel.TabIndex = 1;
            // 
            // foodListPanel
            // 
            this.foodListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.foodListPanel.Controls.Add(this.foodGridView);
            this.foodListPanel.Controls.Add(this.testBtn);
            this.foodListPanel.Controls.Add(this.addBtn);
            this.foodListPanel.Location = new System.Drawing.Point(12, 137);
            this.foodListPanel.Name = "foodListPanel";
            this.foodListPanel.Size = new System.Drawing.Size(638, 575);
            this.foodListPanel.TabIndex = 5;
            // 
            // testBtn
            // 
            this.testBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testBtn.BackColor = System.Drawing.Color.White;
            this.testBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.testBtn.FlatAppearance.BorderSize = 2;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.testBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.testBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.testBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.testBtn.IconSize = 40;
            this.testBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testBtn.Location = new System.Drawing.Point(306, 511);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(156, 61);
            this.testBtn.TabIndex = 4;
            this.testBtn.Text = "test";
            this.testBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.addBtn.FlatAppearance.BorderSize = 2;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.addBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 40;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(479, 511);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 61);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cartPanel
            // 
            this.cartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(254)))), ((int)(((byte)(235)))));
            this.cartPanel.Controls.Add(this.deleteBtn);
            this.cartPanel.Controls.Add(this.cancelBtn);
            this.cartPanel.Controls.Add(this.confirmBtn);
            this.cartPanel.Controls.Add(this.label1);
            this.cartPanel.Controls.Add(this.cartGridView);
            this.cartPanel.Location = new System.Drawing.Point(656, 12);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(564, 701);
            this.cartPanel.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteBtn.IconColor = System.Drawing.Color.Black;
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.IconSize = 40;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(418, 640);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 49);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelBtn.IconColor = System.Drawing.Color.Black;
            this.cancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBtn.IconSize = 40;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(279, 640);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(133, 49);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancle";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.confirmBtn.IconColor = System.Drawing.Color.Black;
            this.confirmBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirmBtn.IconSize = 40;
            this.confirmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmBtn.Location = new System.Drawing.Point(15, 573);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(536, 49);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.Text = "Place Order";
            this.confirmBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cart";
            // 
            // cartGridView
            // 
            this.cartGridView.AllowUserToAddRows = false;
            this.cartGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.cartGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cartGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cart_itemName,
            this.cart_itemCategory,
            this.cart_itemAmount,
            this.cart_itemPrice});
            this.cartGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartGridView.Location = new System.Drawing.Point(15, 72);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.RowHeadersWidth = 51;
            this.cartGridView.RowTemplate.Height = 30;
            this.cartGridView.Size = new System.Drawing.Size(536, 483);
            this.cartGridView.TabIndex = 2;
            // 
            // foodGridView
            // 
            this.foodGridView.AllowUserToAddRows = false;
            this.foodGridView.AllowUserToDeleteRows = false;
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            this.foodGridView.Location = new System.Drawing.Point(3, 3);
            this.foodGridView.Name = "foodGridView";
            this.foodGridView.ReadOnly = true;
            this.foodGridView.RowHeadersWidth = 51;
            this.foodGridView.RowTemplate.Height = 24;
            this.foodGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodGridView.Size = new System.Drawing.Size(632, 150);
            this.foodGridView.TabIndex = 5;
            this.foodGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodGridView_CellContentDoubleClick);
            this.foodGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodGridView_CellDoubleClick);
            this.foodGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.foodGridView_MouseClick);
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 125;
            // 
            // cart_itemName
            // 
            this.cart_itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cart_itemName.HeaderText = "Food ";
            this.cart_itemName.MinimumWidth = 6;
            this.cart_itemName.Name = "cart_itemName";
            this.cart_itemName.ReadOnly = true;
            // 
            // cart_itemCategory
            // 
            this.cart_itemCategory.HeaderText = "Category";
            this.cart_itemCategory.MinimumWidth = 6;
            this.cart_itemCategory.Name = "cart_itemCategory";
            this.cart_itemCategory.ReadOnly = true;
            this.cart_itemCategory.Width = 125;
            // 
            // cart_itemAmount
            // 
            this.cart_itemAmount.HeaderText = "Amount";
            this.cart_itemAmount.MinimumWidth = 6;
            this.cart_itemAmount.Name = "cart_itemAmount";
            this.cart_itemAmount.Width = 125;
            // 
            // cart_itemPrice
            // 
            this.cart_itemPrice.HeaderText = "Price";
            this.cart_itemPrice.MinimumWidth = 6;
            this.cart_itemPrice.Name = "cart_itemPrice";
            this.cart_itemPrice.ReadOnly = true;
            this.cart_itemPrice.Width = 125;
            // 
            // PizzaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 725);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PizzaMenu";
            this.Text = "PizzaMenu";
            this.Load += new System.EventHandler(this.PizzaMenu_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.foodListPanel.ResumeLayout(false);
            this.cartPanel.ResumeLayout(false);
            this.cartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PizzaListBtn;
        private System.Windows.Forms.Button DrinkListBtn;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton cancelBtn;
        private FontAwesome.Sharp.IconButton confirmBtn;
        private System.Windows.Forms.DataGridView cartGridView;
        private FontAwesome.Sharp.IconButton addBtn;
        private System.Windows.Forms.Panel foodListPanel;
        private FontAwesome.Sharp.IconButton testBtn;
        private System.Windows.Forms.DataGridView foodGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_itemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_itemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_itemPrice;
    }
}
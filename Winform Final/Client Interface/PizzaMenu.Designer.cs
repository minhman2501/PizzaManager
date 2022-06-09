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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.PizzaListBtn = new System.Windows.Forms.Button();
            this.DrinkListBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.foodListPanel = new System.Windows.Forms.Panel();
            this.foodGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.cartPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.cancelBtn = new FontAwesome.Sharp.IconButton();
            this.confirmBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.testBtn = new FontAwesome.Sharp.IconButton();
            this.seletectProduct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.foodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPanel.SuspendLayout();
            this.foodListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            this.cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
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
            this.foodListPanel.Size = new System.Drawing.Size(585, 575);
            this.foodListPanel.TabIndex = 5;
            // 
            // foodGridView
            // 
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.foodGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.foodGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seletectProduct,
            this.foodID,
            this.foodName,
            this.foodPrice});
            this.foodGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodGridView.Location = new System.Drawing.Point(0, 0);
            this.foodGridView.Name = "foodGridView";
            this.foodGridView.RowHeadersWidth = 51;
            this.foodGridView.RowTemplate.Height = 30;
            this.foodGridView.Size = new System.Drawing.Size(582, 477);
            this.foodGridView.TabIndex = 2;
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
            this.addBtn.Location = new System.Drawing.Point(426, 511);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 61);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addBtn.UseVisualStyleBackColor = false;
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
            this.cartPanel.Location = new System.Drawing.Point(603, 12);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(617, 701);
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
            this.deleteBtn.Location = new System.Drawing.Point(471, 640);
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
            this.cancelBtn.Location = new System.Drawing.Point(332, 640);
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
            this.confirmBtn.Size = new System.Drawing.Size(589, 49);
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
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.cartGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.cartGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.cartAmountColumn,
            this.Column3,
            this.dataGridViewTextBoxColumn2,
            this.Column2});
            this.cartGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartGridView.Location = new System.Drawing.Point(15, 72);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.RowHeadersWidth = 51;
            this.cartGridView.RowTemplate.Height = 30;
            this.cartGridView.Size = new System.Drawing.Size(589, 483);
            this.cartGridView.TabIndex = 2;
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
            this.testBtn.Location = new System.Drawing.Point(253, 511);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(156, 61);
            this.testBtn.TabIndex = 4;
            this.testBtn.Text = "test";
            this.testBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // seletectProduct
            // 
            this.seletectProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.seletectProduct.HeaderText = "Select";
            this.seletectProduct.MinimumWidth = 6;
            this.seletectProduct.Name = "seletectProduct";
            this.seletectProduct.Width = 51;
            // 
            // foodID
            // 
            this.foodID.HeaderText = "ID";
            this.foodID.MinimumWidth = 6;
            this.foodID.Name = "foodID";
            this.foodID.ReadOnly = true;
            this.foodID.Width = 125;
            // 
            // foodName
            // 
            this.foodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodName.HeaderText = "Food ";
            this.foodName.MinimumWidth = 6;
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            // 
            // foodPrice
            // 
            this.foodPrice.HeaderText = "Price";
            this.foodPrice.MinimumWidth = 6;
            this.foodPrice.Name = "foodPrice";
            this.foodPrice.ReadOnly = true;
            this.foodPrice.Width = 125;
            // 
            // column1
            // 
            this.column1.HeaderText = "ID";
            this.column1.MinimumWidth = 6;
            this.column1.Name = "column1";
            this.column1.Width = 125;
            // 
            // cartAmountColumn
            // 
            this.cartAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartAmountColumn.HeaderText = "Food ";
            this.cartAmountColumn.MinimumWidth = 6;
            this.cartAmountColumn.Name = "cartAmountColumn";
            this.cartAmountColumn.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            this.cartPanel.ResumeLayout(false);
            this.cartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PizzaListBtn;
        private System.Windows.Forms.Button DrinkListBtn;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.DataGridView foodGridView;
        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton cancelBtn;
        private FontAwesome.Sharp.IconButton confirmBtn;
        private System.Windows.Forms.DataGridView cartGridView;
        private FontAwesome.Sharp.IconButton addBtn;
        private System.Windows.Forms.Panel foodListPanel;
        private FontAwesome.Sharp.IconButton testBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seletectProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
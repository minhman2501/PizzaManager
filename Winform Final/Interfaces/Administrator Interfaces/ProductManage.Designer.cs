namespace Winform_Final.Administrator_Interfaces
{
    partial class ProductManage
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
            this.components = new System.ComponentModel.Container();
            this.wrapperPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalDrinkLabel = new System.Windows.Forms.Label();
            this.totalPizzaLabel = new System.Windows.Forms.Label();
            this.totalProductLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productListPanel = new System.Windows.Forms.Panel();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.addProductPanel = new System.Windows.Forms.Panel();
            this.newProductCategoryCb = new System.Windows.Forms.ComboBox();
            this.newProductPriceTxt = new System.Windows.Forms.TextBox();
            this.newProductNameTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelBtn = new FontAwesome.Sharp.IconButton();
            this.saveBtn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idProductLB = new System.Windows.Forms.Label();
            this.dBMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wrapperPanel.SuspendLayout();
            this.productListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.addProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // wrapperPanel
            // 
            this.wrapperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.wrapperPanel.Controls.Add(this.label5);
            this.wrapperPanel.Controls.Add(this.label3);
            this.wrapperPanel.Controls.Add(this.label2);
            this.wrapperPanel.Controls.Add(this.totalDrinkLabel);
            this.wrapperPanel.Controls.Add(this.totalPizzaLabel);
            this.wrapperPanel.Controls.Add(this.totalProductLabel);
            this.wrapperPanel.Controls.Add(this.label1);
            this.wrapperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wrapperPanel.Location = new System.Drawing.Point(0, 0);
            this.wrapperPanel.Name = "wrapperPanel";
            this.wrapperPanel.Size = new System.Drawing.Size(950, 197);
            this.wrapperPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(604, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Drinks";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(604, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Pizzas";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Product";
            // 
            // totalDrinkLabel
            // 
            this.totalDrinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalDrinkLabel.AutoSize = true;
            this.totalDrinkLabel.Font = new System.Drawing.Font("Engravers MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDrinkLabel.ForeColor = System.Drawing.Color.White;
            this.totalDrinkLabel.Location = new System.Drawing.Point(526, 124);
            this.totalDrinkLabel.Name = "totalDrinkLabel";
            this.totalDrinkLabel.Size = new System.Drawing.Size(72, 47);
            this.totalDrinkLabel.TabIndex = 1;
            this.totalDrinkLabel.Text = "50";
            // 
            // totalPizzaLabel
            // 
            this.totalPizzaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalPizzaLabel.AutoSize = true;
            this.totalPizzaLabel.Font = new System.Drawing.Font("Engravers MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPizzaLabel.ForeColor = System.Drawing.Color.White;
            this.totalPizzaLabel.Location = new System.Drawing.Point(526, 58);
            this.totalPizzaLabel.Name = "totalPizzaLabel";
            this.totalPizzaLabel.Size = new System.Drawing.Size(72, 47);
            this.totalPizzaLabel.TabIndex = 1;
            this.totalPizzaLabel.Text = "50";
            // 
            // totalProductLabel
            // 
            this.totalProductLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalProductLabel.AutoSize = true;
            this.totalProductLabel.Font = new System.Drawing.Font("Engravers MT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductLabel.ForeColor = System.Drawing.Color.White;
            this.totalProductLabel.Location = new System.Drawing.Point(87, 93);
            this.totalProductLabel.Name = "totalProductLabel";
            this.totalProductLabel.Size = new System.Drawing.Size(119, 78);
            this.totalProductLabel.TabIndex = 1;
            this.totalProductLabel.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Summary";
            // 
            // productListPanel
            // 
            this.productListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productListPanel.Controls.Add(this.editBtn);
            this.productListPanel.Controls.Add(this.deleteBtn);
            this.productListPanel.Controls.Add(this.addBtn);
            this.productListPanel.Controls.Add(this.productGridView);
            this.productListPanel.Controls.Add(this.label4);
            this.productListPanel.Location = new System.Drawing.Point(12, 203);
            this.productListPanel.Name = "productListPanel";
            this.productListPanel.Size = new System.Drawing.Size(523, 457);
            this.productListPanel.TabIndex = 1;
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.IconSize = 40;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(426, 401);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(94, 38);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(5)))), ((int)(((byte)(44)))));
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.IconSize = 40;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(317, 401);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 38);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.addBtn.FlatAppearance.BorderSize = 2;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 40;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(207, 401);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 38);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(3, 63);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(517, 310);
            this.productGridView.TabIndex = 2;
            this.productGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productGridView_MouseClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(161, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product List";
            // 
            // addProductPanel
            // 
            this.addProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.addProductPanel.Controls.Add(this.newProductCategoryCb);
            this.addProductPanel.Controls.Add(this.newProductPriceTxt);
            this.addProductPanel.Controls.Add(this.newProductNameTxt);
            this.addProductPanel.Controls.Add(this.label9);
            this.addProductPanel.Controls.Add(this.label8);
            this.addProductPanel.Controls.Add(this.cancelBtn);
            this.addProductPanel.Controls.Add(this.saveBtn);
            this.addProductPanel.Controls.Add(this.idProductLB);
            this.addProductPanel.Controls.Add(this.label10);
            this.addProductPanel.Controls.Add(this.label7);
            this.addProductPanel.Controls.Add(this.label6);
            this.addProductPanel.Location = new System.Drawing.Point(552, 203);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(386, 457);
            this.addProductPanel.TabIndex = 1;
            // 
            // newProductCategoryCb
            // 
            this.newProductCategoryCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProductCategoryCb.BackColor = System.Drawing.Color.White;
            this.newProductCategoryCb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductCategoryCb.Items.AddRange(new object[] {
            "Pizza",
            "Drink"});
            this.newProductCategoryCb.Location = new System.Drawing.Point(29, 216);
            this.newProductCategoryCb.Name = "newProductCategoryCb";
            this.newProductCategoryCb.Size = new System.Drawing.Size(345, 29);
            this.newProductCategoryCb.TabIndex = 7;
            // 
            // newProductPriceTxt
            // 
            this.newProductPriceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProductPriceTxt.BackColor = System.Drawing.Color.White;
            this.newProductPriceTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductPriceTxt.Location = new System.Drawing.Point(29, 310);
            this.newProductPriceTxt.Name = "newProductPriceTxt";
            this.newProductPriceTxt.Size = new System.Drawing.Size(345, 28);
            this.newProductPriceTxt.TabIndex = 6;
            // 
            // newProductNameTxt
            // 
            this.newProductNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProductNameTxt.BackColor = System.Drawing.Color.White;
            this.newProductNameTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductNameTxt.Location = new System.Drawing.Point(29, 130);
            this.newProductNameTxt.Name = "newProductNameTxt";
            this.newProductNameTxt.Size = new System.Drawing.Size(345, 28);
            this.newProductNameTxt.TabIndex = 6;
            this.newProductNameTxt.TextChanged += new System.EventHandler(this.newProductNameTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(25, 190);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Category:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(25, 284);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Price:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.cancelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.cancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBtn.IconSize = 40;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(164, 401);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 38);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.saveBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.saveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBtn.IconSize = 40;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(272, 401);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 38);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(25, 104);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(24, 14);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add/Edit Product";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(190, 63);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(35, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "ID:";
            // 
            // idProductLB
            // 
            this.idProductLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idProductLB.AutoSize = true;
            this.idProductLB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProductLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.idProductLB.Location = new System.Drawing.Point(231, 63);
            this.idProductLB.Name = "idProductLB";
            this.idProductLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idProductLB.Size = new System.Drawing.Size(0, 23);
            this.idProductLB.TabIndex = 1;
            // 
            // dBMainBindingSource
            // 
            this.dBMainBindingSource.DataSource = typeof(Winform_Final.DBLayers.DBMain);
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 672);
            this.Controls.Add(this.addProductPanel);
            this.Controls.Add(this.productListPanel);
            this.Controls.Add(this.wrapperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManage";
            this.Text = "ProductManage";
            this.Load += new System.EventHandler(this.ProductManage_Load);
            this.wrapperPanel.ResumeLayout(false);
            this.wrapperPanel.PerformLayout();
            this.productListPanel.ResumeLayout(false);
            this.productListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.addProductPanel.ResumeLayout(false);
            this.addProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBMainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wrapperPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalDrinkLabel;
        private System.Windows.Forms.Label totalPizzaLabel;
        private System.Windows.Forms.Label totalProductLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel productListPanel;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton addBtn;
        private FontAwesome.Sharp.IconButton editBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.ComboBox newProductCategoryCb;
        private System.Windows.Forms.TextBox newProductPriceTxt;
        private System.Windows.Forms.TextBox newProductNameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton cancelBtn;
        private FontAwesome.Sharp.IconButton saveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource dBMainBindingSource;
        private System.Windows.Forms.Label idProductLB;
        private System.Windows.Forms.Label label10;
    }
}
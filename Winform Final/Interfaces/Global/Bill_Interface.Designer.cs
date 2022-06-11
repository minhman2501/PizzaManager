namespace Winform_Final.Interfaces.Global
{
    partial class Bill_Interface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clientAddressTxt = new System.Windows.Forms.TextBox();
            this.bill_itemGridView = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.total_priceLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmBtn = new FontAwesome.Sharp.IconButton();
            this.cancelOrderBtn = new FontAwesome.Sharp.IconButton();
            this.clientName = new System.Windows.Forms.Label();
            this.invoiceDateDTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bill_itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Paradise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ship to:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 17);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.panel2.Location = new System.Drawing.Point(12, 722);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 18);
            this.panel2.TabIndex = 1;
            // 
            // clientAddressTxt
            // 
            this.clientAddressTxt.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddressTxt.Location = new System.Drawing.Point(512, 128);
            this.clientAddressTxt.Multiline = true;
            this.clientAddressTxt.Name = "clientAddressTxt";
            this.clientAddressTxt.Size = new System.Drawing.Size(270, 99);
            this.clientAddressTxt.TabIndex = 2;
            // 
            // bill_itemGridView
            // 
            this.bill_itemGridView.AllowUserToAddRows = false;
            this.bill_itemGridView.AllowUserToDeleteRows = false;
            this.bill_itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill_itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantity,
            this.description,
            this.unitPrice,
            this.amountPrice});
            this.bill_itemGridView.Location = new System.Drawing.Point(36, 320);
            this.bill_itemGridView.Name = "bill_itemGridView";
            this.bill_itemGridView.ReadOnly = true;
            this.bill_itemGridView.RowHeadersWidth = 51;
            this.bill_itemGridView.RowTemplate.Height = 24;
            this.bill_itemGridView.Size = new System.Drawing.Size(746, 241);
            this.bill_itemGridView.TabIndex = 3;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "QTY";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 6;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            this.unitPrice.Width = 125;
            // 
            // amountPrice
            // 
            this.amountPrice.HeaderText = "Amount";
            this.amountPrice.MinimumWidth = 6;
            this.amountPrice.Name = "amountPrice";
            this.amountPrice.ReadOnly = true;
            this.amountPrice.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(30, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "INVOICE TOTAL";
            // 
            // total_priceLB
            // 
            this.total_priceLB.AutoSize = true;
            this.total_priceLB.Font = new System.Drawing.Font("Oswald", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_priceLB.Location = new System.Drawing.Point(404, 250);
            this.total_priceLB.Name = "total_priceLB";
            this.total_priceLB.Size = new System.Drawing.Size(242, 58);
            this.total_priceLB.TabIndex = 0;
            this.total_priceLB.Text = "[insertTotalPrice]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Invoice Date:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.confirmBtn.IconColor = System.Drawing.Color.Black;
            this.confirmBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirmBtn.IconSize = 40;
            this.confirmBtn.Location = new System.Drawing.Point(439, 613);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(230, 81);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelOrderBtn.BackColor = System.Drawing.Color.White;
            this.cancelOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.cancelOrderBtn.FlatAppearance.BorderSize = 3;
            this.cancelOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOrderBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.cancelOrderBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelOrderBtn.IconColor = System.Drawing.Color.Black;
            this.cancelOrderBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelOrderBtn.IconSize = 40;
            this.cancelOrderBtn.Location = new System.Drawing.Point(168, 613);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(230, 81);
            this.cancelOrderBtn.TabIndex = 5;
            this.cancelOrderBtn.Text = "Cancel Order";
            this.cancelOrderBtn.UseVisualStyleBackColor = false;
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.Location = new System.Drawing.Point(178, 128);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(131, 23);
            this.clientName.TabIndex = 0;
            this.clientName.Text = "[insertname]";
            // 
            // invoiceDateDTP
            // 
            this.invoiceDateDTP.CalendarFont = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDateDTP.CustomFormat = "dd / MM / yyyy";
            this.invoiceDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDateDTP.Location = new System.Drawing.Point(181, 190);
            this.invoiceDateDTP.Name = "invoiceDateDTP";
            this.invoiceDateDTP.Size = new System.Drawing.Size(156, 22);
            this.invoiceDateDTP.TabIndex = 6;
            // 
            // Bill_Interface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(794, 762);
            this.Controls.Add(this.invoiceDateDTP);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.bill_itemGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clientAddressTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total_priceLB);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Bill_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill_Interface";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Bill_Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox clientAddressTxt;
        private System.Windows.Forms.DataGridView bill_itemGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total_priceLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPrice;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton confirmBtn;
        private FontAwesome.Sharp.IconButton cancelOrderBtn;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.DateTimePicker invoiceDateDTP;
    }
}
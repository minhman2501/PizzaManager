namespace Winform_Final.Client_Interface
{
    partial class Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foodPriceLb = new System.Windows.Forms.Label();
            this.foodNameLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addToCartBtn = new FontAwesome.Sharp.IconButton();
            this.foodImgPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foodImgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // foodPriceLb
            // 
            this.foodPriceLb.AutoSize = true;
            this.foodPriceLb.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodPriceLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(133)))), ((int)(((byte)(14)))));
            this.foodPriceLb.Location = new System.Drawing.Point(219, 102);
            this.foodPriceLb.Name = "foodPriceLb";
            this.foodPriceLb.Size = new System.Drawing.Size(107, 35);
            this.foodPriceLb.TabIndex = 1;
            this.foodPriceLb.Text = "[price]";
            // 
            // foodNameLb
            // 
            this.foodNameLb.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameLb.Location = new System.Drawing.Point(217, 24);
            this.foodNameLb.Name = "foodNameLb";
            this.foodNameLb.Size = new System.Drawing.Size(446, 44);
            this.foodNameLb.TabIndex = 1;
            this.foodNameLb.Text = "[Food Name]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "VND";
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addToCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.addToCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartBtn.FlatAppearance.BorderSize = 0;
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.ForeColor = System.Drawing.Color.White;
            this.addToCartBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.addToCartBtn.IconColor = System.Drawing.Color.White;
            this.addToCartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addToCartBtn.IconSize = 30;
            this.addToCartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToCartBtn.Location = new System.Drawing.Point(555, 102);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(108, 43);
            this.addToCartBtn.TabIndex = 2;
            this.addToCartBtn.Text = "Add";
            this.addToCartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addToCartBtn.UseVisualStyleBackColor = false;
            // 
            // foodImgPB
            // 
            this.foodImgPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.foodImgPB.Image = global::Winform_Final.Properties.Resources.background;
            this.foodImgPB.Location = new System.Drawing.Point(0, 0);
            this.foodImgPB.Name = "foodImgPB";
            this.foodImgPB.Size = new System.Drawing.Size(185, 162);
            this.foodImgPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foodImgPB.TabIndex = 0;
            this.foodImgPB.TabStop = false;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.foodNameLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.foodPriceLb);
            this.Controls.Add(this.foodImgPB);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Item";
            this.Size = new System.Drawing.Size(677, 162);
            ((System.ComponentModel.ISupportInitialize)(this.foodImgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox foodImgPB;
        private System.Windows.Forms.Label foodPriceLb;
        private System.Windows.Forms.Label foodNameLb;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton addToCartBtn;
    }
}

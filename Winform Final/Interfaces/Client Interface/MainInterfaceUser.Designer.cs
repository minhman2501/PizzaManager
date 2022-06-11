namespace Winform_Final
{
    partial class MainInterfaceUser
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
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.buyHistoryBtn = new FontAwesome.Sharp.IconButton();
            this.MenuBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.wrapperPanel = new System.Windows.Forms.Panel();
            this.sideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.sideBarPanel.Controls.Add(this.iconButton1);
            this.sideBarPanel.Controls.Add(this.buyHistoryBtn);
            this.sideBarPanel.Controls.Add(this.MenuBtn);
            this.sideBarPanel.Controls.Add(this.HomeBtn);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(225, 656);
            this.sideBarPanel.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 581);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(225, 75);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Log Out";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // buyHistoryBtn
            // 
            this.buyHistoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyHistoryBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buyHistoryBtn.FlatAppearance.BorderSize = 0;
            this.buyHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyHistoryBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyHistoryBtn.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.buyHistoryBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.buyHistoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buyHistoryBtn.IconSize = 40;
            this.buyHistoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buyHistoryBtn.Location = new System.Drawing.Point(0, 248);
            this.buyHistoryBtn.Name = "buyHistoryBtn";
            this.buyHistoryBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buyHistoryBtn.Size = new System.Drawing.Size(225, 93);
            this.buyHistoryBtn.TabIndex = 3;
            this.buyHistoryBtn.Text = "Order History";
            this.buyHistoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buyHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.MenuBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.MenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuBtn.IconSize = 40;
            this.MenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBtn.Location = new System.Drawing.Point(0, 167);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MenuBtn.Size = new System.Drawing.Size(225, 66);
            this.MenuBtn.TabIndex = 2;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.IconSize = 40;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 84);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(225, 66);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home ";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // wrapperPanel
            // 
            this.wrapperPanel.BackColor = System.Drawing.Color.Transparent;
            this.wrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperPanel.Location = new System.Drawing.Point(225, 0);
            this.wrapperPanel.Name = "wrapperPanel";
            this.wrapperPanel.Size = new System.Drawing.Size(1113, 656);
            this.wrapperPanel.TabIndex = 1;
            // 
            // MainInterfaceUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1338, 656);
            this.Controls.Add(this.wrapperPanel);
            this.Controls.Add(this.sideBarPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.Name = "MainInterfaceUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton buyHistoryBtn;
        private FontAwesome.Sharp.IconButton MenuBtn;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private System.Windows.Forms.Panel wrapperPanel;
    }
}


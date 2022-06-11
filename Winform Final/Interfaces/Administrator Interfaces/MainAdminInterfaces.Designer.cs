﻿namespace Winform_Final.Administrator_Interfaces
{
    partial class MainAdminInterfaces
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
            this.MenuBtn = new FontAwesome.Sharp.IconButton();
            this.foodManageBtn = new FontAwesome.Sharp.IconButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.sideBarPanel.Controls.Add(this.iconButton1);
            this.sideBarPanel.Controls.Add(this.MenuBtn);
            this.sideBarPanel.Controls.Add(this.foodManageBtn);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(253, 656);
            this.sideBarPanel.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 581);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(253, 75);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Log Out";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.White;
            this.MenuBtn.IconChar = FontAwesome.Sharp.IconChar.Th;
            this.MenuBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.MenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuBtn.IconSize = 40;
            this.MenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBtn.Location = new System.Drawing.Point(0, 204);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MenuBtn.Size = new System.Drawing.Size(253, 66);
            this.MenuBtn.TabIndex = 2;
            this.MenuBtn.Text = "Statistic";
            this.MenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuBtn.UseVisualStyleBackColor = true;
            // 
            // foodManageBtn
            // 
            this.foodManageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodManageBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.foodManageBtn.FlatAppearance.BorderSize = 0;
            this.foodManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodManageBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodManageBtn.ForeColor = System.Drawing.Color.White;
            this.foodManageBtn.IconChar = FontAwesome.Sharp.IconChar.HollyBerry;
            this.foodManageBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.foodManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.foodManageBtn.IconSize = 40;
            this.foodManageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodManageBtn.Location = new System.Drawing.Point(-4, 89);
            this.foodManageBtn.Name = "foodManageBtn";
            this.foodManageBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.foodManageBtn.Size = new System.Drawing.Size(254, 109);
            this.foodManageBtn.TabIndex = 1;
            this.foodManageBtn.Text = "Product Management";
            this.foodManageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodManageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.foodManageBtn.UseVisualStyleBackColor = true;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(253, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1085, 656);
            this.contentPanel.TabIndex = 2;
            // 
            // MainAdminInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 656);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Name = "MainAdminInterfaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAdminInterfaces";
            this.sideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton MenuBtn;
        private FontAwesome.Sharp.IconButton foodManageBtn;
        private System.Windows.Forms.Panel contentPanel;
    }
}
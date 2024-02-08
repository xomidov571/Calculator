﻿namespace Library
{
    partial class DashboardWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
            this.Databtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ControlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MenuPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 761);
            this.panel1.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.MenuPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.MenuPanel.BorderRadius = 15;
            this.MenuPanel.Controls.Add(this.Closebtn);
            this.MenuPanel.Controls.Add(this.Deletebtn);
            this.MenuPanel.Controls.Add(this.Updatebtn);
            this.MenuPanel.Controls.Add(this.Createbtn);
            this.MenuPanel.Controls.Add(this.Databtn);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.MenuPanel.FillColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Location = new System.Drawing.Point(9, 12);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(182, 737);
            this.MenuPanel.TabIndex = 0;
            // 
            // Closebtn
            // 
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.Closebtn.Location = new System.Drawing.Point(0, 658);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(182, 52);
            this.Closebtn.TabIndex = 6;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.Deletebtn.Location = new System.Drawing.Point(0, 386);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(182, 52);
            this.Deletebtn.TabIndex = 5;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.Updatebtn.Location = new System.Drawing.Point(0, 302);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(182, 52);
            this.Updatebtn.TabIndex = 4;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Createbtn
            // 
            this.Createbtn.FlatAppearance.BorderSize = 0;
            this.Createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Createbtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Createbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.Createbtn.Location = new System.Drawing.Point(0, 218);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(182, 52);
            this.Createbtn.TabIndex = 3;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // Databtn
            // 
            this.Databtn.FlatAppearance.BorderSize = 0;
            this.Databtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Databtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Databtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.Databtn.Location = new System.Drawing.Point(0, 132);
            this.Databtn.Name = "Databtn";
            this.Databtn.Size = new System.Drawing.Size(182, 52);
            this.Databtn.TabIndex = 2;
            this.Databtn.Text = "Data";
            this.Databtn.UseVisualStyleBackColor = true;
            this.Databtn.Click += new System.EventHandler(this.Databtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ControlPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 761);
            this.panel2.TabIndex = 1;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanel.BorderColor = System.Drawing.Color.Transparent;
            this.ControlPanel.BorderRadius = 15;
            this.ControlPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.ControlPanel.Location = new System.Drawing.Point(6, 12);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(766, 737);
            this.ControlPanel.TabIndex = 0;
            // 
            // DashboardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel MenuPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Databtn;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Closebtn;
        private Guna.UI2.WinForms.Guna2Panel ControlPanel;
    }
}


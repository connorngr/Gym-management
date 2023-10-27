﻿namespace Gym_management
{
    partial class Login_DB
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
            this.uidTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.labExit = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(263, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRUNG TÂM THỂ LỰC";
            // 
            // uidTb
            // 
            this.uidTb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidTb.Location = new System.Drawing.Point(248, 70);
            this.uidTb.Multiline = true;
            this.uidTb.Name = "uidTb";
            this.uidTb.Size = new System.Drawing.Size(244, 34);
            this.uidTb.TabIndex = 2;
            // 
            // passTb
            // 
            this.passTb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTb.Location = new System.Drawing.Point(248, 131);
            this.passTb.Multiline = true;
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.Size = new System.Drawing.Size(244, 34);
            this.passTb.TabIndex = 4;
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butLogin.FlatAppearance.BorderSize = 0;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(403, 185);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(129, 31);
            this.butLogin.TabIndex = 6;
            this.butLogin.Text = "Đăng nhập";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.butRefresh.FlatAppearance.BorderSize = 0;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRefresh.ForeColor = System.Drawing.Color.White;
            this.butRefresh.Location = new System.Drawing.Point(268, 185);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(129, 31);
            this.butRefresh.TabIndex = 7;
            this.butRefresh.Text = "Làm mới";
            this.butRefresh.UseVisualStyleBackColor = false;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // labExit
            // 
            this.labExit.AutoSize = true;
            this.labExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labExit.Location = new System.Drawing.Point(527, 9);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(28, 28);
            this.labExit.TabIndex = 9;
            this.labExit.Text = "X";
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gym_management.Properties.Resources.FitnessCenter;
            this.pictureBox3.Location = new System.Drawing.Point(46, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gym_management.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(491, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_management.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(491, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 228);
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uidTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_DB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_DB_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uidTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labExit;
    }
}
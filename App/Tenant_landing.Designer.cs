﻿namespace HostelX
{
    partial class Tenant_landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenant_landing));
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_com = new System.Windows.Forms.Button();
            this.btn_app = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(853, 38);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(101, 41);
            this.btn_logout.TabIndex = 15;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome Tenant";
            // 
            // btn_com
            // 
            this.btn_com.BackColor = System.Drawing.SystemColors.Info;
            this.btn_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_com.Location = new System.Drawing.Point(591, 302);
            this.btn_com.Name = "btn_com";
            this.btn_com.Size = new System.Drawing.Size(138, 87);
            this.btn_com.TabIndex = 10;
            this.btn_com.Text = "Complains";
            this.btn_com.UseVisualStyleBackColor = false;
            this.btn_com.Click += new System.EventHandler(this.Btn_com_Click);
            // 
            // btn_app
            // 
            this.btn_app.BackColor = System.Drawing.SystemColors.Info;
            this.btn_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_app.Location = new System.Drawing.Point(245, 302);
            this.btn_app.Name = "btn_app";
            this.btn_app.Size = new System.Drawing.Size(138, 87);
            this.btn_app.TabIndex = 9;
            this.btn_app.Text = "Application";
            this.btn_app.UseVisualStyleBackColor = false;
            this.btn_app.Click += new System.EventHandler(this.Btn_app_Click);
            // 
            // Tenant_landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_com);
            this.Controls.Add(this.btn_app);
            this.Name = "Tenant_landing";
            this.Text = "Tenant_landing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tenant_landing_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_com;
        private System.Windows.Forms.Button btn_app;
    }
}
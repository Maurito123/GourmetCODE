﻿namespace proyecto.Presentacion
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = SystemColors.WindowText;
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.Name = "txtUsuario";
            // 
            // txtContrasena
            // 
            resources.ApplyResources(txtContrasena, "txtContrasena");
            txtContrasena.Name = "txtContrasena";
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2023_07_20_at_7_59_57_PM_removebg_preview;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
    }
}
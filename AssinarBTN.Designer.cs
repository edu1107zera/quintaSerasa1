﻿namespace pi_serasa_LinkeDev
{
    partial class AssinarBTN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssinarBTN));
            imgLogo = new PictureBox();
            panelDES = new WiLBiT.WiLBiTGradientPanel();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelC2 = new WiLBiT.WiLBiTGradientPanel();
            linkLabel1 = new LinkLabel();
            wilBitButton21 = new WiLBiT.WiLBiTButton2();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtUsuario_CR = new WiLBiT.WiLBiTTextBox();
            txtSenha_CR = new WiLBiT.WiLBiTTextBox();
            txtEmail_CR = new WiLBiT.WiLBiTTextBox();
            label3 = new Label();
            btnFechar = new WiLBiT.WiLBiTButton();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            panelDES.SuspendLayout();
            panelC2.SuspendLayout();
            SuspendLayout();
            // 
            // imgLogo
            // 
            imgLogo.Image = (Image)resources.GetObject("imgLogo.Image");
            imgLogo.Location = new Point(100, 370);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(162, 149);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 5;
            imgLogo.TabStop = false;
            imgLogo.Click += imgLogo_Click;
            // 
            // panelDES
            // 
            panelDES.BackColor = Color.FromArgb(18, 112, 254);
            panelDES.BackColor2 = Color.FromArgb(18, 112, 254);
            panelDES.BorderColor = Color.Black;
            panelDES.BorderRadius = 6;
            panelDES.BorderSize = 2;
            panelDES.Controls.Add(label7);
            panelDES.Controls.Add(label2);
            panelDES.Controls.Add(label1);
            panelDES.ForeColor = Color.Black;
            panelDES.Location = new Point(506, -164);
            panelDES.Name = "panelDES";
            panelDES.Size = new Size(442, 779);
            panelDES.TabIndex = 4;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(18, 112, 254);
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 494);
            label7.Name = "label7";
            label7.Size = new Size(329, 267);
            label7.TabIndex = 11;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(18, 112, 254);
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 47);
            label2.Name = "label2";
            label2.Size = new Size(423, 404);
            label2.TabIndex = 1;
            label2.Text = "PARA QUEM BUSCA EVOLUIR   E  TRABALHAR.\r\n\r\nNossos site foi criado com a intençao de ajudar \r\no ramo de T.I a encontrar um caminho para \r\nentender aonde trabalhar e saber por onde começar .\r\n\r\n\r\n\r\n";
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 10);
            label1.Name = "label1";
            label1.Size = new Size(149, 40);
            label1.TabIndex = 0;
            label1.Text = "Descriçao";
            // 
            // panelC2
            // 
            panelC2.BackColor = Color.FromArgb(18, 112, 254);
            panelC2.BackColor2 = Color.FromArgb(18, 112, 254);
            panelC2.BorderColor = Color.Black;
            panelC2.BorderRadius = 6;
            panelC2.BorderSize = 2;
            panelC2.Controls.Add(linkLabel1);
            panelC2.Controls.Add(wilBitButton21);
            panelC2.Controls.Add(label6);
            panelC2.Controls.Add(label5);
            panelC2.Controls.Add(label4);
            panelC2.Controls.Add(txtUsuario_CR);
            panelC2.Controls.Add(txtSenha_CR);
            panelC2.Controls.Add(txtEmail_CR);
            panelC2.Controls.Add(label3);
            panelC2.ForeColor = Color.White;
            panelC2.Location = new Point(-148, -154);
            panelC2.Name = "panelC2";
            panelC2.Size = new Size(609, 441);
            panelC2.TabIndex = 3;
            panelC2.Paint += panelC_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Lime;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(248, 330);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ja tenho uma conta.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // wilBitButton21
            // 
            wilBitButton21.BackColor = Color.DimGray;
            wilBitButton21.BackgroundColor = Color.DimGray;
            wilBitButton21.BorderColor = Color.Black;
            wilBitButton21.BorderRadius = 10;
            wilBitButton21.BorderSize = 2;
            wilBitButton21.FlatAppearance.BorderSize = 0;
            wilBitButton21.FlatStyle = FlatStyle.Flat;
            wilBitButton21.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            wilBitButton21.ForeColor = Color.White;
            wilBitButton21.Location = new Point(234, 276);
            wilBitButton21.Name = "wilBitButton21";
            wilBitButton21.Size = new Size(150, 40);
            wilBitButton21.TabIndex = 9;
            wilBitButton21.Text = "Criar";
            wilBitButton21.TextColor = Color.White;
            wilBitButton21.UseVisualStyleBackColor = false;
            wilBitButton21.Click += wilBitButton21_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 189);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 8;
            label6.Text = "Nome de usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 141);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 89);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtUsuario_CR
            // 
            txtUsuario_CR.BackColor = SystemColors.Window;
            txtUsuario_CR.BorderColor = Color.FromArgb(49, 57, 60);
            txtUsuario_CR.BorderFocusColor = SystemColors.Desktop;
            txtUsuario_CR.BorderRadius = 4;
            txtUsuario_CR.BorderSize = 2;
            txtUsuario_CR.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario_CR.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario_CR.Location = new Point(184, 208);
            txtUsuario_CR.Margin = new Padding(4);
            txtUsuario_CR.Multiline = false;
            txtUsuario_CR.Name = "txtUsuario_CR";
            txtUsuario_CR.Padding = new Padding(10, 7, 10, 7);
            txtUsuario_CR.PasswordChar = false;
            txtUsuario_CR.PlaceholderColor = Color.DarkGray;
            txtUsuario_CR.PlaceholderText = "";
            txtUsuario_CR.Size = new Size(250, 29);
            txtUsuario_CR.TabIndex = 5;
            txtUsuario_CR.Texts = "";
            txtUsuario_CR.UnderlinedStyle = false;
            // 
            // txtSenha_CR
            // 
            txtSenha_CR.BackColor = SystemColors.Window;
            txtSenha_CR.BorderColor = Color.FromArgb(49, 57, 60);
            txtSenha_CR.BorderFocusColor = SystemColors.Desktop;
            txtSenha_CR.BorderRadius = 4;
            txtSenha_CR.BorderSize = 2;
            txtSenha_CR.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha_CR.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha_CR.Location = new Point(184, 156);
            txtSenha_CR.Margin = new Padding(4);
            txtSenha_CR.Multiline = false;
            txtSenha_CR.Name = "txtSenha_CR";
            txtSenha_CR.Padding = new Padding(10, 7, 10, 7);
            txtSenha_CR.PasswordChar = false;
            txtSenha_CR.PlaceholderColor = Color.DarkGray;
            txtSenha_CR.PlaceholderText = "";
            txtSenha_CR.Size = new Size(250, 29);
            txtSenha_CR.TabIndex = 4;
            txtSenha_CR.Texts = "";
            txtSenha_CR.UnderlinedStyle = false;
            // 
            // txtEmail_CR
            // 
            txtEmail_CR.BackColor = SystemColors.Window;
            txtEmail_CR.BorderColor = Color.FromArgb(49, 57, 60);
            txtEmail_CR.BorderFocusColor = SystemColors.Desktop;
            txtEmail_CR.BorderRadius = 4;
            txtEmail_CR.BorderSize = 2;
            txtEmail_CR.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail_CR.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail_CR.Location = new Point(184, 108);
            txtEmail_CR.Margin = new Padding(4);
            txtEmail_CR.Multiline = false;
            txtEmail_CR.Name = "txtEmail_CR";
            txtEmail_CR.Padding = new Padding(10, 7, 10, 7);
            txtEmail_CR.PasswordChar = false;
            txtEmail_CR.PlaceholderColor = Color.DarkGray;
            txtEmail_CR.PlaceholderText = "";
            txtEmail_CR.Size = new Size(250, 29);
            txtEmail_CR.TabIndex = 3;
            txtEmail_CR.Texts = "";
            txtEmail_CR.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(248, 52);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 2;
            label3.Text = "Criar conta";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(72, 116, 245);
            btnFechar.BorderColor = Color.FromArgb(72, 116, 245);
            btnFechar.BorderRadius = 6;
            btnFechar.BorderSize = 0;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(318, 329);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(60, 40);
            btnFechar.TabIndex = 21;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // AssinarBTN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 57, 60);
            ClientSize = new Size(1215, 689);
            Controls.Add(btnFechar);
            Controls.Add(imgLogo);
            Controls.Add(panelDES);
            Controls.Add(panelC2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssinarBTN";
            Text = "AssinarBTN";
            Load += AssinarBTN_Load_1;
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            panelDES.ResumeLayout(false);
            panelDES.PerformLayout();
            panelC2.ResumeLayout(false);
            panelC2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgLogo;
        private WiLBiT.WiLBiTGradientPanel panelDES;
        private Label label7;
        private Label label2;
        private Label label1;
        private WiLBiT.WiLBiTGradientPanel panelC2;
        private LinkLabel linkLabel1;
        private WiLBiT.WiLBiTButton2 wilBitButton21;
        private Label label6;
        private Label label5;
        private Label label4;
        private WiLBiT.WiLBiTTextBox txtUsuario_CR;
        private WiLBiT.WiLBiTTextBox txtSenha_CR;
        private WiLBiT.WiLBiTTextBox txtEmail_CR;
        private Label label3;
        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private WiLBiT.WiLBiTButton2 wilBitButton23;
        private Label label8;
        private Label label9;
        private Label label10;
        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel2;
        private LinkLabel linkLabel2;
        private WiLBiT.WiLBiTButton2 wilBitButton24;
        private Label label11;
        private Label label12;
        private Label label13;
        private WiLBiT.WiLBiTTextBox wilBitTextBox1;
        private WiLBiT.WiLBiTTextBox wilBitTextBox2;
        private WiLBiT.WiLBiTTextBox wilBitTextBox3;
        private Label label14;
        private WiLBiT.WiLBiTButton btnFechar;
    }
}
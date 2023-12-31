﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_serasa_LinkeDev
{
    public partial class CriarC : Form
    {
        public CriarC()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Size = new Size(100, 15);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CriarC_Load(object sender, EventArgs e)
        {
            panelC.Location = new Point(ClientSize.Width - 1400, ClientSize.Height - 750);

            panelDES.Location = new Point(ClientSize.Width - 500, ClientSize.Height - 850);
            imgLogo.Location = new Point(ClientSize.Width - 960, ClientSize.Height - 110);
        }

        private void wilBitButton21_Click(object sender, EventArgs e)
        {
            string email = txtEmail_CR.Texts;
            string senha = txtSenha_CR.Texts;
            string nome = txtUsuario_CR.Texts;

            if (email == "" || senha == "" || nome == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.insereUsuario(email, senha, false);
            usuario.insereCliente(nome);

            Inicial i = new Inicial();
            i.Show();
        }

        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

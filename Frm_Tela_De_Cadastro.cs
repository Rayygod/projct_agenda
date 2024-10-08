using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
{
    public partial class Frm_Tela_De_Cadastro : Form
    {
        public Frm_Tela_De_Cadastro()
        {
            InitializeComponent();
            botao_cadastrar_final.Enabled = false;
        }

        private void abilitar_botao_cadastro()
        {
            bool erro = false;

            if (textBox_nome.Text == "")
            {
                erro = true;
                cadeado_trancado.Visible = true;
                cadeado_destrancado.Visible = false;
            }

            if (textBox_usuario.Text == "")
            {
                erro = true;
                cadeado_trancado.Visible = true;
                cadeado_destrancado.Visible = false;
            }

            if (textBox_telefone.Text.Length < 11)
            {
                erro = true;
                cadeado_trancado.Visible = true;
                cadeado_destrancado.Visible = false;
            }

            if (textBox_senha.Text.Length < 8)
            {
                erro = true;
                cadeado_trancado.Visible = true;
                cadeado_destrancado.Visible = false;
            }

            if (erro == false)
            {
                botao_cadastrar_final.Enabled = true;
                cadeado_trancado.Visible = false;
                cadeado_destrancado.Visible = true;
            }

            //ou

            //textBox_nome.Text != "" && textBox_usuario.Text != "" && textBox_telefone.Text.Length >= 11 && textBox_senha.Text.Length >= 8)
            //{
            //    botao_cadastrar_final.Enabled = true;
            //}

            //else
            //{
            //    botao_cadastrar_final.Enabled = false;
            //}
        }

        private void botao_cadastrar_final_Click(object sender, EventArgs e)
        {
            abilitar_botao_cadastro();
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {
            abilitar_botao_cadastro();
        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {
            abilitar_botao_cadastro();
        }

        private void textBox_telefone_TextChanged(object sender, EventArgs e)
        {
            abilitar_botao_cadastro();
        }

        private void textBox_senha_TextChanged(object sender, EventArgs e)
        {
            abilitar_botao_cadastro();
        }

        private void botao_cancelar_Click(object sender, EventArgs e)
        {
            textBox_nome.Clear();
            textBox_usuario.Clear();
            textBox_telefone.Clear();
            textBox_senha.Clear();
            this.Visible = false;
        }
    }
} 


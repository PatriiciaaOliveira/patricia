using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patricia
{
    public partial class frm_CadastreSe : Form
    {
        private GerenciadorUsuarios gerenciadorUsuarios;

        public frm_CadastreSe()
        {
            InitializeComponent();
            gerenciadorUsuarios = new GerenciadorUsuarios();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
       
            string email = txtEmail.Text;
            string senha = txtSenha1.Text;
            string confSenha = txtConfSenha.Text;
            string nome = txtNome.Text;




            // Verificar se todos os campos foram preenchidos
            if (!(!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha) && !string.IsNullOrWhiteSpace(confSenha)))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se a senha e a confirmação de senha coincidem
            if (senha != confSenha)
            {
                MessageBox.Show("A senha e a confirmação de senha não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chamar o método para adicionar o usuário
            try
            {
                gerenciadorUsuarios.AdicionarUsuario(nome, email, senha);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Fechar o formulário de cadastro e retornar ao formulário de menu
                frm_Menu menu = new frm_Menu();
                menu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void LimparCampos()
        {
            // Limpar todos os campos de entrada
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha1.Text = "";
            txtConfSenha.Text = "";
        }
    }
}

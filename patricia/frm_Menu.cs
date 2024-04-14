using System.Windows.Forms;
using System;
using patricia;


namespace patricia
{
    internal partial class frm_Menu : Form
    {
    
    private string emailUsuario;
    private string senhaUsuario;
    

        public frm_Menu(string nome, string email, string senha)
    {
        InitializeComponent();
        
        emailUsuario = email;
        senhaUsuario = senha;
        AtualizarDadosUsuario();
    }

        private void AtualizarDadosUsuario()
        {
            throw new NotImplementedException();
        }

        private void btnSairr_Click(object sender, EventArgs e) //Aqui Ok
        {
            // Fechar o aplicativo
            Application.Exit();
        }

        private void btnCadastre_Click(object sender, EventArgs e) //Aqui OK
        {
            // formulário de cadastro (frm_CadastreSe)
            frm_CadastreSe formCadastreSe = new frm_CadastreSe();
            formCadastreSe.Show();
            this.Hide(); // Oculta o formulário de menu
        }
        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        public void DefinirLogin(string login)
        {
            txtLogin1.Text = login;

        }
        public void DefinirSenha(string senha)
        {
            txtsenh.Text = senha;

        }


        private void btnEntra_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            bool TemAcesso = controle.Acessar(txtLogin1.Text, txtsenh.Text);

            if (TemAcesso)
            {
                MessageBox.Show("Login não encontrado, verofique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Reserva formReserva = new frm_Reserva();

                formReserva.Show();

                this.Hide();
            }


        }

        private void AtualizarDadosUsuario1()
        {
            
            lblLogin.Text = emailUsuario;
            txtLogin1.Text = emailUsuario; // Preencher automaticamente o campo de login
            txtsenh.Text = senhaUsuario; // Preencher automaticamente o campo de senha
        }
    }
}

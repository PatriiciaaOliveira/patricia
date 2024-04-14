using patricia;
using System.Windows.Forms;
using System;

namespace patricia
{
    partial class frm_Menu : Form
    {
        private GerenciadorUsuarios gerenciadorUsuarios;
        private TextBox txtSenha;
        private TextBox txtNome1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha1;
        private TextBox txtConfSenha;
        private Button btnCadastreSe;
        private Button btnSair;
        private Button btnEntrar;

        public frm_Menu()
        {
            InitializeComponent();
            gerenciadorUsuarios = new GerenciadorUsuarios();
        }

        public frm_Menu(TextBox txtSenha1)
        {
            this.txtSenha1 = txtSenha1;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.btnCadastreSe = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblColegioViverSempre = new System.Windows.Forms.Label();
            this.txtsenh = new System.Windows.Forms.TextBox();
            this.txtLogin1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastre = new System.Windows.Forms.Button();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnEntra = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(0, 0);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 0;
            // 
            // lblColegioViverSempre
            // 
            this.lblColegioViverSempre.AutoSize = true;
            this.lblColegioViverSempre.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColegioViverSempre.Location = new System.Drawing.Point(145, 56);
            this.lblColegioViverSempre.Name = "lblColegioViverSempre";
            this.lblColegioViverSempre.Size = new System.Drawing.Size(566, 77);
            this.lblColegioViverSempre.TabIndex = 27;
            this.lblColegioViverSempre.Text = "Colégio Viver Sempre";
            // 
            // txtsenh
            // 
            this.txtsenh.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenh.Location = new System.Drawing.Point(572, 231);
            this.txtsenh.Name = "txtsenh";
            this.txtsenh.PasswordChar = '*';
            this.txtsenh.Size = new System.Drawing.Size(168, 26);
            this.txtsenh.TabIndex = 26;
            // 
            // txtLogin1
            // 
            this.txtLogin1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin1.Location = new System.Drawing.Point(572, 176);
            this.txtLogin1.Name = "txtLogin1";
            this.txtLogin1.Size = new System.Drawing.Size(168, 26);
            this.txtLogin1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 219);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastre
            // 
            this.btnCadastre.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastre.Location = new System.Drawing.Point(530, 361);
            this.btnCadastre.Name = "btnCadastre";
            this.btnCadastre.Size = new System.Drawing.Size(118, 34);
            this.btnCadastre.TabIndex = 23;
            this.btnCadastre.Text = "Cadastre-se";
            this.btnCadastre.UseVisualStyleBackColor = true;
            this.btnCadastre.Click += new System.EventHandler(this.btnCadastre_Click);
            // 
            // btnSair1
            // 
            this.btnSair1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair1.Location = new System.Drawing.Point(622, 294);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(89, 31);
            this.btnSair1.TabIndex = 22;
            this.btnSair1.Text = "Sair";
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSairr_Click);
            // 
            // btnEntra
            // 
            this.btnEntra.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntra.Location = new System.Drawing.Point(486, 294);
            this.btnEntra.Name = "btnEntra";
            this.btnEntra.Size = new System.Drawing.Size(89, 31);
            this.btnEntra.TabIndex = 21;
            this.btnEntra.Text = "Entrar";
            this.btnEntra.UseVisualStyleBackColor = true;
            this.btnEntra.Click += new System.EventHandler(this.btnEntra_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(458, 227);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(68, 24);
            this.lblSenha.TabIndex = 20;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(458, 176);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(64, 24);
            this.lblLogin.TabIndex = 19;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(163, 244);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 18;
            // 
            // frm_Menu
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblColegioViverSempre);
            this.Controls.Add(this.txtsenh);
            this.Controls.Add(this.txtLogin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastre);
            this.Controls.Add(this.btnSair1);
            this.Controls.Add(this.btnEntra);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCadastreSe_Click_1(object sender, EventArgs e)
        {
            // Recupera os valores dos campos de entrada
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha1.Text;
            string confirmacaoSenha = txtConfSenha.Text;

            // Verifica se a senha e a confirmação de senha coincidem
            if (senha != confirmacaoSenha)
            {
                MessageBox.Show("A senha e a confirmação de senha não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmacaoSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chama o método para adicionar o usuário
            try
            {
                // Corrigido: Chamando o método AdicionarUsuario() sem atribuir seu resultado a uma variável
                gerenciadorUsuarios.AdicionarUsuario(nome, email, senha);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private Label lblColegioViverSempre;
        private TextBox txtsenh;
        private TextBox txtLogin1;
        private PictureBox pictureBox1;
        private Button btnCadastre;
        private Button btnSair1;
        private Button btnEntra;
        private Label lblSenha;
        private Label lblLogin;
        private TextBox txtLogin;
    }
}
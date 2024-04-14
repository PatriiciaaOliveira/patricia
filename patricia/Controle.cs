using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patricia
{
    internal class Controle
    {
        private string mensagem;
        private bool temAcesso;

        public string Mensagem => mensagem;
        public bool TemAcesso => temAcesso;

        public Controle() { }

        public bool Acessar(string login, string senha)
        {
            // Aqui você pode implementar a lógica para verificar as credenciais de login
            // Por exemplo, comparar com valores fixos
            const string usuarioCorreto = "usuario";
            const string senhaCorreta = "senha";

            // Verificar se o login e a senha são válidos
            if (login == usuarioCorreto && senha == senhaCorreta)
            {
                mensagem = "Login realizado com sucesso!";
                temAcesso = true;
                return true;
            }
            else
            {
                mensagem = "Login ou senha incorretos!";
                temAcesso = false;
                return false;
            }
        }

        public void LimparMensagem()
        {
            mensagem = string.Empty;
            temAcesso = false;
        }

        public void RealizarOperacao(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        internal bool Acessar(object text1, object text2)
        {
            throw new NotImplementedException();
        }

       
    }
}



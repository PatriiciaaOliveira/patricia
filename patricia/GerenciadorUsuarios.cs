using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patricia
{
    internal class GerenciadorUsuarios
    {
        // Armazenar os usuários em um dicionário para facilitar a busca
        private Dictionary<string, string> usuarios;

        public GerenciadorUsuarios()
        {
            // Inicializar o dicionário de usuários
            usuarios = new Dictionary<string, string>();
        }

        internal void AdicionarUsuario(string nome, string email, string senha)
        {
            // Verificar se o login já existe
            if (usuarios.ContainsKey(email))
            {
                throw new ArgumentException("Usuário já existe.");
            }

            // Adicionar usuário ao dicionário
            usuarios.Add(email, senha);
        }

        internal void AdicionarUsuario(string email, string senha, string confSenha, string nome)
        {
            throw new NotImplementedException();
        }

        internal bool AutenticarUsuario(string email, string senha)
        {
            // Verificar se o usuário existe e a senha está correta
            if (usuarios.ContainsKey(email) && usuarios[email] == senha)
            {
                return true;
            }

            return false;
        }
    }
}
 
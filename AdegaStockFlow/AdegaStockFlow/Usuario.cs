using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdegaStockFlow
{
    public class Usuario
    {
        //Lista para seguir referencia da original
        List<Usuario> listusuario = new List<Usuario>();

        private int id;
        private string nome;
        private string senha;
        private int nvacesso;
        private string cargo;

        public Usuario()//Construtor
        {
            this.id = -1;
            this.nome = null;
            this.senha = null;
            this.nvacesso = -1;
            this.cargo = null;
        }

        //Métodos Get(s).
        public int getId() { return id; }
        public string getNome() { return nome; }
        public string getSenha() { return senha; }
        public int getNvacesso() { return nvacesso; }
        public string getCargo() { return cargo; }

        //Métodos Set(s).
        public void setId(int id) { this.id = id; }
        public void setNome(string nome) { this.nome = nome; ; }
        public void setSenha(string senha) { this.senha = senha; }
        public void setNvacesso(int nvacesso) { this.nvacesso = nvacesso; }
        public void setCargo(string cargo) { this.cargo = cargo; }

        public Usuario CadastrarUsuario(int id, string nome, string senha, int nvacesso)
        {
            Usuario usuario = new Usuario();
            
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.nvacesso = nvacesso;
            
            if(nvacesso == 2)
            {
                this.cargo = "Gerente";
            }
            else
            {
                this.cargo = "Funcionario";
            }

                return this;
        }
        public Usuario DeletarUsuario(List<Usuario> listusuario, int id)
        {
            this.listusuario = listusuario;

            Usuario resultado = listusuario.FirstOrDefault(p => p.id == id);

            if (resultado != null)
            {
                listusuario.Remove(resultado);
            }

            return resultado;

        }
    }
}

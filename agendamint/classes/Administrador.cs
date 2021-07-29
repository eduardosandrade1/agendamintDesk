using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendamint.classes
{
    public class Administrador
    {
        public int Login { get; set; }
        public string Senha { get; set; }

        public Administrador(int login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public Administrador()
        {
        }

        public bool doLogin(string login, string senha)
        {
            string querySql = "select * from administrador where login = '" + login +"' and senha = md5('"+ senha+"')";
            var banco = Banco.Abrir();
            banco.CommandText = querySql;

            var dadosRecuperados = banco.ExecuteReader();

            if (dadosRecuperados.Read())
            {
                return true;
            }
            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace agendamint.classes
{
    public class Banco
    {
        /// <summary>
        /// Abre a conexao para um banco de dados MYSQL
        /// </summary>
        /// <returns>[object] comandos SQL</returns>
        public static MySqlCommand Abrir()
        {
            MySqlCommand comandosSql = new MySqlCommand();
            string stringDeConexao = @"server=localhost;database=estacionamint;user=root;password=usbw; port=3306;SslMode=none;";//  @ força para interpretar como string
            // conectando
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            // tratativa de exceção
            try
            {
                if (conexao.State != ConnectionState.Open)
                {
                    conexao.Open();
                    comandosSql.Connection = conexao;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return comandosSql;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendamint.classes
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Responsavel { get; set; }
        public string RazaoSocial { get; set; }
        public string ChavePix { get; set; }
        public string TipoPix { get; set; }
        public string BancoTxt { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string CodEmpresa { get; set; }

        public Empresa(string responsavel, string razaoSocial, string chavePix, string tipoPix, string banco, string cnpj, string email, string codEmpresa)
        {
            Responsavel = responsavel;
            RazaoSocial = razaoSocial;
            ChavePix = chavePix;
            TipoPix = tipoPix;
            BancoTxt = banco;
            Cnpj = cnpj;
            Email = email;
            CodEmpresa = codEmpresa;
        }

        public Empresa()
        {
        }

        public void inserir()
        {
            var banco = Banco.Abrir();

            banco.CommandText = "INSERT empresa VALUES (null, '"+Responsavel+"','"+RazaoSocial+"','"+ChavePix+"','"+TipoPix+"','"+BancoTxt+"','"+Cnpj+"', default,default,default,default,'"+Email+"','"+ AlfaRandom.alfanumericoAleatorio(4)+ "');";
            banco.ExecuteNonQuery();

            banco.CommandText = "select @@identity"; // retorna o id inserido


            Id = Convert.ToInt32(banco.ExecuteScalar());// ultimo id na propriedade da classe
            var nomeLogin = Responsavel.Split(' ');
            banco.CommandText = "INSERT funcionarios VALUES(null, "+Id+", 2, '"+RazaoSocial+"', "+Cnpj+", '"+nomeLogin[0]+".master', md5('123400'), '"+Email+"')";
            banco.ExecuteNonQuery();
        }
    }

}

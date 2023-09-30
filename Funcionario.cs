using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Crud
{
    internal class Funcionario
    {
        private int id;
        private  string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf;  }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public bool cadastrarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(Conexao.bancoServidor);
                MySqlConexaoBanco.Open();
                //inserir na tabela 
                string insert = $" insert into funcionarios(nome,email,cpf,endereco) values('{Nome}','{Email}','{Cpf}','{Endereco}')";
                //enviar comando para o banco de dados
                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;
                //Executar comando 
                comandoSql.ExecuteNonQuery();
                return true;


            }catch (Exception ex)
            {
            MessageBox.Show("Erro no banco de dados" +    ex.Message);
                return false;
            }
        }
    }
}

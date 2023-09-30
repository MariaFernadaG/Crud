using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Crud
{
    static class Conexao
    {

        //4 variaveis p passar as infirmaçoes do banco de dado
       private const string servidor = "localhost";
       private const string bancoDados = "dbfuncionarios";
       private const string usuario = "root";
       private const string senha = "Fatec1818";

        //declarando variavel conexaoBanco p conectar o banco de dados 
        static public string bancoServidor = $"servidor{servidor}; user id={usuario}; databse={bancoDados};password={senha}";

    }
}

using MySql.Data.MySqlClient;
using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller
{
    internal class UserController
    {
        public bool AddUser(string nome, string usuario, string telefone, string senha)
        {
            // criando a conexão utilizando a classe ConexaoDB
            MySqlConnection conexao = ConexãoDB.criador_conexao();
            string sql = "INSERT INTO tb_usuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

            //Abrindo conexão
            conexao.Open();

            //Criando o comando para que o SQL execute os parametros do INSERT INTO e tambem a conexao
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            // troca de dados de @ pelos informações que o usuario cadastrou

            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@senha", senha);

            int linhas_afetadas = comando.ExecuteNonQuery();

            conexao.Close();

            if (linhas_afetadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

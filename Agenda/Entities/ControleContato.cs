using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agenda.Entities
{
    class ControleContato
    {
        Conexao conect = new Conexao();
        public string cadastrar(Contato cont)
        {
            try
            {
                string comand = $"INSERT INTO tbcontato(nome, telefone, celular, email)" +
                    $"VALUES('{cont.Nome}', '{cont.Telefone}', '{cont.Celular}', '{cont.Email}')";
                Console.WriteLine(comand);
                MySqlCommand cmd = new MySqlCommand(comand,conect.conexao);

                conect.Conectar();
                cmd.ExecuteNonQuery();
                conect.Desconectar();
                return("Cadastro realizado com sucesso");
            }
            catch(MySqlException erro) 
            {
                return(erro.ToString());
            }
        }
        public string alterar(Contato cont)
        {
            string comand = $"UPDATE tbcontato set nome='{cont.Nome}', telefone='{cont.Telefone}', celular='{cont.Celular}', email='{cont.Email}' WHERE codcontato = {cont.Codcontato};";
            MySqlCommand cmd = new MySqlCommand(comand, conect.conexao);

            conect.Conectar();
            cmd.ExecuteNonQuery();
            conect.Desconectar();
            return ("Alterado com sucesso");
        }
        public string excluir(Contato cont)
        {
            try
            {
                string sql = "delete from tbcontato where codcontato = " + cont.Codcontato + ";";

                MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);

                conect.Conectar();
                cmd.ExecuteNonQuery();
                conect.Desconectar();
                return ("Dados excluidos com Sucesso");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }
        public Contato buscar(int cod)
        {
            Contato cont = new Contato();
            string sql = $"select nome, telefone, celular, email from tbcontatos where codcontato = {cont.Codcontato};";

            MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);

            try
            {
                conect.Conectar();
                MySqlDataReader readerDate = cmd.ExecuteReader();
                if (!readerDate.HasRows)
                {
                    return null;
                }
                else
                {
                    readerDate.Read();
                    cont.Nome = readerDate["nome"].ToString();
                    cont.Telefone = readerDate["telefone"].ToString();
                    cont.Celular = readerDate["celular"].ToString();
                    cont.Email = readerDate["email"].ToString();
                    readerDate.Close();

                    return cont;

                }
               
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }


        }
        public DataTable ConsultaCodigo(int cod)
        {
            /*Cria uma string com comandos SQL*/
            string sql = $"SELECT codcontato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where codcontato = {cod};";
            /*Executa o comando SQL e guarda a informação na váriavel*/
            MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);
            /*Conecta no banco de Dados*/
            conect.Conectar();

            /*Transforma o select já executado para Dados*/
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            /*Cria uma tabela de dados*/
            DataTable tabela = new DataTable();
            /*Adapter preenche a tabla*/
            adapter.Fill(tabela);
            /*Deconecta do BD*/
            conect.Desconectar();
            /*retorna a tabela*/
            return tabela;        
        }
        public DataTable ConsultaNome(string value)
        {
            /*Cria uma string com comandos SQL*/
            string sql = $"SELECT codcontato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where nome like '%{value}%';";
            /*Executa o comando SQL e guarda a informação na váriavel*/
            MySqlCommand cmd = new MySqlCommand(sql ,conect.conexao);
            /*Conecta no banco de Dados*/
            conect.Conectar();
            
            /*Cria uma tabela de dados*/
            DataTable table = new DataTable();            
            /*Transforma o select já executado para Dados*/
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            /*Adapter preenche a tabla*/
            adapter.Fill(table);
            /*Deconecta do BD*/
            conect.Desconectar();
            /*retorna a tabela*/
            return table;
        }
        public DataTable ConsultaTelefone(string value)
        {
            /*Cria uma string com comandos SQL*/
            string sql = $"SELECT codcontato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where telefone like '%{value}%' ;";
            /*Executa o comando SQL e guarda a informação na váriavel*/
            MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);
            /*Conecta no banco de Dados*/
            conect.Conectar();

            /*Transforma o select já executado para Dados*/
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            /*Cria uma tabela de dados*/
            DataTable table = new DataTable();
            /*Adapter preenche a tabla*/
            adapter.Fill(table);
            /*Deconecta do BD*/
            conect.Desconectar();
            /*retorna a tabela*/
            return table;
        }
        public DataTable ConsultaCelular(string value)
        {
            /*Cria uma string com comandos SQL*/
            string sql = $"SELECT codContato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where celular like '%{value}%' ;";
            /*Executa o comando SQL e guarda a informação na váriavel*/
            MySqlCommand cmd = new MySqlCommand (sql ,conect.conexao);
            /*Conecta no banco de Dados*/
            conect.Conectar();

            /*Transforma o select já executado para Dados*/
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            /*Cria uma tabela de dados*/
            DataTable table = new DataTable();
            /*Adapter preenche a tabla*/
            adapter.Fill(table);
            /*Deconecta do BD*/
            conect.Desconectar();
            /*retorna a tabela*/
            return table;
        }
        public DataTable ConsultaEmail(string value)
            {
            /*Cria uma string com comandos SQL*/
            string sql = $"SELECT codContato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where email like '%{value}%' ;";
            /*Executa o comando SQL e guarda a informação na váriavel*/
            MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);
            /*Conecta no banco de Dados*/
            conect.Conectar();

            /*Transforma o select já executado para Dados*/
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            /*Cria uma tabela de dados*/
            DataTable table = new DataTable();
            /*Adapter preenche a tabla*/
            adapter.Fill(table);
            /*Deconecta do BD*/
            conect.Desconectar();
            /*retorna a tabela*/
            return table;
            }
        public DataTable ListarTodos()
            {
            /*Cria uma string com comandos SQL*/
            string sql = $"SELECT codContato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato;";
            /*Executa o comando SQL e guarda a informação na váriavel*/
            MySqlCommand cmd = new MySqlCommand(sql, conect.conexao);
            /*Conecta no banco de Dados*/
            conect.Conectar();

            /*Transforma o select já executado para Dados*/
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            /*Cria uma tabela de dados*/
            DataTable table = new DataTable();
            /*Adapter preenche a tabla*/
            adapter.Fill(table);
            /*Deconecta do BD*/
            conect.Desconectar();
            /*retorna a tabela*/
            return table;
            }
        }
}

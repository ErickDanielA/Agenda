using System;
using MySql.Data.MySqlClient;
using Agenda.Entities;
using System.Data;

namespace Agenda.Entities
    {
    internal class Login
        {
        Conexao c = new Conexao();

        public bool Logar(string l, string s)
            {
            try
                {
                string sql = "select login , senha from tbllogin where login like '" + l + "' and senha like '" + s + "' ;";
                MySqlCommand cmd = new MySqlCommand(sql, c.conexao);
                c.Conectar();
                MySqlDataReader objDados = cmd.ExecuteReader();
                // leitura no banco
                if (!objDados.HasRows)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }

            catch (MySqlException e)
                {
                throw (e);
                }

            finally
                {
                c.Desconectar();
                }
            }
        }
    }

                
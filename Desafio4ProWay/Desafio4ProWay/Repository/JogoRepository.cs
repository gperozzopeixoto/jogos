using Desafio4ProWay.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desafio4ProWay.Repository
{
    public class JogoRepository : BaseRepository
    {
        public void CadastrarNovoJogo(JogoBE jogo)
        {
            SqlConnection connection = ObterConexao();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO JOGO (PLACAR) VALUES (@PLACAR)");
                command.Parameters.AddWithValue("@PLACAR", jogo.Placar);
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.ToUpper().Contains("UQ"))
                {
                    throw new Exception("Jogo já cadastrado");
                }
            }
            finally
            {
                connection.Dispose();
            }
        }

        public List<JogoBE> ObterJogosCadastrados()
        {
            SqlConnection connection = ObterConexao();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM JOGO")
                {
                    Connection = connection
                };
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<JogoBE> jogos = new List<JogoBE>();

                while (reader.Read())
                {
                    jogos.Add(new JogoBE()
                    {
                        Codigo = (int)reader["CODIGO"],
                        Placar = (int)reader["PLACAR"],
                    });

                }
                connection.Dispose();
                return jogos;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class PersonalScoreRepository
    {
        public int InsertPersonalScore(PersonalScore ps)
        {
            int result;
            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                string commandText = string.Format("INSERT INTO Personal_Scores VALUES( {0}, '{1}', {2}, '{3}', {4})",ps.Score, ps.DateAndTime, ps.NumberOfMoves, ps.TimePlayed, ps.PL_ID);
                SqlCommand com = new SqlCommand(commandText, con);

                con.Open();
                result = com.ExecuteNonQuery();
            }
            return result;
        }

        public List<PersonalScore> GetAllPersonalScores(int id)
        {
            List<PersonalScore> ps = new List<PersonalScore>();

            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = string.Format("SELECT * FROM Personal_Scores" +
                    " WHERE PL_ID = {0} ORDER BY Score DESC", id);

                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    PersonalScore ps1 = new PersonalScore();
                    ps1.PersonalScoreID = dr.GetInt32(0);
                    ps1.Score = dr.GetInt32(1);
                    ps1.DateAndTime = dr.GetDateTime(2);
                    ps1.NumberOfMoves = dr.GetInt32(3);
                    ps1.TimePlayed = dr.GetString(4);
                    ps.Add(ps1);
                }


                return ps;
            }
        }

        public List<PersonalScore> GetAllScores()
        {
            List<PersonalScore> ps = new List<PersonalScore>();

            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = string.Format("SELECT * FROM Personal_Scores ORDER BY Score DESC");

                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    PersonalScore ps1 = new PersonalScore();
                    ps1.PersonalScoreID = dr.GetInt32(0);
                    ps1.Score = dr.GetInt32(1);
                    ps1.DateAndTime = dr.GetDateTime(2);
                    ps1.NumberOfMoves = dr.GetInt32(3);
                    ps1.TimePlayed = dr.GetString(4);
                    ps.Add(ps1);
                }


                return ps;
            }
        }

        public List<JoinTopPlayers> GetTopPlayers()
        {
            List<JoinTopPlayers> jps = new List<JoinTopPlayers>();

            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = string.Format("SELECT Players.IGN, Personal_Scores.Score, Personal_Scores.DateAndTime, Personal_Scores.NumberOfMoves, Personal_Scores.TimePlayed " +
                    " FROM Players, Personal_Scores WHERE Players.PlayerID = Personal_Scores.PL_ID ORDER BY Score DESC");

                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    JoinTopPlayers ps1 = new JoinTopPlayers();
                    ps1.IGN = dr.GetString(0);
                    ps1.Score = dr.GetInt32(1);
                    ps1.DateAndTime = dr.GetDateTime(2);
                    ps1.NumberOfMoves = dr.GetInt32(3);
                    ps1.TimePlayed = dr.GetString(4);
                    jps.Add(ps1);
                }

                return jps;
            }
        }

    }
}

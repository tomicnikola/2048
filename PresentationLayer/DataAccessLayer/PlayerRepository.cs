using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class PlayerRepository
    {
        public List<Player> GetAllPlayers()
        {
            List<Player> p = new List<Player>();

            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT * FROM Players";

                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    Player pl = new Player();
                    pl.PlayerID = dr.GetInt32(0);
                    pl.Username = dr.GetString(1);
                    pl.Password = dr.GetString(2);
                    pl.InGameName = dr.GetString(3);

                    p.Add(pl);
                }


                return p;
            }
        }

        public int InsertPlayer(Player p)
        {
            int result;
            using (SqlConnection con = new SqlConnection(Constants.connString))
            {
                string commandText = string.Format("INSERT INTO Players VALUES( '{0}', '{1}', '{2}')", p.Username, p.Password, p.InGameName);
                SqlCommand com = new SqlCommand(commandText, con);
                con.Open();
                result = com.ExecuteNonQuery();
            }
            return result;
        }
    }
}

using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class BLayer
    {
        private readonly PlayerRepository pr;
        private static Player p = new Player();
        private readonly PersonalScoreRepository psr;
        private static Achievement ach;
        private AchievementsRepository ar;
        public BLayer()
        {
            pr = new PlayerRepository();
            psr = new PersonalScoreRepository();
            ar = new AchievementsRepository();
        }

        public bool PlayerLogIn(string username,string password)
        {
            for(int i = 0; i < pr.GetAllPlayers().Count; i++)
            {
                if (pr.GetAllPlayers()[i].Username.Equals(username) && pr.GetAllPlayers()[i].Password.Equals(password))
                {
                    p.PlayerID = pr.GetAllPlayers()[i].PlayerID;
                    p.Username = pr.GetAllPlayers()[i].Username;
                    p.Password = pr.GetAllPlayers()[i].Password;
                    p.InGameName = pr.GetAllPlayers()[i].InGameName;
                    List<Achievement> listAchar=ar.GetAchievements(p.PlayerID);
                    if (listAchar.Count==0)
                    {
                    Achievement a = new Achievement();
                    a.BetterThanAverageMoves = 0;
                    a.BetterThanAverageTime =0;
                    a.CompletedGame = 0;
                    a.PA_ID = p.PlayerID;
                    ar.InsertAchievement(a);
                        ach = a;
                    }
                    else
                    {
                        ach = listAchar[0];
                    }
                    return true;
                }
            }
            return false;
        }

        public List<Player> GetPlayerList() 
        {
            return pr.GetAllPlayers();
        }

        public List<JoinTopPlayers> GetTopPlayers()
        {
            return psr.GetTopPlayers();
        }

        public List<PersonalScore> getPlayerPersonalScores()
        {
            return psr.GetAllPersonalScores(p.PlayerID);
        }
  
        public bool insertPlayerScore(PersonalScore ps)
        {
            if (psr.InsertPersonalScore(ps) > 0)
                return true;
            return false;

        }
        public bool InsertNewPlayer(Player pl)
        {
            if (pr.InsertPlayer(pl) > 0)
            {
                
                return true;
            }
                
            return false;
        }

        public void insertAchievement()
        {
            if (ar.UpdateAchievement(ach,p.PlayerID) > 0)
            {}
        }

        public Player getPlayer()
        {
            return p;
        }
        public Achievement getAchievement()
        {
            return ach;
        }
    }
}

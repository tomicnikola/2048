using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class JoinTopPlayers
    {
        public string IGN { get; set; }
        public int Score { get; set; }
        public DateTime DateAndTime { get; set; }
        public int NumberOfMoves { get; set; }
        public string TimePlayed { get; set; }

        public String toString()
        {
            return " " + IGN + "\t" + Score + "\t" + DateAndTime + "\t" + NumberOfMoves + "\t" + TimePlayed;
        }
    }
}

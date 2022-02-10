using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class PersonalScore
    {
        public int PersonalScoreID { get; set; }
        public int Score { get; set; }
        public DateTime DateAndTime { get; set; }
        public int NumberOfMoves { get; set; }
        public string TimePlayed { get; set; }
        public int PL_ID { get; set; }


        public String toString()
        {
            return "\t" + Score + "\t" + DateAndTime + "\t" + NumberOfMoves + "   \t" + TimePlayed;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Achievement
    {
        public int AchievementID { get; set; }
        public int CompletedGame { get; set; }
        public int BetterThanAverageMoves { get; set; }
        public int BetterThanAverageTime { get; set; }
        public int PA_ID { get; set; }
    }
}

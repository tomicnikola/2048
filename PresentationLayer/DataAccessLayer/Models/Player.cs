using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string InGameName { get; set; }
    }
}

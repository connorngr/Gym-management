using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_management
{
    public class DBString
    {
        public string dB = 
            @"Data Source=CONNOR-PC;Initial Catalog=GymDB;Integrated Security=True";

        public string getDB()
        {
            return dB;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF_Card_Creation_utility
{
    class Player
    {
        string surname { get; set; }
        string givennames { get; set; }
        Team team { get; set; }
        private bool skill;
        bool isskill
        {
            get { return skill; }
            set { skill = value; }
        }
        bool hasRush { get; set; }
        bool hasRec { get; set; }

        bool isQB { get; set; }

        string[] rush_column = new string[12];

        public string getrush_column(int index)
        {
            return rush_column[index];
        }

        public void setrush_column(int index, string value)
        {
            rush_column[index] = value;
        }


    }
}

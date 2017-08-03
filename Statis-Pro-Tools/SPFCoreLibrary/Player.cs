using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPFCoreLibrary
{
    public class Player
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }

        Image OLineCard { get; set; }
        Image SkillCard { get; set; }
        Image QBCard { get; set; }
        Image KickerCard { get; set; }

        public bool canPass { get; set; }
        public bool canRush { get; set; }
        public bool canRecieve { get; set; }
        public bool isOLine { get; set; }
        public bool isDline { get; set;}
        public bool canTE { get; set; }

        public string[,] rushVal = new string[3,12];
        public int[,] passVal = new int[3,12];

        public int comp { get; set; }
        public int longComp { get; set; }
        public int quickComp { get; set; }

        public string rushEndurance { get; set; }
        public string passEndurance { get; set; }
        public string QBEndurance { get; set; }

        public int tackle { get; set; }
        public int passRush { get; set; }
        public int runBlock { get; set; }
        public int passBlock { get; set; }





    }
}

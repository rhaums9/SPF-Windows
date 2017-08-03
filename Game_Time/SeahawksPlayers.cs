using SPFCoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Time
{
    class SeahawksPlayers
    {

        public static Player Andy_Heck = new Player { name = "Andy Heck", runBlock = 2, passBlock = 2, canPass = false, canRecieve = false, canRush = false, canTE = false, isDline = false, isOLine = true };
        public static Player Bill_Hitchcock = new Player { name = "Bill Hitchcock", runBlock = 1, passBlock = 1, canPass = false, canRecieve = false, canRush = false, canTE = false, isDline = false, isOLine = true };
        public static Player Bryan_Millard = new Player { name = "Bryan Millard", runBlock = 2, passBlock = 2, canPass = false, canRecieve = false, canRush = false, canTE = false, isDline = false, isOLine = true };
        public static Player Curt_Stinger = new Player { name = "Curt Stinger", runBlock = 0, passBlock = 1, canPass = false, canRecieve = false, canRush = false, canTE = false, isDline = false, isOLine = true };
        public static Player Darrick_Brillz = new Player { name = "Darrick Brillz", runBlock = 1, passBlock = 0, canPass = false, canRecieve = false, canRush = false, canTE = false, isDline = false, isOLine = true };
        public static Player Grant_Feasel = new Player { name = "Grant Feasel", runBlock = 2, passBlock = 1, canPass = false, canRecieve = false, canRush = false, canTE = false, isDline = false, isOLine = true };
        public static Player Ronnie_Lee = new Player { name = "Ronnie Lee", runBlock = 1, passBlock = 1, canPass = false, canRecieve = false, canRush = false, canTE = false, isDline = false, isOLine = true };
        public static Player David_Daniels = new Player { name = "David Daniels", canRecieve = true, canRush = true };
        public static Player Louis_Clark = new Player { name = "Louis Clark", canRecieve = true, canRush = true };
        public static Player Tommy_Kane = new Player { name = "Tommy Kane", canRecieve = true, canRush = true };

        static string[,] bbrush()
        {
            string[,] p = new string[3, 12];

            p[2, 0] = "11";
            p[1, 0] = "10";
            p[0, 0] = "10";
            p[0, 1] = "8";
            p[0, 2] = "7";
            p[0, 3] = "6";
            p[0, 4] = "5";
            p[0, 5] = "4";
            p[0, 6] = "3";
            p[0, 7] = "2";
            p[0, 8] = "1";
            p[0, 9] = "1";
            p[0, 10] = "0";
            p[0, 11] = "0";

            int i = 1;
            while (i < 12)
            {
                p[2, i] = "10";
                p[1, i] = "10";
                i++;
            }


            return p;
        }



        public static Player Jeff_Kemp = new Player { name = "Jeff Kemp", canPass = true, comp = 32, quickComp = 32, longComp = 15, };

        public static Player Brian_Blades = new Player { name = "Brian Blades", canRecieve = true, canTE = true, canRush = true, rushVal = bbrush() };

        


        public static List<Player> playerlist()
        {
            List<Player> plist = new List<Player>();
            plist.Add(Andy_Heck);
            plist.Add(Bill_Hitchcock);
            plist.Add(Brian_Blades);
            plist.Add(Jeff_Kemp);
            plist.Add(Curt_Stinger);
            plist.Add(Darrick_Brillz);
            plist.Add(Ronnie_Lee);
            plist.Add(Grant_Feasel);
            plist.Add(David_Daniels);
            plist.Add(Tommy_Kane);
            plist.Add(Louis_Clark);
            return plist;
        }
    }
        
}

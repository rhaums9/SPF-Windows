using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace SPFCoreLibrary
{
    public class TeamXML
    {
        public Team readTeam(string file)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            string teamname;
            string headcoach;
            string maincolor;
            string textcolor;

           
            foreach(XmlNode node in doc.ChildNodes)
            {
                if (node.Name == "teamName")
                {
                    teamname = node.Value;
                }
                if (node.Name == "headCoach")
                {
                    headcoach = node.Value;
                }
               
                
            }

            return null;
        }
        }
}

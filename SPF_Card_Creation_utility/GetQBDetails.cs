using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF_Card_Creation_utility
{
    class GetQBDetails
    {
        public int cmp;
        public int ict;
        public int sck;

        public void loadDetails(string TeamURL, string playername)
        {

            string urlmain = "http://www.pro-football-reference.com/teams/" + TeamURL + "/2016.htm";
            string urlshort = "http://www.pro-football-reference.com/play-index/play_finder.cgi?request=1&super_bowl=0&match=summary_all&year_min=2016&year_max=2016&team_id=" + TeamURL + "&opp_id=&game_type=R&game_day_of_week=&game_num_min=0&game_num_max=99&week_num_min=0&week_num_max=99&quarter=1&quarter=2&quarter=3&quarter=4&quarter=5&tr_gtlt=lt&minutes=15&seconds=00&down=0&down=1&down=2&down=3&down=4&yds_to_go_min=&yds_to_go_max=&yg_gtlt=gt&yards=&is_first_down=-1&field_pos_min_field=team&field_pos_min=&field_pos_max_field=team&field_pos_max=&end_field_pos_min_field=team&end_field_pos_min=&end_field_pos_max_field=team&end_field_pos_max=&type=PASS&is_complete=-1&is_turnover=-1&turnover_type=interception&turnover_type=fumble&is_scoring=-1&score_type=touchdown&score_type=field_goal&score_type=safety&is_sack=-1&include_kneels=-1&no_play=0&margin_min=&margin_max=&order_by=yards&more_options=0&rush_direction=LE&rush_direction=LT&rush_direction=LG&rush_direction=M&rush_direction=RG&rush_direction=RT&rush_direction=RE&pass_location=SL&pass_location=SM&pass_location=SR";
            string urldeep = "http://www.pro-football-reference.com/play-index/play_finder.cgi?request=1&super_bowl=0&match=summary_all&year_min=2016&year_max=2016&team_id=" + TeamURL + "&opp_id=&game_type=R&playoff_round=&game_location=&game_result=&game_day_of_week=&game_num_min=0&game_num_max=99&week_num_min=0&week_num_max=99&quarter=1&quarter=2&quarter=3&quarter=4&quarter=5&tr_gtlt=lt&minutes=15&seconds=00&down=0&down=1&down=2&down=3&down=4&yds_to_go_min=&yds_to_go_max=&yg_gtlt=gt&yards=&is_first_down=-1&field_pos_min_field=team&field_pos_min=&field_pos_max_field=team&field_pos_max=&end_field_pos_min_field=team&end_field_pos_min=&end_field_pos_max_field=team&end_field_pos_max=&type=PASS&is_complete=-1&is_turnover=-1&turnover_type=interception&turnover_type=fumble&is_scoring=-1&score_type=touchdown&score_type=field_goal&score_type=safety&is_sack=-1&include_kneels=-1&no_play=0&margin_min=&margin_max=&order_by=yards&more_options=0&rush_direction=LE&rush_direction=LT&rush_direction=LG&rush_direction=M&rush_direction=RG&rush_direction=RT&rush_direction=RE&pass_location=DL&pass_location=DM&pass_location=DR";

            HtmlWeb main = new HtmlWeb();
            HtmlDocument maindoc = main.Load(urlmain);

            HtmlWeb shrt = new HtmlWeb();
            HtmlDocument shortdoc = shrt.Load(urlshort);

            HtmlWeb deep = new HtmlWeb();
            HtmlDocument deepdoc = deep.Load(urldeep);

            maindoc.LoadHtml(urlmain);

            HtmlNodeCollection maintexts = maindoc.DocumentNode.SelectNodes("//table[@class='sortable stats_table now_sortable']");
            var mainrows = maintexts.Descendants("tr").ToList();
            List<List<String>> mainvalues = new List<List<string>>();

            foreach(var row in mainrows)
            {
                List<String> values = new List<string>();
                foreach (var columns in row.ChildNodes)
                {
                    values.Add(columns.InnerText);
                }
                mainvalues.Add(values);
            }
            foreach(var v in mainvalues)
            {

            }
        }
        }
    }


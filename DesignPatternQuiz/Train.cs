using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternQuiz
{
    public abstract class TrainTicket
    {
        public static string Cost = ConfigurationManager.AppSettings.Get("TicketCost");

        public string Description = "Winnipeg To Toronto $" + Cost;

        public abstract void Buy();
    }

    public class decemberTicket : TrainTicket
    {
        public string path = @"C:\Users\Justin\Desktop\DatabaseForQuiz.txt";
        
        public override void Buy()
        {
            if (!File.Exists(path))
            {
                File.AppendAllText(path, Cost + " 12 " + 0 + " 100" + "\n");
            }
            else
            {
                File.AppendAllText(path, Cost + " 12 " + 0 + " 100" + "\n");
            }
            
        }
    }

    public class JuneOrJulyTicket : TrainTicket
    {
        public string path = @"C:\Users\Justin\Desktop\DatabaseForQuiz.txt";

        public override void Buy()
        {
            if (!File.Exists(path))
            {
                File.AppendAllText(path, Cost + " 6/7 " + 0 + " 37.5" + "\n");
            }
            else
            {
                File.AppendAllText(path, Cost + " 6/7 " + 0 + " 37.5" + "\n");
            }
            
        }
    }

    public class OtherMonthTicket : TrainTicket
    {
        public static string path = @"C:\Users\Justin\Desktop\DatabaseForQuiz.txt";


        public override void Buy()
        {
            if (!File.Exists(path))
            {
                File.AppendAllText(path, Cost + " 1/2/3/4/5/8/9/10/11 " + 0 + " 50" + "\n");
            }
            else
            {
                File.AppendAllText(path, Cost + " 1/2/3/4/5/8/9/10/11 " + 0 + " 50" + "\n");

            }
        }
    }
}

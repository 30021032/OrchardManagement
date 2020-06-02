using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchardManagementApp
{
    class Action
    {
        public int ActionID { get; set; }
        public int SectionID { get; set; }
        public string ActionType { get; set; }
        public string Date { get; set; }
        public int HoursInvested { get; set; }
        public string Comment { get; set; }

        public Action(int id, string action_type, string date, int hours_invested)
        {
            ActionID = id;
            ActionType = action_type;
            Date = date;
            HoursInvested = hours_invested;
        }
        public Action(int id, string action_type, string date, int hours_invested, string comment)
        {
            ActionID = id;
            ActionType = action_type;
            Date = date;
            HoursInvested = hours_invested;
            Comment = comment;
        }

        public Action()
        {
            //empty constructor as well
        }
    }
}
